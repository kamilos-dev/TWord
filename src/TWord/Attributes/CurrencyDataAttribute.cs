using System;

namespace TWord
{
    /// <summary>
    /// Additional information for currencies
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    internal class CurrencyDataAttribute : Attribute
    {
        /// <summary>
        /// Number to base. E.g USD has 100.
        /// </summary>
        public readonly int NumberToBase;

        /// <summary>
        /// Creates CurrencyDataAttribute
        /// </summary>
        /// <param name="numberToBase">Number to base. E.g USD has 100.</param>
        public CurrencyDataAttribute(int numberToBase)
        {
            NumberToBase = numberToBase;
        }
    }
}