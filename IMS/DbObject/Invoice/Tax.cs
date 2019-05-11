using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.Invoice
{
    public class Tax : Invoice
    {
        public  Tax(Sale saleInvoice) : base(saleInvoice.Id,saleInvoice.SaleRep,saleInvoice.Vehicle)
        {

        } 
    }
}
