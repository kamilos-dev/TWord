namespace TWord
{
    internal class GermanLargeNumberNamesDictionary : ILargeNumberNamesDictionary
    {
        private readonly Noun[] _largeNumberNames =
        {
            Noun.Empty,
            Noun.Create("tausend"),   
            Noun.Create("Million", "Millionen"),
            Noun.Create("Milliarde", "Milliarden"),
            Noun.Create("Billion", "Billionen"),
            Noun.Create("Billiarde", "Billiarden"),
            Noun.Create("Trillion", "Trillione"),
            Noun.Create("Trilliarde", "Trilliarden"),
            Noun.Create("Quadrillion", "Quadrillione"),
            Noun.Create("Quadrilliarde", "Quadrilliarden"),
            Noun.Create("Quintillion", "Quintillione"),
            Noun.Create("Quintilliarde", "Quintilliarden"),
            Noun.Create("Sextillion", "Sextillione"),
            Noun.Create("Sextilliarde", "Sextilliarden"),
            Noun.Create("Septillion", "Septillione"),
            Noun.Create("Septilliarde", "Septilliarden"),
            Noun.Create("Oktillion", "Oktillione"),
            Noun.Create("Oktilliarde", "Oktilliarden"),
            Noun.Create("Nonillion", "Nonillione"),
            Noun.Create("Nonilliarde", "Nonilliarden"),
            Noun.Create("Dezillion", "Dezillione"),
            Noun.Create("Dezilliarde", "Dezilliarden")
        };

        public Noun GetLargeNumberNoun(int largeNumberIndex)
        {
            if (_largeNumberNames.Length <= largeNumberIndex)
                return Noun.Empty;

            return _largeNumberNames[largeNumberIndex];
        }
    }
}