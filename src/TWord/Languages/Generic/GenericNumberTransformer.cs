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

        public GenericNumberTransformer(
            ILanguageNumbersDictionary numbersDictionary,
            ITripletTransformer triplerTransformer,
            ILargeNumberNamesDictionary largeNumberNamesDictionary,
            INounInflector nounInflector)
        {
            _numbersDictionary = numbersDictionary;
            _triplerTransformer = triplerTransformer;
            _largeNumberNamesDictionary = largeNumberNamesDictionary;
            _nounInflector = nounInflector;
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

            words.AddRange(GetWordsBySplitNumberToTriplets(value));

            return string.Join(" ", words.OfType<string>()).Trim();
        }

        /// <summary>
        /// Returns array of words by transform number into triplets
        /// </summary>
        /// <param name="number">Number to transform</param>
        /// <returns>ArrayList with words</returns>
        private ArrayList GetWordsBySplitNumberToTriplets(long number)
        {
            ArrayList words = new ArrayList();

            var triplets = number.ToTriplets();

            for (var tripletIndex = 0; tripletIndex < triplets.Length; tripletIndex++)
            {
                var triplet = triplets[tripletIndex];
                var phrase = _triplerTransformer.ToWords(triplet);

                var noun = _largeNumberNamesDictionary.GetLargeNumberNoun(tripletIndex);

                if (noun != Noun.Empty)
                {
                    var largeNumberName = noun.Singular;

                    if (_nounInflector != null)
                    {
                        largeNumberName = _nounInflector.InflectNounByNumber(triplet.ToInt(),
                            noun.Singular,
                            noun.Plural,
                            noun.GenitivePlural);
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