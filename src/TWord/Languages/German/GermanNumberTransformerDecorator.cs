namespace TWord.Languages.German
{
    internal class GermanNumberTransformerDecorator
    {
        private readonly INumberTransformer _numberTransformer;

        internal GermanNumberTransformerDecorator(INumberTransformer numberTransformer)
        {
            _numberTransformer = numberTransformer;
        }
    }
}