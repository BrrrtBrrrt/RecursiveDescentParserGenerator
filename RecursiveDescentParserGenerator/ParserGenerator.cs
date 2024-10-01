using RecursiveDescentParserGenerator.Datatypes;
using RecursiveDescentParserGenerator.Datatypes.Bnf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Rule = RecursiveDescentParserGenerator.Datatypes.Bnf.Rule;

namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Contains methods for generating a parser from a BNF grammar.
    /// </summary>
    internal static class ParserGenerator
    {
        /// <summary>
        /// Generates a parser class based on the provided BNF grammar.
        /// </summary>
        /// <param name="grammar">The BNF grammar as a string.</param>
        /// <param name="className">The name of the parser class to generate.</param>
        /// <param name="nameSpace">The namespace for the generated parser class.</param>
        /// <param name="filePath">The file path where the parser class will be saved.</param>
        internal static void Generate(string grammar, string className, string nameSpace, string filePath)
        {
            Debug.WriteLine(GrammarBnfGet()); // Debug output of the BNF grammar
            BnfParser bnfParser = new();
            ParseTree? bnfParseTree = bnfParser.Parse(grammar, out List<string> errors) ??
                throw new Exception(string.Join(Environment.NewLine, errors));
            Debug.WriteLine(bnfParseTree.GraphvizGraphGet()); ; // Debug output of the parse tree
            Grammar grammarParsed;
            try
            {
                grammarParsed = BnfInterpreter.Interpret(bnfParseTree);
            }
            catch (BnfInterpreterException e)
            {
                throw e; // Re-throwing exception from the interpreter
            }
            // Generate the parser code
            Generate(grammarParsed, className, nameSpace, filePath);
        }

        /// <summary>
        /// Generates the source code for a BNF parser and saves it to a predefined location.
        /// </summary>
        internal static void ParserBnfSourceGenerate()
        {
            Debug.WriteLine(GrammarBnfGet()); // Debug output of the BNF grammar
            Generate(GrammarBnfGet(), "BnfParser", "RecursiveDescentParserGenerator", "C:/Users/prusa/source/repos/RecursiveDescentParserGenerator/RecursiveDescentParserGenerator/Parsers/BnfParser.cs");
        }

        /// <summary>
        /// Generates the source code for a parser class based on the provided grammar.
        /// </summary>
        /// <param name="grammar">The parsed grammar object.</param>
        /// <param name="className">The name of the parser class to generate.</param>
        /// <param name="nameSpace">The namespace for the generated parser class.</param>
        /// <param name="filePath">The file path where the parser class will be saved.</param>
        private static void Generate(Grammar grammar, string className, string nameSpace, string filePath)
        {
            Rule ruleStart = grammar.Rules[0];

            // Create a unique hash for the rule identifier
            string ruleStartHash = HashCodeGet(ruleStart.Identifier);

            // Generate the parser source code
            string parserSourceCode = $@"
using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace {nameSpace}
{{
    public class {className} : IParser
    {{
        private string input = string.Empty;
        private int lastId = 0;
        private List<string> errors = new();

        public {nameof(ParseTree)}? Parse(string input, out List<string> errors)
        {{
            this.input = input;
            lastId = 0;
            errors = new();
            this.errors = errors;
            {nameof(ParseTree)}? parseTree = ParseRule{ruleStartHash}();
            return parseTree;
        }}

        {string.Join(Environment.NewLine, grammar.Rules.Select((rule) => {
            string ruleHash = HashCodeGet(rule.Identifier);
            return $@"
        // Parse rule: {rule.Identifier}
        private {nameof(ParseTree)}? ParseRule{ruleHash}()
        {{
            {nameof(ParseTree)}? parseTree;
            string inputSavepoint;
            {string.Join(Environment.NewLine, rule.Options.Select((option, index) => {
                return $@"
            inputSavepoint = input;
            parseTree = ParseRule{ruleHash}Option{index}();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;";
            }))}

            return null;
        }}

        {string.Join(Environment.NewLine, rule.Options.Select((option, index) => {
            return $@"
        // Parse rule: {rule.Identifier} (Option {index})
        private {nameof(ParseTree)}? ParseRule{ruleHash}Option{index}()
        {{
            errors.Clear();
            {nameof(ParseTree)} parseTree = new()
            {{
                Label = ""{rule.Identifier}"",
                Value = ""{rule.Identifier}"",
                Id = lastId
            }};
            lastId++;

            {nameof(ParseTree)}? parseTreeChild;

            {string.Join(Environment.NewLine, option.Tokens.Select((token) => {
                if (token.IsTerminal)
                {
                    return string.Join(Environment.NewLine, token.Value.Select((character) => {
                        string valueEscaped = character.ToString();
                        valueEscaped = valueEscaped.Replace("\\", "\\\\");
                        valueEscaped = valueEscaped.Replace("\"", "\\\"");
                        valueEscaped = valueEscaped.Replace("\n", "\\n");
                        valueEscaped = valueEscaped.Replace("\r", "\\r");
                        valueEscaped = valueEscaped.Replace("\t", "\\t");
                        string valueDoubleEscaped = valueEscaped;
                        valueDoubleEscaped = valueDoubleEscaped.Replace(" ", "Whitespace");
                        valueDoubleEscaped = valueDoubleEscaped.Replace("\\\"", "\\\\\\\"");
                        valueDoubleEscaped = valueDoubleEscaped.Replace("\\n", "\\\\n");
                        valueDoubleEscaped = valueDoubleEscaped.Replace("\\r", "\\\\r");
                        valueDoubleEscaped = valueDoubleEscaped.Replace("\\t", "\\\\t");
                        return $@"
            if (!{nameof(ParserUtil)}.{nameof(ParserUtil.Eat)}(ref input, '{(valueEscaped == "'" ? "\\'" : valueEscaped)}')) {{
                char? nextCharacter = {nameof(ParserUtil)}.{nameof(ParserUtil.Peek)}(ref input);
                errors.Add(""Parse rule: {rule.Identifier} (Option {index}) error: Expected '{valueDoubleEscaped}'; Got '"" + (nextCharacter == null ? ""End of input"" : nextCharacter) + ""'"");
                return null;
            }}
            parseTree.Children.Add(new()
            {{
                Id = lastId,
                Value = ""{valueEscaped}"",
                Label = ""{valueDoubleEscaped}"",
            }});
            lastId++;";
                    }));
                }
                else
                {
                    bool? ruleContainsEpsilonOption = grammar.Rules.Find((rule) => rule.Identifier == token.Value)
                        ?.Options.Exists((option) => option.Tokens .Count == 0);
                    return $@"
            parseTreeChild = ParseRule{HashCodeGet(token.Value)}(); // Parse rule: {token.Value}
            {(ruleContainsEpsilonOption == true ? string.Empty : $@"
            if (parseTreeChild == null) {{
                errors.Add(""Parse rule: {rule.Identifier} (Option {index}) error: Could not parse rule: {token.Value}"");
                return null;
            }}")}
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);";
                }
            }))}

            return parseTree.Children.Count == 0 ? null : parseTree;
        }}";
        }))}";
        }))}
    }}
}}";
            // Write the generated parser source code to the specified file path
            using StreamWriter stream = File.CreateText(filePath);
            stream.Write(parserSourceCode);
        }

        /// <summary>
        /// Constructs a BNF grammar object representing the syntax rules.
        /// </summary>
        /// <returns>The constructed BNF grammar.</returns>
        private static Grammar GrammarBnfGet()
        {
            // Define BNF grammar rules
            Dictionary<string, List<List<Token>>> syntaxRaw = new()
            {
                [Constants.GRAMMAR_BNF_RULE_NAME_ENTRY] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_NAME_RULES },
                    },
                },
                [Constants.GRAMMAR_BNF_RULE_NAME_RULES] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_NAME_RULE },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_NAME_RULES}2" },
                    },
                },
                [$"{Constants.GRAMMAR_BNF_RULE_NAME_RULES}2"] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_NAME_LINE_END },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_NAME_RULE },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_NAME_RULES}2" },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_NAME_RULE] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                        new() { Value = "<", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_RULE_NAME },
                        new() { Value = ">", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                        new() { Value = "::=", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPTIONS },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                    },
                },
                [Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE] = new() {
                    new() {
                        new() { Value = " ", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_RULE_NAME] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_LETTER },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_RULE_NAME}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_DIGIT },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_RULE_NAME}2" },
                    },
                },
                [$"{Constants.GRAMMAR_BNF_RULE_RULE_NAME}2"] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_RULE_NAME },
                    },
                    new() {
                        new() { Value = "-", IsTerminal = true },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_RULE_NAME}2" },
                    },
                    new() {
                        new() { Value = "_", IsTerminal = true },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_RULE_NAME}2" },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_OPTIONS] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPTION },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_OPTIONS}2" },
                    },
                },
                [$"{Constants.GRAMMAR_BNF_RULE_OPTIONS}2"] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                        new() { Value = "|", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPTION },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_OPTIONS}2" },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_OPTION] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_TOKENS },
                    },
                    new() {
                        new() { Value = "E", IsTerminal = true },
                    },
                },
                [Constants.GRAMMAR_BNF_RULE_TOKENS] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_TOKEN },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TOKENS}2" },
                    },
                },
                [$"{Constants.GRAMMAR_BNF_RULE_TOKENS}2"] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_OPT_WHITESPACE },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_TOKEN },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TOKENS}2" },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_TOKEN] = new() {
                    new() {
                        new() { Value = "<", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_RULE_NAME },
                        new() { Value = ">", IsTerminal = true },
                    },
                    new() {
                        new() { Value = "\"", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE },
                        new() { Value = "\"", IsTerminal = true },
                    },
                    new() {
                        new() { Value = "'", IsTerminal = true },
                        new() { Value = Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE },
                        new() { Value = "'", IsTerminal = true },
                    },
                },
                [Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_LETTER },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_DIGIT },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_SYMBOL },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = "\"", IsTerminal = true },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                },
                [$"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2"] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_LETTER },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_DIGIT },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_SYMBOL },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = "\"", IsTerminal = true },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2" },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_LETTER },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_DIGIT },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_SYMBOL },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = "'", IsTerminal = true },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                },
                [$"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2"] = new() {
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_LETTER },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_DIGIT },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = Constants.GRAMMAR_BNF_RULE_SYMBOL },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new() {
                        new() { Value = "'", IsTerminal = true },
                        new() { Value = $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2" },
                    },
                    new(),
                },
                [Constants.GRAMMAR_BNF_RULE_NAME_LINE_END] = new() {
                    new() {
                        new() { Value = "\r\n", IsTerminal = true },
                    },
                    new() {
                        new() { Value = "\n", IsTerminal = true },
                    },
                },
                [Constants.GRAMMAR_BNF_RULE_LETTER] = new() {
                    new() { new() { Value = "A", IsTerminal = true } },
                    new() { new() { Value = "B", IsTerminal = true } },
                    new() { new() { Value = "C", IsTerminal = true } },
                    new() { new() { Value = "D", IsTerminal = true } },
                    new() { new() { Value = "E", IsTerminal = true } },
                    new() { new() { Value = "F", IsTerminal = true } },
                    new() { new() { Value = "G", IsTerminal = true } },
                    new() { new() { Value = "H", IsTerminal = true } },
                    new() { new() { Value = "I", IsTerminal = true } },
                    new() { new() { Value = "J", IsTerminal = true } },
                    new() { new() { Value = "K", IsTerminal = true } },
                    new() { new() { Value = "L", IsTerminal = true } },
                    new() { new() { Value = "M", IsTerminal = true } },
                    new() { new() { Value = "N", IsTerminal = true } },
                    new() { new() { Value = "O", IsTerminal = true } },
                    new() { new() { Value = "P", IsTerminal = true } },
                    new() { new() { Value = "Q", IsTerminal = true } },
                    new() { new() { Value = "R", IsTerminal = true } },
                    new() { new() { Value = "S", IsTerminal = true } },
                    new() { new() { Value = "T", IsTerminal = true } },
                    new() { new() { Value = "U", IsTerminal = true } },
                    new() { new() { Value = "V", IsTerminal = true } },
                    new() { new() { Value = "W", IsTerminal = true } },
                    new() { new() { Value = "X", IsTerminal = true } },
                    new() { new() { Value = "Y", IsTerminal = true } },
                    new() { new() { Value = "Z", IsTerminal = true } },
                    new() { new() { Value = "a", IsTerminal = true } },
                    new() { new() { Value = "b", IsTerminal = true } },
                    new() { new() { Value = "c", IsTerminal = true } },
                    new() { new() { Value = "d", IsTerminal = true } },
                    new() { new() { Value = "e", IsTerminal = true } },
                    new() { new() { Value = "f", IsTerminal = true } },
                    new() { new() { Value = "g", IsTerminal = true } },
                    new() { new() { Value = "h", IsTerminal = true } },
                    new() { new() { Value = "i", IsTerminal = true } },
                    new() { new() { Value = "j", IsTerminal = true } },
                    new() { new() { Value = "k", IsTerminal = true } },
                    new() { new() { Value = "l", IsTerminal = true } },
                    new() { new() { Value = "m", IsTerminal = true } },
                    new() { new() { Value = "n", IsTerminal = true } },
                    new() { new() { Value = "o", IsTerminal = true } },
                    new() { new() { Value = "p", IsTerminal = true } },
                    new() { new() { Value = "q", IsTerminal = true } },
                    new() { new() { Value = "r", IsTerminal = true } },
                    new() { new() { Value = "s", IsTerminal = true } },
                    new() { new() { Value = "t", IsTerminal = true } },
                    new() { new() { Value = "u", IsTerminal = true } },
                    new() { new() { Value = "v", IsTerminal = true } },
                    new() { new() { Value = "w", IsTerminal = true } },
                    new() { new() { Value = "x", IsTerminal = true } },
                    new() { new() { Value = "y", IsTerminal = true } },
                    new() { new() { Value = "z", IsTerminal = true } },
                    new() { new() { Value = "ä", IsTerminal = true } },
                    new() { new() { Value = "ö", IsTerminal = true } },
                    new() { new() { Value = "ü", IsTerminal = true } },
                    new() { new() { Value = "ß", IsTerminal = true } },
                },
                [Constants.GRAMMAR_BNF_RULE_DIGIT] = new() {
                    new() { new() { Value = "0", IsTerminal = true } },
                    new() { new() { Value = "1", IsTerminal = true } },
                    new() { new() { Value = "2", IsTerminal = true } },
                    new() { new() { Value = "3", IsTerminal = true } },
                    new() { new() { Value = "4", IsTerminal = true } },
                    new() { new() { Value = "5", IsTerminal = true } },
                    new() { new() { Value = "6", IsTerminal = true } },
                    new() { new() { Value = "7", IsTerminal = true } },
                    new() { new() { Value = "8", IsTerminal = true } },
                    new() { new() { Value = "9", IsTerminal = true } },
                },
                [Constants.GRAMMAR_BNF_RULE_SYMBOL] = new() {
                    new() { new() { Value = "!", IsTerminal = true } },
                    new() { new() { Value = "§", IsTerminal = true } },
                    new() { new() { Value = "$", IsTerminal = true } },
                    new() { new() { Value = "%", IsTerminal = true } },
                    new() { new() { Value = "&", IsTerminal = true } },
                    new() { new() { Value = "/", IsTerminal = true } },
                    new() { new() { Value = "(", IsTerminal = true } },
                    new() { new() { Value = ")", IsTerminal = true } },
                    new() { new() { Value = "=", IsTerminal = true } },
                    new() { new() { Value = "?", IsTerminal = true } },
                    new() { new() { Value = "`", IsTerminal = true } },
                    new() { new() { Value = "´", IsTerminal = true } },
                    new() { new() { Value = "²", IsTerminal = true } },
                    new() { new() { Value = "³", IsTerminal = true } },
                    new() { new() { Value = "{", IsTerminal = true } },
                    new() { new() { Value = "}", IsTerminal = true } },
                    new() { new() { Value = " ", IsTerminal = true } },
                    new() { new() { Value = "[", IsTerminal = true } },
                    new() { new() { Value = "]", IsTerminal = true } },
                    new() { new() { Value = "\\", IsTerminal = true } },
                    new() { new() { Value = "@", IsTerminal = true } },
                    new() { new() { Value = "€", IsTerminal = true } },
                    new() { new() { Value = "~", IsTerminal = true } },
                    new() { new() { Value = "*", IsTerminal = true } },
                    new() { new() { Value = "+", IsTerminal = true } },
                    new() { new() { Value = "#", IsTerminal = true } },
                    new() { new() { Value = "-", IsTerminal = true } },
                    new() { new() { Value = "_", IsTerminal = true } },
                    new() { new() { Value = ".", IsTerminal = true } },
                    new() { new() { Value = ":", IsTerminal = true } },
                    new() { new() { Value = ",", IsTerminal = true } },
                    new() { new() { Value = ";", IsTerminal = true } },
                    new() { new() { Value = "<", IsTerminal = true } },
                    new() { new() { Value = ">", IsTerminal = true } },
                    new() { new() { Value = "|", IsTerminal = true } },
                    new() { new() { Value = "\t", IsTerminal = true } },
                    new() { new() { Value = "\n", IsTerminal = true } },
                    new() { new() { Value = "\r", IsTerminal = true } },
                },
            };

            Grammar grammar = new();

            foreach (string ruleIdentifier in syntaxRaw.Keys)
            {
                List<List<Token>> ruleRaw = syntaxRaw[ruleIdentifier];

                Rule rule = new()
                {
                    Identifier = ruleIdentifier
                };

                foreach (List<Token> tokens in ruleRaw)
                {
                    rule.Options.Add(new()
                    {
                        Tokens = tokens
                    });
                }

                grammar.Rules.Add(rule);
            }

            return grammar;
        }

        /// <summary>
        /// Generates a hash code for the given string value and returns it as a string.
        /// Negative hash codes are converted to a positive-looking string by replacing the minus sign with 'N'.
        /// </summary>
        /// <param name="value">The string for which to generate a hash code.</param>
        /// <returns>A string representation of the hash code, with negative signs replaced by 'N'.</returns>
        private static string HashCodeGet(string value)
        {
            return value.GetHashCode().ToString().Replace("-", "N");
        }
    }
}
