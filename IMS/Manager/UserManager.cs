using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    class UserManager : Manager,IManager
    {
        //private IDb _db;
        public UserManager(string utable, Database db) : base(utable, db)
        {
            //_db = db;
        }

    }
}
