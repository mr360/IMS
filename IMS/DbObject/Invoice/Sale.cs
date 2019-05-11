using IMS.DbObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.Invoice
{
    public class Sale : Invoice
    {
        public Sale(string id, Staff saleRep, Vehicle buy) : base(id, saleRep, buy)
        {
        }

        public Sale(string id, Staff saleRep, Vehicle buy, Vehicle trade) : this(id, saleRep, buy)
        {
            
        }

    }
}
