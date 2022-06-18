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
        [Fact]
        public void TestWithNewLineSeparatorOtherThanComma()
        {
            Assert.Equal(6, StringCalculator.Add("1\n2,3"));
        }
        [Fact]
        public void TestWithDifferentDelimiters()
        {
            Assert.Equal(6, StringCalculator.Add("//;\n1;2,3"));
        }
        [Fact]
        public void TestWithNumberAsStringInputGreaterThanThousand()
        {
            Assert.Equal(6, StringCalculator.Add("//;\n1;1001;2,3, 1001"));
        }
        [Fact]
        public void TestWithANegativeNumberShouldThrowArgumentException()
        {
            string expectedErrMessage = "negatives not allowed: -3";
            var ex = Assert.Throws<ArgumentException>(() => StringCalculator.Add("//;\n1;2,-3"));
            Assert.Equal(expectedErrMessage, ex.Message);
        }
        [Fact]
        public void TestWithMultipleNegativeNumberShouldThrowArgumentException()
        {
            string expectedErrMessage = "negatives not allowed: -3,-4,-8";
            var ex = Assert.Throws<ArgumentException>(() => StringCalculator.Add("//;\n1;2,-3,-4,1,-8"));
            Assert.Equal(expectedErrMessage, ex.Message);
        }
    }
}