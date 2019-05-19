using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMS.Invoice;
using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Invoice.Tests
{
    [TestClass()]
    public class SaleTests
    {
        Sale si01 = new Sale("SI0001", new Staff("S0001", "Steve", JobRole.Sale), new Vehicle("V00001", Brand.Audi, "MX-60", new DateTime(2008, 01, 01), 125000.00));

        [TestMethod()]
        public void SaleTest()
        {
            si01.Add
        }

        [TestMethod()]
        public void SaleTest1()
        {
            Assert.Fail();
        }
    }
}