namespace TWord
{
    internal class EnglishCurrencyTransformer : LanguageCurrencyTransformer
    {
        protected override ICurrencyTransformer GetCurrencyTransformer()
        {
            var numberTransformer = NumberTransformerSelector.Select(Language.English);
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