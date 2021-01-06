using System;

namespace TWord
{
    /// <summary>
    /// Transform currency to words
    /// </summary>
    public interface ICurrencyTransformer
    {
        /// <summary>
        /// Returns words representing the given amount
        /// </summary>
        /// <param name="amount">Amount</param>
        /// <returns>Words</returns>
        string ToWords(decimal amount, CurrencySymbol currencySymbol, bool integerPartOnly, bool decimalPartAsFraction, MidpointRounding? rounding = null);
    }
}