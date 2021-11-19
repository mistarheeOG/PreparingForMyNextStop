using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;

namespace GrokkingAlgorithms.Tests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void ShouldSortOneItem()
        {
            var items = new int[]{1};
            var quickSort = new QuickSort();
            var result = quickSort.Sort(items, 0, 1);

            Assert.AreEqual(1, result[0]);
        }

        [TestMethod]
        public void ShouldSort()
        {
            var items = new int[]{10, 1, 2, 3};
            var quickSort = new QuickSort();
            var result = quickSort.Sort(items, 0, 3);

            var expected = new int[]{1,2,3,10};
            CollectionAssert.AreEqual(expected, result);
        
        }

        [TestMethod]
        public void ShouldSortWithDupes()
        {
            var items = new int[]{10, 1, 2, 3, 10};
            var quickSort = new QuickSort();
            var result = quickSort.Sort(items, 0, 4);

            var expected = new int[]{1, 2, 3, 10, 10};
            CollectionAssert.AreEqual(expected, result);
        
        }
    }
}