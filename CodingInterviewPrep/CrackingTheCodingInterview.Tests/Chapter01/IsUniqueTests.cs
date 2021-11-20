using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class IsUniqueTests
    {
        [TestMethod]
        public void CheckIfUniqueShouldReturnTrue()
        {
            var checkMe = "abcdefghi";
            var isUnique = new IsUnique();
            var result = isUnique.CheckIfUniqueWithNoDatastructures(checkMe);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfUniqueShouldReturnFalse()
        {
            var checkMe = "abcdefgha";
            var isUnique = new IsUnique();
            var result = isUnique.CheckIfUniqueWithNoDatastructures(checkMe);
            
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfUniqueWithNoDatastructuresShouldReturnTrue()
        {
            var checkMe = "abcdefghi";
            var isUnique = new IsUnique();
            var result = isUnique.CheckIfUniqueWithNoDatastructures(checkMe);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfUniqueWithNoDatastructuresShouldReturnFalse()
        {
            var checkMe = "abcdefgha";
            var isUnique = new IsUnique();
            var result = isUnique.CheckIfUniqueWithNoDatastructures(checkMe);
            
            Assert.IsFalse(result);
        }
    }
}