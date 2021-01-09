using System;

namespace TWord
{
    internal static class NumberTransformerSelector
    {
        internal static INumberTransformer Select(Language language)
        {
            switch (language)
            {
                case Language.Polish:
                    return new PolishNumberTransformer();
                case Language.English:
                    return new EnglishNumberTransformer();
                default:
                    throw new InvalidOperationException($"Transformer for language {language} not found!");
            }
        }
    }
}