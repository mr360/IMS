using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.Invoice
{
    public class Invoice : DbObject
    {
        public Invoice(string id) : base(id)
        {
        }

        public override string View
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
