using System;
using Xunit;
using static ATM.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void BalanceIsReturnedInViewBalance()
        {
            Assert.Equal(5000.00, ViewBalance(5000.00));
        }

        [Fact]
        public void BalanceReturndIsCorrect()
        {
            Assert.NotEqual(4500, ViewBalance(5000.00));
        }

        [Theory]
        [InlineData(4500.00, 500.00)]
        [InlineData(4750.00, 250.00)]
        [InlineData(4399.45, 600.55)]
        [InlineData(4989.01, 10.99)]
        public void ReturnNewBalanceAfterAddition(double balance, double addition)
        {
            Assert.Equal(5000.00, AddToBalance(balance, addition));
        }
    }
}
