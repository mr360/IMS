using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Report;

namespace IMS.Manager
{
    public class ReportManager : Manager,IManager
    {
        public ReportManager(string rtable, Database db) : base(rtable,db)
        {
            //_db = db;
        }

        public override string Add(DbObject item)
        {
            Report.Report r = item as Report.Report;
            try
            {
                if (String.IsNullOrEmpty(r.Id))
                {
                    return "The report does not have all information details.";
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Not of type Report", e);
            }

            return _db.Create(item);
        }
    }
}
