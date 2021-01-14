using System;
using System.Collections;
using System.Linq;

namespace TWord
{
    internal static class NumberExtensions
    {
        /// <summary>
        /// Returns units of given value
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Units as int</returns>
        public static int GetUnits(this int value)
        {
            return ((long)value).GetUnits();
        }

        /// <summary>
        /// Returns tens of given value
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Tens as int</returns>
        public static int GetTens(this int value)
        {
            return ((long)value).GetTens();
        }

        /// <summary>
        /// Returns hundreds of given value
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Hundreds as int</returns>
        public static int GetHundreds(this int value)
        {
            return ((long)value).GetHundreds();
        }

        /// <summary>
        /// Returns units of given value
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Units as int</returns>
        public static int GetUnits(this long value)
        {
            return (int)(value % 10);
        }

        /// <summary>
        /// Returns tens of given value
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Tens as int</returns>
        public static int GetTens(this long value)
        {
            return (int)(value / 10 % 10);
        }

        /// <summary>
        /// Returns hundreds of given value
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Hundreds as int</returns>
        public static int GetHundreds(this long value)
        {
            return (int)(value / 100 % 10);
        }

        /// <summary>
        /// Split number to triples. 
        /// E.g 12345 give 123 and 45
        /// </summary>
        /// <param name="value">Number</param>
        /// <returns>Array of triples</returns>
        public static Triplet[] ToTriplets(this long number)
        {
            ArrayList tripples = new ArrayList();

            while (number > 0)
            {
                Triplet triplet = new Triplet((int)(number % 1000));
                tripples.Add(triplet);

                number = (int)(number / 1000);
            }

            return tripples.OfType<Triplet>().ToArray();
        }

        /// <summary>
        /// Returns decimal part as fraction
        /// E.g 12 -> 12/100
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="divisor">Divisor. Should be less than number</param>
        /// <returns></returns>
        public static string AsFraction(this long number, int divisor = 100)
        {
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
        /// <param name="rounding">Rounding</param>
        /// <returns>Decimal part</returns>
        public static decimal GetDecimalPart(this decimal value)
        {
            if (value == decimal.Zero)
                return 0;

            return (value - value.GetIntegerPart()).Normalize();
        }

        /// <summary>
        /// Add decimal part to decimal value if not exists.
        /// Remove leasing 0 it exists.
        /// E.g 
        ///     1 --> 1.0
        ///     1.010 --> 1.01
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Normalize(this decimal value)
        {
            if(value % 1 == 0)
            {
                return value * 1.0m;
            }

            return value / 1.000000000000000000000000000000000m;
        }
    }
}