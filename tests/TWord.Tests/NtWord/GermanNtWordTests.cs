using Xunit;

namespace TWord.Tests.NtWord
{
    public class GermanNtWordTests
    {
        private readonly INtWord _ntWord;

        public GermanNtWordTests()
        {
            _ntWord = new NtWordBuilder()
                .SetLanguage(Language.German)
                .Build();
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            Assert.Equal("null", _ntWord.ToWords(0));
            Assert.Equal("eins", _ntWord.ToWords(1));
            Assert.Equal("zwei", _ntWord.ToWords(2));
            Assert.Equal("drei", _ntWord.ToWords(3));
            Assert.Equal("vier", _ntWord.ToWords(4));
            Assert.Equal("fünf", _ntWord.ToWords(5));
            Assert.Equal("sechs", _ntWord.ToWords(6));
            Assert.Equal("sieben", _ntWord.ToWords(7));
            Assert.Equal("acht", _ntWord.ToWords(8));
            Assert.Equal("neun", _ntWord.ToWords(9));
        }

        [Fact]
        public void TenToTwentyNumbers()
        {
            Assert.Equal("zehn", _ntWord.ToWords(10));
            Assert.Equal("elf", _ntWord.ToWords(11));
            Assert.Equal("zwölf", _ntWord.ToWords(12));
            Assert.Equal("dreizehn", _ntWord.ToWords(13));
            Assert.Equal("vierzehn", _ntWord.ToWords(14));
            Assert.Equal("fünfzehn", _ntWord.ToWords(15));
            Assert.Equal("sechzehn", _ntWord.ToWords(16));
            Assert.Equal("siebzehn", _ntWord.ToWords(17));
            Assert.Equal("achtzehn", _ntWord.ToWords(18));
            Assert.Equal("neunzehn", _ntWord.ToWords(19));
            Assert.Equal("zwanzig", _ntWord.ToWords(20));
        }

        [Fact]
        public void TewntyToOneHundredRandomNumbers()
        {
            Assert.Equal("einundzwanzig", _ntWord.ToWords(21));
            Assert.Equal("zweiundzwanzig", _ntWord.ToWords(22));
            Assert.Equal("achtundzwanzig", _ntWord.ToWords(28));
            Assert.Equal("dreißig", _ntWord.ToWords(30));
            Assert.Equal("fünfunddreißig", _ntWord.ToWords(35));
            Assert.Equal("vierundvierzig", _ntWord.ToWords(44));
            Assert.Equal("sechsundfünfzig", _ntWord.ToWords(56));
            Assert.Equal("dreiundsechzig", _ntWord.ToWords(63));
            Assert.Equal("einundsiebzig", _ntWord.ToWords(71));
            Assert.Equal("siebenundachtzig", _ntWord.ToWords(87));
            Assert.Equal("achtundneunzig", _ntWord.ToWords(98));
        }

