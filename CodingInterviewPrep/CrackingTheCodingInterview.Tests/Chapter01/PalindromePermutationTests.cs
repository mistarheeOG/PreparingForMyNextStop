using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class PalindromePermutationTests
    {
        [TestMethod]
        public void ShouldReturnTrue()
        {
            var checkMe = "abcdabc";
            var palindromePermutation = new PalindromePermutation();
            var result = palindromePermutation.CheckIfPalindromePermutation(checkMe);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTrueToo()
        {
            var checkMe = "abcabc";
            var palindromePermutation = new PalindromePermutation();
            var result = palindromePermutation.CheckIfPalindromePermutation(checkMe);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalse()
        {
            var checkMe = "abcdba";
            var palindromePermutation = new PalindromePermutation();
            var result = palindromePermutation.CheckIfPalindromePermutation(checkMe);
            
            Assert.IsFalse(result);
        }
    }
}