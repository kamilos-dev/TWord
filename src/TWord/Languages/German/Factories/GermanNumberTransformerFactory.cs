namespace TWord
{
    [LanguageTransformer(Language.German)]
    internal class GermanNumberTransformerFactory : INumberTransformerFactory
    {
        public INumberTransformer Create()
        {
            return GetDefaultBuilder().Build();
        }

        public NumberTransformerBuilder GetDefaultBuilder()
        {
            var languageNumbersDictionary = new GermanNumbersDictionary();
            var largeNumberNamesDictionary = new GermanLargeNumberNamesDictionary();

            var triplerTransformer = new GermanTripletTransformerForNumbers(languageNumbersDictionary);
            var nounInflector = new GermanNounInflector();

            return new NumberTransformerBuilder()
                .SetNumbersDictionary(languageNumbersDictionary)
                .SetLargeNumberNamesDictionary(largeNumberNamesDictionary)
                .SetTriplerTransformer(triplerTransformer)
                .InflectNounsBy(nounInflector)
                .NumberSeparator("");
        }
    }
}