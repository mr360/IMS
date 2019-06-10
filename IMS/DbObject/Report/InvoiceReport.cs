using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Report;

namespace IMS
{
    public enum ReportType { Addon, TradeIn, Sale };
}


namespace IMS.Report
{
    
    public class InvoiceReport : Report
    {
        private ReportType _reportType;
        private double _totalSalePrice;
        private double _amountOfSale;

        public InvoiceReport(string id, string name, ReportType rType, DateTime periodStart, DateTime periodEnd) : base(id, name, periodStart, periodEnd)
        {
            _reportType = rType;
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
                string ss = "**************" + reportType + " Report (Invoice)**************\n"
                    + base.View;
                ss += reportType + "  : " + AmountOfSale + "\n"
                    + "Average " + reportType + " Price: " + AverageSalePrice + "\n"
                    + "Total " + reportType + " Price: " + TotalSalePrice + "\n";
                return ss;
            }
        }

    }
}
