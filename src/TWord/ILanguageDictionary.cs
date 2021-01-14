namespace TWord
{
    /// <summary>
    /// Dicrionary with number names
    /// </summary>
    internal interface ILanguageNumbersDictionary
    {
        /// <summary>
        /// Returns zero word
        /// </summary>
        string Zero { get; }

        /// <summary>
        /// Returns minus word
        /// </summary>
        string Minus { get; }

        /// <summary>
        /// Return hyphenate sigh
        /// </summary>
        string Hyphen { get; }

        /// <summary>
        /// Returns ones (0-9) word
        /// </summary>
        /// <param name="value">Ones</param>
        /// <returns>Word</returns>
        string GetOnesWord(int value);

        /// <summary>
        /// Returns teens (11-19) word
        /// </summary>
        /// <param name="value">Teens</param>
        /// <returns>Word</returns>
        string GetTeensWord(int value);

        /// <summary>
        /// Returns tens (10, 20...90) word
        /// </summary>
        /// <param name="value">Tens</param>
        /// <returns>Word</returns>
        string GetTensWord(int value);

        /// <summary>
        /// Returns hundred (100, 200...900) word
        /// </summary>
        /// <param name="value">Hundred</param>
        /// <returns>Word</returns>
        string GetHundredsWord(int value);
    }
}