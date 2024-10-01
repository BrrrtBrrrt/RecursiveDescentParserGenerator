namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Provides utility methods for parsing operations on strings.
    /// </summary>
    public static class ParserUtil
    {
        /// <summary>
        /// Determines if the input string has more characters remaining.
        /// </summary>
        /// <param name="input">The input string to check.</param>
        /// <returns>True if there are characters remaining in the input string; otherwise, false.</returns>
        public static bool IsMore(ref string input)
        {
            return input.Length > 0;
        }

        /// <summary>
        /// Retrieves the next character from the input string without consuming it.
        /// </summary>
        /// <param name="input">The input string to peek into.</param>
        /// <returns>The next character if available; otherwise, null.</returns>
        public static char? Peek(ref string input)
        {
            return input.Length > 0 ? input[0] : null;
        }

        /// <summary>
        /// Consumes the next character in the input string if it matches the specified character.
        /// </summary>
        /// <param name="input">The input string to consume from.</param>
        /// <param name="character">The character to match and consume.</param>
        /// <returns>True if the character was successfully matched and consumed; otherwise, false.</returns>
        public static bool Eat(ref string input, char character)
        {
            char? currentCharacter = Peek(ref input);
            if (currentCharacter != character)
                return false;
            input = input[1..];
            return true;
        }
    }
}
