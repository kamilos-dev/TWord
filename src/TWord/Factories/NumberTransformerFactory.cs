using System;

namespace TWord
{
    internal class NumberTransformerFactory : TransformerFactory
    {
        /// <summary>
        /// Creates INumberTransformer for given language
        /// </summary>
        /// <param name="language">Language symbol</param>
        internal INumberTransformer Create(Language language)
        {
            return Create<INumberTransformerFactory, INumberTransformer>(language) ??
                throw new InvalidOperationException($"{nameof(INumberTransformer)} for language {language} not found!");
        }

        /// <summary>
        /// Returns default NumberTransformerBuilder for given language
        /// </summary>
        /// <param name="language">Language symbol</param>
        internal NumberTransformerBuilder GetDefaultBuilder(Language language)
        {
            return GetDefaultBuilder<INumberTransformerFactory, NumberTransformerBuilder>(language) ??
                throw new InvalidOperationException($"Default builder {nameof(NumberTransformerBuilder)} for language {language} not found!");
        }
    }    
}