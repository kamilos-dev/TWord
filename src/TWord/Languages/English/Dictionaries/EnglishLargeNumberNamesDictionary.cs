namespace TWord
{
    internal class EnglishLargeNumberNamesDictionary : ILargeNumberNamesDictionary
    {
        private readonly Noun[] _largeNumberNames =
        {
            Noun.Empty,
            Noun.Create("thousand"),
            Noun.Create("million"),
            Noun.Create("billion"),
            Noun.Create("trillion"),
            Noun.Create("quadrillion"),
            Noun.Create("quintillion"),
            Noun.Create("sextillion"),
            Noun.Create("septillion"),
            Noun.Create("septyliard"),
            Noun.Create("octillion"),
            Noun.Create("oktyliard"),
            Noun.Create("nonillion"),
            Noun.Create("decillion")
        };

        public Noun GetLargeNumberNoun(int largeNumberIndex)
        {
            if (_largeNumberNames.Length <= largeNumberIndex)
                return Noun.Empty;

            return _largeNumberNames[largeNumberIndex];
        }
    }
}