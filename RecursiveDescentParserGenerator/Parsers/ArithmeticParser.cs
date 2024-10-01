
using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator
{
    public class ArithmeticParser : IParser
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
            ParseTree? parseTree = ParseRuleN899962833();
            return parseTree;
        }

        
        // Parse rule: arithmetic
        private ParseTree? ParseRuleN899962833()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN899962833Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: arithmetic (Option 0)
        private ParseTree? ParseRuleN899962833Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "arithmetic",
                Value = "arithmetic",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: arithmetic (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expression
        private ParseTree? ParseRule1149039973()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1149039973Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1149039973Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1149039973Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1149039973Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1149039973Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1149039973Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: expression (Option 0)
        private ParseTree? ParseRule1149039973Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "expression",
                Value = "expression",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule990635954(); // Parse rule: addition
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expression (Option 0) error: Could not parse rule: addition");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expression (Option 1)
        private ParseTree? ParseRule1149039973Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "expression",
                Value = "expression",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN999220378(); // Parse rule: subtraction
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expression (Option 1) error: Could not parse rule: subtraction");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expression (Option 2)
        private ParseTree? ParseRule1149039973Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "expression",
                Value = "expression",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN389961600(); // Parse rule: multiplication
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expression (Option 2) error: Could not parse rule: multiplication");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expression (Option 3)
        private ParseTree? ParseRule1149039973Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "expression",
                Value = "expression",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1358129955(); // Parse rule: division
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expression (Option 3) error: Could not parse rule: division");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expression (Option 4)
        private ParseTree? ParseRule1149039973Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "expression",
                Value = "expression",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1901437141(); // Parse rule: number
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expression (Option 4) error: Could not parse rule: number");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expression (Option 5)
        private ParseTree? ParseRule1149039973Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "expression",
                Value = "expression",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: expression (Option 5) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "(",
                Label = "(",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expression (Option 5) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: expression (Option 5) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: addition
        private ParseTree? ParseRule990635954()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule990635954Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: addition (Option 0)
        private ParseTree? ParseRule990635954Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "addition",
                Value = "addition",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '+')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: addition (Option 0) error: Expected '+'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "+",
                Label = "+",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: addition (Option 0) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "(",
                Label = "(",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: addition (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: addition (Option 0) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: addition (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: addition (Option 0) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: subtraction
        private ParseTree? ParseRuleN999220378()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN999220378Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: subtraction (Option 0)
        private ParseTree? ParseRuleN999220378Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "subtraction",
                Value = "subtraction",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: subtraction (Option 0) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: subtraction (Option 0) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "(",
                Label = "(",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: subtraction (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: subtraction (Option 0) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: subtraction (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: subtraction (Option 0) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: multiplication
        private ParseTree? ParseRuleN389961600()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN389961600Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: multiplication (Option 0)
        private ParseTree? ParseRuleN389961600Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "multiplication",
                Value = "multiplication",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '*')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: multiplication (Option 0) error: Expected '*'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "*",
                Label = "*",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: multiplication (Option 0) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "(",
                Label = "(",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: multiplication (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: multiplication (Option 0) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: multiplication (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: multiplication (Option 0) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: division
        private ParseTree? ParseRuleN1358129955()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1358129955Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: division (Option 0)
        private ParseTree? ParseRuleN1358129955Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "division",
                Value = "division",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '/')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: division (Option 0) error: Expected '/'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "/",
                Label = "/",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: division (Option 0) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "(",
                Label = "(",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: division (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: division (Option 0) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ",",
                Label = ",",
            });
            lastId++;

            parseTreeChild = ParseRule1149039973(); // Parse rule: expression
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: division (Option 0) error: Could not parse rule: expression");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: division (Option 0) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: number
        private ParseTree? ParseRuleN1901437141()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1901437141Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1901437141Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: number (Option 0)
        private ParseTree? ParseRuleN1901437141Option0()
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

            
            parseTreeChild = ParseRuleN965531767(); // Parse rule: float
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: number (Option 0) error: Could not parse rule: float");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number (Option 1)
        private ParseTree? ParseRuleN1901437141Option1()
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

            
            parseTreeChild = ParseRuleN727715447(); // Parse rule: integer
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: number (Option 1) error: Could not parse rule: integer");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer
        private ParseTree? ParseRuleN727715447()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN727715447Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN727715447Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: integer (Option 0)
        private ParseTree? ParseRuleN727715447Option0()
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

            
            parseTreeChild = ParseRule2002021910(); // Parse rule: digitWithoutZero
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: integer (Option 0) error: Could not parse rule: digitWithoutZero");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN529230862(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer (Option 1)
        private ParseTree? ParseRuleN727715447Option1()
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

            parseTreeChild = ParseRule2002021910(); // Parse rule: digitWithoutZero
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: integer (Option 1) error: Could not parse rule: digitWithoutZero");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN529230862(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer2
        private ParseTree? ParseRuleN529230862()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN529230862Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN529230862Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: integer2 (Option 0)
        private ParseTree? ParseRuleN529230862Option0()
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

            
            parseTreeChild = ParseRule1026029183(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: integer2 (Option 0) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN529230862(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: integer2 (Option 1)
        private ParseTree? ParseRuleN529230862Option1()
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
        private ParseTree? ParseRuleN965531767()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN965531767Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN965531767Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN965531767Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN965531767Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: float (Option 0)
        private ParseTree? ParseRuleN965531767Option0()
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

            parseTreeChild = ParseRule1039408224(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 0) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: float (Option 1)
        private ParseTree? ParseRuleN965531767Option1()
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

            parseTreeChild = ParseRule1039408224(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 1) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: float (Option 2)
        private ParseTree? ParseRuleN965531767Option2()
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

            parseTreeChild = ParseRuleN727715447(); // Parse rule: integer
            
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

            parseTreeChild = ParseRule1039408224(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 2) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: float (Option 3)
        private ParseTree? ParseRuleN965531767Option3()
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

            
            parseTreeChild = ParseRuleN727715447(); // Parse rule: integer
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 3) error: Could not parse rule: integer");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '.')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: float (Option 3) error: Expected '.'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ".",
                Label = ".",
            });
            lastId++;

            parseTreeChild = ParseRule1039408224(); // Parse rule: floatDecimalPart
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: float (Option 3) error: Could not parse rule: floatDecimalPart");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: floatDecimalPart
        private ParseTree? ParseRule1039408224()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1039408224Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: floatDecimalPart (Option 0)
        private ParseTree? ParseRule1039408224Option0()
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

            
            parseTreeChild = ParseRule1026029183(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: floatDecimalPart (Option 0) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN529230862(); // Parse rule: integer2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digitWithoutZero
        private ParseTree? ParseRule2002021910()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule2002021910Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule2002021910Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: digitWithoutZero (Option 0)
        private ParseTree? ParseRule2002021910Option0()
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
        private ParseTree? ParseRule2002021910Option1()
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
        private ParseTree? ParseRule2002021910Option2()
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
        private ParseTree? ParseRule2002021910Option3()
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
        private ParseTree? ParseRule2002021910Option4()
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
        private ParseTree? ParseRule2002021910Option5()
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
        private ParseTree? ParseRule2002021910Option6()
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
        private ParseTree? ParseRule2002021910Option7()
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
        private ParseTree? ParseRule2002021910Option8()
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
        private ParseTree? ParseRule1026029183()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1026029183Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1026029183Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: digit (Option 0)
        private ParseTree? ParseRule1026029183Option0()
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
        private ParseTree? ParseRule1026029183Option1()
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

            
            parseTreeChild = ParseRule2002021910(); // Parse rule: digitWithoutZero
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: digit (Option 1) error: Could not parse rule: digitWithoutZero");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }
    }
}