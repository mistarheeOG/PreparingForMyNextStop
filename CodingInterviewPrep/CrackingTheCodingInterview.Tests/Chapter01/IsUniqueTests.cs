using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class IsUniqueTests
    {
        [TestMethod]
        public void ShouldReturnTrue()
        {
            var checkMe = "abcdefghi";
            var isUnique = new IsUnique();
            var result = isUnique.CheckIfUnique(checkMe);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalse()
        {
            var checkMe = "abcdefgha";
            var isUnique = new IsUnique();
            var result = isUnique.CheckIfUnique(checkMe);
            
            Assert.IsFalse(result);
        }
    }
}