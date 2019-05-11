using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.Report
{
    public class Report : DbObject
    {
        public Report(string id) : base(id)
        {
        }

        public override string View
        {
            get
            {
                return "The report contains the following information:";
            }
        }
    }
}
