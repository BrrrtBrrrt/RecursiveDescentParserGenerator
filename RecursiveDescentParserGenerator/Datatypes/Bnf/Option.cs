using System.Collections.Generic;

namespace RecursiveDescentParserGenerator.Datatypes.Bnf
{
    /// <summary>
    /// Represents an option in a BNF rule.
    /// </summary>
    public class Option
    {
        /// <summary>
        /// Gets or sets the list of tokens that make up this option.
        /// </summary>
        public List<Token> Tokens { get; set; } = new();

        /// <summary>
        /// Returns a string representation of the option.
        /// </summary>
        /// <returns>
        /// A string that represents the option. If the option has no tokens, returns "E" (epsilon). 
        /// Otherwise, returns a space-separated list of tokens.
        /// </returns>
        public override string? ToString()
        {
            return Tokens.Count == 0 ? "E" : string.Join(" ", Tokens);
        }
    }
}
