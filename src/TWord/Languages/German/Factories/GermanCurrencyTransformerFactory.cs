namespace TWord
{
    [LanguageTransformer(Language.German)]
    internal class GermanCurrencyTransformerFactory : ICurrencyTransformerFactory
    {
        public ICurrencyTransformer Create()
        {
            var numberTransformer = NumberTransformerFactory.Create(Language.German);
            var currencyDictionary = new GermanCurrencyDictionary();
            var nounInflector = new GermanNounInflector();

            return new CurrencyTransformerBuilder()
                .SetNumberTransformer(numberTransformer)
                .SetCurrencyDictionary(currencyDictionary)
                .SetNounInflector(nounInflector)
                .Build();
        }
    }
}