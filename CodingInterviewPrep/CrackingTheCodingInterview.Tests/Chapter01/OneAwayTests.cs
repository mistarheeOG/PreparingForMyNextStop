using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests
{
    [TestClass]
    public class OneAwayTests
    {
        [TestMethod]
        public void ShouldReturnTrueOnDelete()
        {
            var first = "abcdefghi";
            var second = "abcdefgh";
            var oneAway = new OneAway();
            var result = oneAway.CheckIfOneAway(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTrueOnAdd()
        {
            var first = "acdefgh";
            var second = "abcdefgh";
            var oneAway = new OneAway();
            var result = oneAway.CheckIfOneAway(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTrueOnEdit()
        {
            var first = "abcdefghi";
            var second = "abcdefghj";
            var oneAway = new OneAway();
            var result = oneAway.CheckIfOneAway(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTrueOnRemoval()
        {
            var first = "abcdefghi";
            var second = "acdefghi";
            var oneAway = new OneAway();
            var result = oneAway.CheckIfOneAway(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalse()
        {
            var first = "abcdefghi";
            var second = "abcdefgjk";
            var oneAway = new OneAway();
            var result = oneAway.CheckIfOneAway(first, second);
            
            Assert.IsFalse(result);
        }
    }
}