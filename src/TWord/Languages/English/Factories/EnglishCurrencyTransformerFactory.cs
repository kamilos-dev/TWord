namespace TWord
{
    [LanguageTransformer(Language.English)]
    internal class EnglishCurrencyTransformerFactory : ICurrencyTransformerFactory
    {
        public ICurrencyTransformer Create()
        {
            var numberTransformer = NumberTransformerFactory.Create(Language.English);
            var currencyDictionary = new EnglishCurrencyDictionary();
            var nounInflector = new EnglishNounInflector();

            return new CurrencyTransformerBuilder()
                .SetNumberTransformer(numberTransformer)
                .SetCurrencyDictionary(currencyDictionary)
                .SetNounInflector(nounInflector)
                .Build();
        }
    }
}