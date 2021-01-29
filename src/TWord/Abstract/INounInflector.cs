namespace TWord
{
    /// <summary>
    /// Inflect nouns
    /// </summary>
    internal interface INounInflector
    {
        /// <summary>
        /// Returns noun inflected by number
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="noun">Noun</param>
        /// <returns>Noun</returns>
        public string InflectNounByNumber(long number, Noun noun);

        /// <summary>
        /// Returns noun inflected by number and triplet index
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="tripletIndex">Triplet index</param>
        /// <param name="noun">Noun</param>
        /// <returns>Noun</returns>
        public string InflectNounByNumber(long number, int tripletIndex, Noun noun);
    }
}