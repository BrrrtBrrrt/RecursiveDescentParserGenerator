
using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator.Parsers
{
    public class FactorParser : IParser
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
            ParseTree? parseTree = ParseRule1718889050();
            return parseTree;
        }

        
        // Parse rule: expr
        private ParseTree? ParseRule1718889050()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1718889050Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: expr (Option 0)
        private ParseTree? ParseRule1718889050Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "expr",
                Value = "expr",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1152807730(); // Parse rule: factor
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expr (Option 0) error: Could not parse rule: factor");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule842537763(); // Parse rule: expr-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expr-D
        private ParseTree? ParseRule842537763()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule842537763Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule842537763Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: expr-D (Option 0)
        private ParseTree? ParseRule842537763Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "expr-D",
                Value = "expr-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '+')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: expr-D (Option 0) error: Expected '+'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "+",
                Label = "+",
            });
            lastId++;

            parseTreeChild = ParseRule1152807730(); // Parse rule: factor
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: expr-D (Option 0) error: Could not parse rule: factor");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule842537763(); // Parse rule: expr-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: expr-D (Option 1)
        private ParseTree? ParseRule842537763Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "expr-D",
                Value = "expr-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: factor
        private ParseTree? ParseRule1152807730()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1152807730Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: factor (Option 0)
        private ParseTree? ParseRule1152807730Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "factor",
                Value = "factor",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN2113972692(); // Parse rule: number
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: factor (Option 0) error: Could not parse rule: number");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN539631040(); // Parse rule: factor-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: factor-D
        private ParseTree? ParseRuleN539631040()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN539631040Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN539631040Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: factor-D (Option 0)
        private ParseTree? ParseRuleN539631040Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "factor-D",
                Value = "factor-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '*')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: factor-D (Option 0) error: Expected '*'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "*",
                Label = "*",
            });
            lastId++;

            parseTreeChild = ParseRuleN2113972692(); // Parse rule: number
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: factor-D (Option 0) error: Could not parse rule: number");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN539631040(); // Parse rule: factor-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: factor-D (Option 1)
        private ParseTree? ParseRuleN539631040Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "factor-D",
                Value = "factor-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number
        private ParseTree? ParseRuleN2113972692()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN2113972692Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: number (Option 0)
        private ParseTree? ParseRuleN2113972692Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "number",
                Value = "number",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule539728156(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: number (Option 0) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D
        private ParseTree? ParseRuleN976994488()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN976994488Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: number-D (Option 0)
        private ParseTree? ParseRuleN976994488Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '0')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 0) error: Expected '0'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "0",
                Label = "0",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 1)
        private ParseTree? ParseRuleN976994488Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '1')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 1) error: Expected '1'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "1",
                Label = "1",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 2)
        private ParseTree? ParseRuleN976994488Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '2')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 2) error: Expected '2'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "2",
                Label = "2",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 3)
        private ParseTree? ParseRuleN976994488Option3()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '3')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 3) error: Expected '3'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "3",
                Label = "3",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 4)
        private ParseTree? ParseRuleN976994488Option4()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '4')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 4) error: Expected '4'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "4",
                Label = "4",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 5)
        private ParseTree? ParseRuleN976994488Option5()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '5')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 5) error: Expected '5'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "5",
                Label = "5",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 6)
        private ParseTree? ParseRuleN976994488Option6()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '6')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 6) error: Expected '6'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "6",
                Label = "6",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 7)
        private ParseTree? ParseRuleN976994488Option7()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '7')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 7) error: Expected '7'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "7",
                Label = "7",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 8)
        private ParseTree? ParseRuleN976994488Option8()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '8')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 8) error: Expected '8'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "8",
                Label = "8",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 9)
        private ParseTree? ParseRuleN976994488Option9()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '9')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: number-D (Option 9) error: Expected '9'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "9",
                Label = "9",
            });
            lastId++;

            parseTreeChild = ParseRuleN976994488(); // Parse rule: number-D
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: number-D (Option 10)
        private ParseTree? ParseRuleN976994488Option10()
        {
            ParseTree parseTree = new()
            {
                Label = "number-D",
                Value = "number-D",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: digit
        private ParseTree? ParseRule539728156()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule539728156Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule539728156Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: digit (Option 0)
        private ParseTree? ParseRule539728156Option0()
        {
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
        private ParseTree? ParseRule539728156Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '1')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 1) error: Expected '1'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 2)
        private ParseTree? ParseRule539728156Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '2')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 2) error: Expected '2'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 3)
        private ParseTree? ParseRule539728156Option3()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '3')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 3) error: Expected '3'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 4)
        private ParseTree? ParseRule539728156Option4()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '4')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 4) error: Expected '4'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 5)
        private ParseTree? ParseRule539728156Option5()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '5')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 5) error: Expected '5'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 6)
        private ParseTree? ParseRule539728156Option6()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '6')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 6) error: Expected '6'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 7)
        private ParseTree? ParseRule539728156Option7()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '7')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 7) error: Expected '7'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 8)
        private ParseTree? ParseRule539728156Option8()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '8')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 8) error: Expected '8'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: digit (Option 9)
        private ParseTree? ParseRule539728156Option9()
        {
            ParseTree parseTree = new()
            {
                Label = "digit",
                Value = "digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '9')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: digit (Option 9) error: Expected '9'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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
    }
}