using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        Vehicle Setup()
        {
            DateTime vYear = new DateTime(2008, 01, 01);
            double vPrice = 126000.00;
            return  new Vehicle("V00001", Brand.Audi, "MX-60", vYear, vPrice);
        }

        [TestMethod()]
        public void VehicleTestID()
        {
            Vehicle v1 = Setup();
            Assert.AreEqual("V00001", v1.Id);
        }
        
        [TestMethod()]
        public void VehicleTestBrand()
        {
            Vehicle v1 = Setup();
            Assert.AreEqual(Brand.Audi, v1.Brand);
        }

        [TestMethod()]
        public void VehicleTestModel()
        {
            Vehicle v1 = Setup();
            Assert.AreEqual( "MX-60", v1.Model);
        }

        [TestMethod()]
        public void VehicleTestYear()
        {
            Vehicle v1 = Setup();
            Assert.AreEqual("2008",v1.Year);
        }

        [TestMethod()]
        public void VehicleTestPrice()
        {
            Vehicle v1 = Setup();
            Assert.AreEqual(126000.00, v1.Price);
        }

        [TestMethod()]
        public void VehicleTestView()
        {
            Vehicle v1 = Setup();
            Assert.AreEqual("Brand: Audi | Model: MX-60 | Year: 2008 | Price: 126000\n", v1.View);
        }
    }
}