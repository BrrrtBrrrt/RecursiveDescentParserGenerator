using System;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator.Datatypes.Bnf
{
    /// <summary>
    /// Represents a grammar consisting of a list of BNF rules.
    /// </summary>
    public class Grammar
    {
        /// <summary>
        /// Gets or sets the list of rules that make up this grammar.
        /// </summary>
        public List<Rule> Rules { get; set; } = new();

        /// <summary>
        /// Returns a string representation of the grammar.
        /// </summary>
        /// <returns>
        /// A string that represents the grammar, with each rule on a new line.
        /// </returns>
        public override string? ToString()
        {
            return string.Join(Environment.NewLine, Rules);
        }
    }
}
