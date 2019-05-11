using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.DbObject.User;

namespace IMS.DbObject.Invoice
{
    public class Tax : Invoice
    {
        /*public  Tax(Sale saleInvoice) : base(saleInvoice.Id,saleInvoice.SaleRep,saleInvoice.Vehicle)
        {

        } */
        public Tax(string id, Staff saleRep, Vehicle buy) : base(id, saleRep, buy)
        {
        }
    }
}
