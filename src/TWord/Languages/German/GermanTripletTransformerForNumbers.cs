using System.Collections;

namespace TWord
{
    ///<inheritdoc/>
    internal class GermanTripletTransformerForNumbers : GermanTripletTransformerBase
    {
        public GermanTripletTransformerForNumbers(ILanguageNumbersDictionary numbersDictionary) 
            : base(numbersDictionary)
        {
        }

        protected override ArrayList GetUnits(Triplet triplet, int? tripletIndex)
        {
            ArrayList words = new ArrayList();

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

            return words;
        }
    }
}