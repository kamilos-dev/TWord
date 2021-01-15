using Xunit;

namespace TWord.Tests.AtWord
{
    public class PolishAtWordTests
    {
        private readonly IAtWord _at;

        public PolishAtWordTests()
        {
            _at = new AtWordBuilder()
                .SetLanguage(Language.Polish)
                .SetCurrency(CurrencySymbol.PLN)
                .Build();
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            Assert.Equal("zero złotych zero groszy", _at.ToWords(0));
            Assert.Equal("jeden złoty zero groszy", _at.ToWords(1));
            Assert.Equal("dwa złote zero groszy", _at.ToWords(2));
            Assert.Equal("trzy złote zero groszy", _at.ToWords(3));
            Assert.Equal("cztery złote zero groszy", _at.ToWords(4));
            Assert.Equal("pięć złotych zero groszy", _at.ToWords(5));
            Assert.Equal("sześć złotych zero groszy", _at.ToWords(6));
            Assert.Equal("siedem złotych zero groszy", _at.ToWords(7));
            Assert.Equal("osiem złotych zero groszy", _at.ToWords(8));
            Assert.Equal("dziewięć złotych zero groszy", _at.ToWords(9));
        }

        [Fact]
        public void TenToTwelveNumbers()
        {
            Assert.Equal("dziesięć złotych zero groszy", _at.ToWords(10));
            Assert.Equal("jedenaście złotych zero groszy", _at.ToWords(11));
            Assert.Equal("dwanaście złotych zero groszy", _at.ToWords(12));
            Assert.Equal("trzynaście złotych zero groszy", _at.ToWords(13));
            Assert.Equal("czternaście złotych zero groszy", _at.ToWords(14));
            Assert.Equal("piętnaście złotych zero groszy", _at.ToWords(15));
            Assert.Equal("szesnaście złotych zero groszy", _at.ToWords(16));
            Assert.Equal("siedemnaście złotych zero groszy", _at.ToWords(17));
            Assert.Equal("osiemnaście złotych zero groszy", _at.ToWords(18));
            Assert.Equal("dziewietnaście złotych zero groszy", _at.ToWords(19));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("jeden tysiąc złotych zero groszy", _at.ToWords(1000));
            Assert.Equal("jeden tysiąc jeden złotych zero groszy", _at.ToWords(1001));
            Assert.Equal("jeden tysiąc jedenaście złotych zero groszy", _at.ToWords(1011));
            Assert.Equal("jeden tysiąc dwadzieścia pięć złotych zero groszy", _at.ToWords(1025));
            Assert.Equal("jeden tysiąc czterysta dwadzieścia pięć złotych zero groszy", _at.ToWords(1425));

            Assert.Equal("dwa tysiące złotych zero groszy", _at.ToWords(2000));
            Assert.Equal("dwa tysiące trzydzieści złotych zero groszy", _at.ToWords(2030));
            Assert.Equal("dwa tysiące siedemdziesiąt sześć złotych zero groszy", _at.ToWords(2076));
            Assert.Equal("dwa tysiące dziewięćdziesiąt dziewięć złotych zero groszy", _at.ToWords(2099));
            Assert.Equal("dwa tysiące pięćset dziewięćdziesiąt dziewięć złotych zero groszy", _at.ToWords(2599));

            Assert.Equal("trzy tysiące złotych zero groszy", _at.ToWords(3000));
            Assert.Equal("trzy tysiące trzydzieści dwa złote zero groszy", _at.ToWords(3032));
            Assert.Equal("trzy tysiące sześćdziesiąt siedem złotych zero groszy", _at.ToWords(3067));
            Assert.Equal("trzy tysiące osiemdziesiąt złotych zero groszy", _at.ToWords(3080));
            Assert.Equal("trzy tysiące sto osiemdziesiąt złotych zero groszy", _at.ToWords(3180));

            Assert.Equal("cztery tysiące złotych zero groszy", _at.ToWords(4000));
            Assert.Equal("cztery tysiące dwadzieścia trzy złote zero groszy", _at.ToWords(4023));
            Assert.Equal("cztery tysiące pięćdziesiąt sześć złotych zero groszy", _at.ToWords(4056));
            Assert.Equal("cztery tysiące siedemdziesiąt złotych zero groszy", _at.ToWords(4070));
            Assert.Equal("cztery tysiące dziewięćset siedemdziesiąt złotych zero groszy", _at.ToWords(4970));

            Assert.Equal("pięć tysięcy złotych zero groszy", _at.ToWords(5000));
            Assert.Equal("pięć tysięcy jeden złotych zero groszy", _at.ToWords(5001));
            Assert.Equal("pięć tysięcy dziesięć złotych zero groszy", _at.ToWords(5010));
            Assert.Equal("pięć tysięcy dziewięćdziesiąt złotych zero groszy", _at.ToWords(5090));
            Assert.Equal("pięć tysięcy sto dziewięćdziesiąt złotych zero groszy", _at.ToWords(5190));
        }
    }
}