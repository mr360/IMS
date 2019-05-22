using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMS.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Invoice;
using IMS.User;

namespace IMS.Builder.Tests
{
    [TestClass()]
    public class InvoiceBuilderTests
    {
        Order Setup()
        {
            Order order;
            order.buyVehicle = new Vehicle("V00001", Brand.Audi, "MX-60", new DateTime(2008, 01, 01), 126000.00);
            order.addons = new List<Addon>() { new Addon("A0001", "BodyKit3", "The latest bodykit with seven carbon atoms", 155.0) };
            return order;
        }
        [TestMethod()]
        public void InvoiceBuilderTest()
        {
            Staff saleRep = new Staff("QAD0001", "Shuayb", JobRole.Sale);
            Order order = Setup();

            InvoiceBuilder iBuild = new InvoiceBuilder();
            iBuild.Order = order;
            iBuild.Staff = saleRep;
            Sale sInvoice = iBuild.Prepare() as Sale;
            Assert.Fail();
        }
    }

}