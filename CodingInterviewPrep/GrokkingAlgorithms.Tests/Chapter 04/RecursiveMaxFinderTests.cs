using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrokkingAlgorithms;

namespace GrokkingAlgorithms.Tests
{
    [TestClass]
    public class RecursiveMaxFinderTests
    {
        [TestMethod]
        public void ShouldCountZero()
        {
            var items = new int[]{};
            var recursiveMaxFinder = new RecursiveMaxFinder();
            var result = recursiveMaxFinder.FindMax(items);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShouldCountOne()
        {
            var items = new int[]{10};
            var recursiveMaxFinder = new RecursiveMaxFinder();
            var result = recursiveMaxFinder.FindMax(items);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ShouldCount()
        {
            var items = new int[]{10, 1, 2, 3};
            var recursiveMaxFinder = new RecursiveMaxFinder();
            var result = recursiveMaxFinder.FindMax(items);

            Assert.AreEqual(10, result);
        }
    }
}