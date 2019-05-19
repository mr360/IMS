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
    public class BayTests
    {
        [TestMethod()]
        public void BayAvailableFalseTest()
        {
            Bay b1 = new Bay("B00001");
            Assert.AreEqual(false,b1.Available);
        }

        [TestMethod()]
        public void BayAvailableTrueTest()
        {
            Bay b1 = new Bay("B00001");
            b1.Vehicle = "V00001";
            Assert.AreEqual(true, b1.Available);
        }
    }
}