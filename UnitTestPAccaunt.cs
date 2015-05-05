using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dataLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTestPAccaunt
    {
        // unit test code
        [TestMethod]
        public void DecreaseBalance_WithValidAmount_UpdatesBalance()
        {
            // arrange
            Int32 userId = 1;
            double beginningBalance = PAccaunt.GetBalance(userId);
            double decreaseAmount = 4.55;
            double expected = 7.44;
            PAccaunt account = new PAccaunt(userId);

            // act
            account.DecreaseBalance(decreaseAmount);

            // assert
            double actual = PAccaunt.GetBalance(userId);
            Assert.AreEqual(expected, actual, 0.001, "Account not decreased correctly");
        }

        [TestMethod]
        public void IncreaseBalance_WithValidAmount_UpdatesBalance()
        {
            // arrange
            Int32 userId = 1;
            double beginningBalance = PAccaunt.GetBalance(userId);
            double increaseAmount = 4.55;
            double expected = 11.99;
            PAccaunt account = new PAccaunt(userId);

            // act
            account.IncreaseBalance(increaseAmount);

            // assert
            double actual = PAccaunt.GetBalance(userId);
            Assert.AreEqual(expected, actual, 0.001, "Account not decreased correctly");
        }
    }
}
