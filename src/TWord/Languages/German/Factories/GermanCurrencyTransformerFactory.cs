namespace TWord
{
    [LanguageTransformer(Language.German)]
    internal class GermanCurrencyTransformerFactory : ICurrencyTransformerFactory
    {
        public ICurrencyTransformer Create()
        {
            return GetDefaultBuilder().Build();
        }

        public CurrencyTransformerBuilder GetDefaultBuilder()
        {
            var numberDictionary = new GermanNumbersDictionary();
            var tripletTransformer = new GermanTripletTransformerBase(numberDictionary);

            var numberTransformer = new NumberTransformerFactory()
                .GetDefaultBuilder(Language.German)
                .SetTriplerTransformer(tripletTransformer)
                .Build();

            var currencyDictionary = new GermanCurrencyDictionary();
            var nounInflector = new GermanNounInflector();

            return new CurrencyTransformerBuilder()
                .SetNumberTransformer(numberTransformer)
                .SetCurrencyDictionary(currencyDictionary)
                .SetNounInflector(nounInflector);
        }
    }
}