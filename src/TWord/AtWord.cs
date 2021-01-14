namespace TWord
{
    public class AtWord : IAtWord
    {
        private readonly ICurrencyTransformer _currencyTransformer;

        private readonly CurrencySymbol _currencySymbol;
        private readonly CurrencyOptions _currencyOptions;

        public AtWord(Language language, CurrencySymbol currencySymbol, CurrencyOptions currencyOptions)
        {
            _currencySymbol = currencySymbol;
            _currencyOptions = currencyOptions;

            _currencyTransformer = CurrencyTransformerSelector.Select(language);
        }

        public string ToWord(decimal amount)
        {
            return _currencyTransformer.ToWords(amount, _currencySymbol, _currencyOptions);
        }
    }
}