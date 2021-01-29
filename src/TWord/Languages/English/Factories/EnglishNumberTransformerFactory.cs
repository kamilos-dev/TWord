namespace TWord
{
    [LanguageTransformer(Language.English)]
    internal class EnglishNumberTransformerFactory : INumberTransformerFactory
    {
        public INumberTransformer Create()
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