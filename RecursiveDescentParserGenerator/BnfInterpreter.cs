using RecursiveDescentParserGenerator.Datatypes;
using RecursiveDescentParserGenerator.Datatypes.Bnf;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Provides functionality to interpret a BNF (Backus-Naur Form) parse tree and convert it into a <see cref="Grammar"/> object.
    /// </summary>
    internal static class BnfInterpreter
    {
        /// <summary>
        /// Interprets the given parse tree to produce a <see cref="Grammar"/> object.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the BNF grammar.</param>
        /// <returns>A <see cref="Grammar"/> object representing the interpreted BNF grammar.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected structure.</exception>
        public static Grammar Interpret(ParseTree parseTree)
        {
            return InterpretGrammar(parseTree);
        }

        /// <summary>
        /// Interprets the BNF grammar from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the BNF grammar.</param>
        /// <returns>A <see cref="Grammar"/> object representing the interpreted BNF grammar.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected root node or children.</exception>
        private static Grammar InterpretGrammar(ParseTree parseTree)
        {
            if (parseTree.Value != Constants.GRAMMAR_BNF_RULE_NAME_ENTRY)
                throw new BnfInterpreterException($"Parse tree '{Constants.GRAMMAR_BNF_RULE_NAME_ENTRY}' not found");
            ParseTree? rulesParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_NAME_RULES);
            if (rulesParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_NAME_RULES}'");
            List<Rule> rules = InterpretRules(rulesParseTree);
            return new()
            {
                Rules = rules,
            };
        }

        /// <summary>
        /// Interprets a list of rules from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the rules.</param>
        /// <returns>A list of <see cref="Rule"/> objects.</returns>
        private static List<Rule> InterpretRules(ParseTree parseTree)
        {
            List<Rule> rules = new();
            InterpretRulesRek(parseTree, rules);
            return rules;
        }

        /// <summary>
        /// Recursively interprets rules from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the rules.</param>
        /// <param name="rules">The list to which interpreted rules will be added.</param>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected rule node.</exception>
        private static void InterpretRulesRek(ParseTree parseTree, List<Rule> rules)
        {
            ParseTree? ruleParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_NAME_RULE);
            if (ruleParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_NAME_RULE}'");
            Rule rule = InterpretRule(ruleParseTree);
            rules.Add(rule);
            ParseTree? rulesParseTree = parseTree.Children.Find((child) => child.Value == $"{Constants.GRAMMAR_BNF_RULE_NAME_RULES}2");
            if (rulesParseTree != null)
                InterpretRulesRek(rulesParseTree, rules);
        }

        /// <summary>
        /// Interprets a single rule from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the rule.</param>
        /// <returns>A <see cref="Rule"/> object.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected identifier or options nodes.</exception>
        private static Rule InterpretRule(ParseTree parseTree)
        {
            ParseTree? identifierParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_RULE_NAME);
            if (identifierParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_RULE_NAME}'");
            string identifier = InterpretIdentifier(identifierParseTree);

            ParseTree? optionsParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_OPTIONS);
            if (optionsParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_OPTIONS}'");
            List<Option> options = InterpretOptions(optionsParseTree);

            return new()
            {
                Identifier = identifier,
                Options = options,
            };
        }

        /// <summary>
        /// Interprets an identifier from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the identifier.</param>
        /// <returns>The interpreted identifier as a string.</returns>
        private static string InterpretIdentifier(ParseTree parseTree)
        {
            string identifier = string.Empty;
            InterpretIdentifierRek(parseTree, ref identifier);
            return identifier;
        }

        /// <summary>
        /// Recursively interprets an identifier from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the identifier.</param>
        /// <param name="identifier">The identifier string being constructed.</param>
        private static void InterpretIdentifierRek(ParseTree parseTree, ref string identifier)
        {
            if (parseTree.Children.Exists((child) => child.Value == "-"))
                identifier += "-";
            if (parseTree.Children.Exists((child) => child.Value == "_"))
                identifier += "_";
            ParseTree? letterParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_LETTER);
            if (letterParseTree != null)
                identifier += InterpretLetter(letterParseTree);
            ParseTree? digitParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_DIGIT);
            if (digitParseTree != null)
                identifier += InterpretDigit(digitParseTree);
            ParseTree? identifierParseTree = parseTree.Children.Find((child) => child.Value.Contains(Constants.GRAMMAR_BNF_RULE_RULE_NAME));
            if (identifierParseTree != null)
            {
                InterpretIdentifierRek(identifierParseTree, ref identifier);
            }
        }

        /// <summary>
        /// Interprets a letter from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the letter.</param>
        /// <returns>The interpreted letter as a string.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not have children.</exception>
        private static string InterpretLetter(ParseTree parseTree)
        {
            if (parseTree.Children.Count == 0)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no childs");
            return parseTree.Children[0].Value;
        }

        /// <summary>
        /// Interprets a digit from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the digit.</param>
        /// <returns>The interpreted digit as a string.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not have children.</exception>
        private static string InterpretDigit(ParseTree parseTree)
        {
            if (parseTree.Children.Count == 0)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no childs");
            return parseTree.Children[0].Value;
        }

        /// <summary>
        /// Interprets a symbol from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the symbol.</param>
        /// <returns>The interpreted symbol as a string.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not have children.</exception>
        private static string InterpretSymbol(ParseTree parseTree)
        {
            if (parseTree.Children.Count == 0)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no childs");
            return parseTree.Children[0].Value;
        }

        /// <summary>
        /// Interprets a list of options from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the options.</param>
        /// <returns>A list of <see cref="Option"/> objects.</returns>
        private static List<Option> InterpretOptions(ParseTree parseTree)
        {
            List<Option> options = new();
            InterpretOptionsRek(parseTree, options);
            return options;
        }

        /// <summary>
        /// Recursively interprets options from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the options.</param>
        /// <param name="options">The list to which interpreted options will be added.</param>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected option node.</exception>
        private static void InterpretOptionsRek(ParseTree parseTree, List<Option> options)
        {
            ParseTree? optionParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_OPTION);
            if (optionParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_OPTION}'");
            Option option = InterpretOption(optionParseTree);
            options.Add(option);
            ParseTree? optionsParseTree = parseTree.Children.Find((child) => child.Value == $"{Constants.GRAMMAR_BNF_RULE_OPTIONS}2");
            if (optionsParseTree != null)
                InterpretOptionsRek(optionsParseTree, options);
        }

        /// <summary>
        /// Interprets a single option from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the option.</param>
        /// <returns>An <see cref="Option"/> object.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected tokens node or epsilon node.</exception>
        private static Option InterpretOption(ParseTree parseTree)
        {
            ParseTree? epsilonParseTree = parseTree.Children.Find((child) => child.Value == "E");
            if (epsilonParseTree != null)
                return new();
            ParseTree? tokensParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_TOKENS);
            if (tokensParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_TOKENS}'");
            List<Token> tokens = InterpretTokens(tokensParseTree);
            return new()
            {
                Tokens = tokens,
            };
        }

        /// <summary>
        /// Interprets a list of tokens from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the tokens.</param>
        /// <returns>A list of <see cref="Token"/> objects.</returns>
        private static List<Token> InterpretTokens(ParseTree parseTree)
        {
            List<Token> tokens = new();
            InterpretTokensRek(parseTree, tokens);
            return tokens;
        }

        /// <summary>
        /// Recursively interprets tokens from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the tokens.</param>
        /// <param name="tokens">The list to which interpreted tokens will be added.</param>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain the expected token node.</exception>
        private static void InterpretTokensRek(ParseTree parseTree, List<Token> tokens)
        {
            ParseTree? tokenParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_TOKEN);
            if (tokenParseTree == null)
                throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_TOKEN}'");
            Token token = InterpretToken(tokenParseTree);
            tokens.Add(token);
            ParseTree? tokensParseTree = parseTree.Children.Find((child) => child.Value == $"{Constants.GRAMMAR_BNF_RULE_TOKENS}2");
            if (tokensParseTree != null)
                InterpretTokensRek(tokensParseTree, tokens);
        }

        /// <summary>
        /// Interprets a single token from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the token.</param>
        /// <returns>A <see cref="Token"/> object.</returns>
        /// <exception cref="BnfInterpreterException">Thrown when the parse tree does not contain expected text nodes or rule name.</exception>
        private static Token InterpretToken(ParseTree parseTree)
        {
            bool isTerminal = false;
            string value = string.Empty;
            if (parseTree.Children.Exists((child) => child.Value == "<"))
            {
                ParseTree? identifierParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_RULE_NAME);
                if (identifierParseTree == null)
                    throw new BnfInterpreterException($"Parse tree '{parseTree.Value}' has no child '{Constants.GRAMMAR_BNF_RULE_RULE_NAME}'");
                value = InterpretIdentifier(identifierParseTree);
            }
            else
            {
                isTerminal = true;
                ParseTree? textNoDoubleQuoteParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE);
                if (textNoDoubleQuoteParseTree != null)
                    value = InterpretTextNoDoubleQuote(textNoDoubleQuoteParseTree);
                ParseTree? textNoSingleQuoteParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE);
                if (textNoSingleQuoteParseTree != null)
                    value = InterpretTextNoSingleQuote(textNoSingleQuoteParseTree);
            }

            return new()
            {
                IsTerminal = isTerminal,
                Value = value,
            };
        }

        /// <summary>
        /// Interprets text that does not contain double quotes from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the text without double quotes.</param>
        /// <returns>The interpreted text as a string.</returns>
        private static string InterpretTextNoDoubleQuote(ParseTree parseTree)
        {
            string text = string.Empty;
            InterpretTextNoDoubleQuoteRek(parseTree, ref text);
            return text;
        }

        /// <summary>
        /// Recursively interprets text that does not contain double quotes from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the text without double quotes.</param>
        /// <param name="text">The text string being constructed.</param>
        private static void InterpretTextNoDoubleQuoteRek(ParseTree parseTree, ref string text)
        {
            if (parseTree.Children.Exists((child) => child.Value == "'"))
                text += "'";
            ParseTree? letterParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_LETTER);
            if (letterParseTree != null)
                text += InterpretLetter(letterParseTree);
            ParseTree? digitParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_DIGIT);
            if (digitParseTree != null)
                text += InterpretDigit(digitParseTree);
            ParseTree? symbolParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_SYMBOL);
            if (symbolParseTree != null)
                text += InterpretSymbol(symbolParseTree);
            ParseTree? textNoDoubleQuoteParseTree = parseTree.Children.Find((child) => child.Value == $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE}2");
            if (textNoDoubleQuoteParseTree != null)
                InterpretTextNoDoubleQuoteRek(textNoDoubleQuoteParseTree, ref text);
        }

        /// <summary>
        /// Interprets text that does not contain single quotes from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the text without single quotes.</param>
        /// <returns>The interpreted text as a string.</returns>
        private static string InterpretTextNoSingleQuote(ParseTree parseTree)
        {
            string text = string.Empty;
            InterpretTextNoSingleQuoteRek(parseTree, ref text);
            return text;
        }

        /// <summary>
        /// Recursively interprets text that does not contain single quotes from the given parse tree.
        /// </summary>
        /// <param name="parseTree">The parse tree representing the text without single quotes.</param>
        /// <param name="text">The text string being constructed.</param>
        private static void InterpretTextNoSingleQuoteRek(ParseTree parseTree, ref string text)
        {
            if (parseTree.Children.Exists((child) => child.Value == "\""))
                text += "\"";
            ParseTree? letterParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_LETTER);
            if (letterParseTree != null)
                text += InterpretLetter(letterParseTree);
            ParseTree? digitParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_DIGIT);
            if (digitParseTree != null)
                text += InterpretDigit(digitParseTree);
            ParseTree? symbolParseTree = parseTree.Children.Find((child) => child.Value == Constants.GRAMMAR_BNF_RULE_SYMBOL);
            if (symbolParseTree != null)
                text += InterpretSymbol(symbolParseTree);
            ParseTree? textNoDoubleQuoteParseTree = parseTree.Children.Find((child) => child.Value == $"{Constants.GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE}2");
            if (textNoDoubleQuoteParseTree != null)
                InterpretTextNoSingleQuoteRek(textNoDoubleQuoteParseTree, ref text);
        }
    }
}
