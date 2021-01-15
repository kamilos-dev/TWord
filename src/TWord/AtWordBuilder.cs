namespace TWord
{
    /// <summary>
    /// Builder for IAtWord instance
    /// </summary>
    public class AtWordBuilder
    {
        private readonly CurrencyOptions _currencyOptions;

        private Language _language;
        private CurrencySymbol _currencySymbol;

        public AtWordBuilder()
        {
            _currencyOptions = new CurrencyOptions();
        }

        /// <summary>
        /// Set language
        /// </summary>
        /// <param name="language">Language symbol</param>
        /// <returns>AtWordBuilder instance</returns>
        public AtWordBuilder SetLanguage(Language language)
        {
            _language = language;

            return this;
        }

        /// <summary>
        /// Set currency
        /// </summary>
        /// <param name="currencySymbol">Currency symbol</param>
        /// <returns>AtWordBuilder instance</returns>
        public AtWordBuilder SetCurrency(CurrencySymbol currencySymbol)
        {
            _currencySymbol = currencySymbol;

            return this;
        }

        /// <summary>
        /// Transform number to words without decimal part
        /// </summary>
        /// <returns>AtWordBuilder instance</returns>
        public AtWordBuilder IntegerPartOnly()
        {
            _currencyOptions.IntegerPartOnly = true;

            return this;
        }

        /// <summary>
        /// Returns decimal part as fraction e.g 5/100
        /// </summary>
        /// <returns>AtWordBuilder instance</returns>
        public AtWordBuilder DecimalPartAsFraction()
        {
            _currencyOptions.DecimalAsFraction = true;

            return this;
        }

        /// <summary>
        /// Hides subunit. For example 1.05 gives 
        /// one dollar five
        /// </summary>
        /// <returns>AtWordBuilder instance</returns>
        public AtWordBuilder HideSubunit()
        {
            _currencyOptions.HideSubunit = true;

            return this;
        }

        /// <summary>
        /// Set separator for integer and decimal part
        /// </summary>
        /// <returns>AtWordBuilder instance</returns>
        public AtWordBuilder IntegerAndDecimalPartSeparator(string separator)
        {
            _currencyOptions.IntegerAndDecimalPartSeparator = separator;

            return this;
        }

        /// <summary>
        /// Returns IAtWord instance
        /// </summary>
        public IAtWord Build()
        {
            return new AtWord(_language, _currencySymbol, _currencyOptions);
        }
    }
}