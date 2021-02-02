namespace TWord
{
    /// <summary>
    /// Transform currency to words
    /// </summary>
    internal interface ICurrencyTransformer
    {
        /// <summary>
        /// Returns words representing the given amount
        /// </summary>
        /// <param name="amount">Amount</param>
        /// <returns>Words</returns>
        string ToWords(decimal amount, CurrencySymbol currencySymbol, CurrencyOptions currencyOptions);
    }
}