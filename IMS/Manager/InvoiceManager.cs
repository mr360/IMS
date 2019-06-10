using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Invoice;
using IMS.User;

namespace IMS.Manager
{
    public sealed class InvoiceManager : Manager, IManager
    {
        /// <summary>
        /// Interacts with the database through the invoice manager
        /// Allows accessing of invoice specific methods
        /// Add, delete, remove, update and retreival of invoice done via this manager 
        /// </summary>

        private static InvoiceManager _instance;
        public static InvoiceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("Invoice Manager not created");
                }
                return _instance;
            }
        }

        public static void Create(string itable, Database db)
        {
            if (_instance == null)
            {
                _instance = new InvoiceManager(itable, db);
            }
        }
        private InvoiceManager(string itable, Database db) : base(itable, db)
        {
        }

        public override string Add(DbObject item)
        {
            Invoice.Invoice i = item as Invoice.Invoice;
            
            if (i == null)
            {
                throw new NullReferenceException("Not of type Invoice");
            }

            if (_db.Create(item))
            {
                return "Successfully added invoice.";
            }

            return "Duplication! Invoice already exists. ID:" + item.Id;
        }

        public override List<DbObject> RetrieveMany(string id)
        {
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
                    case "all":
                        lInvoice = _db.Read(ids) as Invoice.Invoice;
                        break;
                    default:
                        throw new ArgumentException("Needs to be either tax / sale or all");
                }

                if (lInvoice != null) lOutput.Add(lInvoice);
            }
            return lOutput;
        }
    }
}
