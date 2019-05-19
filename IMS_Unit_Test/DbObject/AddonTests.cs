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
        [TestMethod()]
        public void AddonAddCompatibleTest()
        {
            Addon a1 = new Addon("A0001", "BodyKit3", "The latest bodykit with seven carbon atoms", 155.0);
            //Add compatible vehicles 
            a1.AddCompatible("V0001");
            a1.AddCompatible("V0002"); 
        }

        [TestMethod()]
        public void AddonDeleteCompatibleTest()
        {
        }

        [TestMethod()]
        public void AddonCheckCompatibleTest()
        {
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

    }
}