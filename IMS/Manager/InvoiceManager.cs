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

        public override List<DbObject> RetrieveMany(string id)
        {
            // Tax / Sale
            List<DbObject> lOutput = new List<DbObject>();
            List<string> lIdList = _db.GetIDs;
            foreach (string ids in lIdList)
            {
                Invoice.Invoice lInvoice = null;
                switch (id.ToLower())
                {
                    case "tax":
                        lInvoice = _db.Read(ids) as Tax;
                        break;
                    case "sale":
                        lInvoice = _db.Read(ids) as Sale;
                        break;
                    default:
                        throw new ArgumentException("Needs to be either tax or sale");
                }

                if (lInvoice != null) lOutput.Add(lInvoice);
            }
            return lOutput;
        }
    }
}
