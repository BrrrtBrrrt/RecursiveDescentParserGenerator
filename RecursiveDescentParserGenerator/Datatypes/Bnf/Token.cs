namespace RecursiveDescentParserGenerator.Datatypes.Bnf
{
    /// <summary>
    /// Represents a token in a BNF grammar.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Gets or sets the value of the token.
        /// </summary>
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the token is terminal.
        /// </summary>
        public bool IsTerminal { get; set; } = false;

        /// <summary>
        /// Returns a string representation of the token.
        /// </summary>
        /// <returns>A string that represents the token.</returns>
        public override string? ToString()
        {
            string value = Value;
            value = value.Replace("\n", "\\n");
            value = value.Replace("\r", "\\r");
            value = value.Replace("\t", "\\t");
            return IsTerminal ? "\"" + value + "\"" : "<" + value + ">";
        }
    }
}
