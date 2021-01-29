namespace TWord
{
    [LanguageTransformer(Language.German)]
    internal class GermanNumberTransformerFactory 
        : INumberTransformerFactory
    {
        public INumberTransformer Create()
        {
            var languageNumbersDictionary = new GermanNumbersDictionary();
            var largeNumberNamesDictionary = new GermanLargeNumberNamesDictionary();

            var triplerTransformer = new GermanTripletTransformer(languageNumbersDictionary);
            var nounInflector = new GermanNounInflector();

            return new NumberTransformerBuilder()
                .SetNumbersDictionary(languageNumbersDictionary)
                .SetLargeNumberNamesDictionary(largeNumberNamesDictionary)
                .SetTriplerTransformer(triplerTransformer)
                .InflectNounsBy(nounInflector)
                .NumberSeparator("")
                .Build();
        }
    }
}