namespace TWord
{
    internal class NtWord : INtWord
    {
        private readonly INumberTransformer _numberTransformer;

        public NtWord(Language language)
        {
            _numberTransformer = NumberTransformerSelector.Select(language);           
        }

        public string ToWords(long number)
        {
            return _numberTransformer.ToWords(number);
        }
    }
}