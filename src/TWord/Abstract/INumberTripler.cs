namespace TWord
{
    /// <summary>
    /// Triplet transformer
    /// </summary>
    internal interface ITripletTransformer
    {
        /// <summary>
        /// Transform given triplet to words
        /// </summary>
        /// <param name="triplet">Three-digits number (triplet)</param>
        /// <param name="tripletIndex">Index of triplet</param>
        /// <param name="numberSeparator">Number separator</param>
        /// <returns>Words</returns>
        string ToWords(Triplet triplet, int? tripletIndex = null, string numberSeparator = null);
    }
}