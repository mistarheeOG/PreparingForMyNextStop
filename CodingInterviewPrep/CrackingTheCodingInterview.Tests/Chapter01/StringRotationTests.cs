using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class StringRotationTests
    {
        [TestMethod]
        public void ShouldReturnTrue()
        {
            var first = "MikeLee";
            var second = "eeMikeL";
            var stringRotation = new StringRotation();
            var result = stringRotation.Check(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalse()
        {
            var first = "MikeLee";
            var second = "eeMikeZ";
            var stringRotation = new StringRotation();
            var result = stringRotation.Check(first, second);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldReturnFalseToo()
        {
            var first = "MikeLee";
            var second = "MikeLees";
            var stringRotation = new StringRotation();
            var result = stringRotation.Check(first, second);

            Assert.IsFalse(result);
        }
    }
}