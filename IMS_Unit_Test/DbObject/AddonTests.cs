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
    public class AddonTests
    {
        Addon a1 = new Addon("A0001", "BodyKit3", "The latest bodykit with seven carbon atoms", 155.0);

        [TestMethod()]
        public void AddonAddCompatibleTest()
        { 
            bool status = a1.AddCompatible("V0001");
            Assert.AreEqual(true, status);
        }

        [TestMethod()]
        public void AddonAddDuplicateCompatibleTest()
        {
            bool status =  a1.AddCompatible("V0002");
            status = a1.AddCompatible("V0002");

            Assert.AreEqual(false, status);
        }


        [TestMethod()]
        public void AddonCheckCompatibleTrueTest()
        {
            bool status = a1.AddCompatible("V0005");
            status = a1.IsCompatible("V0005");

            Assert.AreEqual(true, status);
        }

        [TestMethod()]
        public void AddonCheckCompatibleFalseTest()
        {
            bool status = a1.AddCompatible("V0005");
            status = a1.IsCompatible("V0009");

            Assert.AreEqual(false, status);
        }

        [TestMethod()]
        public void AddonPriceTest()
        {
        }

        [TestMethod()]
        public void AddonDescTest()
        {
        }

        [TestMethod()]
        public void AddonNameTest()
        {
        }

        [TestMethod()]
        public void AddonViewTest()
        {
        }

        [TestMethod()]
        public void AddonDeleteCompatibleTest()
        {
        }

    }
}