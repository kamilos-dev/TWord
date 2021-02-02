namespace TWord
{
    internal class PolishNounInflector : INounInflector
    {
        public string InflectNounByNumber(long number, Noun noun)
        {
            return InflectNounByNumber(number, 0, noun);
        }

        public string InflectNounByNumber(long number, int tripletIndex, Noun noun)
        {
            var units = number.GetUnits();
            var tens = number.GetTens();

            if (number == 1)
            {
                return noun.Singular;
            }

            if (tens != 1 &&
                units >= 2 && units <= 4)
            {
                return noun.Plural;
            }

            return noun.GenitivePlural;
        }
    }
}