namespace TWord
{
    internal record Noun
    {
        public static Noun Empty => null;

        public string Singular { get; private set; }

        public string Plural { get; private set; }

        public string GenitivePlural { get; private set; }

        internal Noun(string singular, string plural, string genitivePlural)
            => (Singular, Plural, GenitivePlural)
            = (singular, plural, genitivePlural);

        internal static Noun Create(string singular, string plural, string genitivePlural)
            => new Noun(singular, plural, genitivePlural);
    }
}