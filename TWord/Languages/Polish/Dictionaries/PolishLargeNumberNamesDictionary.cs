namespace TWord
{
    internal class PolishLargeNumberNamesDictionary : ILargeNumberNamesDictionary
    {
        private readonly Noun[] _largeNumberNames =
        {
            Noun.Empty,
            Noun.Create("tysiąc", "tysiące", "tysięcy"),
            Noun.Create("milion", "miliony", "milionów"),
            Noun.Create("miliard", "miliardy", "miliardów"),
            Noun.Create("bilion", "biliony", "bilionów"),
            Noun.Create("biliard", "biliardy", "biliardów"),
            Noun.Create("trylion", "tryliony", "trylionów"),
            Noun.Create("tryliard", "tryliardy", "tryliardów"),
            Noun.Create("kwadrylion", "kwadryliony", "kwadrylionów"),
            Noun.Create("kwadryliard", "kwadryliardy", "kwadryliardów"),
            Noun.Create("kwintylion", "kwintyliony", "kwintylionów"),
            Noun.Create("kwintyliiard", "kwintyliardy", "kwintyliardów"),
            Noun.Create("sekstylion", "sekstyliony", "sekstylionów"),
            Noun.Create("sekstyliard", "sekstyliardy", "sekstyliardów"),
            Noun.Create("septylion", "septyliony", "septylionów"),
            Noun.Create("septyliard", "septyliardy", "septyliardów"),
            Noun.Create("oktylion", "oktyliony", "oktylionów"),
            Noun.Create("oktyliard", "oktyliardy", "oktyliardów"),
            Noun.Create("nonylion", "nonyliony", "nonylionów"),
            Noun.Create("nonyliard", "nonyliardy", "nonyliardów"),
            Noun.Create("decylion", "decyliony", "decylionów"),
            Noun.Create("decyliard", "decyliardy", "decyliardów")
        };

        public Noun GetLargeNumberNoun(int largeNumberIndex)
        {
            if (_largeNumberNames.Length <= largeNumberIndex)
                return null;

            return _largeNumberNames[largeNumberIndex];
        }
    }
}