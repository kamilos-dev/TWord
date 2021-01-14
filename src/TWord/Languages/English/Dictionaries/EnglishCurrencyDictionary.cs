using System.Collections.Generic;

namespace TWord
{
    internal class EnglishCurrencyDictionary : CurrencyDictionary
    {
        protected override IEnumerable<Currency> _currencies => new List<Currency>
        {
            Currency.Create(CurrencySymbol.PLN,
                Noun.Create("zloty", "zlote", "zlotych"),
                Noun.Create("grosz", "grosze", "groszy")),

            Currency.Create(CurrencySymbol.USD,
                Noun.Create("dollar", "dollars"),
                Noun.Create("cent", "cents")),

            Currency.Create(CurrencySymbol.EUR,
                Noun.Create("euro", "euros"),
                Noun.Create("cent", "cents"))
        };
    }
}