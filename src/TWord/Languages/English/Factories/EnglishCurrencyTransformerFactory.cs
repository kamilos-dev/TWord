namespace TWord
{
    [LanguageTransformer(Language.English)]
    internal class EnglishCurrencyTransformerFactory : ICurrencyTransformerFactory
    {
        public ICurrencyTransformer Create()
        {
            return GetDefaultBuilder().Build();
        }

        public CurrencyTransformerBuilder GetDefaultBuilder()
        {
            var numberTransformer = new NumberTransformerFactory().Create(Language.English);
            var currencyDictionary = new EnglishCurrencyDictionary();
            var nounInflector = new EnglishNounInflector();

            return new CurrencyTransformerBuilder()
                .SetNumberTransformer(numberTransformer)
                .SetCurrencyDictionary(currencyDictionary)
                .SetNounInflector(nounInflector);
        }
    }
}