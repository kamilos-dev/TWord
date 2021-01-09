namespace TWord
{
    internal class EnglishNumberTransformer : LanguageNumberTransformer
    {
        protected override INumberTransformer GetNumberTransformer()
        {
            var languageNumbersDictionary = new EnglishNumbersDictionary();
            var largeNumberNamesDictionary = new EnglishLargeNumberNamesDictionary();

            var triplerTransformer = new GenericTripletTransformer(languageNumbersDictionary);

            return new NumberTransformerBuilder()
                .SetNumbersDictionary(languageNumbersDictionary)
                .SetLargeNumberNamesDictionary(largeNumberNamesDictionary)
                .SetTriplerTransformer(triplerTransformer)
                .Build();
        }
    }
}