using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;

namespace GrokkingAlgorithms.Tests
{
    [TestClass]
    public class DivideAndConquerSumTests
    {
        [TestMethod]
        public void ShouldSumToZero()
        {
            var items = new int[]{};
            var divideAndConquerSum = new DivideAndConquerSum();
            var result = divideAndConquerSum.Sum(items);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShouldSumToSingleValue()
        {
            var items = new int[]{10};
            var divideAndConquerSum = new DivideAndConquerSum();
            var result = divideAndConquerSum.Sum(items);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ShouldSum()
        {
            var items = new int[]{10, 1, 2, 3};
            var divideAndConquerSum = new DivideAndConquerSum();
            var result = divideAndConquerSum.Sum(items);

            Assert.AreEqual(16, result);
        }
    }
}