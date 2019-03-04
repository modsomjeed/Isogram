using System;
using Xunit;
using Isogram;

namespace IsogramTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("lumber")]
        [InlineData("background")]
        [InlineData("downstream")]
        [InlineData("six-year-old")]
        [InlineData("Emily Jung Schwartzkopf")]
        public void TestShouldReturnTrue(string data)
        {
            var controller = new CheckIsogram();
            var result = controller.checkText(data);
            Assert.True(result);
        }

        [Theory]
        [InlineData("lumblerjacks")]
        [InlineData("backgroundg")]
        [InlineData("dowmnstream")]
        [InlineData("siix-year-old")]
        [InlineData("Emily Jung Schwaartzkopf")]
        public void TestShouldReturnFalse(string data)
        {
            var controller = new CheckIsogram();
            var result = controller.checkText(data);
            Assert.False(result);
        }
    }
}
