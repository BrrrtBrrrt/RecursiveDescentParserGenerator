
using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator
{
    public class BnfParser : IParser
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
            ParseTree? parseTree = ParseRuleN665207827();
            return parseTree;
        }

        
        // Parse rule: BNF
        private ParseTree? ParseRuleN665207827()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN665207827Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: BNF (Option 0)
        private ParseTree? ParseRuleN665207827Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "BNF",
                Value = "BNF",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule261431393(); // Parse rule: Rules
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: BNF (Option 0) error: Could not parse rule: Rules");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Rules
        private ParseTree? ParseRule261431393()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule261431393Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Rules (Option 0)
        private ParseTree? ParseRule261431393Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Rules",
                Value = "Rules",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1841857374(); // Parse rule: Rule
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Rules (Option 0) error: Could not parse rule: Rule");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN690094720(); // Parse rule: Rules2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Rules2
        private ParseTree? ParseRuleN690094720()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN690094720Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN690094720Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Rules2 (Option 0)
        private ParseTree? ParseRuleN690094720Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Rules2",
                Value = "Rules2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN150404546(); // Parse rule: LineEnd
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Rules2 (Option 0) error: Could not parse rule: LineEnd");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1841857374(); // Parse rule: Rule
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Rules2 (Option 0) error: Could not parse rule: Rule");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN690094720(); // Parse rule: Rules2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Rules2 (Option 1)
        private ParseTree? ParseRuleN690094720Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Rules2",
                Value = "Rules2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Rule
        private ParseTree? ParseRuleN1841857374()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1841857374Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Rule (Option 0)
        private ParseTree? ParseRuleN1841857374Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Rule",
                Value = "Rule",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '<')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Rule (Option 0) error: Expected '<'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "<",
                Label = "<",
            });
            lastId++;

            parseTreeChild = ParseRule605324277(); // Parse rule: RuleName
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Rule (Option 0) error: Could not parse rule: RuleName");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '>')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Rule (Option 0) error: Expected '>'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ">",
                Label = ">",
            });
            lastId++;

            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Rule (Option 0) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ":",
                Label = ":",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Rule (Option 0) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ":",
                Label = ":",
            });
            lastId++;

            if (!ParserUtil.Eat(ref input, '=')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Rule (Option 0) error: Expected '='; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "=",
                Label = "=",
            });
            lastId++;

            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule2000200929(); // Parse rule: Options
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Rule (Option 0) error: Could not parse rule: Options");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: WhiteSpaceOptional
        private ParseTree? ParseRuleN1632136647()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1632136647Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1632136647Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: WhiteSpaceOptional (Option 0)
        private ParseTree? ParseRuleN1632136647Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "WhiteSpaceOptional",
                Value = "WhiteSpaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ' ')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: WhiteSpaceOptional (Option 0) error: Expected 'Whitespace'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = " ",
                Label = "Whitespace",
            });
            lastId++;

            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: WhiteSpaceOptional (Option 1)
        private ParseTree? ParseRuleN1632136647Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "WhiteSpaceOptional",
                Value = "WhiteSpaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: RuleName
        private ParseTree? ParseRule605324277()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule605324277Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule605324277Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: RuleName (Option 0)
        private ParseTree? ParseRule605324277Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "RuleName",
                Value = "RuleName",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN573938828(); // Parse rule: Letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: RuleName (Option 0) error: Could not parse rule: Letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1870164535(); // Parse rule: RuleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: RuleName (Option 1)
        private ParseTree? ParseRule605324277Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "RuleName",
                Value = "RuleName",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN583007879(); // Parse rule: Digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: RuleName (Option 1) error: Could not parse rule: Digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1870164535(); // Parse rule: RuleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: RuleName2
        private ParseTree? ParseRule1870164535()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1870164535Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1870164535Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1870164535Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1870164535Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: RuleName2 (Option 0)
        private ParseTree? ParseRule1870164535Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "RuleName2",
                Value = "RuleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule605324277(); // Parse rule: RuleName
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: RuleName2 (Option 0) error: Could not parse rule: RuleName");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: RuleName2 (Option 1)
        private ParseTree? ParseRule1870164535Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "RuleName2",
                Value = "RuleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: RuleName2 (Option 1) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            parseTreeChild = ParseRule1870164535(); // Parse rule: RuleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: RuleName2 (Option 2)
        private ParseTree? ParseRule1870164535Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "RuleName2",
                Value = "RuleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '_')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: RuleName2 (Option 2) error: Expected '_'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "_",
                Label = "_",
            });
            lastId++;

            parseTreeChild = ParseRule1870164535(); // Parse rule: RuleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: RuleName2 (Option 3)
        private ParseTree? ParseRule1870164535Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "RuleName2",
                Value = "RuleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Options
        private ParseTree? ParseRule2000200929()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule2000200929Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Options (Option 0)
        private ParseTree? ParseRule2000200929Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Options",
                Value = "Options",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN572632277(); // Parse rule: Option
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Options (Option 0) error: Could not parse rule: Option");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1236961124(); // Parse rule: Options2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Options2
        private ParseTree? ParseRuleN1236961124()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1236961124Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1236961124Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Options2 (Option 0)
        private ParseTree? ParseRuleN1236961124Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Options2",
                Value = "Options2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '|')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Options2 (Option 0) error: Expected '|'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "|",
                Label = "|",
            });
            lastId++;

            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN572632277(); // Parse rule: Option
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Options2 (Option 0) error: Could not parse rule: Option");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1236961124(); // Parse rule: Options2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Options2 (Option 1)
        private ParseTree? ParseRuleN1236961124Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Options2",
                Value = "Options2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Option
        private ParseTree? ParseRuleN572632277()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN572632277Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN572632277Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Option (Option 0)
        private ParseTree? ParseRuleN572632277Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Option",
                Value = "Option",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule773767832(); // Parse rule: Tokens
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Option (Option 0) error: Could not parse rule: Tokens");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Option (Option 1)
        private ParseTree? ParseRuleN572632277Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Option",
                Value = "Option",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'E')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Option (Option 1) error: Expected 'E'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Tokens
        private ParseTree? ParseRule773767832()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule773767832Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Tokens (Option 0)
        private ParseTree? ParseRule773767832Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Tokens",
                Value = "Tokens",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1147738821(); // Parse rule: Token
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Tokens (Option 0) error: Could not parse rule: Token");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule995248312(); // Parse rule: Tokens2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Tokens2
        private ParseTree? ParseRule995248312()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule995248312Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule995248312Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Tokens2 (Option 0)
        private ParseTree? ParseRule995248312Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Tokens2",
                Value = "Tokens2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1632136647(); // Parse rule: WhiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1147738821(); // Parse rule: Token
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Tokens2 (Option 0) error: Could not parse rule: Token");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule995248312(); // Parse rule: Tokens2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Tokens2 (Option 1)
        private ParseTree? ParseRule995248312Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Tokens2",
                Value = "Tokens2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: Token
        private ParseTree? ParseRuleN1147738821()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1147738821Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1147738821Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1147738821Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Token (Option 0)
        private ParseTree? ParseRuleN1147738821Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Token",
                Value = "Token",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '<')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Token (Option 0) error: Expected '<'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "<",
                Label = "<",
            });
            lastId++;

            parseTreeChild = ParseRule605324277(); // Parse rule: RuleName
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Token (Option 0) error: Could not parse rule: RuleName");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '>')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Token (Option 0) error: Expected '>'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Token (Option 1)
        private ParseTree? ParseRuleN1147738821Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Token",
                Value = "Token",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Token (Option 1) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRule1582814305(); // Parse rule: TextNoDoubleQuote
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Token (Option 1) error: Could not parse rule: TextNoDoubleQuote");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Token (Option 1) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Token (Option 2)
        private ParseTree? ParseRuleN1147738821Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Token",
                Value = "Token",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Token (Option 2) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            parseTreeChild = ParseRuleN371096139(); // Parse rule: TextNoSingleQuote
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: Token (Option 2) error: Could not parse rule: TextNoSingleQuote");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Token (Option 2) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote
        private ParseTree? ParseRuleN371096139()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN371096139Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN371096139Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN371096139Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN371096139Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: TextNoSingleQuote (Option 0)
        private ParseTree? ParseRuleN371096139Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote",
                Value = "TextNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN573938828(); // Parse rule: Letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoSingleQuote (Option 0) error: Could not parse rule: Letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote (Option 1)
        private ParseTree? ParseRuleN371096139Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote",
                Value = "TextNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN583007879(); // Parse rule: Digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoSingleQuote (Option 1) error: Could not parse rule: Digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote (Option 2)
        private ParseTree? ParseRuleN371096139Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote",
                Value = "TextNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1272993890(); // Parse rule: Symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoSingleQuote (Option 2) error: Could not parse rule: Symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote (Option 3)
        private ParseTree? ParseRuleN371096139Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote",
                Value = "TextNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: TextNoSingleQuote (Option 3) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote2
        private ParseTree? ParseRule1281940655()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1281940655Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1281940655Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1281940655Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1281940655Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1281940655Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: TextNoSingleQuote2 (Option 0)
        private ParseTree? ParseRule1281940655Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote2",
                Value = "TextNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN573938828(); // Parse rule: Letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoSingleQuote2 (Option 0) error: Could not parse rule: Letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote2 (Option 1)
        private ParseTree? ParseRule1281940655Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote2",
                Value = "TextNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN583007879(); // Parse rule: Digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoSingleQuote2 (Option 1) error: Could not parse rule: Digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote2 (Option 2)
        private ParseTree? ParseRule1281940655Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote2",
                Value = "TextNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1272993890(); // Parse rule: Symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoSingleQuote2 (Option 2) error: Could not parse rule: Symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote2 (Option 3)
        private ParseTree? ParseRule1281940655Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote2",
                Value = "TextNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: TextNoSingleQuote2 (Option 3) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRule1281940655(); // Parse rule: TextNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoSingleQuote2 (Option 4)
        private ParseTree? ParseRule1281940655Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoSingleQuote2",
                Value = "TextNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote
        private ParseTree? ParseRule1582814305()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1582814305Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1582814305Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1582814305Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1582814305Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: TextNoDoubleQuote (Option 0)
        private ParseTree? ParseRule1582814305Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote",
                Value = "TextNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN573938828(); // Parse rule: Letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoDoubleQuote (Option 0) error: Could not parse rule: Letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote (Option 1)
        private ParseTree? ParseRule1582814305Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote",
                Value = "TextNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN583007879(); // Parse rule: Digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoDoubleQuote (Option 1) error: Could not parse rule: Digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote (Option 2)
        private ParseTree? ParseRule1582814305Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote",
                Value = "TextNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1272993890(); // Parse rule: Symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoDoubleQuote (Option 2) error: Could not parse rule: Symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote (Option 3)
        private ParseTree? ParseRule1582814305Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote",
                Value = "TextNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: TextNoDoubleQuote (Option 3) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote2
        private ParseTree? ParseRule123087938()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule123087938Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule123087938Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule123087938Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule123087938Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule123087938Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: TextNoDoubleQuote2 (Option 0)
        private ParseTree? ParseRule123087938Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote2",
                Value = "TextNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN573938828(); // Parse rule: Letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoDoubleQuote2 (Option 0) error: Could not parse rule: Letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote2 (Option 1)
        private ParseTree? ParseRule123087938Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote2",
                Value = "TextNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN583007879(); // Parse rule: Digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoDoubleQuote2 (Option 1) error: Could not parse rule: Digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote2 (Option 2)
        private ParseTree? ParseRule123087938Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote2",
                Value = "TextNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1272993890(); // Parse rule: Symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: TextNoDoubleQuote2 (Option 2) error: Could not parse rule: Symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote2 (Option 3)
        private ParseTree? ParseRule123087938Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote2",
                Value = "TextNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: TextNoDoubleQuote2 (Option 3) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            parseTreeChild = ParseRule123087938(); // Parse rule: TextNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: TextNoDoubleQuote2 (Option 4)
        private ParseTree? ParseRule123087938Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "TextNoDoubleQuote2",
                Value = "TextNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: LineEnd
        private ParseTree? ParseRuleN150404546()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN150404546Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN150404546Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: LineEnd (Option 0)
        private ParseTree? ParseRuleN150404546Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "LineEnd",
                Value = "LineEnd",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: LineEnd (Option 0) error: Expected '\\r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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
                errors.Add("Parse rule: LineEnd (Option 0) error: Expected '\\n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: LineEnd (Option 1)
        private ParseTree? ParseRuleN150404546Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "LineEnd",
                Value = "LineEnd",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: LineEnd (Option 1) error: Expected '\\n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter
        private ParseTree? ParseRuleN573938828()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option11();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option12();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option13();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option14();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option15();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option16();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option17();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option18();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option19();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option20();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option21();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option22();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option23();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option24();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option25();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option26();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option27();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option28();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option29();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option30();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option31();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option32();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option33();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option34();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option35();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option36();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option37();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option38();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option39();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option40();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option41();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option42();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option43();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option44();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option45();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option46();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option47();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option48();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option49();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option50();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option51();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option52();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option53();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option54();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN573938828Option55();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Letter (Option 0)
        private ParseTree? ParseRuleN573938828Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'A')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 0) error: Expected 'A'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 1)
        private ParseTree? ParseRuleN573938828Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'B')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 1) error: Expected 'B'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 2)
        private ParseTree? ParseRuleN573938828Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'C')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 2) error: Expected 'C'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 3)
        private ParseTree? ParseRuleN573938828Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'D')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 3) error: Expected 'D'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 4)
        private ParseTree? ParseRuleN573938828Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'E')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 4) error: Expected 'E'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 5)
        private ParseTree? ParseRuleN573938828Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'F')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 5) error: Expected 'F'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 6)
        private ParseTree? ParseRuleN573938828Option6()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'G')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 6) error: Expected 'G'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 7)
        private ParseTree? ParseRuleN573938828Option7()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'H')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 7) error: Expected 'H'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 8)
        private ParseTree? ParseRuleN573938828Option8()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'I')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 8) error: Expected 'I'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 9)
        private ParseTree? ParseRuleN573938828Option9()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'J')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 9) error: Expected 'J'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 10)
        private ParseTree? ParseRuleN573938828Option10()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'K')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 10) error: Expected 'K'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 11)
        private ParseTree? ParseRuleN573938828Option11()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'L')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 11) error: Expected 'L'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 12)
        private ParseTree? ParseRuleN573938828Option12()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'M')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 12) error: Expected 'M'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 13)
        private ParseTree? ParseRuleN573938828Option13()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'N')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 13) error: Expected 'N'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 14)
        private ParseTree? ParseRuleN573938828Option14()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'O')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 14) error: Expected 'O'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 15)
        private ParseTree? ParseRuleN573938828Option15()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'P')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 15) error: Expected 'P'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 16)
        private ParseTree? ParseRuleN573938828Option16()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'Q')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 16) error: Expected 'Q'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 17)
        private ParseTree? ParseRuleN573938828Option17()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'R')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 17) error: Expected 'R'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 18)
        private ParseTree? ParseRuleN573938828Option18()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'S')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 18) error: Expected 'S'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 19)
        private ParseTree? ParseRuleN573938828Option19()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'T')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 19) error: Expected 'T'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 20)
        private ParseTree? ParseRuleN573938828Option20()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'U')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 20) error: Expected 'U'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 21)
        private ParseTree? ParseRuleN573938828Option21()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'V')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 21) error: Expected 'V'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 22)
        private ParseTree? ParseRuleN573938828Option22()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'W')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 22) error: Expected 'W'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 23)
        private ParseTree? ParseRuleN573938828Option23()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'X')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 23) error: Expected 'X'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 24)
        private ParseTree? ParseRuleN573938828Option24()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'Y')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 24) error: Expected 'Y'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 25)
        private ParseTree? ParseRuleN573938828Option25()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'Z')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 25) error: Expected 'Z'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 26)
        private ParseTree? ParseRuleN573938828Option26()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'a')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 26) error: Expected 'a'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 27)
        private ParseTree? ParseRuleN573938828Option27()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'b')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 27) error: Expected 'b'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 28)
        private ParseTree? ParseRuleN573938828Option28()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'c')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 28) error: Expected 'c'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 29)
        private ParseTree? ParseRuleN573938828Option29()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'd')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 29) error: Expected 'd'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 30)
        private ParseTree? ParseRuleN573938828Option30()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'e')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 30) error: Expected 'e'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 31)
        private ParseTree? ParseRuleN573938828Option31()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'f')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 31) error: Expected 'f'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 32)
        private ParseTree? ParseRuleN573938828Option32()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'g')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 32) error: Expected 'g'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 33)
        private ParseTree? ParseRuleN573938828Option33()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'h')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 33) error: Expected 'h'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 34)
        private ParseTree? ParseRuleN573938828Option34()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'i')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 34) error: Expected 'i'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 35)
        private ParseTree? ParseRuleN573938828Option35()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'j')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 35) error: Expected 'j'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 36)
        private ParseTree? ParseRuleN573938828Option36()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'k')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 36) error: Expected 'k'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 37)
        private ParseTree? ParseRuleN573938828Option37()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'l')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 37) error: Expected 'l'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 38)
        private ParseTree? ParseRuleN573938828Option38()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'm')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 38) error: Expected 'm'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 39)
        private ParseTree? ParseRuleN573938828Option39()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 39) error: Expected 'n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 40)
        private ParseTree? ParseRuleN573938828Option40()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'o')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 40) error: Expected 'o'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 41)
        private ParseTree? ParseRuleN573938828Option41()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'p')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 41) error: Expected 'p'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 42)
        private ParseTree? ParseRuleN573938828Option42()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'q')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 42) error: Expected 'q'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 43)
        private ParseTree? ParseRuleN573938828Option43()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 43) error: Expected 'r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 44)
        private ParseTree? ParseRuleN573938828Option44()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 's')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 44) error: Expected 's'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 45)
        private ParseTree? ParseRuleN573938828Option45()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 't')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 45) error: Expected 't'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 46)
        private ParseTree? ParseRuleN573938828Option46()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'u')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 46) error: Expected 'u'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 47)
        private ParseTree? ParseRuleN573938828Option47()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'v')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 47) error: Expected 'v'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 48)
        private ParseTree? ParseRuleN573938828Option48()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'w')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 48) error: Expected 'w'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 49)
        private ParseTree? ParseRuleN573938828Option49()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'x')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 49) error: Expected 'x'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 50)
        private ParseTree? ParseRuleN573938828Option50()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'y')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 50) error: Expected 'y'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 51)
        private ParseTree? ParseRuleN573938828Option51()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'z')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 51) error: Expected 'z'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 52)
        private ParseTree? ParseRuleN573938828Option52()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ä')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 52) error: Expected 'ä'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 53)
        private ParseTree? ParseRuleN573938828Option53()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ö')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 53) error: Expected 'ö'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 54)
        private ParseTree? ParseRuleN573938828Option54()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ü')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 54) error: Expected 'ü'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Letter (Option 55)
        private ParseTree? ParseRuleN573938828Option55()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Letter",
                Value = "Letter",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'ß')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Letter (Option 55) error: Expected 'ß'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit
        private ParseTree? ParseRuleN583007879()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN583007879Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Digit (Option 0)
        private ParseTree? ParseRuleN583007879Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '0')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 0) error: Expected '0'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 1)
        private ParseTree? ParseRuleN583007879Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '1')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 1) error: Expected '1'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 2)
        private ParseTree? ParseRuleN583007879Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '2')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 2) error: Expected '2'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 3)
        private ParseTree? ParseRuleN583007879Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '3')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 3) error: Expected '3'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 4)
        private ParseTree? ParseRuleN583007879Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '4')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 4) error: Expected '4'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 5)
        private ParseTree? ParseRuleN583007879Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '5')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 5) error: Expected '5'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 6)
        private ParseTree? ParseRuleN583007879Option6()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '6')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 6) error: Expected '6'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 7)
        private ParseTree? ParseRuleN583007879Option7()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '7')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 7) error: Expected '7'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 8)
        private ParseTree? ParseRuleN583007879Option8()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '8')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 8) error: Expected '8'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Digit (Option 9)
        private ParseTree? ParseRuleN583007879Option9()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Digit",
                Value = "Digit",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '9')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Digit (Option 9) error: Expected '9'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol
        private ParseTree? ParseRule1272993890()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1272993890Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option11();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option12();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option13();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option14();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option15();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option16();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option17();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option18();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option19();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option20();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option21();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option22();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option23();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option24();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option25();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option26();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option27();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option28();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option29();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option30();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option31();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option32();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option33();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option34();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option35();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option36();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1272993890Option37();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: Symbol (Option 0)
        private ParseTree? ParseRule1272993890Option0()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '!')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 0) error: Expected '!'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 1)
        private ParseTree? ParseRule1272993890Option1()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '§')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 1) error: Expected '§'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 2)
        private ParseTree? ParseRule1272993890Option2()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '$')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 2) error: Expected '$'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 3)
        private ParseTree? ParseRule1272993890Option3()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '%')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 3) error: Expected '%'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 4)
        private ParseTree? ParseRule1272993890Option4()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '&')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 4) error: Expected '&'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 5)
        private ParseTree? ParseRule1272993890Option5()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '/')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 5) error: Expected '/'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 6)
        private ParseTree? ParseRule1272993890Option6()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '(')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 6) error: Expected '('; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 7)
        private ParseTree? ParseRule1272993890Option7()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ')')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 7) error: Expected ')'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 8)
        private ParseTree? ParseRule1272993890Option8()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '=')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 8) error: Expected '='; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 9)
        private ParseTree? ParseRule1272993890Option9()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '?')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 9) error: Expected '?'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 10)
        private ParseTree? ParseRule1272993890Option10()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '`')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 10) error: Expected '`'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 11)
        private ParseTree? ParseRule1272993890Option11()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '´')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 11) error: Expected '´'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 12)
        private ParseTree? ParseRule1272993890Option12()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '²')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 12) error: Expected '²'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 13)
        private ParseTree? ParseRule1272993890Option13()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '³')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 13) error: Expected '³'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 14)
        private ParseTree? ParseRule1272993890Option14()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '{')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 14) error: Expected '{'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 15)
        private ParseTree? ParseRule1272993890Option15()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '}')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 15) error: Expected '}'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 16)
        private ParseTree? ParseRule1272993890Option16()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ' ')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 16) error: Expected 'Whitespace'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 17)
        private ParseTree? ParseRule1272993890Option17()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '[')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 17) error: Expected '['; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 18)
        private ParseTree? ParseRule1272993890Option18()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ']')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 18) error: Expected ']'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 19)
        private ParseTree? ParseRule1272993890Option19()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\\')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 19) error: Expected '\\'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 20)
        private ParseTree? ParseRule1272993890Option20()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '@')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 20) error: Expected '@'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 21)
        private ParseTree? ParseRule1272993890Option21()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '€')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 21) error: Expected '€'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 22)
        private ParseTree? ParseRule1272993890Option22()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '~')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 22) error: Expected '~'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 23)
        private ParseTree? ParseRule1272993890Option23()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '*')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 23) error: Expected '*'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 24)
        private ParseTree? ParseRule1272993890Option24()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '+')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 24) error: Expected '+'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 25)
        private ParseTree? ParseRule1272993890Option25()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '#')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 25) error: Expected '#'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 26)
        private ParseTree? ParseRule1272993890Option26()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 26) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 27)
        private ParseTree? ParseRule1272993890Option27()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '_')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 27) error: Expected '_'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 28)
        private ParseTree? ParseRule1272993890Option28()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '.')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 28) error: Expected '.'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 29)
        private ParseTree? ParseRule1272993890Option29()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 29) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 30)
        private ParseTree? ParseRule1272993890Option30()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ',')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 30) error: Expected ','; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 31)
        private ParseTree? ParseRule1272993890Option31()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ';')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 31) error: Expected ';'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 32)
        private ParseTree? ParseRule1272993890Option32()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '<')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 32) error: Expected '<'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 33)
        private ParseTree? ParseRule1272993890Option33()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '>')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 33) error: Expected '>'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 34)
        private ParseTree? ParseRule1272993890Option34()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '|')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 34) error: Expected '|'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 35)
        private ParseTree? ParseRule1272993890Option35()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\t')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 35) error: Expected '\\t'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 36)
        private ParseTree? ParseRule1272993890Option36()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\n')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 36) error: Expected '\\n'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: Symbol (Option 37)
        private ParseTree? ParseRule1272993890Option37()
        {
            errors.Clear();
            ParseTree parseTree = new()
            {
                Label = "Symbol",
                Value = "Symbol",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\r')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: Symbol (Option 37) error: Expected '\\r'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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