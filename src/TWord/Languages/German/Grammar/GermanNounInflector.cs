namespace TWord
{
    internal class GermanNounInflector : INounInflector
    {
        public string InflectNounByNumber(long number, Noun noun)
        {
            return InflectNounByNumber(number, 0, noun);
        }

        public string InflectNounByNumber(long number, int tripletIndex, Noun noun)
        {
            var word = noun.Singular;

            if (number > 1)
            {
                word = noun.Plural;
            }

            if (tripletIndex > 1)
            {
                word = $" {word}";
            }

            return word;
        }
    }
}