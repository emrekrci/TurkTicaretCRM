using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.DataAccess.Test.EntityFrameworkTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Add_Customer()
        {
            EfCustomerDal customerDal = new EfCustomerDal();
            Customer customer = new Customer
            {
                CustomerName = "Emre",
                CustomerSurname = "Kırcı",
                CustomerAddress = "Gazi kemal mahallesi muhtar şevki sokak babaeski/kırklareli",
                CustomerMail = "emrekrci@hotmail.com",
                CustomerPhone = "5375022611",
                RegistrationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            var result = customerDal.Add(customer);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Add_Debit()
        {
            EfDebitDal debitDal = new EfDebitDal();
            Debit debit = new Debit { DebitReason = "Kömür" };
            var result = debitDal.Add(debit);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add_CustomerDebit()
        {
            EfCustomerDebitDal customerDebitDal = new EfCustomerDebitDal();
            CustomerDebit customerDebit = new CustomerDebit
            {
                CustomerDebitStatus = true,
                CustomerID = 1,
                DebitID = 1,
                DebitTotal = 450,
                RegistrationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            var result = customerDebitDal.Add(customerDebit);
            Assert.IsNotNull(result);
        }
    }
}
