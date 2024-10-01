using RecursiveDescentParserGenerator.Datatypes;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Defines the contract for a parser that processes input text and produces a parse tree.
    /// Implementations of this interface should provide the logic to parse a given input string
    /// according to the grammar they support.
    public interface IParser
    {
        /// <summary>
        /// Parses the given input string and produces a parse tree.
        /// </summary>
        /// <param name="input">The input string to be parsed.</param>
        /// <param name="errors">A list of error messages encountered during parsing.</param>
        /// <returns>
        /// A <see cref="ParseTree"/> object representing the result of the parsing operation,
        /// or <c>null</c> if parsing fails.
        /// </returns>
        /// <remarks>
        /// If the parsing operation is successful, the <see cref="ParseTree"/> will contain
        /// the structure of the input based on the implemented grammar. The <paramref name="errors"/>
        /// parameter will be populated with any error messages that occurred during parsing.
        /// If parsing fails, <paramref name="errors"/> will contain detailed information about the
        /// encountered issues, and the return value will be <c>null</c>.
        /// </remarks>
        public ParseTree? Parse(string input, out List<string> errors);
    }
}
