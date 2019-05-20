using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    class BayManager : Manager, IManager
    {
        //private IDb _db;
        public BayManager(string btable, Database db) : base(btable, db)
        {
            //_db = db;
        }

    }
}
