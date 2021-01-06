using System;

namespace TWord
{
    internal static class CurrencyTransformerSelector
    {
        internal static ICurrencyTransformer Select(Language language)
        {
            switch (language)
            {
                case Language.Polish:
                    return new PolishCurrencyTransformer();
                default:
                    throw new InvalidOperationException($"Transformer for language {language} not found!");
            }
        }
    }
}