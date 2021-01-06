using Xunit;

namespace TWord.Tests.NtWord.Polish
{
    public class PolishAtWordTests
    {
        private readonly AtWordBuilder _builder;

        public PolishAtWordTests()
        {
            _builder = new AtWordBuilder()
                .SetLanguage(Language.Polish)
                .SetCurrency(CurrencySymbol.PLN);
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            var atWord = _builder.Build();

            Assert.Equal("zero złotych zero groszy", atWord.ToWord(0));
            Assert.Equal("jeden złoty zero groszy", atWord.ToWord(1));
            Assert.Equal("dwa złote zero groszy", atWord.ToWord(2));
            Assert.Equal("trzy złote zero groszy", atWord.ToWord(3));
            Assert.Equal("cztery złote zero groszy", atWord.ToWord(4));
            Assert.Equal("pięć złotych zero groszy", atWord.ToWord(5));
            Assert.Equal("sześć złotych zero groszy", atWord.ToWord(6));
            Assert.Equal("siedem złotych zero groszy", atWord.ToWord(7));
            Assert.Equal("osiem złotych zero groszy", atWord.ToWord(8));
            Assert.Equal("dziewięć złotych zero groszy", atWord.ToWord(9));
        }

        [Fact]
        public void ZeroToNineNumbers_DecimalPartAsFraction()
        {
            var atWord = _builder
                .DecimalPartAsFraction()
                .Build();

            Assert.Equal("zero złotych 0/100 groszy", atWord.ToWord(0));
            Assert.Equal("jeden złoty 0/100 groszy", atWord.ToWord(1.001m));
            Assert.Equal("dwa złote 1/100 grosz", atWord.ToWord(2.005m));
            Assert.Equal("trzy złote 1/100 grosz", atWord.ToWord(3.01m));
            Assert.Equal("cztery złote 2/100 grosze", atWord.ToWord(4.02m));
            Assert.Equal("pięć złotych 5/100 groszy", atWord.ToWord(5.05m));
            Assert.Equal("sześć złotych 10/100 groszy", atWord.ToWord(6.1m));
            Assert.Equal("siedem złotych 20/100 groszy", atWord.ToWord(7.20m));
            Assert.Equal("osiem złotych 55/100 groszy", atWord.ToWord(8.55m));
            Assert.Equal("dziewięć złotych 0/100 groszy", atWord.ToWord(9));
        }

        [Fact]
        public void ZeroToNineNumbers_IntegerPartOnly()
        {
            var atWord = _builder
                .IntegerPartOnly()
                .Build();

            Assert.Equal("zero złotych", atWord.ToWord(0));
            Assert.Equal("jeden złoty", atWord.ToWord(1.001m));
            Assert.Equal("dwa złote", atWord.ToWord(2.005m));
            Assert.Equal("trzy złote", atWord.ToWord(3.01m));
            Assert.Equal("cztery złote", atWord.ToWord(4.02m));
            Assert.Equal("pięć złotych", atWord.ToWord(5.05m));
            Assert.Equal("sześć złotych", atWord.ToWord(6.1m));
            Assert.Equal("siedem złotych", atWord.ToWord(7.20m));
            Assert.Equal("osiem złotych", atWord.ToWord(8.55m));
            Assert.Equal("dziewięć złotych", atWord.ToWord(9));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            var atWord = _builder.Build();

            Assert.Equal("jeden tysiąc złotych zero groszy", atWord.ToWord(1000));
            Assert.Equal("jeden tysiąc jeden złotych zero groszy", atWord.ToWord(1001));
            Assert.Equal("jeden tysiąc jedenaście złotych zero groszy", atWord.ToWord(1011));
            Assert.Equal("jeden tysiąc dwadzieścia pięć złotych zero groszy", atWord.ToWord(1025));
            Assert.Equal("jeden tysiąc czterysta dwadzieścia pięć złotych zero groszy", atWord.ToWord(1425));

            Assert.Equal("dwa tysiące złotych zero groszy", atWord.ToWord(2000));
            Assert.Equal("dwa tysiące trzydzieści złotych zero groszy", atWord.ToWord(2030));
            Assert.Equal("dwa tysiące siedemdziesiąt sześć złotych zero groszy", atWord.ToWord(2076));
            Assert.Equal("dwa tysiące dziewięćdziesiąt dziewięć złotych zero groszy", atWord.ToWord(2099));
            Assert.Equal("dwa tysiące pięćset dziewięćdziesiąt dziewięć złotych zero groszy", atWord.ToWord(2599));

            Assert.Equal("trzy tysiące złotych zero groszy", atWord.ToWord(3000));
            Assert.Equal("trzy tysiące trzydzieści dwa złote zero groszy", atWord.ToWord(3032));
            Assert.Equal("trzy tysiące sześćdziesiąt siedem złotych zero groszy", atWord.ToWord(3067));
            Assert.Equal("trzy tysiące osiemdziesiąt złotych zero groszy", atWord.ToWord(3080));
            Assert.Equal("trzy tysiące sto osiemdziesiąt złotych zero groszy", atWord.ToWord(3180));

            Assert.Equal("cztery tysiące złotych zero groszy", atWord.ToWord(4000));
            Assert.Equal("cztery tysiące dwadzieścia trzy złote zero groszy", atWord.ToWord(4023));
            Assert.Equal("cztery tysiące pięćdziesiąt sześć złotych zero groszy", atWord.ToWord(4056));
            Assert.Equal("cztery tysiące siedemdziesiąt złotych zero groszy", atWord.ToWord(4070));
            Assert.Equal("cztery tysiące dziewięćset siedemdziesiąt złotych zero groszy", atWord.ToWord(4970));

            Assert.Equal("pięć tysięcy złotych zero groszy", atWord.ToWord(5000));
            Assert.Equal("pięć tysięcy jeden złotych zero groszy", atWord.ToWord(5001));
            Assert.Equal("pięć tysięcy dziesięć złotych zero groszy", atWord.ToWord(5010));
            Assert.Equal("pięć tysięcy dziewięćdziesiąt złotych zero groszy", atWord.ToWord(5090));
            Assert.Equal("pięć tysięcy sto dziewięćdziesiąt złotych zero groszy", atWord.ToWord(5190));
        }


    }
}