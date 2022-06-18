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
            var actualResult = FizzBuzz.PrintNumber();
            Assert.Contains("Fizz", actualResult);
        }

        [Fact]
        public void CanReturnBuzzIfNumberIsDivisibleByFive()
        {
            var actualResult = FizzBuzz.PrintNumber();
            Assert.Contains("Buzz", actualResult);
        }
    }
}
