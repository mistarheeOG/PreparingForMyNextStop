using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class URLifyTests
    {
        [TestMethod]
        public void ShouldReturnCorrectString()
        {
            var transformMe = "Hello Mr. Wilson    ";
            var urlify = new URLify();
            var result = urlify.Transform(transformMe);

            Assert.AreEqual("Hello%20Mr.%20Wilson", result);
        }
    }
}