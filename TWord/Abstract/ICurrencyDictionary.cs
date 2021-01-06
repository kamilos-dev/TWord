namespace TWord
{
    /// <summary>
    /// Dictionary with currencies
    /// </summary>
    internal interface ICurrencyDictionary
    {
        /// <summary>
        /// Return object with currency information and nouns.
        /// </summary>
        /// <param name="symbol">Currency symbol</param>
        /// <returns>Object with currency information and nouns.</returns>
        Currency GetCurrency(CurrencySymbol symbol);
    }
}