namespace TWord
{
    public interface IAtWord
    {
        string ToWord(decimal amount);
    }

    public class AtWord : IAtWord
    {
        private ICurrencyTransformer _currencyTransformer;

        private CurrencySymbol _currencySymbol;
        private bool _integerPartOnly;
        private bool _decimalPartAsFraction;

        public AtWord(Language language, CurrencySymbol currencySymbol, bool integerPartOnly, bool decimalPartAsFraction)
        {
            _currencySymbol = currencySymbol;
            _integerPartOnly = integerPartOnly;
            _decimalPartAsFraction = decimalPartAsFraction;

            _currencyTransformer = CurrencyTransformerSelector.Select(language);
        }

        public string ToWord(decimal amount)
        {
            return _currencyTransformer.ToWords(amount, _currencySymbol, _integerPartOnly, _decimalPartAsFraction);
        }
    }
}