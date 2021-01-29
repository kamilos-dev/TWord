namespace TWord
{
    internal struct Triplet
    {
        public int Units { get; private set; }

        public int Tens { get; private set; }

        public int Hundreds { get; private set; }

        public int Value => Hundreds* 100 + Tens* 10 + Units;

        public static Triplet Empty => new Triplet(0);

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

        public override bool Equals(object obj)
        {
            if (!(obj is Triplet))
                return false;

            var triplet = (Triplet)obj;

            return (triplet.Units == this.Units
                && triplet.Tens == this.Tens
                && triplet.Hundreds == this.Hundreds);
        }

        public static bool operator ==(Triplet o1, Triplet o2)
        {
            return o1.Equals(o2);
        }

        public static bool operator !=(Triplet o1, Triplet o2)
        {
            return !o1.Equals(o2);
        }
    }
}