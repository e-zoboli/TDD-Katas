using Xunit;

namespace Kata.KarateChop
{
    public class KarateChopTest
    {
        [Fact]
        public void SearchOnAnEmptyArrayShouldReturnMinusOne()
        {
            var testList = new int[] { };
            Assert.Equal(-1, KarateChop.Search(3, testList));

        }
        [Fact]
        public void ShouldReturnMinusOneIfNumberNotInArray()
        {
            var testList = new int[] { 1 };
            Assert.Equal(-1, KarateChop.Search(3, testList));

        }
        [Fact]
        public void ShouldReturnZeroIfNumberIsInArrayAtPositionZero()
        {
            var testList = new int[] { 3 };
            Assert.Equal(0, KarateChop.Search(3, testList));

        }
        [Fact]
        public void ShouldReturnCorrectIndexIfNumberIsInArray()
        {
            var testList = new int[] { 2, 3, 5 };
            Assert.Equal(1, KarateChop.Search(3, testList));

        }
        [Fact]
        public void ShouldReturnCorrectIndexIfNumberIsInLongerArray()
        {
            var testList = new int[] { 2, 5, 6, 10, 16, 99, 134  };
            Assert.Equal(4, KarateChop.Search(16, testList));

        }
    }
}