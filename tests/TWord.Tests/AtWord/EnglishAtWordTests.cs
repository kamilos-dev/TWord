using Xunit;

namespace TWord.Tests.AtWord
{
    public class English_atTests
    {
        private readonly IAtWord _at;

        public English_atTests()
        {
            _at = new AtWordBuilder()
                .SetLanguage(Language.English)
                .SetCurrency(CurrencySymbol.USD)
                .Build();
        }

        [Fact]
        public void DecimalNumbers()
        {
            Assert.Equal("zero dollars zero cents", _at.ToWord(0.0m));
            Assert.Equal("zero dollars zero cents", _at.ToWord(0.00m));
            Assert.Equal("zero dollars zero cents", _at.ToWord(0.001m));
            Assert.Equal("zero dollars zero cents", _at.ToWord(0.004m));

            Assert.Equal("zero dollars one cent", _at.ToWord(0.005m));
            Assert.Equal("zero dollars one cent", _at.ToWord(0.01m));
            Assert.Equal("zero dollars one cent", _at.ToWord(0.0140999m));
            Assert.Equal("zero dollars one cent", _at.ToWord(0.0146999m));

            Assert.Equal("zero dollars two cents", _at.ToWord(0.0156999m));
            Assert.Equal("zero dollars two cents", _at.ToWord(0.02m));

            Assert.Equal("zero dollars five cents", _at.ToWord(0.05m));
            Assert.Equal("zero dollars five cents", _at.ToWord(0.054m));

            Assert.Equal("zero dollars ten cents", _at.ToWord(0.099m));
            Assert.Equal("zero dollars ten cents", _at.ToWord(0.1m));

            Assert.Equal("zero dollars thirty one cents", _at.ToWord(0.305m));

            Assert.Equal("zero dollars ninety nine cents", _at.ToWord(0.99m));
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            Assert.Equal("zero dollars zero cents", _at.ToWord(0));
            Assert.Equal("one dollar zero cents", _at.ToWord(1));
            Assert.Equal("two dollars zero cents", _at.ToWord(2));
            Assert.Equal("three dollars zero cents", _at.ToWord(3));
            Assert.Equal("four dollars zero cents", _at.ToWord(4));
            Assert.Equal("five dollars zero cents", _at.ToWord(5));
            Assert.Equal("six dollars zero cents", _at.ToWord(6));
            Assert.Equal("seven dollars zero cents", _at.ToWord(7));
            Assert.Equal("eight dollars zero cents", _at.ToWord(8));
            Assert.Equal("nine dollars zero cents", _at.ToWord(9));
        }

        [Fact]
        public void TenToTwelveNumbers()
        {
            Assert.Equal("ten dollars zero cents", _at.ToWord(10));
            Assert.Equal("eleven dollars zero cents", _at.ToWord(11));
            Assert.Equal("twelve dollars zero cents", _at.ToWord(12));
            Assert.Equal("thirteen dollars zero cents", _at.ToWord(13));
            Assert.Equal("fourteen dollars zero cents", _at.ToWord(14));
            Assert.Equal("fifteen dollars zero cents", _at.ToWord(15));
            Assert.Equal("sixteen dollars zero cents", _at.ToWord(16));
            Assert.Equal("seventeen dollars zero cents", _at.ToWord(17));
            Assert.Equal("eighteen dollars zero cents", _at.ToWord(18));
            Assert.Equal("nineteen dollars zero cents", _at.ToWord(19));
            Assert.Equal("twenty dollars zero cents", _at.ToWord(20));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("one thousand dollars zero cents", _at.ToWord(1000));
            Assert.Equal("one thousand one dollars zero cents", _at.ToWord(1001));
            Assert.Equal("one thousand eleven dollars zero cents", _at.ToWord(1011));
            Assert.Equal("one thousand twenty five dollars zero cents", _at.ToWord(1025));
            Assert.Equal("one thousand four hundred twenty five dollars zero cents", _at.ToWord(1425));

            Assert.Equal("two thousand dollars zero cents", _at.ToWord(2000));
            Assert.Equal("two thousand thirty dollars zero cents", _at.ToWord(2030));
            Assert.Equal("two thousand seventy six dollars zero cents", _at.ToWord(2076));
            Assert.Equal("two thousand ninety nine dollars zero cents", _at.ToWord(2099));
            Assert.Equal("two thousand five hundred ninety nine dollars zero cents", _at.ToWord(2599));

            Assert.Equal("three thousand dollars zero cents", _at.ToWord(3000));
            Assert.Equal("three thousand thirty two dollars zero cents", _at.ToWord(3032));
            Assert.Equal("three thousand sixty seven dollars zero cents", _at.ToWord(3067));
            Assert.Equal("three thousand eighty dollars zero cents", _at.ToWord(3080));
            Assert.Equal("three thousand one hundred eighty dollars zero cents", _at.ToWord(3180));

            Assert.Equal("four thousand dollars zero cents", _at.ToWord(4000));
            Assert.Equal("four thousand twenty three dollars zero cents", _at.ToWord(4023));
            Assert.Equal("four thousand fifty six dollars zero cents", _at.ToWord(4056));
            Assert.Equal("four thousand seventy dollars zero cents", _at.ToWord(4070));
            Assert.Equal("four thousand nine hundred seventy dollars zero cents", _at.ToWord(4970));

            Assert.Equal("five thousand dollars zero cents", _at.ToWord(5000));
            Assert.Equal("five thousand one dollars zero cents", _at.ToWord(5001));
            Assert.Equal("five thousand ten dollars zero cents", _at.ToWord(5010));
            Assert.Equal("five thousand ninety dollars zero cents", _at.ToWord(5090));
            Assert.Equal("five thousand one hundred ninety dollars zero cents", _at.ToWord(5190));
        }
    }
}