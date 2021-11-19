using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class PermutationTests
    {
        [TestMethod]
        public void ShouldReturnTrue()
        {
            var first = "abcdefghi";
            var second = "ghidefabc";
            var permutation = new Permutation();
            var result = permutation.CheckIfSecondIsPermutationOfFirst(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalse()
        {
            var first = "abcdefghi";
            var second = "aaabbbccc";
            var permutation = new Permutation();
            var result = permutation.CheckIfSecondIsPermutationOfFirst(first, second);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldReturnAlsoFalse()
        {
            var first = "abcdefghi";
            var second = "a";
            var permutation = new Permutation();
            var result = permutation.CheckIfSecondIsPermutationOfFirst(first, second);

            Assert.IsFalse(result);
        }
    }
}