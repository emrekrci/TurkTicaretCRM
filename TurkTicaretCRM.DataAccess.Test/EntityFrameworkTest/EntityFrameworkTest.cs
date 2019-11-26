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
       public void Get_All_Returns_All_Products()
        {
            EfCustomerDal customer = new EfCustomerDal();
            var result = customer.GetList();

            Assert.AreEqual(1, result.Count);
        }
    }
}
