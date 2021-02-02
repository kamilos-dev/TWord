using System;
using System.Collections;
using System.Linq;

namespace TWord
{
    ///<inheritdoc/>
    internal class GenericNumberTransformer : INumberTransformer
    {
        private readonly ILanguageNumbersDictionary _numbersDictionary;
        private readonly ITripletTransformer _triplerTransformer;
        private readonly ILargeNumberNamesDictionary _largeNumberNamesDictionary;
        private readonly INounInflector _nounInflector;
        private readonly string _numberSeparator;

        public GenericNumberTransformer(
            ILanguageNumbersDictionary numbersDictionary,
            ITripletTransformer triplerTransformer,
            ILargeNumberNamesDictionary largeNumberNamesDictionary,
            INounInflector nounInflector,
            string numberSeparator)
        {
            _numbersDictionary = numbersDictionary;
            _triplerTransformer = triplerTransformer;
            _largeNumberNamesDictionary = largeNumberNamesDictionary;
            _nounInflector = nounInflector;

            _numberSeparator = numberSeparator;

            if (_numberSeparator == null)
                _numberSeparator = " ";
        }

        ///<inheritdoc/>
        public string ToWords(long value)
        {
            if (value == 0)
                return _numbersDictionary.Zero;

            ArrayList words = new ArrayList();

            if (value < 0)
            {
                words.Add(_numbersDictionary.Minus);
                value = Math.Abs(value);
            }

            words.AddRange(GetWordsBySplitNumberToTriplets(value, _numberSeparator));

            return string.Join(_numberSeparator, words.OfType<string>()).Trim();
        }

        /// <summary>
        /// Returns array of words by transform number into triplets
        /// </summary>
        /// <param name="number">Number to transform</param>
        /// <param name="numberSeparator">Nunber separator</param>
        /// <returns>ArrayList with words</returns>
        private ArrayList GetWordsBySplitNumberToTriplets(long number, string numberSeparator)
        {
            ArrayList words = new ArrayList();

            var triplets = number.ToTriplets();

            for (var tripletIndex = 0; tripletIndex < triplets.Length; tripletIndex++)
            {
                var triplet = triplets[tripletIndex];

                if (triplet == Triplet.Empty)
                    continue;

                var phrase = _triplerTransformer.ToWords(triplet, tripletIndex, numberSeparator);

                var noun = _largeNumberNamesDictionary.GetLargeNumberNoun(tripletIndex);

                if (noun != Noun.Empty)
                {
                    var largeNumberName = noun.Singular;

                    if (_nounInflector != null)
                    {
                        largeNumberName = _nounInflector.InflectNounByNumber(triplet.Value, tripletIndex, noun);
                    }

                    words.Add(largeNumberName);
                }

                words.Add(phrase);
            }

            words.Reverse();

            return words;
        }
    }
}