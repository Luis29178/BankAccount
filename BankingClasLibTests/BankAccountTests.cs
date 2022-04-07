using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void BLTZero()
        {
            BankAccount bankAccount = new BankAccount(0);
            try
            {
                bankAccount.Debit(20);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Insufficent Funds");               
                return;
            }
            Assert.Fail();



        }
        [TestMethod()]
        public void BGTHundK()
        {
            BankAccount bankAccount = new BankAccount(100000);
            try
            {
                bankAccount.Credit(20);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Communism");
                return;
            }
            Assert.Fail();



        }

        [TestMethod()]
        public void AccountFrozen()
        {
            BankAccount bankAccount = new BankAccount(200);
            bankAccount.frozen = true;
            try
            {
                bankAccount.Debit(43);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Frozen");
                return;
            }
            Assert.Fail();

        }
    }
}