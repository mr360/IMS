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
            DateTime vYear = new DateTime(2008); double vPrice = 126000.00;
            return  new Vehicle("V00001", Brand.Audi, "MX-60", vYear, vPrice);
        }

        /*
            v1.Brand;
            v1.Id;
            v1.Model;
            v1.Price;
            v1.Year;
            v1.View;
         */
        [TestMethod()]
        public void VehicleTestID()
        {
            Vehicle v1 = Setup();
            Assert.Equals(v1.Id, "V00001");
        }
        
        [TestMethod()]
        public void VehicleTestBrand()
        {
            Vehicle v1 = Setup();
            Assert.Equals(v1.Id, Brand.Audi);
        }

        [TestMethod()]
        public void VehicleTestModel()
        {
            Vehicle v1 = Setup();
            Assert.Equals(v1.Id, "MX-60");
        }

        [TestMethod()]
        public void VehicleTestYear()
        {
            Vehicle v1 = Setup();
            Assert.Equals(v1.Id, 2008);
        }

        [TestMethod()]
        public void VehicleTestPrice()
        {
            Vehicle v1 = Setup();
            Assert.Equals(v1.Price, 126000.00);
        }


    }
}