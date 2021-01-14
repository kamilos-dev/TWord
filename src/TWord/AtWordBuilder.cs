namespace TWord
{
    public class AtWordBuilder
    {
        private Language _language;

        private CurrencySymbol _currencySymbol;

        private readonly CurrencyOptions _currencyOptions;

        public AtWordBuilder()
        {
            _currencyOptions = new CurrencyOptions();
        }

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
            _currencyOptions.IntegerPartOnly = true;

            return this;
        }

        public AtWordBuilder DecimalPartAsFraction()
        {
            _currencyOptions.DecimalAsFraction = true;

            return this;
        }

        public AtWordBuilder HideSubunit()
        {
            _currencyOptions.HideSubunit = true;

            return this;
        }

        public AtWordBuilder IntegerAndDecimalPartSeparator(string separator)
        {
            _currencyOptions.IntegerAndDecimalPartSeparator = separator;

            return this;
        }

        public IAtWord Build()
        {
            return new AtWord(_language, _currencySymbol, _currencyOptions);
        }
    }
}