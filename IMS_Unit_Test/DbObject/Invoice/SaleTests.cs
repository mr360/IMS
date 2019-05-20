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
        static Vehicle v01 = new Vehicle("V00001", Brand.Audi, "MX-60", new DateTime(2008, 01, 01), 125000.00);
        static Staff s01 = new Staff("S0001", "Steve", JobRole.Sale);
        Sale si01 = new Sale("SI0001", s01 , v01);

        [TestMethod()]
        public void SaleDateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleRepTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddAddonTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddVehicleNewTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddVehicleTradeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddAddonDuplicateTradeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddVehicleNewDuplicateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddVehicleTradeDuplicateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleVehicleCostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleTradeCostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleAddonCostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleTotalCostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleViewAddonTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaleViewTest()
        {
            Assert.Fail();
        }
    }
}