using Xunit;

namespace TWord.Tests.NtWord
{
    public class PolishNtWordTests
    {
        private readonly INtWord _ntWord;

        public PolishNtWordTests()
        {
            _ntWord = new NtWordBuilder()
                .SetLanguage(Language.Polish)
                .Build();
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            Assert.Equal("zero", _ntWord.ToWords(0));
            Assert.Equal("jeden", _ntWord.ToWords(1));
            Assert.Equal("dwa", _ntWord.ToWords(2));
            Assert.Equal("trzy", _ntWord.ToWords(3));
            Assert.Equal("cztery", _ntWord.ToWords(4));
            Assert.Equal("pięć", _ntWord.ToWords(5));
            Assert.Equal("sześć", _ntWord.ToWords(6));
            Assert.Equal("siedem", _ntWord.ToWords(7));
            Assert.Equal("osiem", _ntWord.ToWords(8));
            Assert.Equal("dziewięć", _ntWord.ToWords(9));
        }

        [Fact]
        public void TenToTwentyNumbers()
        {
            Assert.Equal("dziesięć", _ntWord.ToWords(10));
            Assert.Equal("jedenaście", _ntWord.ToWords(11));
            Assert.Equal("dwanaście", _ntWord.ToWords(12));
            Assert.Equal("trzynaście", _ntWord.ToWords(13));
            Assert.Equal("czternaście", _ntWord.ToWords(14));
            Assert.Equal("piętnaście", _ntWord.ToWords(15));
            Assert.Equal("szesnaście", _ntWord.ToWords(16));
            Assert.Equal("siedemnaście", _ntWord.ToWords(17));
            Assert.Equal("osiemnaście", _ntWord.ToWords(18));
            Assert.Equal("dziewietnaście", _ntWord.ToWords(19));
            Assert.Equal("dwadzieścia", _ntWord.ToWords(20));
        }

        [Fact]
        public void RandomHundredsNumbers()
        {
            Assert.Equal("sto", _ntWord.ToWords(100));
            Assert.Equal("sto jeden", _ntWord.ToWords(101));
            Assert.Equal("sto jedenaście", _ntWord.ToWords(111));
            Assert.Equal("sto dwadzieścia pięć", _ntWord.ToWords(125));

            Assert.Equal("dwieście", _ntWord.ToWords(200));
            Assert.Equal("dwieście trzydzieści", _ntWord.ToWords(230));
            Assert.Equal("dwieście siedemdziesiąt sześć", _ntWord.ToWords(276));
            Assert.Equal("dwieście dziewięćdziesiąt dziewięć", _ntWord.ToWords(299));

            Assert.Equal("trzysta", _ntWord.ToWords(300));
            Assert.Equal("trzysta trzydzieści dwa", _ntWord.ToWords(332));
            Assert.Equal("trzysta sześćdziesiąt siedem", _ntWord.ToWords(367));
            Assert.Equal("trzysta osiemdziesiąt", _ntWord.ToWords(380));

            Assert.Equal("czterysta", _ntWord.ToWords(400));
            Assert.Equal("czterysta dwadzieścia trzy", _ntWord.ToWords(423));
            Assert.Equal("czterysta pięćdziesiąt sześć", _ntWord.ToWords(456));
            Assert.Equal("czterysta siedemdziesiąt", _ntWord.ToWords(470));

            Assert.Equal("pięćset", _ntWord.ToWords(500));
            Assert.Equal("pięćset jeden", _ntWord.ToWords(501));
            Assert.Equal("pięćset dziesięć", _ntWord.ToWords(510));
            Assert.Equal("pięćset dziewięćdziesiąt", _ntWord.ToWords(590));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("jeden tysiąc", _ntWord.ToWords(1000));
            Assert.Equal("jeden tysiąc jeden", _ntWord.ToWords(1001));
            Assert.Equal("jeden tysiąc jedenaście", _ntWord.ToWords(1011));
            Assert.Equal("jeden tysiąc dwadzieścia pięć", _ntWord.ToWords(1025));
            Assert.Equal("jeden tysiąc czterysta dwadzieścia pięć", _ntWord.ToWords(1425));

            Assert.Equal("dwa tysiące", _ntWord.ToWords(2000));
            Assert.Equal("dwa tysiące trzydzieści", _ntWord.ToWords(2030));
            Assert.Equal("dwa tysiące siedemdziesiąt sześć", _ntWord.ToWords(2076));
            Assert.Equal("dwa tysiące dziewięćdziesiąt dziewięć", _ntWord.ToWords(2099));
            Assert.Equal("dwa tysiące pięćset dziewięćdziesiąt dziewięć", _ntWord.ToWords(2599));

            Assert.Equal("trzy tysiące", _ntWord.ToWords(3000));
            Assert.Equal("trzy tysiące trzydzieści dwa", _ntWord.ToWords(3032));
            Assert.Equal("trzy tysiące sześćdziesiąt siedem", _ntWord.ToWords(3067));
            Assert.Equal("trzy tysiące osiemdziesiąt", _ntWord.ToWords(3080));
            Assert.Equal("trzy tysiące sto osiemdziesiąt", _ntWord.ToWords(3180));

            Assert.Equal("cztery tysiące", _ntWord.ToWords(4000));
            Assert.Equal("cztery tysiące dwadzieścia trzy", _ntWord.ToWords(4023));
            Assert.Equal("cztery tysiące pięćdziesiąt sześć", _ntWord.ToWords(4056));
            Assert.Equal("cztery tysiące siedemdziesiąt", _ntWord.ToWords(4070));
            Assert.Equal("cztery tysiące dziewięćset siedemdziesiąt", _ntWord.ToWords(4970));

            Assert.Equal("pięć tysięcy", _ntWord.ToWords(5000));
            Assert.Equal("pięć tysięcy jeden", _ntWord.ToWords(5001));
            Assert.Equal("pięć tysięcy dziesięć", _ntWord.ToWords(5010));
            Assert.Equal("pięć tysięcy dziewięćdziesiąt", _ntWord.ToWords(5090));
            Assert.Equal("pięć tysięcy sto dziewięćdziesiąt", _ntWord.ToWords(5190));
        }
    }
}