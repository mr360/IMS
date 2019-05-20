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
           // si01.Date
        }

        [TestMethod()]
        public void SaleRepTest()
        {
            //si01.SaleRep
        }

        [TestMethod()]
        public void SaleAddAddonTest()
        {

        }

        [TestMethod()]
        public void SaleAddVehicleNewTest()
        {

        }

        [TestMethod()]
        public void SaleAddVehicleTradeTest()
        {

        }

        [TestMethod()]
        public void SaleAddAddonDuplicateTradeTest()
        {

        }

        [TestMethod()]
        public void SaleAddVehicleNewDuplicateTest()
        {

        }

        [TestMethod()]
        public void SaleAddVehicleTradeDuplicateTest()
        {

        }

        [TestMethod()]
        public void SaleVehicleCostTest()
        {

        }

        [TestMethod()]
        public void SaleTradeCostTest()
        {

        }

        [TestMethod()]
        public void SaleAddonCostTest()
        {

        }

        [TestMethod()]
        public void SaleTotalCostTest()
        {

        }

        [TestMethod()]
        public void SaleViewAddonTest()
        {

        }

        [TestMethod()]
        public void SaleViewTest()
        {

        }
    }
}