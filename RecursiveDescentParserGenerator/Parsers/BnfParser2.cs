
using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator.Parsers
{
    public class BnfParser2 : IParser
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
            ParseTree? parseTree = ParseRule936960907();
            return parseTree;
        }

        
        // Parse rule: bnf
        private ParseTree? ParseRule936960907()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule936960907Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: bnf (Option 0)
        private ParseTree? ParseRule936960907Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "bnf",
                Value = "bnf",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN637903950(); // Parse rule: rules
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: bnf (Option 0) error: Could not parse rule: rules");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: rules
        private ParseTree? ParseRuleN637903950()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN637903950Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: rules (Option 0)
        private ParseTree? ParseRuleN637903950Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "rules",
                Value = "rules",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1707511585(); // Parse rule: rule
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: rules (Option 0) error: Could not parse rule: rule");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule249235311(); // Parse rule: rules2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: rules2
        private ParseTree? ParseRule249235311()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule249235311Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule249235311Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: rules2 (Option 0)
        private ParseTree? ParseRule249235311Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "rules2",
                Value = "rules2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1276073765(); // Parse rule: lineEnd
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: rules2 (Option 0) error: Could not parse rule: lineEnd");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1707511585(); // Parse rule: rule
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: rules2 (Option 0) error: Could not parse rule: rule");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule249235311(); // Parse rule: rules2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: rules2 (Option 1)
        private ParseTree? ParseRule249235311Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "rules2",
                Value = "rules2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: rule
        private ParseTree? ParseRule1707511585()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1707511585Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: rule (Option 0)
        private ParseTree? ParseRule1707511585Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "rule",
                Value = "rule",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '<')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: rule (Option 0) error: Expected '<'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "<",
                Label = "<",
            });
            lastId++;

            parseTreeChild = ParseRule1859580978(); // Parse rule: ruleName
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: rule (Option 0) error: Could not parse rule: ruleName");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '>')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: rule (Option 0) error: Expected '>'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = ">",
                Label = ">",
            });
            lastId++;

            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, ':')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: rule (Option 0) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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
                errors.Add("Parse rule: rule (Option 0) error: Expected ':'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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
                errors.Add("Parse rule: rule (Option 0) error: Expected '='; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "=",
                Label = "=",
            });
            lastId++;

            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule1265249092(); // Parse rule: ruleOptions
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: rule (Option 0) error: Could not parse rule: ruleOptions");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: whiteSpaceOptional
        private ParseTree? ParseRuleN325434810()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN325434810Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN325434810Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: whiteSpaceOptional (Option 0)
        private ParseTree? ParseRuleN325434810Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "whiteSpaceOptional",
                Value = "whiteSpaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, ' ')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: whiteSpaceOptional (Option 0) error: Expected 'Whitespace'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = " ",
                Label = "Whitespace",
            });
            lastId++;

            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: whiteSpaceOptional (Option 1)
        private ParseTree? ParseRuleN325434810Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "whiteSpaceOptional",
                Value = "whiteSpaceOptional",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleName
        private ParseTree? ParseRule1859580978()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1859580978Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1859580978Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: ruleName (Option 0)
        private ParseTree? ParseRule1859580978Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleName",
                Value = "ruleName",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1258527231(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: ruleName (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1630864368(); // Parse rule: ruleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleName (Option 1)
        private ParseTree? ParseRule1859580978Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleName",
                Value = "ruleName",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1023606944(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: ruleName (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1630864368(); // Parse rule: ruleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleName2
        private ParseTree? ParseRuleN1630864368()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1630864368Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1630864368Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1630864368Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1630864368Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: ruleName2 (Option 0)
        private ParseTree? ParseRuleN1630864368Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleName2",
                Value = "ruleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1859580978(); // Parse rule: ruleName
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: ruleName2 (Option 0) error: Could not parse rule: ruleName");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleName2 (Option 1)
        private ParseTree? ParseRuleN1630864368Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleName2",
                Value = "ruleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '-')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: ruleName2 (Option 1) error: Expected '-'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "-",
                Label = "-",
            });
            lastId++;

            parseTreeChild = ParseRuleN1630864368(); // Parse rule: ruleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleName2 (Option 2)
        private ParseTree? ParseRuleN1630864368Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleName2",
                Value = "ruleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '_')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: ruleName2 (Option 2) error: Expected '_'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "_",
                Label = "_",
            });
            lastId++;

            parseTreeChild = ParseRuleN1630864368(); // Parse rule: ruleName2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleName2 (Option 3)
        private ParseTree? ParseRuleN1630864368Option3()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleName2",
                Value = "ruleName2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleOptions
        private ParseTree? ParseRule1265249092()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1265249092Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: ruleOptions (Option 0)
        private ParseTree? ParseRule1265249092Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleOptions",
                Value = "ruleOptions",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1186717488(); // Parse rule: ruleOption
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: ruleOptions (Option 0) error: Could not parse rule: ruleOption");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule929975616(); // Parse rule: ruleOptions2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleOptions2
        private ParseTree? ParseRule929975616()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule929975616Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule929975616Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: ruleOptions2 (Option 0)
        private ParseTree? ParseRule929975616Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleOptions2",
                Value = "ruleOptions2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '|')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: ruleOptions2 (Option 0) error: Expected '|'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "|",
                Label = "|",
            });
            lastId++;

            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1186717488(); // Parse rule: ruleOption
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: ruleOptions2 (Option 0) error: Could not parse rule: ruleOption");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule929975616(); // Parse rule: ruleOptions2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleOptions2 (Option 1)
        private ParseTree? ParseRule929975616Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleOptions2",
                Value = "ruleOptions2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleOption
        private ParseTree? ParseRuleN1186717488()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1186717488Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1186717488Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: ruleOption (Option 0)
        private ParseTree? ParseRuleN1186717488Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleOption",
                Value = "ruleOption",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1185505023(); // Parse rule: tokens
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: ruleOption (Option 0) error: Could not parse rule: tokens");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: ruleOption (Option 1)
        private ParseTree? ParseRuleN1186717488Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "ruleOption",
                Value = "ruleOption",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, 'E')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: ruleOption (Option 1) error: Expected 'E'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: tokens
        private ParseTree? ParseRule1185505023()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1185505023Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: tokens (Option 0)
        private ParseTree? ParseRule1185505023Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "tokens",
                Value = "tokens",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1023906596(); // Parse rule: token
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: tokens (Option 0) error: Could not parse rule: token");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN204364584(); // Parse rule: tokens2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: tokens2
        private ParseTree? ParseRuleN204364584()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN204364584Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN204364584Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: tokens2 (Option 0)
        private ParseTree? ParseRuleN204364584Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "tokens2",
                Value = "tokens2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN325434810(); // Parse rule: whiteSpaceOptional
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN1023906596(); // Parse rule: token
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: tokens2 (Option 0) error: Could not parse rule: token");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN204364584(); // Parse rule: tokens2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: tokens2 (Option 1)
        private ParseTree? ParseRuleN204364584Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "tokens2",
                Value = "tokens2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: token
        private ParseTree? ParseRuleN1023906596()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1023906596Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023906596Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023906596Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: token (Option 0)
        private ParseTree? ParseRuleN1023906596Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "token",
                Value = "token",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '<')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: token (Option 0) error: Expected '<'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "<",
                Label = "<",
            });
            lastId++;

            parseTreeChild = ParseRule1859580978(); // Parse rule: ruleName
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: token (Option 0) error: Could not parse rule: ruleName");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '>')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: token (Option 0) error: Expected '>'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: token (Option 1)
        private ParseTree? ParseRuleN1023906596Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "token",
                Value = "token",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: token (Option 1) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRuleN1165520924(); // Parse rule: textNoDoubleQuote
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: token (Option 1) error: Could not parse rule: textNoDoubleQuote");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: token (Option 1) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: token (Option 2)
        private ParseTree? ParseRuleN1023906596Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "token",
                Value = "token",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: token (Option 2) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "'",
                Label = "'",
            });
            lastId++;

            parseTreeChild = ParseRule1760192639(); // Parse rule: textNoSingleQuote
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: token (Option 2) error: Could not parse rule: textNoSingleQuote");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            if (!ParserUtil.Eat(ref input, '\'')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: token (Option 2) error: Expected '''; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
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

        // Parse rule: textNoSingleQuote
        private ParseTree? ParseRule1760192639()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1760192639Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1760192639Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1760192639Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1760192639Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: textNoSingleQuote (Option 0)
        private ParseTree? ParseRule1760192639Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote",
                Value = "textNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1258527231(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoSingleQuote (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote (Option 1)
        private ParseTree? ParseRule1760192639Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote",
                Value = "textNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1023606944(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoSingleQuote (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote (Option 2)
        private ParseTree? ParseRule1760192639Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote",
                Value = "textNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN220814282(); // Parse rule: symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoSingleQuote (Option 2) error: Could not parse rule: symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote (Option 3)
        private ParseTree? ParseRule1760192639Option3()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote",
                Value = "textNoSingleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: textNoSingleQuote (Option 3) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote2
        private ParseTree? ParseRuleN113077552()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN113077552Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN113077552Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN113077552Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN113077552Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN113077552Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: textNoSingleQuote2 (Option 0)
        private ParseTree? ParseRuleN113077552Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote2",
                Value = "textNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1258527231(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoSingleQuote2 (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote2 (Option 1)
        private ParseTree? ParseRuleN113077552Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote2",
                Value = "textNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1023606944(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoSingleQuote2 (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote2 (Option 2)
        private ParseTree? ParseRuleN113077552Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote2",
                Value = "textNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN220814282(); // Parse rule: symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoSingleQuote2 (Option 2) error: Could not parse rule: symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote2 (Option 3)
        private ParseTree? ParseRuleN113077552Option3()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote2",
                Value = "textNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            if (!ParserUtil.Eat(ref input, '\"')) {
                char? nextCharacter = ParserUtil.Peek(ref input);
                errors.Add("Parse rule: textNoSingleQuote2 (Option 3) error: Expected '\\\"'; Got '" + (nextCharacter == null ? "End of input" : nextCharacter) + "'");
                return null;
            }
            parseTree.Children.Add(new()
            {
                Id = lastId,
                Value = "\"",
                Label = "\\\"",
            });
            lastId++;

            parseTreeChild = ParseRuleN113077552(); // Parse rule: textNoSingleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoSingleQuote2 (Option 4)
        private ParseTree? ParseRuleN113077552Option4()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoSingleQuote2",
                Value = "textNoSingleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote
        private ParseTree? ParseRuleN1165520924()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1165520924Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1165520924Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1165520924Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1165520924Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: textNoDoubleQuote (Option 0)
        private ParseTree? ParseRuleN1165520924Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1258527231(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 1)
        private ParseTree? ParseRuleN1165520924Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1023606944(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 2)
        private ParseTree? ParseRuleN1165520924Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote",
                Value = "textNoDoubleQuote",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN220814282(); // Parse rule: symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote (Option 2) error: Could not parse rule: symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote (Option 3)
        private ParseTree? ParseRuleN1165520924Option3()
        {
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

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2
        private ParseTree? ParseRule517107431()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule517107431Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule517107431Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule517107431Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule517107431Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule517107431Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: textNoDoubleQuote2 (Option 0)
        private ParseTree? ParseRule517107431Option0()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRule1258527231(); // Parse rule: letter
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 0) error: Could not parse rule: letter");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 1)
        private ParseTree? ParseRule517107431Option1()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN1023606944(); // Parse rule: digit
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 1) error: Could not parse rule: digit");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 2)
        private ParseTree? ParseRule517107431Option2()
        {
            ParseTree parseTree = new()
            {
                Label = "textNoDoubleQuote2",
                Value = "textNoDoubleQuote2",
                Id = lastId
            };
            lastId++;

            ParseTree? parseTreeChild;

            
            parseTreeChild = ParseRuleN220814282(); // Parse rule: symbol
            
            if (parseTreeChild == null) {
                errors.Add("Parse rule: textNoDoubleQuote2 (Option 2) error: Could not parse rule: symbol");
                return null;
            }
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 3)
        private ParseTree? ParseRule517107431Option3()
        {
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

            parseTreeChild = ParseRule517107431(); // Parse rule: textNoDoubleQuote2
            
            if (parseTreeChild != null) parseTree.Children.Add(parseTreeChild);

            return parseTree.Children.Count == 0 ? null : parseTree;
        }

        // Parse rule: textNoDoubleQuote2 (Option 4)
        private ParseTree? ParseRule517107431Option4()
        {
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

        // Parse rule: lineEnd
        private ParseTree? ParseRuleN1276073765()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1276073765Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1276073765Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: lineEnd (Option 0)
        private ParseTree? ParseRuleN1276073765Option0()
        {
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
        private ParseTree? ParseRuleN1276073765Option1()
        {
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

        // Parse rule: letter
        private ParseTree? ParseRule1258527231()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRule1258527231Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option11();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option12();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option13();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option14();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option15();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option16();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option17();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option18();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option19();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option20();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option21();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option22();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option23();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option24();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option25();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option26();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option27();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option28();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option29();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option30();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option31();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option32();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option33();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option34();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option35();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option36();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option37();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option38();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option39();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option40();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option41();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option42();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option43();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option44();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option45();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option46();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option47();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option48();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option49();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option50();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option51();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option52();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option53();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option54();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRule1258527231Option55();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: letter (Option 0)
        private ParseTree? ParseRule1258527231Option0()
        {
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
        private ParseTree? ParseRule1258527231Option1()
        {
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
        private ParseTree? ParseRule1258527231Option2()
        {
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
        private ParseTree? ParseRule1258527231Option3()
        {
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
        private ParseTree? ParseRule1258527231Option4()
        {
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
        private ParseTree? ParseRule1258527231Option5()
        {
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
        private ParseTree? ParseRule1258527231Option6()
        {
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
        private ParseTree? ParseRule1258527231Option7()
        {
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
        private ParseTree? ParseRule1258527231Option8()
        {
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
        private ParseTree? ParseRule1258527231Option9()
        {
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
        private ParseTree? ParseRule1258527231Option10()
        {
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
        private ParseTree? ParseRule1258527231Option11()
        {
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
        private ParseTree? ParseRule1258527231Option12()
        {
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
        private ParseTree? ParseRule1258527231Option13()
        {
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
        private ParseTree? ParseRule1258527231Option14()
        {
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
        private ParseTree? ParseRule1258527231Option15()
        {
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
        private ParseTree? ParseRule1258527231Option16()
        {
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
        private ParseTree? ParseRule1258527231Option17()
        {
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
        private ParseTree? ParseRule1258527231Option18()
        {
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
        private ParseTree? ParseRule1258527231Option19()
        {
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
        private ParseTree? ParseRule1258527231Option20()
        {
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
        private ParseTree? ParseRule1258527231Option21()
        {
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
        private ParseTree? ParseRule1258527231Option22()
        {
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
        private ParseTree? ParseRule1258527231Option23()
        {
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
        private ParseTree? ParseRule1258527231Option24()
        {
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
        private ParseTree? ParseRule1258527231Option25()
        {
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
        private ParseTree? ParseRule1258527231Option26()
        {
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
        private ParseTree? ParseRule1258527231Option27()
        {
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
        private ParseTree? ParseRule1258527231Option28()
        {
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
        private ParseTree? ParseRule1258527231Option29()
        {
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
        private ParseTree? ParseRule1258527231Option30()
        {
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
        private ParseTree? ParseRule1258527231Option31()
        {
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
        private ParseTree? ParseRule1258527231Option32()
        {
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
        private ParseTree? ParseRule1258527231Option33()
        {
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
        private ParseTree? ParseRule1258527231Option34()
        {
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
        private ParseTree? ParseRule1258527231Option35()
        {
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
        private ParseTree? ParseRule1258527231Option36()
        {
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
        private ParseTree? ParseRule1258527231Option37()
        {
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
        private ParseTree? ParseRule1258527231Option38()
        {
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
        private ParseTree? ParseRule1258527231Option39()
        {
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
        private ParseTree? ParseRule1258527231Option40()
        {
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
        private ParseTree? ParseRule1258527231Option41()
        {
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
        private ParseTree? ParseRule1258527231Option42()
        {
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
        private ParseTree? ParseRule1258527231Option43()
        {
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
        private ParseTree? ParseRule1258527231Option44()
        {
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
        private ParseTree? ParseRule1258527231Option45()
        {
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
        private ParseTree? ParseRule1258527231Option46()
        {
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
        private ParseTree? ParseRule1258527231Option47()
        {
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
        private ParseTree? ParseRule1258527231Option48()
        {
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
        private ParseTree? ParseRule1258527231Option49()
        {
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
        private ParseTree? ParseRule1258527231Option50()
        {
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
        private ParseTree? ParseRule1258527231Option51()
        {
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
        private ParseTree? ParseRule1258527231Option52()
        {
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
        private ParseTree? ParseRule1258527231Option53()
        {
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
        private ParseTree? ParseRule1258527231Option54()
        {
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
        private ParseTree? ParseRule1258527231Option55()
        {
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

        // Parse rule: digit
        private ParseTree? ParseRuleN1023606944()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN1023606944Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: digit (Option 0)
        private ParseTree? ParseRuleN1023606944Option0()
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
        private ParseTree? ParseRuleN1023606944Option1()
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
        private ParseTree? ParseRuleN1023606944Option2()
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
        private ParseTree? ParseRuleN1023606944Option3()
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
        private ParseTree? ParseRuleN1023606944Option4()
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
        private ParseTree? ParseRuleN1023606944Option5()
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
        private ParseTree? ParseRuleN1023606944Option6()
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
        private ParseTree? ParseRuleN1023606944Option7()
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
        private ParseTree? ParseRuleN1023606944Option8()
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
        private ParseTree? ParseRuleN1023606944Option9()
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

        // Parse rule: symbol
        private ParseTree? ParseRuleN220814282()
        {
            ParseTree? parseTree;
            string inputSavepoint;
            
            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option0();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option1();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option2();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option3();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option4();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option5();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option6();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option7();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option8();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option9();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option10();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option11();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option12();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option13();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option14();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option15();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option16();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option17();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option18();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option19();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option20();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option21();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option22();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option23();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option24();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option25();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option26();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option27();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option28();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option29();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option30();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option31();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option32();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option33();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option34();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option35();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option36();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            inputSavepoint = input;
            parseTree = ParseRuleN220814282Option37();
            if (parseTree != null)
                return parseTree;
            input = inputSavepoint;

            return null;
        }

        
        // Parse rule: symbol (Option 0)
        private ParseTree? ParseRuleN220814282Option0()
        {
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
        private ParseTree? ParseRuleN220814282Option1()
        {
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
        private ParseTree? ParseRuleN220814282Option2()
        {
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
        private ParseTree? ParseRuleN220814282Option3()
        {
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
        private ParseTree? ParseRuleN220814282Option4()
        {
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
        private ParseTree? ParseRuleN220814282Option5()
        {
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
        private ParseTree? ParseRuleN220814282Option6()
        {
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
        private ParseTree? ParseRuleN220814282Option7()
        {
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
        private ParseTree? ParseRuleN220814282Option8()
        {
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
        private ParseTree? ParseRuleN220814282Option9()
        {
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
        private ParseTree? ParseRuleN220814282Option10()
        {
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
        private ParseTree? ParseRuleN220814282Option11()
        {
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
        private ParseTree? ParseRuleN220814282Option12()
        {
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
        private ParseTree? ParseRuleN220814282Option13()
        {
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
        private ParseTree? ParseRuleN220814282Option14()
        {
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
        private ParseTree? ParseRuleN220814282Option15()
        {
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
        private ParseTree? ParseRuleN220814282Option16()
        {
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
        private ParseTree? ParseRuleN220814282Option17()
        {
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
        private ParseTree? ParseRuleN220814282Option18()
        {
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
        private ParseTree? ParseRuleN220814282Option19()
        {
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
        private ParseTree? ParseRuleN220814282Option20()
        {
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
        private ParseTree? ParseRuleN220814282Option21()
        {
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
        private ParseTree? ParseRuleN220814282Option22()
        {
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
        private ParseTree? ParseRuleN220814282Option23()
        {
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
        private ParseTree? ParseRuleN220814282Option24()
        {
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
        private ParseTree? ParseRuleN220814282Option25()
        {
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
        private ParseTree? ParseRuleN220814282Option26()
        {
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
        private ParseTree? ParseRuleN220814282Option27()
        {
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
        private ParseTree? ParseRuleN220814282Option28()
        {
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
        private ParseTree? ParseRuleN220814282Option29()
        {
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
        private ParseTree? ParseRuleN220814282Option30()
        {
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
        private ParseTree? ParseRuleN220814282Option31()
        {
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
        private ParseTree? ParseRuleN220814282Option32()
        {
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
        private ParseTree? ParseRuleN220814282Option33()
        {
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
        private ParseTree? ParseRuleN220814282Option34()
        {
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
        private ParseTree? ParseRuleN220814282Option35()
        {
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
        private ParseTree? ParseRuleN220814282Option36()
        {
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
        private ParseTree? ParseRuleN220814282Option37()
        {
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