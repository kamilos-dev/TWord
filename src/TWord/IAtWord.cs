namespace TWord
{
    /// <summary>
    /// Amount to Word
    /// </summary>
    public interface IAtWord
    {
        /// <summary>
        /// Transform given amount to words
        /// </summary>
        /// <param name="amount">Amount</param>
        /// <returns>Words</returns>
        string ToWord(decimal amount);
    }
}