using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void CanReturnFizzIfNumberIsDivisibleByThree()
        {
            var actualResult = FizzBuzz.PrintNumber(3);
            Assert.Contains("Fizz", actualResult);
        }

        [Fact]
        public void CanReturnBuzzIfNumberIsDivisibleByFive()
        {
            var actualResult = FizzBuzz.PrintNumber(5);
            Assert.Contains("Buzz", actualResult);
        }
        
        [Fact]
        public void CanReturnFizzBuzzIfNumberIsMultipleOfBothThreeAndFive()
        {
            var actualResult = FizzBuzz.PrintNumber(15);
            Assert.Contains("FizzBuzz",actualResult);
        }

        [Fact]
        public void CanPrintTheCorrectString()
        {
            var actualResult = FizzBuzz.PrintNumber(4);
            Assert.Equal("1 2 Fizz 4", actualResult);
        }
    }
}
