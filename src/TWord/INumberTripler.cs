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
        /// <returns>Words</returns>
        string ToWords(Triplet triplet);
    }
}