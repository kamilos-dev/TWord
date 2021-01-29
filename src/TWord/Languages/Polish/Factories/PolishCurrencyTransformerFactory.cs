namespace TWord
{
    [LanguageTransformer(Language.Polish)]
    internal class PolishCurrencyTransformerFactory : ICurrencyTransformerFactory
    {
        public ICurrencyTransformer Create()
        {
            var numberTransformer = NumberTransformerFactory.Create(Language.Polish);
            var currencyDictionary = new PolishCurrencyDictionary();
            var nounInflector = new PolishNounInflector();

            return new CurrencyTransformerBuilder()
                .SetNumberTransformer(numberTransformer)
                .SetCurrencyDictionary(currencyDictionary)
                .SetNounInflector(nounInflector)
                .Build();
        }
    }
}