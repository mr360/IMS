using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Invoice;
using IMS.User;

namespace IMS.Manager
{
    public class InvoiceManager : Manager, IManager
    {
        public InvoiceManager(string itable, Database db) : base(itable, db)
        {
            //_db = db;
        }

        public override string Add(DbObject item)
        {
            Invoice.Invoice i = item as Invoice.Invoice;
            try
            {
                if (String.IsNullOrEmpty(i.Id) || i.SaleRep == null)
                {
                    return "The addon does not have all information details.";
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Not of type Invoice", e);
            }

            return _db.Create(item);
        }
    }
}
