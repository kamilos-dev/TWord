namespace TWord
{
    internal class PolishCurrencyTransformer : LanguageCurrencyTransformer
    {
        protected override ICurrencyTransformer GetCurrencyTransformer()
        {
            var numberTransformer = NumberTransformerSelector.Select(Language.Polish);
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