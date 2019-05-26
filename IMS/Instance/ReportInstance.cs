using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Manager;
using IMS.Builder;

namespace IMS.Instance
{
    /// <summary>
    /// Supports the managements staff requirments, such as viewing and creating reports.
    /// </summary>
    public class ReportInstance : Instance
    {
        public ReportInstance(Staff s, ReportManager rm, InvoiceManager im) : base(rm,im)
        {
            if (s.Role != JobRole.Management)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create report instance!");
            }
        }

        public string CreateReport(string reportName, string periodStart, string periodEnd, ReportType rType)
        {
            ReportBuilder rBuild = new ReportBuilder(_manager);
            rBuild.Name = reportName;
            rBuild.Period(periodStart, periodEnd);
            rBuild.Type = rType;

            string lOutputMsg = rBuild.Prepare();
            if (lOutputMsg == "Success")
            {
                Report.Report lReport = rBuild.Report;
                if (lReport != null)
                {
                    lOutputMsg = _manager["Report"].Add(lReport);
                } 
            }
            return lOutputMsg;
        }

        public string ViewSelectedReport(string reportId)
        {
            Report.Report lSelectedReport = _manager["Report"].Retrieve(reportId) as Report.Report;
            if (lSelectedReport == null)
            {
                return "Please select a report.";
            }
            return lSelectedReport.View;
        }

        public List<string> GetReportList 
        { 
            get
            {
                return _manager["Report"].GetIDs;
            }
        }
        
    }
}
