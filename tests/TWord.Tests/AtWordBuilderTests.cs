using Xunit;

namespace TWord.Tests
{
    public class AtWordBuilderTests
    {
        private AtWordBuilder _builder;

        public AtWordBuilderTests()
        {
            _builder = new AtWordBuilder();
        }

        [Fact]
        public void SetLanguageTest()
        {
            var at = _builder
                .SetLanguage(Language.English)
                .SetCurrency(CurrencySymbol.USD)
                .Build();

            Assert.Equal("one dollar zero cents", at.ToWords(1));
        }

        [Fact]
        public void SetCurrencyTest()
        {
            var at = _builder
                .SetLanguage(Language.Polish)
                .SetCurrency(CurrencySymbol.EUR)
                .Build();

            Assert.Equal("jeden euro zero centów", at.ToWords(1));
        }

        [Fact]
        public void IntegerPartOnlyTest()
        {
            var at = _builder
                .SetLanguage(Language.German)
                .SetCurrency(CurrencySymbol.EUR)
                .IntegerPartOnly()
                .Build();

            Assert.Equal("ein Euro", at.ToWords(1));
        }

        [Fact]
        public void DecimalPartAsFractionTest()
        {
            var at = _builder
                .SetLanguage(Language.English)
                .SetCurrency(CurrencySymbol.PLN)
                .DecimalPartAsFraction()
                .Build();

            Assert.Equal("one zloty 0/100 groszy", at.ToWords(1));
        }

        [Fact]
        public void HideSubunitTest()
        {
            var at = _builder
                .SetLanguage(Language.English)
                .SetCurrency(CurrencySymbol.EUR)
                .HideSubunit()
                .Build();

            Assert.Equal("one euro zero", at.ToWords(1));
        }

        [Fact]
        public void IntegerAndDecimalPartSeparatorTest()
        {
            var at = _builder
                .SetLanguage(Language.English)
                .SetCurrency(CurrencySymbol.EUR)
                .IntegerAndDecimalPartSeparator(", decimal part: ")
                .Build();

            Assert.Equal("one euro, decimal part: zero cents", at.ToWords(1));
        }
    }
}