using System;
using System.Collections;
using System.Linq;

namespace TWord
{
    internal class GenericCurrencyTransformer : ICurrencyTransformer
    {
        private readonly INumberTransformer _numberTransformer;
        private readonly ICurrencyDictionary _currencyDictionary;
        private readonly INounInflector _nounInflector;

        public GenericCurrencyTransformer(
            INumberTransformer numberTransformer, 
            ICurrencyDictionary currencyDictionary,
            INounInflector nounInflector)
        {
            _numberTransformer = numberTransformer;
            _currencyDictionary = currencyDictionary;
            _nounInflector = nounInflector;
        }

        public string ToWords(decimal amount, CurrencySymbol currencySymbol, bool integerPartOnly, 
            bool decimalPartAsFraction, MidpointRounding? rounding = null)
        {
            var integerPart = amount.GetIntegerPart();
            var currency = _currencyDictionary.GetCurrency(currencySymbol);

            var words = new ArrayList();

            words.AddRange(IntegerToWords(integerPart, currency));

            if(!integerPartOnly)
            {
                var decimalPart = amount.GetDecimalPart(rounding);
                words.AddRange(DecimalToWords(decimalPart, currency, decimalPartAsFraction));
            }

            return string.Join(" ", words.OfType<string>()).Trim();
        }

        private ArrayList IntegerToWords(long number, Currency currency)
        {
            var words = new ArrayList();

            words.Add(_numberTransformer.ToWords(number));
            words.Add(InflectCurrencyNoun(number, currency.IntegerNoun));

            return words;
        }

        private ArrayList DecimalToWords(int number, Currency currency, bool decimalPartAsFraction)
        {
            var words = new ArrayList();

            if(decimalPartAsFraction)
            {
                words.Add(number.AsFraction(100));
            }
            else
            {
                words.Add(_numberTransformer.ToWords(number));
            }
            
            words.Add(InflectCurrencyNoun(number, currency.DecimalNoun));

            return words;
        }

        private string InflectCurrencyNoun(long number, Noun currencyNoun)
        {
            return _nounInflector.InflectNounByNumber(number,
                currencyNoun.Singular,
                currencyNoun.Plural,
                currencyNoun.GenitivePlural);
        }
    }
}