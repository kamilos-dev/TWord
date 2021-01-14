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
            Assert.Equal("zero złotych zero groszy", _at.ToWord(0));
            Assert.Equal("jeden złoty zero groszy", _at.ToWord(1));
            Assert.Equal("dwa złote zero groszy", _at.ToWord(2));
            Assert.Equal("trzy złote zero groszy", _at.ToWord(3));
            Assert.Equal("cztery złote zero groszy", _at.ToWord(4));
            Assert.Equal("pięć złotych zero groszy", _at.ToWord(5));
            Assert.Equal("sześć złotych zero groszy", _at.ToWord(6));
            Assert.Equal("siedem złotych zero groszy", _at.ToWord(7));
            Assert.Equal("osiem złotych zero groszy", _at.ToWord(8));
            Assert.Equal("dziewięć złotych zero groszy", _at.ToWord(9));
        }

        [Fact]
        public void TenToTwelveNumbers()
        {
            Assert.Equal("dziesięć złotych zero groszy", _at.ToWord(10));
            Assert.Equal("jedenaście złotych zero groszy", _at.ToWord(11));
            Assert.Equal("dwanaście złotych zero groszy", _at.ToWord(12));
            Assert.Equal("trzynaście złotych zero groszy", _at.ToWord(13));
            Assert.Equal("czternaście złotych zero groszy", _at.ToWord(14));
            Assert.Equal("piętnaście złotych zero groszy", _at.ToWord(15));
            Assert.Equal("szesnaście złotych zero groszy", _at.ToWord(16));
            Assert.Equal("siedemnaście złotych zero groszy", _at.ToWord(17));
            Assert.Equal("osiemnaście złotych zero groszy", _at.ToWord(18));
            Assert.Equal("dziewietnaście złotych zero groszy", _at.ToWord(19));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("jeden tysiąc złotych zero groszy", _at.ToWord(1000));
            Assert.Equal("jeden tysiąc jeden złotych zero groszy", _at.ToWord(1001));
            Assert.Equal("jeden tysiąc jedenaście złotych zero groszy", _at.ToWord(1011));
            Assert.Equal("jeden tysiąc dwadzieścia pięć złotych zero groszy", _at.ToWord(1025));
            Assert.Equal("jeden tysiąc czterysta dwadzieścia pięć złotych zero groszy", _at.ToWord(1425));

            Assert.Equal("dwa tysiące złotych zero groszy", _at.ToWord(2000));
            Assert.Equal("dwa tysiące trzydzieści złotych zero groszy", _at.ToWord(2030));
            Assert.Equal("dwa tysiące siedemdziesiąt sześć złotych zero groszy", _at.ToWord(2076));
            Assert.Equal("dwa tysiące dziewięćdziesiąt dziewięć złotych zero groszy", _at.ToWord(2099));
            Assert.Equal("dwa tysiące pięćset dziewięćdziesiąt dziewięć złotych zero groszy", _at.ToWord(2599));

            Assert.Equal("trzy tysiące złotych zero groszy", _at.ToWord(3000));
            Assert.Equal("trzy tysiące trzydzieści dwa złote zero groszy", _at.ToWord(3032));
            Assert.Equal("trzy tysiące sześćdziesiąt siedem złotych zero groszy", _at.ToWord(3067));
            Assert.Equal("trzy tysiące osiemdziesiąt złotych zero groszy", _at.ToWord(3080));
            Assert.Equal("trzy tysiące sto osiemdziesiąt złotych zero groszy", _at.ToWord(3180));

            Assert.Equal("cztery tysiące złotych zero groszy", _at.ToWord(4000));
            Assert.Equal("cztery tysiące dwadzieścia trzy złote zero groszy", _at.ToWord(4023));
            Assert.Equal("cztery tysiące pięćdziesiąt sześć złotych zero groszy", _at.ToWord(4056));
            Assert.Equal("cztery tysiące siedemdziesiąt złotych zero groszy", _at.ToWord(4070));
            Assert.Equal("cztery tysiące dziewięćset siedemdziesiąt złotych zero groszy", _at.ToWord(4970));

            Assert.Equal("pięć tysięcy złotych zero groszy", _at.ToWord(5000));
            Assert.Equal("pięć tysięcy jeden złotych zero groszy", _at.ToWord(5001));
            Assert.Equal("pięć tysięcy dziesięć złotych zero groszy", _at.ToWord(5010));
            Assert.Equal("pięć tysięcy dziewięćdziesiąt złotych zero groszy", _at.ToWord(5090));
            Assert.Equal("pięć tysięcy sto dziewięćdziesiąt złotych zero groszy", _at.ToWord(5190));
        }
    }
}