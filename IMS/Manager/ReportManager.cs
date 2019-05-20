using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    class ReportManager : Manager,IManager
    {
        public ReportManager(string rtable, Database db) : base(rtable,db)
        {
            //_db = db;
        }
       
    }
}
