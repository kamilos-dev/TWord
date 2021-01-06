using System.Collections.Generic;

namespace TWord
{
    ///<inheritdoc/>
    internal class PolishNumbersDictionary : LanguageNumbersDictionary
    {
        ///<inheritdoc/>
        public override string Zero => "zero";

        ///<inheritdoc/>
        public override string Minus => "minus";

        protected override Dictionary<int, string> _ones => new Dictionary<int, string>
        {
            {0, "zero" },
            {1, "jeden" },
            {2, "dwa" },
            {3, "trzy" },
            {4, "cztery" },
            {5, "pięć" },
            {6, "sześć" },
            {7, "siedem" },
            {8, "osiem" },
            {9, "dziewięć" }
        };

        protected override Dictionary<int, string> _teens => new Dictionary<int, string>
        {
            {1, "jedenaście" },
            {2, "dwanaście" },
            {3, "trzynaście" },
            {4, "czternaście" },
            {5, "piętnaście" },
            {6, "szesnaście" },
            {7, "siedemnaście" },
            {8, "osiemnaście" },
            {9, "dziewietnaście" }
        };

        protected override Dictionary<int, string> _tens => new Dictionary<int, string>
        {
            {1, "dziesięć" },
            {2, "dwadzieścia" },
            {3, "trzydzieści" },
            {4, "czterdzieści" },
            {5, "pięćdziesiąt" },
            {6, "sześćdziesiąt" },
            {7, "siedemdziesiąt" },
            {8, "osiemdziesiąt" },
            {9, "dziewięćdziesiąt" }
        };

        protected override Dictionary<int, string> _hundreds => new Dictionary<int, string>
        {
            {1, "sto" },
            {2, "dwieście" },
            {3, "trzysta" },
            {4, "czterysta" },
            {5, "pięćset" },
            {6, "sześćset" },
            {7, "siedemset" },
            {8, "osiemset" },
            {9, "dziewięćset" }
        };        
    }
}