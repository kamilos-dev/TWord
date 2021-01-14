namespace TWord
{
    internal class PolishNounInflector : INounInflector
    {
        public string InflectNounByNumber(long number,
            string singular, string plural, string genitivePlural)
        {
            var units = number.GetUnits();
            var tens = number.GetTens();

            if (number == 1)
            {
                return singular;
            }

            if (tens != 1 &&
                units >= 2 && units <= 4)
            {
                return plural;
            }

            return genitivePlural;
        }
    }
}