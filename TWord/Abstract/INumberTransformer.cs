namespace TWord
{
    /// <summary>
    /// Transform number to words
    /// </summary>
    internal interface INumberTransformer
    {
        /// <summary>
        /// Returns words representing the given number
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Words</returns>
        string ToWords(long number);
    }
}