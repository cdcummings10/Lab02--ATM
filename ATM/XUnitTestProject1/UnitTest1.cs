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
    }
}
