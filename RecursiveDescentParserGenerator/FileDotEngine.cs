using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Provides methods for interacting with Graphviz's `dot` utility to generate images
    /// from DOT language graph descriptions.
    /// </summary>
    public static class FileDotEngine
    {
        #region Public functions

        /// <summary>
        /// Runs the Graphviz `dot` utility to generate a bitmap image from a DOT language graph description.
        /// </summary>
        /// <param name="dot">
        /// A string containing the DOT language graph description.
        /// </param>
        /// <returns>
        /// A <see cref="Bitmap"/> object representing the generated image.
        /// </returns>
        /// <remarks>
        /// This method writes the DOT description to a temporary file, executes the Graphviz `dot` 
        /// utility to convert the DOT file into a JPG image, and then reads the JPG image into a
        /// <see cref="Bitmap"/> object. The temporary files are deleted after the image is created.
        /// </remarks>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the Graphviz `dot` executable is not found at the specified path.
        /// </exception>
        public static Bitmap Run(string dot)
        {
            string executable = @"C:\Program Files\Graphviz\bin\dot.exe";
            string output = @".\tempgraph";
            File.WriteAllText(output, dot);

            Process process = new();

            // Stop the process from opening a new window
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Setup executable and parameters
            process.StartInfo.FileName = executable;
            process.StartInfo.Arguments = $"{output} -Tjpg -O";

            /*process.OutputDataReceived += (sender, e) =>
            {
                if (e.Data != null)
                    Debug.WriteLine(e.Data);
            };*/

            // Go
            process.Start();
            // and wait dot.exe to complete and exit
            process.WaitForExit();
            Bitmap bitmap;

            using (Stream bmpStream = File.Open(output + ".jpg", FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);
                bitmap = new Bitmap(image);
            }
            File.Delete(output);
            File.Delete(output + ".jpg");
            return bitmap;
        }

        #endregion
    }
}
