using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_Returns_0_For_Empty_String()
        {
            var underTest = new StringCalculator();

            var expected = underTest.Add("");

            Assert.Equal(0, expected);
        }
    }
}
