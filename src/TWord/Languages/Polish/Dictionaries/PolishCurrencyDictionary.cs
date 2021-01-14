using System.Collections.Generic;

namespace TWord
{
    internal class PolishCurrencyDictionary : CurrencyDictionary
    {
        protected override IEnumerable<Currency> _currencies => new List<Currency>
        {
            Currency.Create(CurrencySymbol.PLN,
                Noun.Create("złoty", "złote", "złotych"),
                Noun.Create("grosz", "grosze", "groszy")),

            Currency.Create(CurrencySymbol.USD,
                Noun.Create("dolar", "dolary", "dolarów"),
                Noun.Create("cent", "centy", "centów")),

            Currency.Create(CurrencySymbol.EUR,
                Noun.Create("euro", "euro", "euro"),
                Noun.Create("cent", "centy", "centów"))
        };
    }
}