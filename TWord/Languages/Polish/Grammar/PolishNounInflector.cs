namespace TWord
{
    internal class PolishNounInflector : INounInflector
    {
        public string InflectNounByNumber(long number,
            string singular, string plural, string genitivePlural)
        {
            var units = number % 10;

            if (number == 1)
            {
                return singular;
            }

            if (units >= 2 && units <= 4)
            {
                return plural;
            }

            return genitivePlural;
        }
    }
}