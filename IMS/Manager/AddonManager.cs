using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class AddonManager : Manager, IManager
    {
        public AddonManager(string atable, Database db) : base(atable, db)
        {
            //_db = db;
        }

    }
}
