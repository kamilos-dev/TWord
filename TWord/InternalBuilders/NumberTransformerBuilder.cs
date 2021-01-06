namespace TWord
{
    internal class NumberTransformerBuilder
    {
        private ILanguageNumbersDictionary _numbersDictionary;
        private string _separator;

        private ITriplerTransformer _triplerTransformer;
        private ILargeNumberNamesDictionary _namesDictionary;

        private INounInflector _nounInflector;

        public NumberTransformerBuilder SetNumbersDictionary(
            ILanguageNumbersDictionary numbersDictionary)
        {
            _numbersDictionary = numbersDictionary;

            return this;
        }

        public NumberTransformerBuilder SetLargeNumberNamesDictionary(
            ILargeNumberNamesDictionary namesDictionary)
        {
            _namesDictionary = namesDictionary;

            return this;
        }

        public NumberTransformerBuilder WordsSeparatedBy(string separator)
        {
            _separator = separator;

            return this;
        }

        public NumberTransformerBuilder TransformNumberWithTriplets(
            ITriplerTransformer triplerTransformer)
        {
            _triplerTransformer = triplerTransformer;

            return this;
        }

        public NumberTransformerBuilder InflectNounsBy(
            INounInflector nounInflector)
        {
            _nounInflector = nounInflector;

            return this;
        }

        public INumberTransformer Build()
        {
            return new GenericNumberTransformer(_numbersDictionary, _triplerTransformer, _namesDictionary,
                _nounInflector, _separator);
        }
    }
}