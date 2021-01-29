using System;

namespace TWord
{
    internal static class NumberTransformerFactory
    {
        internal static INumberTransformer Create(Language language)
        {
            return TransformerFactory.Create<INumberTransformerFactory, INumberTransformer>(language) ??
                throw new InvalidOperationException($"{typeof(INumberTransformer)} for language {language} not found!");
        }
    }    
}