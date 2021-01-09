using System;
using System.Globalization;

namespace TWord
{
    internal static class DecimalConventer
    {
        /// <summary>
        /// Convert given decimal fractial part to Int64
        /// </summary>
        /// <param name="value">Decimal</param>
        /// <returns>Int64 value</returns>
        public static long ConvertDecimalPartToLong(decimal value)
        {
            string fractialPartStr = value
                .ToString("0.00", CultureInfo.InvariantCulture)
                .Split(".")[1];

            return Convert.ToInt64(fractialPartStr);
        }
    }
}