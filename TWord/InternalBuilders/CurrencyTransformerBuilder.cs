namespace TWord
{
    internal class CurrencyTransformerBuilder
    {
        private INumberTransformer _numberTransformer;
        private ICurrencyDictionary _currencyDictionary;
        private INounInflector _nounInflector;

        internal CurrencyTransformerBuilder SetNumberTransformer(INumberTransformer numberTransformer)
        {
            _numberTransformer = numberTransformer;

            return this;
        }

        internal CurrencyTransformerBuilder SetCurrencyDictionary(ICurrencyDictionary currencyDictionary)
        {
            _currencyDictionary = currencyDictionary;

            return this;
        }

        internal CurrencyTransformerBuilder SetNounInflector(INounInflector nounInflector)
        {
            _nounInflector = nounInflector;

            return this;
        }

        public ICurrencyTransformer Build()
        {
            return new GenericCurrencyTransformer(_numberTransformer, _currencyDictionary, _nounInflector);
        }
    }
}