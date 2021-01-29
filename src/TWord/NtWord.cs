namespace TWord
{
    internal class NtWord : INtWord
    {
        private readonly INumberTransformer _numberTransformer;

        ///<inheritdoc/>
        public NtWord(Language language)
        {
            _numberTransformer = NumberTransformerFactory.Create(language);
        }

        ///<inheritdoc/>
        public string ToWords(long number)
        {
            return _numberTransformer.ToWords(number);
        }
    }
}