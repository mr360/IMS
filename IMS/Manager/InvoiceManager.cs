using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    class InvoiceManager : Manager, IManager
    {
        public InvoiceManager(string itable, Database db) : base(itable, db)
        {
            //_db = db;
        }

    }
}
