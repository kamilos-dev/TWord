namespace TWord
{
    /// <summary>
    /// Factory to get ICurrencyTransformer or default builder
    /// </summary>
    internal interface ICurrencyTransformerFactory
    {
        /// <summary>
        /// Creates ICurrencyTransformer instance
        /// </summary>
        ICurrencyTransformer Create();

        /// <summary>
        /// Returns default CurrencyTransformer builder
        /// </summary>
        CurrencyTransformerBuilder GetDefaultBuilder();
    }
}