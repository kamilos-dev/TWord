using Xunit;

namespace TWord.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void GetUnitsTests()
        {
            int number1 = 1234;
            long number2 = 1234;

            int number3 = 0;
            long number4 = 0;

            Assert.Equal(4, number1.GetUnits());
            Assert.Equal(4, number2.GetUnits());

            Assert.Equal(0, number3.GetUnits());
            Assert.Equal(0, number4.GetUnits());
        }

        [Fact]
        public void GetTensTests()
        {
            int number1 = 1234;
            long number2 = 1234;

            int number3 = 0;
            long number4 = 0;

            Assert.Equal(3, number1.GetTens());
            Assert.Equal(3, number2.GetTens());

            Assert.Equal(0, number3.GetTens());
            Assert.Equal(0, number4.GetTens());
        }

        [Fact]
        public void GetHundredsTests()
        {
            int number1 = 1234;
            long number2 = 1234;

            int number3 = 0;
            long number4 = 0;

            Assert.Equal(2, number1.GetHundreds());
            Assert.Equal(2, number2.GetHundreds());

            Assert.Equal(0, number3.GetHundreds());
            Assert.Equal(0, number4.GetHundreds());
        }

        [Fact]
        public void ToTripletsTests()
        {
            long number1 = 123456;

            Assert.Equal(123, number1.ToTriplets()[1].ToInt());
            Assert.Equal(456, number1.ToTriplets()[0].ToInt());

            long number2 = 12345;

            Assert.Equal(12, number2.ToTriplets()[1].ToInt());
            Assert.Equal(345, number2.ToTriplets()[0].ToInt());

            long number3 = 1234;

            Assert.Equal(1, number3.ToTriplets()[1].ToInt());
            Assert.Equal(234, number3.ToTriplets()[0].ToInt());

            long number4 = 123;

            Assert.Equal(123, number4.ToTriplets()[0].ToInt());
        }

        [Fact]
        public void AsFractionTests()
        {
            Assert.Equal("100/100", ((long)100).AsFraction());
            Assert.Equal("0/100", ((long)0).AsFraction(100));
            Assert.Equal("1/100", ((long)1).AsFraction(100));
            Assert.Equal("100/100", ((long)100).AsFraction(100));
            Assert.Equal("100/10", ((long)100).AsFraction(10));
        }

        [Fact]
        public void GetIntegerPartTests()
        {
            Assert.Equal(0, 0.005m.GetIntegerPart());
            Assert.Equal(1, 1.005m.GetIntegerPart());
            Assert.Equal(12, 12.005m.GetIntegerPart());
            Assert.Equal(123, 123.005m.GetIntegerPart());
        }

        [Fact]
        public void GetDecimalPartTests()
        {
            Assert.Equal(0.005m, 0.005m.GetDecimalPart());
            Assert.Equal(0.00556m, 1.00556m.GetDecimalPart());
            Assert.Equal(0, 12m.GetDecimalPart());
            Assert.Equal(0.5m, 123.5m.GetDecimalPart());
        }
    }
}