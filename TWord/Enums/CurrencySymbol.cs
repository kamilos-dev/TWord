namespace TWord
{
    /// <summary>
    /// ISO 4217 standard
    /// </summary>
    public enum CurrencySymbol
    {
        [CurrencyData(numberToBase: 100)]
        EUR,

        [CurrencyData(numberToBase: 100)]
        PLN,

        [CurrencyData(numberToBase: 100)]
        USD        
    }
}