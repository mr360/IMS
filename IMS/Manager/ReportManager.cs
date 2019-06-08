using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Report;

namespace IMS.Manager
{
    public sealed class ReportManager : Manager,IManager
    {
        /// <summary>
        /// Interacts with the database through the report manager
        /// Allows accessing of report specific methods
        /// Add, delete, remove, update and retreival of reports done via this manager 
        /// </summary>
        private static ReportManager _instance;

        public static ReportManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("Report Manager not created");
                }
                return _instance;
            }
        }

        public static void Create(string rtable, Database db)
        {
            if (_instance == null)
            {
                _instance = new ReportManager(rtable, db);
            }
        }

        private ReportManager(string rtable, Database db) : base(rtable,db)
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
