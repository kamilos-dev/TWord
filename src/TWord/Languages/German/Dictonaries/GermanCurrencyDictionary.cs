using System.Collections.Generic;

namespace TWord
{
    internal class GermanCurrencyDictionary : CurrencyDictionary
    {
        protected override IEnumerable<Currency> _currencies => new List<Currency>
        {
            Currency.Create(CurrencySymbol.PLN,
                Noun.Create("Zloty"),
                Noun.Create("Grosz")),

            Currency.Create(CurrencySymbol.USD,
                Noun.Create("Dollar"),
                Noun.Create("Cent")),

            Currency.Create(CurrencySymbol.EUR,
                Noun.Create("Euro"),
                Noun.Create("Cent"))
        };
    }
}