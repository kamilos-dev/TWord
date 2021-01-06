using System.Collections;

namespace TWord
{
    public class TripleLanguageTransformer : ITriplerTransformer
    {
        private readonly ILanguageNumbersDictionary _numbersDictionary;

        public TripleLanguageTransformer(ILanguageNumbersDictionary numbersDictionary)
        {
            _numbersDictionary = numbersDictionary;
        }

        public string ToPhrase(int triple)
        {
            var numberParts = triple.GetDigits();

            int units = numberParts[0];
            int tens = numberParts[1];
            int hundreds = numberParts[2];

            ArrayList words = new ArrayList();

            if (hundreds > 0)
            {
                // 100, 200, 300
                words.Add(_numbersDictionary.GetHundredsWord(hundreds)); 
            }

            if (tens == 1 && units != 0)
            {
                // 11, 12 ,13
                words.Add(_numbersDictionary.GetTeensWord(units));
            }

            if (tens == 1 && units == 0
                || tens > 1)
            {
                // 10, 20, 30
                words.Add(_numbersDictionary.GetTensWord(tens)); 
            }

            if(tens != 1 && units > 0)
            {
                // 1, 2, 3
                words.Add(_numbersDictionary.GetOnesWord(units));
            }

            var phrase = string.Join(' ', words.ToArray());

            return phrase;
        }
    }
}