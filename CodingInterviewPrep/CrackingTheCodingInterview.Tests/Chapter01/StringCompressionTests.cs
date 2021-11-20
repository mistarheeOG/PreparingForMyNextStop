using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class StringCompressionTests
    {
        [TestMethod]
        public void ShouldReturnCorrectString()
        {
            var transformMe = "aabbbccccddddd";
            var stringCompression = new StringCompression();
            var result = stringCompression.Compress(transformMe);

            Assert.AreEqual("a2b3c4d5", result);
        }

        [TestMethod]
        public void ShouldReturnOriginalString()
        {
            var transformMe = "aabbcc";
            var stringCompression = new StringCompression();
            var result = stringCompression.Compress(transformMe);

            Assert.AreEqual(transformMe, result);
        }
    }
}