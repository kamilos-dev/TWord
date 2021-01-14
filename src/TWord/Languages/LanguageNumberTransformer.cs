namespace TWord
{
    ///<inheritdoc/>
    internal abstract class LanguageNumberTransformer : INumberTransformer
    {
        protected abstract INumberTransformer GetNumberTransformer();

        ///<inheritdoc/>
        public string ToWords(long number)
        {
            return GetNumberTransformer().ToWords(number);
        }
    }
}