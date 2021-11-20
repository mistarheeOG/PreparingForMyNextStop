using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class RotateMatrixTests
    {
        [TestMethod]
        public void ShouldRotate()
        {
            var matrix = new int[,]{ {1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16} };
            var rotateMatrix = new RotateMatrix();
            var result = rotateMatrix.Rotate(matrix);
            
            var expected = new int[,]{ {13,9,5,1},{14,10,6,2},{15,11,7,3},{16,12,8,4} };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}