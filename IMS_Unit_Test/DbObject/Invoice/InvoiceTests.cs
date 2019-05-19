using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IMS.Invoice.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void InvoiceTest()
        {
           Invoice x = new Sale("", new User.Staff("","",JobRole.Sale), new Vehicle("", Brand.Audi, "", DateTime.Now, 10.00));
        }
    }
}