using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.User.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        Customer c1 = new Customer("C0001", "Jackson", "25 Milwalki Street, CA, 80010");

        [TestMethod()]
        public void CustomerAccountTypeTest()
        {
            Assert.AreEqual("IMS.User.Customer", c1.AccountType.ToString());
        }

        [TestMethod()]
        public void CustomerIDTest()
        {
            Assert.AreEqual("C0001", c1.Id);
        }

        [TestMethod()]
        public void CustomerNameTest()
        {
            Assert.AreEqual("Jackson", c1.Name);
        }

        [TestMethod()]
        public void CustomerAddressTest()
        {
            Assert.AreEqual("25 Milwalki Street, CA, 80010", c1.Address);
        }

        [TestMethod()]
        public void CustomerViewTest()
        {
            Assert.AreEqual("Customer :Jackson | Address: 25 Milwalki Street, CA, 80010\n", c1.View);
        }
    }
}