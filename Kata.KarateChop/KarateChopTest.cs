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
        public void SearchOnEmptyArrayShouldReturnMinusOn()
        {
            var testList = new int[] { };

            Assert.Equal(-1, KarateChop.SearchRecursively(3, testList, 0, testList.Length - 1));
        }

        [Fact]
        public void ShouldReturnMinusOneIfNumberNotInArray()
        {
            var testList = new int[] { 1 };
            Assert.Equal(-1, KarateChop.Search(3, testList));

        }
        [Fact]
        public void ShouldReturnMinusOneIfNumberNotInArrayRec()
        {
            var testList = new int[] { 1 };

            Assert.Equal(-1, KarateChop.SearchRecursively(3, testList, 0, testList.Length - 1));
        }
        [Fact]
        public void ShouldReturnZeroIfNumberIsInArrayAtPositionZero()
        {
            var testList = new int[] { 3 };
            Assert.Equal(0, KarateChop.Search(3, testList));

        }
        [Fact]
        public void ShouldReturnZeroIfIsInArrayAtPosZeroRec()
        {
            var testList = new[] { 3 };
            Assert.Equal(0, KarateChop.SearchRecursively(3, testList, 0, testList.Length - 1));
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
        [Fact]
        public void ShouldReturnCorrectIndexIfNumberInRecu()
        {
            var testList = new int[] { 2, 5, 6, 10, 16, 99, 134 };
            Assert.Equal(4, KarateChop.SearchRecursively(16, testList, 0, testList.Length -1));
        }
    }
}