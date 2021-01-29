using System.Collections.Generic;

namespace TWord
{
    ///<inheritdoc/>
    internal class EnglishNumbersDictionary : LanguageNumbersDictionary
    {
        ///<inheritdoc/>
        public override string Zero => "zero";

        ///<inheritdoc/>
        public override string Minus => "minus";

        ///<inheritdoc/>
        public override string Hyphen => "-";

        protected override Dictionary<int, string> _ones => new Dictionary<int, string>
        {
            {1, "one" },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" },
            {6, "six" },
            {7, "seven" },
            {8, "eight" },
            {9, "nine" }
        };

        protected override Dictionary<int, string> _teens => new Dictionary<int, string>
        {
            {1, "eleven" },
            {2, "twelve" },
            {3, "thirteen" },
            {4, "fourteen" },
            {5, "fifteen" },
            {6, "sixteen" },
            {7, "seventeen" },
            {8, "eighteen" },
            {9, "nineteen" }
        };

        protected override Dictionary<int, string> _tens => new Dictionary<int, string>
        {
            {1, "ten" },
            {2, "twenty" },
            {3, "thirty" },
            {4, "fourty" },
            {5, "fifty" },
            {6, "sixty" },
            {7, "seventy" },
            {8, "eighty" },
            {9, "ninety" }
        };

        protected override Dictionary<int, string> _hundreds => new Dictionary<int, string>
        {
            {0, "hundred" },
        };

        public override string GetHundredsWord(int value)
        {
            return $"{_ones[value]} {_hundreds[0]}";
        }
    }
}