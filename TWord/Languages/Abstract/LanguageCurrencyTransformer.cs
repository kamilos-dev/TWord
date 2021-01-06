using System;

namespace TWord
{
    internal abstract class LanguageCurrencyTransformer : ICurrencyTransformer
    {
        protected abstract ICurrencyTransformer GetCurrencyTransformer();

        public string ToWords(decimal amount, CurrencySymbol currencySymbol, bool integerPartOnly, bool decimalPartAsFraction, 
            MidpointRounding? rounding = null)
        {
            return GetCurrencyTransformer().ToWords(amount, currencySymbol, integerPartOnly, decimalPartAsFraction, rounding);
        }
    }
}