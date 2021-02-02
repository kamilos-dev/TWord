namespace TWord
{
    /// <summary>
    /// Factory to get INumberTransformerFactory or default builder
    /// </summary>
    internal interface INumberTransformerFactory
    {
        /// <summary>
        /// Creates INumberTransformer instance
        /// </summary>
        INumberTransformer Create();

        /// <summary>
        /// Returns default NumberTransformerBuilder builder
        /// </summary>
        NumberTransformerBuilder GetDefaultBuilder();
    }
}