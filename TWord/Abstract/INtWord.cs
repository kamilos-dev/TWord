namespace TWord
{
    /// <summary>
    /// Provider to transform number to words
    /// </summary>
    public interface INtWord
    {
        /// <summary>
        /// Transform given number to words
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Words</returns>
        string ToWords(int number);
    }
}