namespace TWord
{
    internal record Noun
    {
        /// <summary>
        /// Empty noun
        /// </summary>
        public static Noun Empty => null;

        /// <summary>
        /// Singular
        /// </summary>
        public string Singular { get; private set; }

        /// <summary>
        /// Plural
        /// </summary>
        public string Plural { get; private set; }

        /// <summary>
        /// Genitive plural
        /// </summary>
        public string GenitivePlural { get; private set; }

        internal Noun(string singular, string plural, string genitivePlural)
            => (Singular, Plural, GenitivePlural)
            = (singular, plural, genitivePlural);

        internal static Noun Create(string singular)
            => new Noun(singular, singular, singular);

        internal static Noun Create(string singular, string plural)
            => new Noun(singular, plural, plural);

        internal static Noun Create(string singular, string plural, string genitivePlural)
            => new Noun(singular, plural, genitivePlural);
    }
}