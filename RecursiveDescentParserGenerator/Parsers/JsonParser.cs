
using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator
{
    public class JsonParser : IParser
    {
        private string input = string.Empty;
        private int lastId = 0;
        private List<string> errors = new();

        public ParseTree? Parse(string input, out List<string> errors)
        {
            this.input = input;
            lastId = 0;
            errors = new();
            this.errors = errors;
            ParseTree? parseTree = ParseRuleN1172100011();
            return parseTree;
        }

        
        // Parse rule: json
        private ParseTree? ParseRuleN1172100011()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1172100011Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: json (Option 0)
        private ParseTree? ParseRuleN1172100011Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "json",
                Value = "json",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN264237395(); // Parse rule: jsonObject
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: json (Option 0) error: Could not parse rule: jsonObject");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: jsonObject
        private ParseTree? ParseRuleN264237395()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN264237395Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN264237395Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN264237395Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN264237395Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN264237395Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN264237395Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: jsonObject (Option 0)
        private ParseTree? ParseRuleN264237395Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "jsonObject",
                Value = "jsonObject",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule502438460(); // Parse rule: null
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: jsonObject (Option 0) error: Could not parse rule: null");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: jsonObject (Option 1)
        private ParseTree? ParseRuleN264237395Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "jsonObject",
                Value = "jsonObject",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN744346847(); // Parse rule: boolean
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: jsonObject (Option 1) error: Could not parse rule: boolean");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: jsonObject (Option 2)
        private ParseTree? ParseRuleN264237395Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "jsonObject",
                Value = "jsonObject",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1428109724(); // Parse rule: string
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: jsonObject (Option 2) error: Could not parse rule: string");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: jsonObject (Option 3)
        private ParseTree? ParseRuleN264237395Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "jsonObject",
                Value = "jsonObject",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN341808801(); // Parse rule: number
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: jsonObject (Option 3) error: Could not parse rule: number");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: jsonObject (Option 4)
        private ParseTree? ParseRuleN264237395Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "jsonObject",
                Value = "jsonObject",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule589379438(); // Parse rule: array
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: jsonObject (Option 4) error: Could not parse rule: array");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: jsonObject (Option 5)
        private ParseTree? ParseRuleN264237395Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "jsonObject",
                Value = "jsonObject",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1536301838(); // Parse rule: object
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: jsonObject (Option 5) error: Could not parse rule: object");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: null
        private ParseTree? ParseRule502438460()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule502438460Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: null (Option 0)
        private ParseTree? ParseRule502438460Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "null",
                Value = "null",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: null (Option 0) error: Expected 'n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "n",
                Label = "n",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'u')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: null (Option 0) error: Expected 'u'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "u",
                Label = "u",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'l')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: null (Option 0) error: Expected 'l'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "l",
                Label = "l",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'l')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: null (Option 0) error: Expected 'l'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "l",
                Label = "l",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: boolean
        private ParseTree? ParseRuleN744346847()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN744346847Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN744346847Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: boolean (Option 0)
        private ParseTree? ParseRuleN744346847Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "boolean",
                Value = "boolean",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 't')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 0) error: Expected 't'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "t",
                Label = "t",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 0) error: Expected 'r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "r",
                Label = "r",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'u')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 0) error: Expected 'u'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "u",
                Label = "u",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'e')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 0) error: Expected 'e'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "e",
                Label = "e",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: boolean (Option 1)
        private ParseTree? ParseRuleN744346847Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "boolean",
                Value = "boolean",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'f')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 1) error: Expected 'f'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "f",
                Label = "f",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'a')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 1) error: Expected 'a'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "a",
                Label = "a",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'l')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 1) error: Expected 'l'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "l",
                Label = "l",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 's')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 1) error: Expected 's'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "s",
                Label = "s",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, 'e')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: boolean (Option 1) error: Expected 'e'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "e",
                Label = "e",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: string
        private ParseTree? ParseRuleN1428109724()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1428109724Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: string (Option 0)
        private ParseTree? ParseRuleN1428109724Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "string",
                Value = "string",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: string (Option 0) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRule187531467(); // Parse rule: textNoDoubleQuote
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: string (Option 0) error: Could not parse rule: textNoDoubleQuote");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: string (Option 0) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number
        private ParseTree? ParseRuleN341808801()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN341808801Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN341808801Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: number (Option 0)
        private ParseTree? ParseRuleN341808801Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "number",
                Value = "number",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN484324395(); // Parse rule: integer
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: number (Option 0) error: Could not parse rule: integer");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number (Option 1)
        private ParseTree? ParseRuleN341808801Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "number",
                Value = "number",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule2103219050(); // Parse rule: float
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: number (Option 1) error: Could not parse rule: float");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer
        private ParseTree? ParseRuleN484324395()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN484324395Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN484324395Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: integer (Option 0)
        private ParseTree? ParseRuleN484324395Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "integer",
                Value = "integer",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN721255545(); // Parse rule: digitWithoutZero
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: integer (Option 0) error: Could not parse rule: digitWithoutZero");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule914082200(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer (Option 1)
        private ParseTree? ParseRuleN484324395Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "integer",
                Value = "integer",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: integer (Option 1) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            parseTreeChild = ParseRuleN721255545(); // Parse rule: digitWithoutZero
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: integer (Option 1) error: Could not parse rule: digitWithoutZero");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule914082200(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer2
        private ParseTree? ParseRule914082200()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule914082200Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule914082200Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: integer2 (Option 0)
        private ParseTree? ParseRule914082200Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "integer2",
                Value = "integer2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN730440534(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: integer2 (Option 0) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule914082200(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer2 (Option 1)
        private ParseTree? ParseRule914082200Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "integer2",
                Value = "integer2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: float
        private ParseTree? ParseRule2103219050()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule2103219050Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2103219050Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2103219050Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: float (Option 0)
        private ParseTree? ParseRule2103219050Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "float",
                Value = "float",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '0')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 0) error: Expected '0'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "0",
                Label = "0",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '.')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 0) error: Expected '.'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ".",
                Label = ".",
            });
            lastId++;

            parseTreeChild = ParseRule213650330(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 0) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: float (Option 1)
        private ParseTree? ParseRule2103219050Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "float",
                Value = "float",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 1) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '0')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 1) error: Expected '0'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "0",
                Label = "0",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '.')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 1) error: Expected '.'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ".",
                Label = ".",
            });
            lastId++;

            parseTreeChild = ParseRule213650330(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 1) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: float (Option 2)
        private ParseTree? ParseRule2103219050Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "float",
                Value = "float",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 2) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            parseTreeChild = ParseRuleN484324395(); // Parse rule: integer
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 2) error: Could not parse rule: integer");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '.')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 2) error: Expected '.'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ".",
                Label = ".",
            });
            lastId++;

            parseTreeChild = ParseRule213650330(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 2) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: floatDecimalPart
        private ParseTree? ParseRule213650330()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule213650330Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: floatDecimalPart (Option 0)
        private ParseTree? ParseRule213650330Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "floatDecimalPart",
                Value = "floatDecimalPart",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN730440534(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: floatDecimalPart (Option 0) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule914082200(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: array
        private ParseTree? ParseRule589379438()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule589379438Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: array (Option 0)
        private ParseTree? ParseRule589379438Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "array",
                Value = "array",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '[')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: array (Option 0) error: Expected '['; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "[",
                Label = "[",
            });
            lastId++;

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN205296313(); // Parse rule: arrayElements
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ']')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: array (Option 0) error: Expected ']'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "]",
                Label = "]",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: arrayElements
        private ParseTree? ParseRuleN205296313()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN205296313Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN205296313Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: arrayElements (Option 0)
        private ParseTree? ParseRuleN205296313Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "arrayElements",
                Value = "arrayElements",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN264237395(); // Parse rule: jsonObject
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: arrayElements (Option 0) error: Could not parse rule: jsonObject");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1707394593(); // Parse rule: arrayElements2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: arrayElements (Option 1)
        private ParseTree? ParseRuleN205296313Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "arrayElements",
                Value = "arrayElements",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: arrayElements2
        private ParseTree? ParseRuleN1707394593()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1707394593Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1707394593Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: arrayElements2 (Option 0)
        private ParseTree? ParseRuleN1707394593Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "arrayElements2",
                Value = "arrayElements2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: arrayElements2 (Option 0) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN264237395(); // Parse rule: jsonObject
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: arrayElements2 (Option 0) error: Could not parse rule: jsonObject");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1707394593(); // Parse rule: arrayElements2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: arrayElements2 (Option 1)
        private ParseTree? ParseRuleN1707394593Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "arrayElements2",
                Value = "arrayElements2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: object
        private ParseTree? ParseRule1536301838()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1536301838Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: object (Option 0)
        private ParseTree? ParseRule1536301838Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "object",
                Value = "object",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '{')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: object (Option 0) error: Expected '{'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "{",
                Label = "{",
            });
            lastId++;

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN134123100(); // Parse rule: objectFields
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '}')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: object (Option 0) error: Expected '}'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "}",
                Label = "}",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: objectFields
        private ParseTree? ParseRuleN134123100()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN134123100Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN134123100Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: objectFields (Option 0)
        private ParseTree? ParseRuleN134123100Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "objectFields",
                Value = "objectFields",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN960487416(); // Parse rule: key
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: objectFields (Option 0) error: Could not parse rule: key");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: objectFields (Option 0) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ":",
                Label = ":",
            });
            lastId++;

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN264237395(); // Parse rule: jsonObject
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: objectFields (Option 0) error: Could not parse rule: jsonObject");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1608821667(); // Parse rule: objectFields2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: objectFields (Option 1)
        private ParseTree? ParseRuleN134123100Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "objectFields",
                Value = "objectFields",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: objectFields2
        private ParseTree? ParseRuleN1608821667()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1608821667Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1608821667Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: objectFields2 (Option 0)
        private ParseTree? ParseRuleN1608821667Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "objectFields2",
                Value = "objectFields2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: objectFields2 (Option 0) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN960487416(); // Parse rule: key
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: objectFields2 (Option 0) error: Could not parse rule: key");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: objectFields2 (Option 0) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ":",
                Label = ":",
            });
            lastId++;

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN264237395(); // Parse rule: jsonObject
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: objectFields2 (Option 0) error: Could not parse rule: jsonObject");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1608821667(); // Parse rule: objectFields2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: objectFields2 (Option 1)
        private ParseTree? ParseRuleN1608821667Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "objectFields2",
                Value = "objectFields2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: key
        private ParseTree? ParseRuleN960487416()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN960487416Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN960487416Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: key (Option 0)
        private ParseTree? ParseRuleN960487416Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "key",
                Value = "key",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1428109724(); // Parse rule: string
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: key (Option 0) error: Could not parse rule: string");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: key (Option 1)
        private ParseTree? ParseRuleN960487416Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "key",
                Value = "key",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN341808801(); // Parse rule: number
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: key (Option 1) error: Could not parse rule: number");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: spaceOptional
        private ParseTree? ParseRuleN1588170962()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1588170962Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1588170962Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1588170962Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1588170962Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: spaceOptional (Option 0)
        private ParseTree? ParseRuleN1588170962Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "spaceOptional",
                Value = "spaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule223041330(); // Parse rule: whiteSpace
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: spaceOptional (Option 0) error: Could not parse rule: whiteSpace");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: spaceOptional (Option 1)
        private ParseTree? ParseRuleN1588170962Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "spaceOptional",
                Value = "spaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN304869861(); // Parse rule: lineEnd
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: spaceOptional (Option 1) error: Could not parse rule: lineEnd");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: spaceOptional (Option 2)
        private ParseTree? ParseRuleN1588170962Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "spaceOptional",
                Value = "spaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN23815682(); // Parse rule: tabulator
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: spaceOptional (Option 2) error: Could not parse rule: tabulator");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1588170962(); // Parse rule: spaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: spaceOptional (Option 3)
        private ParseTree? ParseRuleN1588170962Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "spaceOptional",
                Value = "spaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: whiteSpace
        private ParseTree? ParseRule223041330()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule223041330Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: whiteSpace (Option 0)
        private ParseTree? ParseRule223041330Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "whiteSpace",
                Value = "whiteSpace",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ' ')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: whiteSpace (Option 0) error: Expected 'Whitespace'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = " ",
                Label = "Whitespace",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: lineEnd
        private ParseTree? ParseRuleN304869861()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN304869861Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN304869861Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: lineEnd (Option 0)
        private ParseTree? ParseRuleN304869861Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "lineEnd",
                Value = "lineEnd",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: lineEnd (Option 0) error: Expected '\\r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\r",
                Label = "\\r",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '\n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: lineEnd (Option 0) error: Expected '\\n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\n",
                Label = "\\n",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: lineEnd (Option 1)
        private ParseTree? ParseRuleN304869861Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "lineEnd",
                Value = "lineEnd",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: lineEnd (Option 1) error: Expected '\\n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\n",
                Label = "\\n",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: tabulator
        private ParseTree? ParseRuleN23815682()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN23815682Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: tabulator (Option 0)
        private ParseTree? ParseRuleN23815682Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "tabulator",
                Value = "tabulator",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\t')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: tabulator (Option 0) error: Expected '\\t'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\t",
                Label = "\\t",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote
        private ParseTree? ParseRule187531467()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule187531467Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule187531467Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule187531467Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule187531467Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule187531467Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: textNoDoubleQuote (Option 0)
        private ParseTree? ParseRule187531467Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule2070604292(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 1)
        private ParseTree? ParseRule187531467Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN730440534(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 2)
        private ParseTree? ParseRule187531467Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule962506183(); // Parse rule: symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote (Option 2) error: Could not parse rule: symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 3)
        private ParseTree? ParseRule187531467Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: textNoDoubleQuote (Option 3) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 4)
        private ParseTree? ParseRule187531467Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\\')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: textNoDoubleQuote (Option 4) error: Expected '\\'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\\",
                Label = "\\",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: textNoDoubleQuote (Option 4) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2
        private ParseTree? ParseRuleN569699950()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN569699950Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN569699950Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN569699950Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN569699950Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN569699950Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: textNoDoubleQuote2 (Option 0)
        private ParseTree? ParseRuleN569699950Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule2070604292(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 1)
        private ParseTree? ParseRuleN569699950Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN730440534(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 2)
        private ParseTree? ParseRuleN569699950Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule962506183(); // Parse rule: symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 2) error: Could not parse rule: symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 3)
        private ParseTree? ParseRuleN569699950Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 3) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            parseTreeChild = ParseRuleN569699950(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 4)
        private ParseTree? ParseRuleN569699950Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter
        private ParseTree? ParseRule2070604292()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule2070604292Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option11();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option12();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option13();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option14();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option15();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option16();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option17();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option18();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option19();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option20();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option21();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option22();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option23();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option24();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option25();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option26();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option27();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option28();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option29();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option30();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option31();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option32();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option33();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option34();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option35();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option36();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option37();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option38();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option39();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option40();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option41();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option42();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option43();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option44();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option45();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option46();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option47();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option48();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option49();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option50();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option51();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option52();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option53();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option54();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2070604292Option55();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: letter (Option 0)
        private ParseTree? ParseRule2070604292Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'A')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 0) error: Expected 'A'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "A",
                Label = "A",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 1)
        private ParseTree? ParseRule2070604292Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'B')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 1) error: Expected 'B'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "B",
                Label = "B",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 2)
        private ParseTree? ParseRule2070604292Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'C')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 2) error: Expected 'C'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "C",
                Label = "C",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 3)
        private ParseTree? ParseRule2070604292Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'D')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 3) error: Expected 'D'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "D",
                Label = "D",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 4)
        private ParseTree? ParseRule2070604292Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'E')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 4) error: Expected 'E'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "E",
                Label = "E",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 5)
        private ParseTree? ParseRule2070604292Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'F')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 5) error: Expected 'F'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "F",
                Label = "F",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 6)
        private ParseTree? ParseRule2070604292Option6()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'G')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 6) error: Expected 'G'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "G",
                Label = "G",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 7)
        private ParseTree? ParseRule2070604292Option7()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'H')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 7) error: Expected 'H'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "H",
                Label = "H",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 8)
        private ParseTree? ParseRule2070604292Option8()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'I')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 8) error: Expected 'I'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "I",
                Label = "I",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 9)
        private ParseTree? ParseRule2070604292Option9()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'J')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 9) error: Expected 'J'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "J",
                Label = "J",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 10)
        private ParseTree? ParseRule2070604292Option10()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'K')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 10) error: Expected 'K'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "K",
                Label = "K",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 11)
        private ParseTree? ParseRule2070604292Option11()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'L')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 11) error: Expected 'L'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "L",
                Label = "L",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 12)
        private ParseTree? ParseRule2070604292Option12()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'M')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 12) error: Expected 'M'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "M",
                Label = "M",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 13)
        private ParseTree? ParseRule2070604292Option13()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'N')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 13) error: Expected 'N'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "N",
                Label = "N",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 14)
        private ParseTree? ParseRule2070604292Option14()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'O')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 14) error: Expected 'O'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "O",
                Label = "O",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 15)
        private ParseTree? ParseRule2070604292Option15()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'P')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 15) error: Expected 'P'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "P",
                Label = "P",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 16)
        private ParseTree? ParseRule2070604292Option16()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'Q')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 16) error: Expected 'Q'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "Q",
                Label = "Q",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 17)
        private ParseTree? ParseRule2070604292Option17()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'R')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 17) error: Expected 'R'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "R",
                Label = "R",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 18)
        private ParseTree? ParseRule2070604292Option18()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'S')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 18) error: Expected 'S'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "S",
                Label = "S",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 19)
        private ParseTree? ParseRule2070604292Option19()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'T')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 19) error: Expected 'T'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "T",
                Label = "T",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 20)
        private ParseTree? ParseRule2070604292Option20()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'U')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 20) error: Expected 'U'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "U",
                Label = "U",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 21)
        private ParseTree? ParseRule2070604292Option21()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'V')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 21) error: Expected 'V'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "V",
                Label = "V",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 22)
        private ParseTree? ParseRule2070604292Option22()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'W')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 22) error: Expected 'W'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "W",
                Label = "W",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 23)
        private ParseTree? ParseRule2070604292Option23()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'X')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 23) error: Expected 'X'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "X",
                Label = "X",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 24)
        private ParseTree? ParseRule2070604292Option24()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'Y')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 24) error: Expected 'Y'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "Y",
                Label = "Y",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 25)
        private ParseTree? ParseRule2070604292Option25()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'Z')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 25) error: Expected 'Z'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "Z",
                Label = "Z",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 26)
        private ParseTree? ParseRule2070604292Option26()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'a')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 26) error: Expected 'a'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "a",
                Label = "a",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 27)
        private ParseTree? ParseRule2070604292Option27()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'b')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 27) error: Expected 'b'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "b",
                Label = "b",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 28)
        private ParseTree? ParseRule2070604292Option28()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'c')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 28) error: Expected 'c'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "c",
                Label = "c",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 29)
        private ParseTree? ParseRule2070604292Option29()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'd')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 29) error: Expected 'd'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "d",
                Label = "d",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 30)
        private ParseTree? ParseRule2070604292Option30()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'e')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 30) error: Expected 'e'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "e",
                Label = "e",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 31)
        private ParseTree? ParseRule2070604292Option31()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'f')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 31) error: Expected 'f'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "f",
                Label = "f",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 32)
        private ParseTree? ParseRule2070604292Option32()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'g')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 32) error: Expected 'g'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "g",
                Label = "g",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 33)
        private ParseTree? ParseRule2070604292Option33()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'h')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 33) error: Expected 'h'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "h",
                Label = "h",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 34)
        private ParseTree? ParseRule2070604292Option34()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'i')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 34) error: Expected 'i'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "i",
                Label = "i",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 35)
        private ParseTree? ParseRule2070604292Option35()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'j')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 35) error: Expected 'j'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "j",
                Label = "j",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 36)
        private ParseTree? ParseRule2070604292Option36()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'k')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 36) error: Expected 'k'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "k",
                Label = "k",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 37)
        private ParseTree? ParseRule2070604292Option37()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'l')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 37) error: Expected 'l'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "l",
                Label = "l",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 38)
        private ParseTree? ParseRule2070604292Option38()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'm')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 38) error: Expected 'm'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "m",
                Label = "m",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 39)
        private ParseTree? ParseRule2070604292Option39()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 39) error: Expected 'n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "n",
                Label = "n",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 40)
        private ParseTree? ParseRule2070604292Option40()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'o')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 40) error: Expected 'o'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "o",
                Label = "o",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 41)
        private ParseTree? ParseRule2070604292Option41()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'p')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 41) error: Expected 'p'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "p",
                Label = "p",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 42)
        private ParseTree? ParseRule2070604292Option42()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'q')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 42) error: Expected 'q'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "q",
                Label = "q",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 43)
        private ParseTree? ParseRule2070604292Option43()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 43) error: Expected 'r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "r",
                Label = "r",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 44)
        private ParseTree? ParseRule2070604292Option44()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 's')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 44) error: Expected 's'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "s",
                Label = "s",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 45)
        private ParseTree? ParseRule2070604292Option45()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 't')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 45) error: Expected 't'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "t",
                Label = "t",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 46)
        private ParseTree? ParseRule2070604292Option46()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'u')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 46) error: Expected 'u'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "u",
                Label = "u",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 47)
        private ParseTree? ParseRule2070604292Option47()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'v')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 47) error: Expected 'v'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "v",
                Label = "v",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 48)
        private ParseTree? ParseRule2070604292Option48()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'w')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 48) error: Expected 'w'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "w",
                Label = "w",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 49)
        private ParseTree? ParseRule2070604292Option49()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'x')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 49) error: Expected 'x'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "x",
                Label = "x",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 50)
        private ParseTree? ParseRule2070604292Option50()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'y')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 50) error: Expected 'y'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "y",
                Label = "y",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 51)
        private ParseTree? ParseRule2070604292Option51()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'z')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 51) error: Expected 'z'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "z",
                Label = "z",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 52)
        private ParseTree? ParseRule2070604292Option52()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ä')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 52) error: Expected 'ä'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "ä",
                Label = "ä",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 53)
        private ParseTree? ParseRule2070604292Option53()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ö')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 53) error: Expected 'ö'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "ö",
                Label = "ö",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 54)
        private ParseTree? ParseRule2070604292Option54()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ü')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 54) error: Expected 'ü'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "ü",
                Label = "ü",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: letter (Option 55)
        private ParseTree? ParseRule2070604292Option55()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "letter",
                Value = "letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ß')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: letter (Option 55) error: Expected 'ß'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "ß",
                Label = "ß",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero
        private ParseTree? ParseRuleN721255545()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN721255545Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: digitWithoutZero (Option 0)
        private ParseTree? ParseRuleN721255545Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '1')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 0) error: Expected '1'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "1",
                Label = "1",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 1)
        private ParseTree? ParseRuleN721255545Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '2')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 1) error: Expected '2'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "2",
                Label = "2",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 2)
        private ParseTree? ParseRuleN721255545Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '3')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 2) error: Expected '3'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "3",
                Label = "3",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 3)
        private ParseTree? ParseRuleN721255545Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '4')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 3) error: Expected '4'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "4",
                Label = "4",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 4)
        private ParseTree? ParseRuleN721255545Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '5')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 4) error: Expected '5'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "5",
                Label = "5",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 5)
        private ParseTree? ParseRuleN721255545Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '6')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 5) error: Expected '6'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "6",
                Label = "6",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 6)
        private ParseTree? ParseRuleN721255545Option6()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '7')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 6) error: Expected '7'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "7",
                Label = "7",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 7)
        private ParseTree? ParseRuleN721255545Option7()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '8')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 7) error: Expected '8'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "8",
                Label = "8",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero (Option 8)
        private ParseTree? ParseRuleN721255545Option8()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digitWithoutZero",
                Value = "digitWithoutZero",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '9')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digitWithoutZero (Option 8) error: Expected '9'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "9",
                Label = "9",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digit
        private ParseTree? ParseRuleN730440534()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN730440534Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN730440534Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: digit (Option 0)
        private ParseTree? ParseRuleN730440534Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '0')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 0) error: Expected '0'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "0",
                Label = "0",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digit (Option 1)
        private ParseTree? ParseRuleN730440534Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN721255545(); // Parse rule: digitWithoutZero
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: digit (Option 1) error: Could not parse rule: digitWithoutZero");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol
        private ParseTree? ParseRule962506183()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule962506183Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option11();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option12();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option13();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option14();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option15();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option16();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option17();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option18();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option19();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option20();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option21();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option22();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option23();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option24();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option25();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option26();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option27();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option28();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option29();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option30();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option31();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option32();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option33();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option34();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option35();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option36();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule962506183Option37();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: symbol (Option 0)
        private ParseTree? ParseRule962506183Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '!')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 0) error: Expected '!'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "!",
                Label = "!",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 1)
        private ParseTree? ParseRule962506183Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '§')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 1) error: Expected '§'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "§",
                Label = "§",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 2)
        private ParseTree? ParseRule962506183Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '$')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 2) error: Expected '$'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "$",
                Label = "$",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 3)
        private ParseTree? ParseRule962506183Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '%')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 3) error: Expected '%'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "%",
                Label = "%",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 4)
        private ParseTree? ParseRule962506183Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '&')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 4) error: Expected '&'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "&",
                Label = "&",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 5)
        private ParseTree? ParseRule962506183Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '/')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 5) error: Expected '/'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "/",
                Label = "/",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 6)
        private ParseTree? ParseRule962506183Option6()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 6) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "(",
                Label = "(",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 7)
        private ParseTree? ParseRule962506183Option7()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 7) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ")",
                Label = ")",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 8)
        private ParseTree? ParseRule962506183Option8()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '=')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 8) error: Expected '='; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "=",
                Label = "=",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 9)
        private ParseTree? ParseRule962506183Option9()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '?')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 9) error: Expected '?'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "?",
                Label = "?",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 10)
        private ParseTree? ParseRule962506183Option10()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '`')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 10) error: Expected '`'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "`",
                Label = "`",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 11)
        private ParseTree? ParseRule962506183Option11()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '´')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 11) error: Expected '´'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "´",
                Label = "´",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 12)
        private ParseTree? ParseRule962506183Option12()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '²')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 12) error: Expected '²'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "²",
                Label = "²",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 13)
        private ParseTree? ParseRule962506183Option13()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '³')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 13) error: Expected '³'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "³",
                Label = "³",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 14)
        private ParseTree? ParseRule962506183Option14()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '{')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 14) error: Expected '{'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "{",
                Label = "{",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 15)
        private ParseTree? ParseRule962506183Option15()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '}')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 15) error: Expected '}'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "}",
                Label = "}",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 16)
        private ParseTree? ParseRule962506183Option16()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ' ')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 16) error: Expected 'Whitespace'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = " ",
                Label = "Whitespace",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 17)
        private ParseTree? ParseRule962506183Option17()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '[')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 17) error: Expected '['; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "[",
                Label = "[",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 18)
        private ParseTree? ParseRule962506183Option18()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ']')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 18) error: Expected ']'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "]",
                Label = "]",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 19)
        private ParseTree? ParseRule962506183Option19()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\\')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 19) error: Expected '\\'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\\",
                Label = "\\",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 20)
        private ParseTree? ParseRule962506183Option20()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '@')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 20) error: Expected '@'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "@",
                Label = "@",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 21)
        private ParseTree? ParseRule962506183Option21()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '€')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 21) error: Expected '€'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "€",
                Label = "€",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 22)
        private ParseTree? ParseRule962506183Option22()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '~')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 22) error: Expected '~'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "~",
                Label = "~",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 23)
        private ParseTree? ParseRule962506183Option23()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '*')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 23) error: Expected '*'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "*",
                Label = "*",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 24)
        private ParseTree? ParseRule962506183Option24()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '+')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 24) error: Expected '+'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "+",
                Label = "+",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 25)
        private ParseTree? ParseRule962506183Option25()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '#')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 25) error: Expected '#'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "#",
                Label = "#",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 26)
        private ParseTree? ParseRule962506183Option26()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 26) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 27)
        private ParseTree? ParseRule962506183Option27()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '_')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 27) error: Expected '_'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "_",
                Label = "_",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 28)
        private ParseTree? ParseRule962506183Option28()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '.')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 28) error: Expected '.'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ".",
                Label = ".",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 29)
        private ParseTree? ParseRule962506183Option29()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 29) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ":",
                Label = ":",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 30)
        private ParseTree? ParseRule962506183Option30()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 30) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 31)
        private ParseTree? ParseRule962506183Option31()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ';')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 31) error: Expected ';'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ";",
                Label = ";",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 32)
        private ParseTree? ParseRule962506183Option32()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '<')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 32) error: Expected '<'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "<",
                Label = "<",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 33)
        private ParseTree? ParseRule962506183Option33()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '>')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 33) error: Expected '>'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ">",
                Label = ">",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 34)
        private ParseTree? ParseRule962506183Option34()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '|')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 34) error: Expected '|'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "|",
                Label = "|",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 35)
        private ParseTree? ParseRule962506183Option35()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\t')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 35) error: Expected '\\t'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\t",
                Label = "\\t",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 36)
        private ParseTree? ParseRule962506183Option36()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 36) error: Expected '\\n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\n",
                Label = "\\n",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: symbol (Option 37)
        private ParseTree? ParseRule962506183Option37()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "symbol",
                Value = "symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: symbol (Option 37) error: Expected '\\r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\r",
                Label = "\\r",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }
    }
}