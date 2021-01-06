namespace TWord
{
    internal class NtWord : INtWord
    {
        private INumberTransformer _numberTransformer;

        public NtWord(Language language)
        {
            _numberTransformer = NumberTransformerSelector.Select(language);
        }

        public string ToWords(int number)
        {
            return _numberTransformer.ToWords(number);
        }
    }
}