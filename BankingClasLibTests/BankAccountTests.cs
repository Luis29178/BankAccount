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

                StringAssert.Contains(e.Message, "Fail");               
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

                StringAssert.Contains(e.Message, "Fail");
                return;
            }
            Assert.Fail();



        }


        [TestMethod()]
        public void validCTransA()
        {
            BankAccount bankAccount = new BankAccount(200);       
            bool test = bankAccount.Credit(40);
            Assert.IsTrue(test);
           
        }


        [TestMethod()]
        public void validCTransB()
        {
            BankAccount bankAccount = new BankAccount(200);
            try
            {
                bankAccount.Credit(0);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Fail");
            }
           
        }


        [TestMethod()]
        public void validCTransC()
        {
            BankAccount bankAccount = new BankAccount(200);
            try
            {
                bankAccount.Credit(10000);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Fail");
            }

        }


        [TestMethod()]
        public void AccountFrozenC()
        {
            BankAccount bankAccount = new BankAccount(200);
            bankAccount.frozen = true;
            try
            {
                bankAccount.Credit(43);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Fail");
                return;
            }
            Assert.Fail();

        }


        [TestMethod()]
        public void validDTransA()
        {
            BankAccount bankAccount = new BankAccount(200);
            bool test = bankAccount.Debit(40);
            Assert.IsTrue(test);

        }


        [TestMethod()]
        public void validDTransB()
        {
            BankAccount bankAccount = new BankAccount(200);
            try
            {
                bankAccount.Debit(0);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Fail");
            }

        }


        [TestMethod()]
        public void validDTransC()
        {
            BankAccount bankAccount = new BankAccount(200);
            try
            {
                bankAccount.Debit(0);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Fail");
            }

        }


        [TestMethod()]
        public void AccountFrozenD()
        {
            BankAccount bankAccount = new BankAccount(200);
            bankAccount.frozen = true;
            try
            {
                bankAccount.Debit(43);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Fail");
                return;
            }
            Assert.Fail();

        }


       

    }
}