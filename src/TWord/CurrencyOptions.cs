namespace TWord
{
    public class CurrencyOptions
    {
        /// <summary>
        /// Display decimal part as fraction
        /// E.g insted of ten cents display 10/100 cents
        /// 
        /// It has no effect when IntegerPartOnly is true
        /// </summary>
        public bool DecimalAsFraction { get; set; }

        /// <summary>
        /// Hides subunit.
        /// E.g display ten or 10/100 without subunit word
        /// 
        /// It has no effect when IntegerPartOnly is true
        /// </summary>
        public bool HideSubunit { get; set; }

        /// <summary>
        /// Returns words without decimal part.
        /// E.g 10.05 returns 'ten dollars'
        /// </summary>
        public bool IntegerPartOnly { get; set; }

        /// <summary>
        /// Separator for integer and decimal part.
        /// Default is a space " ".
        /// E.g ten dollars zero cents.
        /// If separator is "and" result will be 
        /// E.g ten dollars and zero cents.
        /// </summary>
        public string IntegerAndDecimalPartSeparator { get; set; }
    }
}