using System;

namespace TWord
{
    internal static class CurrencyTransformerFactory
    {
        internal static ICurrencyTransformer Create(Language language)
        {
            return TransformerFactory.Create<ICurrencyTransformerFactory, ICurrencyTransformer>(language) ??
                throw new InvalidOperationException($"{typeof(INumberTransformer)} for language {language} not found!");
        }
    }
}
