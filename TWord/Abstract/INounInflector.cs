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
        /// <param name="singular">Singular noun</param>
        /// <param name="plural">Plural noun</param>
        /// <param name="genitivePlural">Genitive plural noun</param>
        /// <returns>Noun</returns>
        public string InflectNounByNumber(long number,
            string singular, string plural, string genitivePlural);
    }
}