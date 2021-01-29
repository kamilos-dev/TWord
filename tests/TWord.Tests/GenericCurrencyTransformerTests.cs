using Xunit;

namespace TWord.Tests
{
    internal static class GenericNumberTransformer
    {
        public static INumberTransformer GetNumberTransformer()
        {
            return new NumberTransformerBuilder()
                .SetNumbersDictionary(new EnglishNumbersDictionary())
                .SetLargeNumberNamesDictionary(new EnglishLargeNumberNamesDictionary())
                .SetTriplerTransformer(new GenericTripletTransformer(new EnglishNumbersDictionary()))
                .Build();
        }
    }

    public class GenericCurrencyTransformerTests
    {
        private readonly CurrencySymbol _currency;
        private readonly ICurrencyTransformer _transformer;

        public GenericCurrencyTransformerTests()
        {
            _currency = CurrencySymbol.USD;

            _transformer = new GenericCurrencyTransformer(
                GenericNumberTransformer.GetNumberTransformer(),
                new EnglishCurrencyDictionary(),
                new EnglishNounInflector());
        }

        [Fact]
        public void GenericCurrencyTransformer()
        {
            var options = new CurrencyOptions();

            Assert.Equal("one hundred dollars zero cents", _transformer.ToWords(100, _currency, options));
            Assert.Equal("one hundred dollars one cent", _transformer.ToWords(100.01m, _currency, options));
            Assert.Equal("one hundred dollars ten cents", _transformer.ToWords(100.1m, _currency, options));
            Assert.Equal("one hundred dollars fifty seven cents", _transformer.ToWords(100.57m, _currency, options));
        }

        [Fact]
        public void GenericCurrencyTransformer_DecimalAsFraction()
        {
            var options = new CurrencyOptions
            {
                DecimalAsFraction = true
            };

            Assert.Equal("one hundred dollars 0/100 cents", _transformer.ToWords(100, _currency, options));
            Assert.Equal("one hundred dollars 1/100 cent", _transformer.ToWords(100.01m, _currency, options));
            Assert.Equal("one hundred dollars 10/100 cents", _transformer.ToWords(100.1m, _currency, options));
            Assert.Equal("one hundred dollars 57/100 cents", _transformer.ToWords(100.57m, _currency, options));
        }

        [Fact]
        public void GenericCurrencyTransformer_DecimalAsFraction_HideSubunit()
        {
            var options = new CurrencyOptions
            {
                DecimalAsFraction = true,
                HideSubunit = true
            };

            Assert.Equal("one hundred dollars 0/100", _transformer.ToWords(100, _currency, options));
            Assert.Equal("one hundred dollars 1/100", _transformer.ToWords(100.01m, _currency, options));
            Assert.Equal("one hundred dollars 10/100", _transformer.ToWords(100.1m, _currency, options));
            Assert.Equal("one hundred dollars 57/100", _transformer.ToWords(100.57m, _currency, options));
        }

        [Fact]
        public void GenericCurrencyTransformer_IntegerPartOnly()
        {
            var options = new CurrencyOptions
            {
                IntegerPartOnly = true
            };

            Assert.Equal("one hundred dollars", _transformer.ToWords(100, _currency, options));
            Assert.Equal("one hundred dollars", _transformer.ToWords(100.01m, _currency, options));
            Assert.Equal("one hundred dollars", _transformer.ToWords(100.1m, _currency, options));
            Assert.Equal("one hundred dollars", _transformer.ToWords(100.57m, _currency, options));
        }

        [Fact]
        public void GenericCurrencyTransformer_IntegerAndDecimalPartSeparator()
        {
            var options = new CurrencyOptions
            {
                IntegerAndDecimalPartSeparator = " and "
            };

            Assert.Equal("one hundred dollars and zero cents", _transformer.ToWords(100, _currency, options));
            Assert.Equal("one hundred dollars and one cent", _transformer.ToWords(100.01m, _currency, options));
            Assert.Equal("one hundred dollars and ten cents", _transformer.ToWords(100.1m, _currency, options));
            Assert.Equal("one hundred dollars and fifty seven cents", _transformer.ToWords(100.57m, _currency, options));
        }
    }
}