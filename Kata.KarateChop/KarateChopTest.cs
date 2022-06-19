using Xunit;

namespace Kata.KarateChop
{
    public class KarateChopTest
    {
        [Fact]
        public void AnEmptyArrayShouldReturnMinusOne()
        {
            var testArr = new int[] { };
            Assert.Equal(-1, KarateChop.Search(3, testArr));

        }
    }
}