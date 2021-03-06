﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        Addon a1 = new Addon("A0001", "BodyKit3", "The latest bodykit with seven carbon atoms", 155.0);
        Sale si01 = new Sale("SI0001", s01 , v01);

        [TestMethod()]
        public void SaleDateTest()
        {
            Assert.AreEqual(DateTime.Now.ToShortDateString(), si01.Date);
        }

        [TestMethod()]
        public void SaleRepTest()
        {
            Assert.AreEqual("IMS.User.Staff", si01.SaleRep.ToString());
        }

        [TestMethod()]
        public void SaleAddAddonTest()
        {
            si01.Add(a1);
            Assert.AreEqual(155,si01.AddonCost);
        }

        [TestMethod()]
        public void SaleAddVehicleNewTest()
        {
            si01.Add(VType.New, v01);
            Assert.AreEqual(125000, si01.VehicleCost);
        }

        [TestMethod()]
        public void SaleAddVehicleTradeTest()
        {
            si01.Add(VType.TradeIn, v01);
            Assert.AreEqual(-31250, si01.TradeRebateCost);
        }

        [TestMethod()]
        public void SaleAddAddonDuplicateTradeTest()
        {
            bool status = si01.Add(a1);
            status = si01.Add(a1);
            Assert.AreEqual(false, status);
        }

      
        [TestMethod()]
        public void SaleVehicleCostTest()
        {
            Assert.AreEqual(125000, si01.VehicleCost);
        }

        [TestMethod()]
        public void SaleTradeCostTest()
        {
            si01.Add(VType.TradeIn, v01);
            Assert.AreEqual(-31250, si01.TradeRebateCost);
        }

        [TestMethod()]
        public void SaleAddonCostTest()
        {
            si01.Add(a1);
            Assert.AreEqual(155, si01.AddonCost);
        }

        [TestMethod()]
        public void SaleTotalCostTest()
        {
            Assert.AreEqual(125000, si01.TotalCost);
        }

        [TestMethod()]
        public void SaleViewAddonTest()
        {
            si01.Add(a1);
            Assert.AreEqual("Addon Name: BodyKit3| Desc: The latest bodykit with seven carbon atoms| Price: 155\n", si01.ViewAllAddon); ;
        }

        [TestMethod()]
        public void SaleViewTest()
        {
            Assert.AreEqual("it works", si01.View);
        }
    }
}