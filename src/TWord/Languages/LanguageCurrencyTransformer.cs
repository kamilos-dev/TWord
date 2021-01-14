using System;

namespace TWord
{
    ///<inheritdoc/>
    internal abstract class LanguageCurrencyTransformer : ICurrencyTransformer
    {
        protected abstract ICurrencyTransformer GetCurrencyTransformer();

        ///<inheritdoc/>
        public string ToWords(decimal amount, CurrencySymbol currencySymbol, CurrencyOptions currencyOptions)
        {
            return GetCurrencyTransformer().ToWords(amount, currencySymbol, currencyOptions);
        }
    }
}