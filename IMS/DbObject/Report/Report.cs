using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Report
{
    public abstract class Report : DbObject
    {
        private string _name;
        private DateTime _periodStart;
        private DateTime _periodEnd;


        public Report(string id, string name, DateTime periodStart, DateTime periodEnd) : base(id)
        {
            _name = name;
            _periodStart = periodStart;
            _periodEnd = periodEnd;

        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string PeriodStart
        {
            get
            {
                return _periodStart.ToShortDateString();
            }
        }

        public string PeriodEnd
        {
            get
            {
                return _periodEnd.ToShortDateString();
            }
        }

      
        public override string View
        {
            get
            {
                string ss 
                = "Report Title: " + Name + "\n"
                + "Start Period: " + PeriodStart + "\n"
                + "End Period: " + PeriodEnd + "\n"
                + "-----------------------------------------------------\n";

                return ss;
            }
        }
    }
}
