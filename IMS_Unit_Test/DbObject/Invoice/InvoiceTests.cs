using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMS.DbObject.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.Invoice.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void InvoiceTest()
        {
           Sale x = new Sale("", new User.Staff("","",JobRole.Sale), new Vehicle("", Brand.Audi, "", DateTime.Now, 10.00));
        }
    }
}