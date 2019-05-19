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
    public class StaffTests
    {
        Staff s1 = new Staff("S0001", "Steve", JobRole.Sale);

        [TestMethod()]
        public void StaffAccountTypeTest()
        {
            Assert.AreEqual("IMS.User.Staff", s1.AccountType.ToString());
        }

        [TestMethod()]
        public void StaffRoleTest()
        {
            Assert.AreEqual(JobRole.Sale, s1.Role);
        }

        [TestMethod()]
        public void StaffViewTest()
        {
            Assert.AreEqual("Staff :Steve | Role: Sale\n", s1.View);
        }
    }
}