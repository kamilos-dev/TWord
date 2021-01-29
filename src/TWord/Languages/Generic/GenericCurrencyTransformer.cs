using System.Collections;
using System.Linq;

namespace TWord
{
    ///<inheritdoc/>
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

        ///<inheritdoc/>
        public string ToWords(decimal amount, CurrencySymbol currencySymbol,
            CurrencyOptions currencyOptions)
        {
            var currency = _currencyDictionary.GetCurrency(currencySymbol);

            var integerWords = IntegerPartToWords(amount, currency);

            var withDecimalPart = !currencyOptions?.IntegerPartOnly ?? true;
            var integerAndDecimalPartSeparator = currencyOptions?.IntegerAndDecimalPartSeparator;

            var decimalWords = new ArrayList();

            if (withDecimalPart)
            {
                decimalWords = DecimalPartToWords(amount, currency, currencyOptions);
            }

            return JoinNumberParts(integerWords, decimalWords, integerAndDecimalPartSeparator);
        }

        /// <summary>
        /// Transform integer part of amount to words.
        /// </summary>
        /// <param name="amount">Decimal number</param>
        /// <param name="currency">Currency</param>
        /// <returns>ArrayList of words</returns>
        private ArrayList IntegerPartToWords(decimal amount, Currency currency)
        {
            var integerPart = amount.GetIntegerPart();

            return IntegerToWords(integerPart, currency);
        }

        /// <summary>
        /// Transform decimal part of amount to words.
        /// </summary>
        /// <param name="amount">Decimal number</param>
        /// <param name="currency">Currency</param>
        /// <returns>ArrayList of words</returns>
        private ArrayList DecimalPartToWords(decimal amount, Currency currency, CurrencyOptions currencyOptions)
        {
            var words = new ArrayList();

            var decimalPartAsFraction = currencyOptions?.DecimalAsFraction ?? false;
            var hideSubunit = currencyOptions?.HideSubunit ?? false;

            var decimalPart = amount.GetDecimalPart();
            var decimalWords = DecimalToWords(decimalPart, currency, decimalPartAsFraction, hideSubunit);

            words.AddRange(decimalWords);

            return words;
        }

        /// <summary>
        /// Transform given integer number to words
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="currency">Currency</param>
        /// <returns>ArrayList of words</returns>
        private ArrayList IntegerToWords(long number, Currency currency)
        {
            var words = new ArrayList();

            words.Add(_numberTransformer.ToWords(number));
            words.Add(InflectCurrencyNoun(number, currency.IntegerNoun));

            return words;
        }

        /// <summary>
        /// Transform given decimal part to words
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="currency">Currency</param>
        /// <returns>ArrayList of words</returns>
        private ArrayList DecimalToWords(decimal number, Currency currency, bool decimalPartAsFraction, bool hideSubunit)
        {
            var words = new ArrayList();

            long decimalPart = DecimalConventer.ConvertDecimalPartToLong(number);

            if (decimalPartAsFraction)
            {
                words.Add(decimalPart.AsFraction(currency.NumberToBasic));
            }
            else
            {
                words.Add(_numberTransformer.ToWords(decimalPart));
            }

            if (!hideSubunit)
            {
                words.Add(InflectCurrencyNoun(decimalPart, currency.DecimalNoun));
            }

            return words;
        }

        /// <summary>
        /// Inflect currency noun by number
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="currencyNoun">Nouns of the currency</param>
        /// <returns>Inflected noun</returns>
        private string InflectCurrencyNoun(long number, Noun currencyNoun)
        {
            return _nounInflector.InflectNounByNumber(number, currencyNoun);
        }

        /// <summary>
        /// Concat the integer and decimal part words into phrase with part separator
        /// </summary>
        /// <param name="integerWords">Integer part words</param>
        /// <param name="decimalWords">Decimal part words</param>
        /// <param name="integerAndDecimalPartSeparator">Integer and decimal part separator</param>
        /// <returns></returns>
        private string JoinNumberParts(ArrayList integerWords, ArrayList decimalWords, 
            string integerAndDecimalPartSeparator)
        {
            if (string.IsNullOrEmpty(integerAndDecimalPartSeparator))
            {
                integerAndDecimalPartSeparator = " ";
            }

            var integerPart = string.Join(" ", integerWords.OfType<string>()).Trim();
            var decimalPart = string.Join(" ", decimalWords.OfType<string>()).Trim();

            var phrase = $"{integerPart}{integerAndDecimalPartSeparator}{decimalPart}".Trim();
            return phrase;
        }
    }
}