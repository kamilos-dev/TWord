namespace TWord
{
    public class AtWordBuilder
    {
        private Language _language;

        private CurrencySymbol _currencySymbol;

        private bool _integerPartOnly;
        private bool _decimalPartAsFraction;

        public AtWordBuilder SetLanguage(Language language)
        {
            _language = language;

            return this;
        }

        public AtWordBuilder SetCurrency(CurrencySymbol currencySymbol)
        {
            _currencySymbol = currencySymbol;

            return this;
        }

        public AtWordBuilder IntegerPartOnly()
        {
            _integerPartOnly = true;

            return this;
        }

        public AtWordBuilder DecimalPartAsFraction()
        {
            _decimalPartAsFraction = true;

            return this;
        }

        public IAtWord Build()
        {
            return new AtWord(_language, _currencySymbol, _integerPartOnly, _decimalPartAsFraction);
        }
    }
}