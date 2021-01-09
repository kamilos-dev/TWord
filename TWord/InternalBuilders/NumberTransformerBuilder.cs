using System;

namespace TWord
{
    internal class NumberTransformerBuilder
    {
        private ILanguageNumbersDictionary _numbersDictionary;
        private ILargeNumberNamesDictionary _namesDictionary;
        private ITripletTransformer _triplerTransformer;
        private INounInflector _nounInflector;

        /// <summary>
        /// Set numbers dictionary
        /// </summary>
        /// <param name="numbersDictionary">Numbers dictionary</param>
        /// <returns>NumberTransformerBuilder instance</returns>
        public NumberTransformerBuilder SetNumbersDictionary(
            ILanguageNumbersDictionary numbersDictionary)
        {
            _numbersDictionary = numbersDictionary;

            return this;
        }

        /// <summary>
        /// Set large number names dictionary
        /// </summary>
        /// <param name="namesDictionary">Large number names dictionary</param>
        /// <returns>NumberTransformerBuilder instance</returns>
        public NumberTransformerBuilder SetLargeNumberNamesDictionary(
            ILargeNumberNamesDictionary namesDictionary)
        {
            _namesDictionary = namesDictionary;

            return this;
        }

        /// <summary>
        /// Set tripler transformer
        /// </summary>
        /// <param name="triplerTransformer">Tripler transformer</param>
        /// <returns>NumberTransformerBuilder instance</returns>
        public NumberTransformerBuilder SetTriplerTransformer(
            ITripletTransformer triplerTransformer)
        {
            _triplerTransformer = triplerTransformer;

            return this;
        }

        /// <summary>
        /// Set inflector for nouns
        /// </summary>
        /// <param name="nounInflector">Noun inflector</param>
        /// <returns>NumberTransformerBuilder instance</returns>
        public NumberTransformerBuilder InflectNounsBy(
            INounInflector nounInflector)
        {
            _nounInflector = nounInflector;

            return this;
        }

        /// <summary>
        /// Returns INumberTransformer instance
        /// </summary>
        public INumberTransformer Build()
        {
            if(_numbersDictionary == null)
            {
                throw new NullReferenceException($"{nameof(ILanguageNumbersDictionary)} cannot be null. Use {nameof(SetNumbersDictionary)} to set it.");
            }

            if (_namesDictionary == null)
            {
                throw new NullReferenceException($"{nameof(ILargeNumberNamesDictionary)} cannot be null. Use {nameof(SetLargeNumberNamesDictionary)} to set it.");
            }

            if (_triplerTransformer == null)
            {
                throw new NullReferenceException($"{nameof(ITripletTransformer)} cannot be null. Use {nameof(SetTriplerTransformer)} to set it.");
            }

            return new GenericNumberTransformer(_numbersDictionary, _triplerTransformer, _namesDictionary,
                _nounInflector);
        }
    }
}