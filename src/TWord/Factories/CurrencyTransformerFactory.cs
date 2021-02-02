using System;

namespace TWord
{
    internal class CurrencyTransformerFactory : TransformerFactory
    {
        /// <summary>
        /// Creates ICurrencyTransformer for given language
        /// </summary>
        /// <param name="language">Language symbol</param>
        internal ICurrencyTransformer Create(Language language)
        {
            return Create<ICurrencyTransformerFactory, ICurrencyTransformer>(language) ??
                throw new InvalidOperationException($"{typeof(INumberTransformer)} for language {language} not found!");
        }

        /// <summary>
        /// Returns default CurrencyTransformerBuilder for given language
        /// </summary>
        /// <param name="language">Language symbol</param>
        internal CurrencyTransformerBuilder GetDefaultBuilder(Language language)
        {
            return GetDefaultBuilder<ICurrencyTransformerFactory, CurrencyTransformerBuilder>(language) ??
                throw new InvalidOperationException($"Default builder {nameof(CurrencyTransformerBuilder)} for language {language} not found!");
        }
    }
}