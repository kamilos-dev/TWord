namespace TWord
{
    internal struct Triplet
    {
        public int Units { get; private set; }

        public int Tens { get; private set; }

        public int Hundreds { get; private set; }

        internal Triplet(int triplet)
        {
            if (triplet > 999)
            {
                throw new System.Exception($"Invalid value given to Triplet argument. " +
                   $"Given value '{triplet}' while it should be triplet. Max value is 999.");
            }

            var units = triplet.GetUnits();
            var tens = triplet.GetTens();
            var hundreds = triplet.GetHundreds();

            Units = units;
            Tens = tens;
            Hundreds = hundreds;
        }

        internal int ToInt()
        {
            return
                Hundreds * 100 +
                Tens * 10 +
                Units;
        }
    }
}