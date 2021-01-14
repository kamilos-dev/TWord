using System.Linq;

namespace TWord
{
    internal record Currency
    {
        /// <summary>
        /// Currency symbol
        /// </summary>
        public CurrencySymbol Symbol { get; private set; }

        /// <summary>
        /// Noun for integer part
        /// </summary>
        public Noun IntegerNoun { get; private set; }

        /// <summary>
        /// Noun for decimal part
        /// </summary>
        public Noun DecimalNoun { get; private set; }

        /// <summary>
        /// Number to basic.
        /// E.g. for USD it is 100.
        /// </summary>
        public int NumberToBasic => GetNumberToBasic();

        internal Currency(CurrencySymbol symbol, Noun integerNoun, Noun decimalNoun)
         => (Symbol, IntegerNoun, DecimalNoun)
         = (symbol, integerNoun, decimalNoun);

        internal static Currency Create(CurrencySymbol symbol, Noun integerNoun, Noun decimalNoun)
         => new Currency(symbol, integerNoun, decimalNoun);

        /// <summary>
        /// Returns number to basic
        /// </summary>
        /// <returns>Number to basic</returns>
        private int GetNumberToBasic()
        {
            return typeof(CurrencySymbol)
                .GetField(Symbol.ToString())
                .GetCustomAttributes(typeof(CurrencyDataAttribute), true)
                .OfType<CurrencyDataAttribute>()
                .Single()
                .NumberToBase;
        }
    }
}