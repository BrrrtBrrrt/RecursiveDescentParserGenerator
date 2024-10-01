using System;
using System.Collections.Generic;

namespace RecursiveDescentParserGenerator.Datatypes
{
    /// <summary>
    /// Represents a node in a parse tree used in recursive descent parsing.
    /// </summary>
    public class ParseTree
    {
        /// <summary>
        /// Gets or sets the label of the parse tree node.
        /// </summary>
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the value of the parse tree node.
        /// </summary>
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier of the parse tree node.
        /// </summary>
        public int Id { get; set; } = -1;

        /// <summary>
        /// Gets or sets the list of child nodes of the parse tree node.
        /// </summary>
        public List<ParseTree> Children { get; set; } = new();

        /// <summary>
        /// Generates a Graphviz representation of the parse tree.
        /// </summary>
        /// <returns>A string containing the Graphviz representation of the parse tree.</returns>
        public string GraphvizGraphGet()
        {
            List<string> lines = new()
            {
                "digraph G {"
            };

            GraphvizGraphGetRek(this, lines);

            lines.Add("}");

            return string.Join(Environment.NewLine, lines);
        }

        /// <summary>
        /// Recursively generates the Graphviz representation of the parse tree.
        /// </summary>
        /// <param name="parseTree">The current parse tree node.</param>
        /// <param name="lines">The list of lines to which the Graphviz representation is added.</param>
        private static void GraphvizGraphGetRek(ParseTree parseTree, List<string> lines)
        {
            string label = parseTree.Label;
            if (label == "\\") label = "\\\\";
            label = label.Replace("\\r", "\\\\r");
            label = label.Replace("\\n", "\\\\n");
            label = label.Replace("\\t", "\\\\t");
            lines.Add($"{parseTree.Id} [label=\"{label}\"];");
            foreach (ParseTree child in parseTree.Children)
            {
                lines.Add($"{parseTree.Id} -> {child.Id};");
                GraphvizGraphGetRek(child, lines);
            }
        }
    }
}
