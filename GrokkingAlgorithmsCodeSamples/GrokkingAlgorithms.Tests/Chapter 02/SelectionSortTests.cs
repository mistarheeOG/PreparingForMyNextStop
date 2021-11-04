using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;

namespace GrokkingAlgorithms.Tests
{
    [TestClass]
    public class SelectionSortTests
    {
        [TestMethod]
        public void ShouldSortArray()
        {
            var unsorted = new int[]{9,1,8,2,7,3,6,4,5};
            var selectionSort = new SelectionSort();
            var result = selectionSort.Sort(unsorted);

            var sorted = new int[]{1,2,3,4,5,6,7,8,9};
            CollectionAssert.AreEqual(result, sorted);
        }
    }
}