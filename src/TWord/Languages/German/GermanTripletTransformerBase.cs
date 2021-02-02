using System.Collections;

namespace TWord
{
    ///<inheritdoc/>
    internal class GermanTripletTransformerBase : ITripletTransformer
    {
        protected readonly ILanguageNumbersDictionary _numbersDictionary;

        public GermanTripletTransformerBase(ILanguageNumbersDictionary numbersDictionary)
        {
            _numbersDictionary = numbersDictionary;
        }

        ///<inheritdoc/>
        public string ToWords(Triplet triplet, int? tripletIndex, string numberSeparator)
        {
            ArrayList words = new ArrayList();

            // 100, 200, 300
            words.AddRange(GetHundreds(triplet));

            // 1, 2, 3
            words.AddRange(GetUnits(triplet, tripletIndex));

            // 11, 12 ,13
            words.AddRange(GetTeens(triplet));

            // 10, 20, 30
            words.AddRange(GetTens(triplet));

            return string.Join(numberSeparator, words.ToArray());
        }

        protected virtual ArrayList GetHundreds(Triplet triplet)
        {
            ArrayList words = new ArrayList();

            if (triplet.Hundreds > 0)
            {
                words.Add(_numbersDictionary.GetHundredsWord(triplet.Hundreds));
            }

            return words;
        }

        protected virtual ArrayList GetUnits(Triplet triplet, int? tripletIndex)
        {
            ArrayList words = new ArrayList();

            if (triplet.Tens != 1 && triplet.Units > 0)
            {
                words.Add(_numbersDictionary.GetOnesWord(triplet.Units));
            }

            return words;
        }

        protected virtual ArrayList GetTeens(Triplet triplet)
        {
            ArrayList words = new ArrayList();

            if (triplet.Tens == 1 && triplet.Units != 0)
            {                
                words.Add(_numbersDictionary.GetTeensWord(triplet.Units));
            }

            return words;
        }
       
        protected virtual ArrayList GetTens(Triplet triplet)
        {
            ArrayList words = new ArrayList();

            if (triplet.Tens == 1 && triplet.Units == 0
                || triplet.Tens > 1)
            {
                if (triplet.Units > 0)
                {
                    words.Add("und");
                }

                words.Add(_numbersDictionary.GetTensWord(triplet.Tens));
            }

            return words;
        }
    }
}