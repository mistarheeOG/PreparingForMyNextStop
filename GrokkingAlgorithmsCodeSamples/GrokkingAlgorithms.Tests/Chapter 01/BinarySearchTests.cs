using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;

namespace GrokkingAlgorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void ShouldFindValue()
        {
            var items = new int[]{1,2,3,4,5,6,7,8,9,10};
            var item = 8;

            var binarySearch = new BinarySearch();
            var result = binarySearch.FindItem(items, item);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotFindValue()
        {
            var items = new int[]{1,2,3,4,6,7,8,9,10};
            var item = 5;

            var binarySearch = new BinarySearch();
            var result = binarySearch.FindItem(items, item);

            Assert.IsFalse(result);
        }
    }
}
