using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Report
{
    public class Report : DbObject
    {
        private string _name;
        private DateTime _periodStart;
        private DateTime _periodEnd;
        private ReportType _reportType = ReportType.None;

        private double _totalSalePrice;
        private double _amountOfSale;

        public Report(string id,string name, ReportType rType, DateTime periodStart, DateTime periodEnd) : base(id)
        {
            _name = name;
            _periodStart = periodStart;
            _periodEnd = periodEnd;
            _reportType = rType;
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

        public ReportType Type
        {
            get
            {
                return _reportType;
            }
        }
        public double TotalSalePrice { get; set; }
        public double AverageSalePrice 
        {
            get 
            { 
                return TotalSalePrice / AmountOfSale; 
            } 
        }

        public int AmountOfSale { get; set; }

        public override string View
        {
            get
            {
                string reportType = _reportType.ToString();
                string ss = "**************" + reportType + "Report **************\n"
                          + "Report Title: " + Name + "\n"
                          + "Start Period: " + PeriodStart + "\n"
                          + "End Period: " + PeriodEnd + "\n"
                          + "-----------------------------------------------------\n"
                          + reportType + " #: " + AmountOfSale + "\n"
                          + "Average " + reportType + " #: " + AverageSalePrice + "\n"
                          + "Total " + reportType + " #: " + TotalSalePrice + "\n";
                return ss;
            }
        }
    }
}
