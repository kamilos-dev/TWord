using Xunit;

namespace TWord.Tests.AtWord
{
    public class GermanAtWordTests
    {
        private readonly IAtWord _at;

        public GermanAtWordTests()
        {
            _at = new AtWordBuilder()
                .SetLanguage(Language.German)
                .SetCurrency(CurrencySymbol.EUR)
                .Build();
        }

        [Fact]
        public void DecimalNumbers()
        {
            Assert.Equal("null Euro null Cent", _at.ToWords(0.0m));
            Assert.Equal("null Euro null Cent", _at.ToWords(0.00m));
            Assert.Equal("null Euro null Cent", _at.ToWords(0.001m));
            Assert.Equal("null Euro null Cent", _at.ToWords(0.004m));

            Assert.Equal("null Euro ein Cent", _at.ToWords(0.005m));
            Assert.Equal("null Euro ein Cent", _at.ToWords(0.01m));
            Assert.Equal("null Euro ein Cent", _at.ToWords(0.0140999m));
            Assert.Equal("null Euro ein Cent", _at.ToWords(0.0146999m));

            Assert.Equal("null Euro zwei Cent", _at.ToWords(0.0156999m));
            Assert.Equal("null Euro zwei Cent", _at.ToWords(0.02m));

            Assert.Equal("null Euro fünf Cent", _at.ToWords(0.05m));
            Assert.Equal("null Euro fünf Cent", _at.ToWords(0.054m));

            Assert.Equal("null Euro zehn Cent", _at.ToWords(0.099m));
            Assert.Equal("null Euro zehn Cent", _at.ToWords(0.1m));

            Assert.Equal("null Euro einunddreißig Cent", _at.ToWords(0.305m));

            Assert.Equal("null Euro neunundneunzig Cent", _at.ToWords(0.99m));
        }

        [Fact]
        public void ZeroToNineNumbers()
        {
            Assert.Equal("null Euro null Cent", _at.ToWords(0));
            Assert.Equal("ein Euro null Cent", _at.ToWords(1));
            Assert.Equal("zwei Euro null Cent", _at.ToWords(2));
            Assert.Equal("drei Euro null Cent", _at.ToWords(3));
            Assert.Equal("vier Euro null Cent", _at.ToWords(4));
            Assert.Equal("fünf Euro null Cent", _at.ToWords(5));
            Assert.Equal("sechs Euro null Cent", _at.ToWords(6));
            Assert.Equal("sieben Euro null Cent", _at.ToWords(7));
            Assert.Equal("acht Euro null Cent", _at.ToWords(8));
            Assert.Equal("neun Euro null Cent", _at.ToWords(9));
        }

        [Fact]
        public void TenToTwelveNumbers()
        {
            Assert.Equal("zehn Euro null Cent", _at.ToWords(10));
            Assert.Equal("elf Euro null Cent", _at.ToWords(11));
            Assert.Equal("zwölf Euro null Cent", _at.ToWords(12));
            Assert.Equal("dreizehn Euro null Cent", _at.ToWords(13));
            Assert.Equal("vierzehn Euro null Cent", _at.ToWords(14));
            Assert.Equal("fünfzehn Euro null Cent", _at.ToWords(15));
            Assert.Equal("sechzehn Euro null Cent", _at.ToWords(16));
            Assert.Equal("siebzehn Euro null Cent", _at.ToWords(17));
            Assert.Equal("achtzehn Euro null Cent", _at.ToWords(18));
            Assert.Equal("neunzehn Euro null Cent", _at.ToWords(19));
        }

        [Fact]
        public void RandomThousandNumbers()
        {
            Assert.Equal("eintausend Euro null Cent", _at.ToWords(1000));
            Assert.Equal("eintausendein Euro null Cent", _at.ToWords(1001));
            Assert.Equal("eintausendelf Euro null Cent", _at.ToWords(1011));
            Assert.Equal("eintausendfünfundzwanzig Euro null Cent", _at.ToWords(1025));
            Assert.Equal("eintausendvierhundertfünfundzwanzig Euro null Cent", _at.ToWords(1425));

            Assert.Equal("zweitausend Euro null Cent", _at.ToWords(2000));
            Assert.Equal("zweitausenddreißig Euro null Cent", _at.ToWords(2030));
            Assert.Equal("zweitausendsechsundsiebzig Euro null Cent", _at.ToWords(2076));
            Assert.Equal("zweitausendneunundneunzig Euro null Cent", _at.ToWords(2099));
            Assert.Equal("zweitausendfünfhundertneunundneunzig Euro null Cent", _at.ToWords(2599));

            Assert.Equal("dreitausend Euro null Cent", _at.ToWords(3000));
            Assert.Equal("dreitausendzweiunddreißig Euro null Cent", _at.ToWords(3032));
            Assert.Equal("dreitausendsiebenundsechzig Euro null Cent", _at.ToWords(3067));
            Assert.Equal("dreitausendachtzig Euro null Cent", _at.ToWords(3080));
            Assert.Equal("dreitausendeinhundertachtzig Euro null Cent", _at.ToWords(3180));

            Assert.Equal("viertausend Euro null Cent", _at.ToWords(4000));
            Assert.Equal("viertausenddreiundzwanzig Euro null Cent", _at.ToWords(4023));
            Assert.Equal("viertausendsechsundfünfzig Euro null Cent", _at.ToWords(4056));
            Assert.Equal("viertausendsiebzig Euro null Cent", _at.ToWords(4070));
            Assert.Equal("viertausendneunhundertsiebzig Euro null Cent", _at.ToWords(4970));

            Assert.Equal("fünftausend Euro null Cent", _at.ToWords(5000));
            Assert.Equal("fünftausendein Euro null Cent", _at.ToWords(5001));
            Assert.Equal("fünftausendzehn Euro null Cent", _at.ToWords(5010));
            Assert.Equal("fünftausendneunzig Euro null Cent", _at.ToWords(5090));
            Assert.Equal("fünftausendeinhundertneunzig Euro null Cent", _at.ToWords(5190));
        }
    }
}