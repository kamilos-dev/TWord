using System;

namespace TWord
{
    internal class CurrencyTransformerBuilder
    {
        private INumberTransformer _numberTransformer;
        private ICurrencyDictionary _currencyDictionary;
        private INounInflector _nounInflector;

        /// <summary>
        /// Set number transformer
        /// </summary>
        /// <param name="numberTransformer">Number transformer</param>
        /// <returns>CurrencyTransformerBuilder instance</returns>
        internal CurrencyTransformerBuilder SetNumberTransformer(
            INumberTransformer numberTransformer)
        {
            _numberTransformer = numberTransformer;

            return this;
        }

        /// <summary>
        /// Set currency directory
        /// </summary>
        /// <param name="currencyDictionary">Currency dictionary</param>
        /// <returns>CurrencyTransformerBuilder instance</returns>
        internal CurrencyTransformerBuilder SetCurrencyDictionary(
            ICurrencyDictionary currencyDictionary)
        {
            _currencyDictionary = currencyDictionary;

            return this;
        }

        /// <summary>
        /// Set noun inflector
        /// </summary>
        /// <param name="nounInflector">Noun inflector</param>
        /// <returns>CurrencyTransformerBuilder instance</returns>
        internal CurrencyTransformerBuilder SetNounInflector(
            INounInflector nounInflector)
        {
            _nounInflector = nounInflector;

            return this;
        }

        /// <summary>
        /// Returns ICurrencyTransformer instance
        /// </summary>
        public ICurrencyTransformer Build()
        {
            if (_numberTransformer == null)
            {
                throw new NullReferenceException($"{nameof(INumberTransformer)} cannot be null. " +
                    $"Use {nameof(SetNumberTransformer)} to set it.");
            }

            if (_currencyDictionary == null)
            {
                throw new NullReferenceException($"{nameof(ICurrencyDictionary)} cannot be null. " +
                    $"Use {nameof(SetCurrencyDictionary)} to set it.");
            }

            if (_currencyDictionary == null)
            {
                throw new NullReferenceException($"{nameof(INounInflector)} cannot be null. " +
                    $"Use {nameof(SetNounInflector)} to set it.");
            }

            return new GenericCurrencyTransformer(_numberTransformer,
                _currencyDictionary, _nounInflector);
        }
    }
}