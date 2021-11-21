using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class ZeroMatrixTests
    {
        [TestMethod]
        public void ShouldZereo()
        {
            var matrix = new int[,]{ {1,2,3,4,5},{4,5,6,7,8},{8,9,0,11,12},{12,13,14,15,16} };
            var zeroMatrix = new ZeroMatrix();
            var result = zeroMatrix.Transform(matrix);
            
            var expected = new int[,]{ {1,2,0,4,5},{4,5,0,7,8},{0,0,0,0,0},{12,13,0,15,16} };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}