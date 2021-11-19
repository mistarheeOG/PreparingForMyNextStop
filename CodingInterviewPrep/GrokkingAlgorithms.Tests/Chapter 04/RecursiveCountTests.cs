using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;

namespace GrokkingAlgorithms.Tests
{
    [TestClass]
    public class RecursiveCountTests
    {
        [TestMethod]
        public void ShouldCountZero()
        {
            var items = new int[]{};
            var recursiveCount = new RecursiveCount();
            var result = recursiveCount.Count(items);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShouldCountOne()
        {
            var items = new int[]{10};
            var recursiveCount = new RecursiveCount();
            var result = recursiveCount.Count(items);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ShouldCount()
        {
            var items = new int[]{10, 1, 2, 3};
            var recursiveCount = new RecursiveCount();
            var result = recursiveCount.Count(items);

            Assert.AreEqual(4, result);
        }
    }
}