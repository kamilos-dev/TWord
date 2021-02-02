using System;
using Xunit;

namespace TWord.Tests.TransformerBuilderTests
{
    public class NumberTransformerBuilderTests
    {
        private NumberTransformerBuilder _builder;

        [Fact]
        public void NullNumbersDictionary_ThrowException()
        {
            NullReferenceException ex = Assert.Throws<NullReferenceException>(() => new NumberTransformerBuilder().Build());
            NullReferenceException ex2 = Assert.Throws<NullReferenceException>(() => new NumberTransformerBuilder().SetNumbersDictionary(null).Build());

            Assert.Equal("ILanguageNumbersDictionary cannot be null. Use SetNumbersDictionary to set it.", ex.Message);
            Assert.Equal("ILanguageNumbersDictionary cannot be null. Use SetNumbersDictionary to set it.", ex2.Message);
        }

        [Fact]
        public void NullNamesDictionary_ThrowException()
        {
            NullReferenceException ex = Assert.Throws<NullReferenceException>(() => new NumberTransformerBuilder()
               .SetNumbersDictionary(new EnglishNumbersDictionary())
               .Build());

            NullReferenceException ex2 = Assert.Throws<NullReferenceException>(() => new NumberTransformerBuilder()
                .SetNumbersDictionary(new EnglishNumbersDictionary())
                .SetLargeNumberNamesDictionary(null)
                .Build());

            Assert.Equal("ILargeNumberNamesDictionary cannot be null. Use SetLargeNumberNamesDictionary to set it.", ex.Message);
            Assert.Equal("ILargeNumberNamesDictionary cannot be null. Use SetLargeNumberNamesDictionary to set it.", ex2.Message);
        }

        [Fact]
        public void NullTriplerTransformer_ThrowException()
        {
            NullReferenceException ex = Assert.Throws<NullReferenceException>(() => new NumberTransformerBuilder()
               .SetNumbersDictionary(new EnglishNumbersDictionary())
               .SetLargeNumberNamesDictionary(new EnglishLargeNumberNamesDictionary())
               .Build());

            NullReferenceException ex2 = Assert.Throws<NullReferenceException>(() => new NumberTransformerBuilder()
                .SetNumbersDictionary(new EnglishNumbersDictionary())
                .SetLargeNumberNamesDictionary(new EnglishLargeNumberNamesDictionary())
                .SetTriplerTransformer(null)
                .Build());

            Assert.Equal("ITripletTransformer cannot be null. Use SetTriplerTransformer to set it.", ex.Message);
            Assert.Equal("ITripletTransformer cannot be null. Use SetTriplerTransformer to set it.", ex2.Message);
        }
    }
}