namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Provides a collection of constant string values used throughout the grammar parsing process.
    /// </summary>
    internal static class Constants
    {
        /// <summary>
        /// The name of the entry rule in the BNF (Backus-Naur Form) grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_NAME_ENTRY = "BNF";

        /// <summary>
        /// The name of the rule that defines the set of grammar rules in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_NAME_RULES = "Rules";

        /// <summary>
        /// The name of the rule that denotes the end of a line in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_NAME_LINE_END = "LineEnd";

        /// <summary>
        /// The name of a rule that defines a single grammar rule in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_NAME_RULE = "Rule";

        /// <summary>
        /// The name of the optional whitespace rule in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_OPT_WHITESPACE = "WhiteSpaceOptional";

        /// <summary>
        /// The name of the rule that specifies the name of a grammar rule.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_RULE_NAME = "RuleName";

        /// <summary>
        /// The name of the rule that defines options for a grammar rule in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_OPTIONS = "Options";

        /// <summary>
        /// The name of the rule that defines an individual option within the options for a grammar rule.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_OPTION = "Option";

        /// <summary>
        /// The name of the rule that defines tokens in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_TOKENS = "Tokens";

        /// <summary>
        /// The name of the rule that defines a single token in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_TOKEN = "Token";

        /// <summary>
        /// The name of the rule that defines letters in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_LETTER = "Letter";

        /// <summary>
        /// The name of the rule that defines digits in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_DIGIT = "Digit";

        /// <summary>
        /// The name of the rule that defines symbols in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_SYMBOL = "Symbol";

        /// <summary>
        /// The name of the rule that defines text without double quotes in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_TEXT_NO_DOUBLE_QUOTE = "TextNoDoubleQuote";

        /// <summary>
        /// The name of the rule that defines text without single quotes in the BNF grammar.
        /// </summary>
        public const string GRAMMAR_BNF_RULE_TEXT_NO_SINGLE_QUOTE = "TextNoSingleQuote";
    }
}