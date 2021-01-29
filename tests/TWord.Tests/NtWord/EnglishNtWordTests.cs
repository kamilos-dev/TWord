using Xunit;

namespace TWord.Tests.NtWord
{
    public class EnglishNtWordTests
    {
        private readonly INtWord _ntWord;

        public EnglishNtWordTests()
        {
            _ntWord = new NtWordBuilder()
                .SetLanguage(Language.English)
                .Build();
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            Assert.Equal("zero", _ntWord.ToWords(0));
            Assert.Equal("one", _ntWord.ToWords(1));
            Assert.Equal("two", _ntWord.ToWords(2));
            Assert.Equal("three", _ntWord.ToWords(3));
            Assert.Equal("four", _ntWord.ToWords(4));
            Assert.Equal("five", _ntWord.ToWords(5));
            Assert.Equal("six", _ntWord.ToWords(6));
            Assert.Equal("seven", _ntWord.ToWords(7));
            Assert.Equal("eight", _ntWord.ToWords(8));
            Assert.Equal("nine", _ntWord.ToWords(9));
        }

        [Fact]
        public void TenToTwentyNumbers()
        {
            Assert.Equal("ten", _ntWord.ToWords(10));
            Assert.Equal("eleven", _ntWord.ToWords(11));
            Assert.Equal("twelve", _ntWord.ToWords(12));
            Assert.Equal("thirteen", _ntWord.ToWords(13));
            Assert.Equal("fourteen", _ntWord.ToWords(14));
            Assert.Equal("fifteen", _ntWord.ToWords(15));
            Assert.Equal("sixteen", _ntWord.ToWords(16));
            Assert.Equal("seventeen", _ntWord.ToWords(17));
            Assert.Equal("eighteen", _ntWord.ToWords(18));
            Assert.Equal("nineteen", _ntWord.ToWords(19));
            Assert.Equal("twenty", _ntWord.ToWords(20));
        }

        [Fact]
        public void TewntyToOneHundredRandomNumbers()
        {
            Assert.Equal("twenty two", _ntWord.ToWords(22));
            Assert.Equal("twenty eight", _ntWord.ToWords(28));
        }

        [Fact]
        public void RandomHundredsNumbers()
        {
            Assert.Equal("one hundred", _ntWord.ToWords(100));
            Assert.Equal("one hundred one", _ntWord.ToWords(101));
            Assert.Equal("one hundred eleven", _ntWord.ToWords(111));
            Assert.Equal("one hundred twenty five", _ntWord.ToWords(125));

            Assert.Equal("two hundred", _ntWord.ToWords(200));
            Assert.Equal("two hundred thirty", _ntWord.ToWords(230));
            Assert.Equal("two hundred seventy six", _ntWord.ToWords(276));
            Assert.Equal("two hundred ninety nine", _ntWord.ToWords(299));

            Assert.Equal("three hundred", _ntWord.ToWords(300));
            Assert.Equal("three hundred thirty two", _ntWord.ToWords(332));
            Assert.Equal("three hundred sixty seven", _ntWord.ToWords(367));
            Assert.Equal("three hundred eighty", _ntWord.ToWords(380));

            Assert.Equal("four hundred", _ntWord.ToWords(400));
            Assert.Equal("four hundred twenty three", _ntWord.ToWords(423));
            Assert.Equal("four hundred fifty six", _ntWord.ToWords(456));
            Assert.Equal("four hundred seventy", _ntWord.ToWords(470));

            Assert.Equal("five hundred", _ntWord.ToWords(500));
            Assert.Equal("five hundred one", _ntWord.ToWords(501));
            Assert.Equal("five hundred ten", _ntWord.ToWords(510));
            Assert.Equal("five hundred ninety", _ntWord.ToWords(590));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("one thousand", _ntWord.ToWords(1000));
            Assert.Equal("one thousand one", _ntWord.ToWords(1001));
            Assert.Equal("one thousand eleven", _ntWord.ToWords(1011));
            Assert.Equal("one thousand twenty five", _ntWord.ToWords(1025));
            Assert.Equal("one thousand four hundred twenty five", _ntWord.ToWords(1425));

            Assert.Equal("two thousand", _ntWord.ToWords(2000));
            Assert.Equal("two thousand thirty", _ntWord.ToWords(2030));
            Assert.Equal("two thousand seventy six", _ntWord.ToWords(2076));
            Assert.Equal("two thousand ninety nine", _ntWord.ToWords(2099));
            Assert.Equal("two thousand five hundred ninety nine", _ntWord.ToWords(2599));

            Assert.Equal("three thousand", _ntWord.ToWords(3000));
            Assert.Equal("three thousand thirty two", _ntWord.ToWords(3032));
            Assert.Equal("three thousand sixty seven", _ntWord.ToWords(3067));
            Assert.Equal("three thousand eighty", _ntWord.ToWords(3080));
            Assert.Equal("three thousand one hundred eighty", _ntWord.ToWords(3180));

            Assert.Equal("four thousand", _ntWord.ToWords(4000));
            Assert.Equal("four thousand twenty three", _ntWord.ToWords(4023));
            Assert.Equal("four thousand fifty six", _ntWord.ToWords(4056));
            Assert.Equal("four thousand seventy", _ntWord.ToWords(4070));
            Assert.Equal("four thousand nine hundred seventy", _ntWord.ToWords(4970));

            Assert.Equal("five thousand", _ntWord.ToWords(5000));
            Assert.Equal("five thousand one", _ntWord.ToWords(5001));
            Assert.Equal("five thousand ten", _ntWord.ToWords(5010));
            Assert.Equal("five thousand ninety", _ntWord.ToWords(5090));
            Assert.Equal("five thousand one hundred ninety", _ntWord.ToWords(5190));
        }

        [Fact]
        public void RandomLargeNumbers()
        {
            Assert.Equal("ten thousand", _ntWord.ToWords(10000));
            Assert.Equal("one hundred thousand", _ntWord.ToWords(100000));

            Assert.Equal("one million", _ntWord.ToWords(1000000));
            Assert.Equal("ten million", _ntWord.ToWords(10000000));
            Assert.Equal("one hundred million", _ntWord.ToWords(100000000));

            Assert.Equal("one billion", _ntWord.ToWords(1000000000));
            Assert.Equal("ten billion", _ntWord.ToWords(10000000000));
            Assert.Equal("one hundred billion", _ntWord.ToWords(100000000000));

            Assert.Equal("one trillion", _ntWord.ToWords(1000000000000));
            Assert.Equal("ten trillion", _ntWord.ToWords(10000000000000));
            Assert.Equal("one hundred trillion", _ntWord.ToWords(100000000000000));

            Assert.Equal("one quadrillion", _ntWord.ToWords(1000000000000000));
            Assert.Equal("ten quadrillion", _ntWord.ToWords(10000000000000000));
            Assert.Equal("one hundred quadrillion", _ntWord.ToWords(100000000000000000));

            Assert.Equal("one quintillion", _ntWord.ToWords(1000000000000000000));
        }
    }
}