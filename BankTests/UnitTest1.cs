using System;
using C0730406_C0731847_;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//C0731847
//C0730406
namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public void Debit_WithValidAmount_UpdatesBalance()

        {

            //Arrange

            double beginningBalance = 11.99;

            double debitAmount = 4.55;

            double expected = 7.44;

            BankAccount account = new BankAccount("Gagan, Manpreet", beginningBalance);



            //Act

            account.Debit(debitAmount);



            //Assert

            double actual = account.Balance;

            Assert.AreEqual(expected, actual, 0.0001, "Account nt debited correctly");

        }


    }



}
}
