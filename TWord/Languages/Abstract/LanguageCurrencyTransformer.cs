using System;

namespace TWord
{
    internal abstract class LanguageCurrencyTransformer : ICurrencyTransformer
    {
        protected abstract ICurrencyTransformer GetCurrencyTransformer();

        public string ToWords(decimal amount, CurrencySymbol currencySymbol, CurrencyOptions currencyOptions)
        {
            return GetCurrencyTransformer().ToWords(amount, currencySymbol, currencyOptions);
        }
    }
}