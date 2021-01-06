namespace TWord
{
    internal abstract class LanguageNumberTransformer : INumberTransformer
    {
        protected abstract INumberTransformer GetNumberTransformer();

        public string ToWords(long number)
        {
            return GetNumberTransformer().ToWords(number);
        }
    }
}