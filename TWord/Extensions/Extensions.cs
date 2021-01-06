using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace TWord
{
    public static class Extensions
    {
        /// <summary>
        /// Split number to triples. 
        /// E.g 12345 give 123 and 45
        /// </summary>
        /// <param name="value">Number</param>
        /// <returns>Array of triples</returns>
        public static int[] ToTriples(this long number)
        {
            ArrayList tripples = new ArrayList();

            while (number > 0)
            {
                tripples.Add((int)(number % 1000));
                number = (int)(number / 1000);
            }

            return tripples.OfType<int>().ToArray();
        }

        /// <summary>
        /// Returns each digit of the number separately
        /// E.g. 123 -> 1, 2, 3
        /// </summary>
        /// <param name="value">Number</param>
        /// <returns>Array of digits</returns>
        public static int[] GetDigits(this int value)
        {
            var units = value % 10;
            var tens = (value / 10) % 10;
            var hundreds = (value / 100) % 10;

            return new int[] { units, tens, hundreds };
        }

        /// <summary>
        /// Returns decimal part as fraction
        /// E.g 12 -> 12/100
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="divisor">Divisor. Should be less than number</param>
        /// <returns></returns>
        public static string AsFraction(this int number, int divisor)
        {
            if(number > divisor)
            {
                throw new Exception("Na pewno?");
            }

            return $"{number}/{divisor}";
        }

        /// <summary>
        /// Returns integer part of decimal number.
        /// E.g. 123.45 returns 123
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <returns>Integer part</returns>
        public static long GetIntegerPart(this decimal value)
        {
            return (long)Math.Truncate(value);
        }

        /// <summary>
        /// Returns decimal part of decimal number.
        /// E.g. 123.45 returns 45
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <returns>Decimal part</returns>
        public static int GetDecimalPart(this decimal value)
        {
            return GetDecimalPart(value, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Returns decimal part of decimal number.
        /// E.g. 123.45 returns 45
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <param name="rounding">Rounding of the decimal part</param>
        /// <returns>Decimal part</returns>
        public static int GetDecimalPart(this decimal value, MidpointRounding? rounding = MidpointRounding.AwayFromZero)
        {
            return GetDecimalPart(value, rounding, 2);
        }

        /// <summary>
        /// Returns decimal part of decimal number.
        /// E.g. 123.45 returns 45
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <param name="rounding">Rounding</param>
        /// <returns>Decimal part</returns>
        public static int GetDecimalPart(this decimal value, MidpointRounding? rounding = MidpointRounding.AwayFromZero, int? decimalPlaces = 2)
        {
            if (value == decimal.Zero)
                return 0;

            var fractialPart = value - value.GetIntegerPart();
            var roundedFractialPart = Math.Round(fractialPart, decimalPlaces.Value, rounding.Value);

            var stringFormat = "0.00";
            var cultureInfo = CultureInfo.InvariantCulture;

            string fractialPartStr = roundedFractialPart.ToString(stringFormat, cultureInfo).Split(".")[1];
            int fractialPartInt = Convert.ToInt32(fractialPartStr);

            return fractialPartInt;
        }
    }
}