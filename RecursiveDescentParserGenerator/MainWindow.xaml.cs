using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Win32;
using RecursiveDescentParserGenerator.Datatypes;
using RecursiveDescentParserGenerator.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Provides the main interaction logic for the application window.
    /// This class manages the user interface and handles events for generating, loading, and parsing grammar files,
    /// as well as saving and loading input files.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The parser instance used to parse input based on the loaded grammar.
        /// </summary>
        private IParser? parser = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class and sets up the user interface.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the "Generate" button.
        /// Opens a file dialog to specify the location for saving a generated parser file.
        /// Processes the input grammar, class name, and namespace to generate the parser code file.
        /// </summary>
        private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "C# File|*.cs",
                FileName = "Parser",
            };
            bool? dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != true) return;
            string filePath = saveFileDialog.FileName;
            string[] pathParts = filePath.Split("\\");
            string className = pathParts[^1].Replace(".cs", string.Empty);
            string nameSpace = TextBoxNamespace.Text;
            string grammar = TextBoxGrammar.Text;

            // Replace escaped characters in grammar with actual characters
            grammar = grammar.Replace("\\\\", "\\");
            grammar = grammar.Replace("\\n", "\n");
            grammar = grammar.Replace("\\r", "\r");
            grammar = grammar.Replace("\\t", "\t");
            ParserGenerator.Generate(grammar, className, nameSpace, filePath);
        }


        /// <summary>
        /// Handles the click event for the "Load Parser" button.
        /// Opens a file dialog to select a compiled C# parser file, compiles it, and loads the parser into the application.
        /// </summary>
        private void ButtonLoadParser_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "C# File|*.cs",
            };
            bool? dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != true) return;
            string filePath = openFileDialog.FileName;
            string[] pathParts = filePath.Split("\\");
            string className = pathParts[^1].Replace(".cs", string.Empty);

            string sourceCode = File.ReadAllText(filePath);

            // Set up the compilation options and references
            var compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

            // Add necessary references
            var references = new[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Runtime.AssemblyTargetedPatchBandAttribute).Assembly.Location),
                MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
                MetadataReference.CreateFromFile(Assembly.Load("RecursiveDescentParserGenerator").Location),
                MetadataReference.CreateFromFile(Assembly.Load("System.Collections").Location),
            };

            // Compile the code
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceCode);
            var compilation = CSharpCompilation.Create("LibraryAssembly")
                .WithOptions(compilationOptions)
                .AddReferences(references)
                .AddSyntaxTrees(syntaxTree);

            using var ms = new MemoryStream();
            var emitResult = compilation.Emit(ms);

            if (!emitResult.Success)
            {
                // Log compilation errors
                foreach (var diagnostic in emitResult.Diagnostics)
                {
                    Debug.WriteLine(diagnostic.ToString());
                }
            }
            else
            {
                ms.Seek(0, SeekOrigin.Begin);

                // Load and instantiate the compiled assembly
                Assembly assembly = Assembly.Load(ms.ToArray());

                Type? libraryClassType = assembly.ExportedTypes.First((type) => type.Name == className);
                object? libraryInstance = Activator.CreateInstance(libraryClassType);
                if (libraryInstance == null)
                {
                    Debug.WriteLine("Parser could not be instanciated");
                    return;
                }
                parser = (IParser)libraryInstance;
                LabelParserFilePath.Content = filePath;
                LabelParserClassName.Content = className;
            }
        }

        /// <summary>
        /// Handles the click event for the "Parse" button.
        /// Uses the loaded parser to parse the input text and generate a parse tree.
        /// Converts the parse tree into an image and displays it in the user interface.
        /// </summary>
        private void ButtonParse_Click(object sender, RoutedEventArgs e)
        {
            if (parser == null) return;
            string input = TextBoxInput.Text;
            ParseTree? parseTree = parser.Parse(input, out List<string> errors);
            if (parseTree == null)
            {
                Debug.WriteLine(string.Join(Environment.NewLine, errors));
                return;
            }
            string graphVizGraph = parseTree.GraphvizGraphGet();
            Bitmap bitmap = FileDotEngine.Run(graphVizGraph);
            ImageSource imageSource = bitmap.ToImageSource();
            ImageParseTree.Source = imageSource;
        }

        /// <summary>
        /// Handles the click event for the "Load Grammar" button.
        /// Opens a file dialog to select a grammar file and loads its content into the grammar text box.
        /// </summary>
        private void ButtonLoadGrammar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Grammar File|*.grm",
            };
            bool? dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != true) return;
            string filePath = openFileDialog.FileName;
            TextBoxGrammar.Text = File.ReadAllText(filePath);
        }

        /// <summary>
        /// Handles the click event for the "Save Grammar" button.
        /// Opens a file dialog to specify the location for saving the current grammar content.
        /// </summary>
        private void ButtonSaveGrammar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Grammar File|*.grm",
                FileName = "Grammar",
            };
            bool? dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != true) return;
            string filePath = saveFileDialog.FileName;
            using StreamWriter stream = File.CreateText(filePath);
            stream.Write(TextBoxGrammar.Text);
        }

        /// <summary>
        /// Handles the click event for the "Load Input" button.
        /// Opens a file dialog to select an input file and loads its content into the input text box.
        /// </summary>
        private void ButtonLoadInput_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Any File|*.*",
            };
            bool? dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != true) return;
            string filePath = openFileDialog.FileName;
            TextBoxInput.Text = File.ReadAllText(filePath);
        }

        /// <summary>
        /// Handles the click event for the "Save Input" button.
        /// Opens a file dialog to specify the location for saving the current input content.
        /// </summary>
        private void ButtonSaveInput_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Any File|*.*",
                FileName = "Input",
            };
            bool? dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != true) return;
            string filePath = saveFileDialog.FileName;
            using StreamWriter stream = File.CreateText(filePath);
            stream.Write(TextBoxInput.Text);
        }

        /// <summary>
        /// Handles the click event for the "Debug" button.
        /// Triggers the generation of a BNF source for debugging purposes.
        /// </summary>
        private void ButtonDebug_Click(object sender, RoutedEventArgs e)
        {
            ParserGenerator.ParserBnfSourceGenerate();
        }
    }
}
