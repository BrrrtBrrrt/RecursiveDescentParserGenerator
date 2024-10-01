using System.Collections.Generic;

namespace RecursiveDescentParserGenerator.Datatypes.Bnf
{
    /// <summary>
    /// Represents a rule in a BNF grammar.
    /// </summary>
    public class Rule
    {
        /// <summary>
        /// Gets or sets the identifier of the rule.
        /// </summary>
        public string Identifier { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of options for the rule.
        /// </summary>
        public List<Option> Options { get; set; } = new();

        /// <summary>
        /// Returns a string representation of the rule.
        /// </summary>
        /// <returns>A string that represents the rule in BNF format.</returns>
        public override string? ToString()
        {
            return "<" + Identifier + "> ::= " + string.Join(" | ", Options);
        }
    }
}
