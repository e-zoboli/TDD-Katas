using Xunit;

namespace Kata.StringCalculator
{
    public class StringCalculatorTest
    {
        [Fact]
        public void TestWithEmpyInputString()
        {
            Assert.Equal(0, StringCalculator.Add(""));
        }
        [Fact]
        public void TestWithOneAsInpuString()
        {
            Assert.Equal(1, StringCalculator.Add("1"));
        }
        [Fact]
        public void TestWithTwoNumberAsStringInput()
        {
            Assert.Equal(3, StringCalculator.Add("1,2"));
        }
        [Fact]
        public void TestWithMoreNumberAsStringInput()
        {
            Assert.Equal(15, StringCalculator.Add("1,2,3,4,5"));
        }
    }
}