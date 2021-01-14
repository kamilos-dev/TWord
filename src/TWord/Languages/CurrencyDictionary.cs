using System;
using System.Collections.Generic;
using System.Linq;

namespace TWord
{
    ///<inheritdoc/>
    internal abstract class CurrencyDictionary : ICurrencyDictionary
    {
        protected abstract IEnumerable<Currency> _currencies { get; }

        ///<inheritdoc/>
        public Currency GetCurrency(CurrencySymbol symbol)
        {
            return _currencies.SingleOrDefault(c => c.Symbol == symbol)
                ?? throw new InvalidOperationException($"There is no {symbol} currency in {this.GetType()}.");
        }
    }
}