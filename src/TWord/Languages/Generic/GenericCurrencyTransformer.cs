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
            var words = new ArrayList();

            var currency = _currencyDictionary.GetCurrency(currencySymbol);

            words.AddRange(IntegerPartToWords(amount, currency));

            var withDecimalPart = !currencyOptions?.IntegerPartOnly ?? true;

            if (withDecimalPart)
            {
                words.AddRange(DecimalPartToWords(amount, currency, currencyOptions));
            }

            return string.Join(" ", words.OfType<string>()).Trim();
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
            var integerAndDecimalPartSeparator = currencyOptions?.IntegerAndDecimalPartSeparator;

            if (!string.IsNullOrEmpty(integerAndDecimalPartSeparator))
            {
                words.Add(integerAndDecimalPartSeparator);
            }

            var decimalPart = amount.GetDecimalPart();
            words.AddRange(DecimalToWords(decimalPart, currency, decimalPartAsFraction, hideSubunit));

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
            return _nounInflector.InflectNounByNumber(number,
                currencyNoun.Singular,
                currencyNoun.Plural,
                currencyNoun.GenitivePlural);
        }
    }
}