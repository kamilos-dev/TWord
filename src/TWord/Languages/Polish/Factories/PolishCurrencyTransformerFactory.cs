namespace TWord
{
    [LanguageTransformer(Language.Polish)]
    internal class PolishCurrencyTransformerFactory : ICurrencyTransformerFactory
    {
        public ICurrencyTransformer Create()
        {
            return GetDefaultBuilder().Build();
        }

        public CurrencyTransformerBuilder GetDefaultBuilder()
        {
            var numberTransformer = new NumberTransformerFactory().Create(Language.Polish);
            var currencyDictionary = new PolishCurrencyDictionary();
            var nounInflector = new PolishNounInflector();

            return new CurrencyTransformerBuilder()
                .SetNumberTransformer(numberTransformer)
                .SetCurrencyDictionary(currencyDictionary)
                .SetNounInflector(nounInflector);
        }
    }
}