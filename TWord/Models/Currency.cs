namespace TWord
{
    internal record Currency
    {
        public CurrencySymbol Symbol { get; private set; }

        public Noun IntegerNoun { get; private set; }

        public Noun DecimalNoun { get; private set; }

        internal Currency(CurrencySymbol symbol, Noun integerNoun, Noun decimalNoun)
         => (Symbol, IntegerNoun, DecimalNoun)
         = (symbol, integerNoun, decimalNoun);

        internal static Currency Create(CurrencySymbol symbol, Noun integerNoun, Noun decimalNoun)
         => new Currency(symbol, integerNoun, decimalNoun);
    }
}