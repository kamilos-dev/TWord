using System.Collections;

namespace TWord
{
    ///<inheritdoc/>
    internal class GermanTripletTransformer : ITripletTransformer
    {
        private readonly ILanguageNumbersDictionary _numbersDictionary;

        public GermanTripletTransformer(ILanguageNumbersDictionary numbersDictionary)
        {
            _numbersDictionary = numbersDictionary;
        }

        ///<inheritdoc/>
        public string ToWords(Triplet triplet, int? tripletIndex, string numberSeparator)
        {
            ArrayList words = new ArrayList();

            if (triplet.Hundreds > 0)
            {
                // 100, 200, 300
                words.Add(_numbersDictionary.GetHundredsWord(triplet.Hundreds));
            }

            if (triplet.Tens != 1 && triplet.Units > 0)
            {
                // 1, 2, 3
                words.Add(_numbersDictionary.GetOnesWord(triplet.Units));

                if (tripletIndex == 0 && triplet.Value == 1
                    || triplet.Hundreds != 0 && triplet.Units == 1)
                {
                    words.Add("s");
                }
            }

            if (triplet.Tens == 1 && triplet.Units != 0)
            {
                // 11, 12 ,13
                words.Add(_numbersDictionary.GetTeensWord(triplet.Units));
            }

            if (triplet.Tens == 1 && triplet.Units == 0
                || triplet.Tens > 1)
            {
                if (triplet.Units > 0)
                {
                    words.Add("und");
                }

                // 10, 20, 30
                words.Add(_numbersDictionary.GetTensWord(triplet.Tens));
            }

            return string.Join(numberSeparator, words.ToArray());
        }
    }
}