﻿using System.Collections;

namespace TWord
{
    ///<inheritdoc cref="ITripletTransformer"/>
    internal class GenericTripletTransformer : ITripletTransformer
    {
        private readonly ILanguageNumbersDictionary _numbersDictionary;

        public GenericTripletTransformer(ILanguageNumbersDictionary numbersDictionary)
        {
            _numbersDictionary = numbersDictionary;
        }

        ///<inheritdoc cref="ITripletTransformer"/>
        public string ToWords(Triplet triplet)
        {
            ArrayList words = new ArrayList();

            if (triplet.Hundreds > 0)
            {
                // 100, 200, 300
                words.Add(_numbersDictionary.GetHundredsWord(triplet.Hundreds));
            }

            if (triplet.Tens == 1 && triplet.Units != 0)
            {
                // 11, 12 ,13
                words.Add(_numbersDictionary.GetTeensWord(triplet.Units));
            }

            if (triplet.Tens == 1 && triplet.Units == 0
                || triplet.Tens > 1)
            {
                // 10, 20, 30
                words.Add(_numbersDictionary.GetTensWord(triplet.Tens));
            }

            if (triplet.Tens != 1 && triplet.Units > 0)
            {
                // 1, 2, 3
                words.Add(_numbersDictionary.GetOnesWord(triplet.Units));
            }

            return string.Join(' ', words.ToArray());
        }
    }
}