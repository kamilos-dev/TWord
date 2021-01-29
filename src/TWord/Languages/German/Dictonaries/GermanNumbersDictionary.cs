using System.Collections.Generic;

namespace TWord
{
    ///<inheritdoc/>
    internal class GermanNumbersDictionary : LanguageNumbersDictionary
    {
        ///<inheritdoc/>
        public override string Zero => "null";

        ///<inheritdoc/>
        public override string Minus => "minus";

        ///<inheritdoc/>
        public override string Hyphen => "-";

        protected override Dictionary<int, string> _ones => new Dictionary<int, string>
        {
            {1, "ein" },
            {2, "zwei" },
            {3, "drei" },
            {4, "vier" },
            {5, "fünf" },
            {6, "sechs" },
            {7, "sieben" },
            {8, "acht" },
            {9, "neun" }
        };

        protected override Dictionary<int, string> _teens => new Dictionary<int, string>
        {
            {1, "elf" },
            {2, "zwölf" },
            {3, "dreizehn" },
            {4, "vierzehn" },
            {5, "fünfzehn" },
            {6, "sechzehn" },
            {7, "siebzehn" },
            {8, "achtzehn" },
            {9, "neunzehn" }
        };

        protected override Dictionary<int, string> _tens => new Dictionary<int, string>
        {
            {1, "zehn" },
            {2, "zwanzig" },
            {3, "dreißig" },
            {4, "vierzig" },
            {5, "fünfzig" },
            {6, "sechzig" },
            {7, "siebzig" },
            {8, "achtzig" },
            {9, "neunzig" }
        };

        protected override Dictionary<int, string> _hundreds => new Dictionary<int, string>
        {
            {0, "hundert" },
        };

        public override string GetHundredsWord(int value)
        {
            return $"{_ones[value]}{_hundreds[0]}";
        }
    }
}