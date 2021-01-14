namespace TWord
{
    internal class PolishNumberTransformer : LanguageNumberTransformer
    {
        protected override INumberTransformer GetNumberTransformer()
        {
            var languageNumbersDictionary = new PolishNumbersDictionary();
            var largeNumberNamesDictionary = new PolishLargeNumberNamesDictionary();

            var triplerTransformer = new GenericTripletTransformer(languageNumbersDictionary);
            var nounInflector = new PolishNounInflector();

            return new NumberTransformerBuilder()
                .SetNumbersDictionary(languageNumbersDictionary)
                .SetLargeNumberNamesDictionary(largeNumberNamesDictionary)
                .SetTriplerTransformer(triplerTransformer)
                .InflectNounsBy(nounInflector)
                .Build();
        }
    }
}