        [Fact]
        public void RandomHundredsNumbers()
        {
            Assert.Equal("einhundert", _ntWord.ToWords(100));
            Assert.Equal("einhunderteins", _ntWord.ToWords(101));
            Assert.Equal("einhundertelf", _ntWord.ToWords(111));
            Assert.Equal("einhundertfünfundzwanzig", _ntWord.ToWords(125));

            Assert.Equal("zweihundert", _ntWord.ToWords(200));
            Assert.Equal("zweihundertdreißig", _ntWord.ToWords(230));
            Assert.Equal("zweihundertsechsundsiebzig", _ntWord.ToWords(276));
            Assert.Equal("zweihundertneunundneunzig", _ntWord.ToWords(299));

            Assert.Equal("dreihundert", _ntWord.ToWords(300));
            Assert.Equal("dreihundertzweiunddreißig", _ntWord.ToWords(332));
            Assert.Equal("dreihundertsiebenundsechzig", _ntWord.ToWords(367));
            Assert.Equal("dreihundertachtzig", _ntWord.ToWords(380));

            Assert.Equal("vierhundert", _ntWord.ToWords(400));
            Assert.Equal("vierhundertdreiundzwanzig", _ntWord.ToWords(423));
            Assert.Equal("vierhundertsechsundfünfzig", _ntWord.ToWords(456));
            Assert.Equal("vierhundertsiebzig", _ntWord.ToWords(470));

            Assert.Equal("fünfhundert", _ntWord.ToWords(500));
            Assert.Equal("fünfhunderteins", _ntWord.ToWords(501));
            Assert.Equal("fünfhundertzehn", _ntWord.ToWords(510));
            Assert.Equal("fünfhundertneunzig", _ntWord.ToWords(590));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("eintausend", _ntWord.ToWords(1000));
            Assert.Equal("eintausendeins", _ntWord.ToWords(1001));
            Assert.Equal("eintausendelf", _ntWord.ToWords(1011));
            Assert.Equal("eintausendfünfundzwanzig", _ntWord.ToWords(1025));
            Assert.Equal("eintausendvierhundertfünfundzwanzig", _ntWord.ToWords(1425));

            Assert.Equal("zweitausend", _ntWord.ToWords(2000));
            Assert.Equal("zweitausenddreißig", _ntWord.ToWords(2030));
            Assert.Equal("zweitausendsechsundsiebzig", _ntWord.ToWords(2076));
            Assert.Equal("zweitausendneunundneunzig", _ntWord.ToWords(2099));
            Assert.Equal("zweitausendfünfhundertneunundneunzig", _ntWord.ToWords(2599));

            Assert.Equal("dreitausend", _ntWord.ToWords(3000));
            Assert.Equal("dreitausendzweiunddreißig", _ntWord.ToWords(3032));
            Assert.Equal("dreitausendsiebenundsechzig", _ntWord.ToWords(3067));
            Assert.Equal("dreitausendachtzig", _ntWord.ToWords(3080));
            Assert.Equal("dreitausendeinhundertachtzig", _ntWord.ToWords(3180));

            Assert.Equal("viertausend", _ntWord.ToWords(4000));
            Assert.Equal("viertausenddreiundzwanzig", _ntWord.ToWords(4023));
            Assert.Equal("viertausendsechsundfünfzig", _ntWord.ToWords(4056));
            Assert.Equal("viertausendsiebzig", _ntWord.ToWords(4070));
            Assert.Equal("viertausendneunhundertsiebzig", _ntWord.ToWords(4970));

            Assert.Equal("fünftausend", _ntWord.ToWords(5000));
            Assert.Equal("fünftausendeins", _ntWord.ToWords(5001));
            Assert.Equal("fünftausendzehn", _ntWord.ToWords(5010));
            Assert.Equal("fünftausendneunzig", _ntWord.ToWords(5090));
            Assert.Equal("fünftausendeinhundertneunzig", _ntWord.ToWords(5190));
        }

        [Fact]
        public void RandomLargeNumbers()
        {
            Assert.Equal("zehntausend", _ntWord.ToWords(10000));
            Assert.Equal("einhunderttausend", _ntWord.ToWords(100000));

            Assert.Equal("ein Million", _ntWord.ToWords(1000000));
            Assert.Equal("zehn Millionen", _ntWord.ToWords(10000000));
            Assert.Equal("einhundert Millionen", _ntWord.ToWords(100000000));

            Assert.Equal("ein Milliarde", _ntWord.ToWords(1000000000));
            Assert.Equal("zehn Milliarden", _ntWord.ToWords(10000000000));
            Assert.Equal("einhundert Milliarden", _ntWord.ToWords(100000000000));

            Assert.Equal("ein Billion", _ntWord.ToWords(1000000000000));
            Assert.Equal("zehn Billionen", _ntWord.ToWords(10000000000000));
            Assert.Equal("einhundert Billionen", _ntWord.ToWords(100000000000000));

            Assert.Equal("ein Billiarde", _ntWord.ToWords(1000000000000000));
            Assert.Equal("zehn Billiarden", _ntWord.ToWords(10000000000000000));
            Assert.Equal("einhundert Billiarden", _ntWord.ToWords(100000000000000000));

            Assert.Equal("ein Trillion", _ntWord.ToWords(1000000000000000000));
        }
    }
}