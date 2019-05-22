using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Manager;

namespace IMS.Instance
{
    public class ReportInstance : Instance
    {
        public ReportInstance(Staff s, ReportManager rm) : base(rm)
        {
            if (s.Role != JobRole.Management)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create instance!");
            }
        }

        public Report.Report Report(string reportId)
        {
            throw new NotImplementedException();
        }
        public string ViewReportList { get; }
        
    }
}
