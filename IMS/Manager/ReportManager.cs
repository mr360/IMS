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
        /// <summary>
        /// Interacts with the database through the report manager
        /// Allows accessing of report specific methods
        /// Add, delete, remove, update and retreival of reports done via this manager 
        /// </summary>
        public ReportManager(string rtable, Database db) : base(rtable,db)
        {
        }

        public override string Add(DbObject item)
        {
            Report.Report r = item as Report.Report;
            
            if (r == null)
            {
                throw new NullReferenceException("Not of type Report");
            }

            if (_db.Create(item))
            {
                return "Successfully added report.";
            }

            return "Duplication! Report already exists. ID:" + item.Id;
        }
    }
}
