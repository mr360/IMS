using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;
using IMS.Invoice;
using IMS;
using IMS.Tools;
namespace IMS
{
    public enum ReportType { Addon, TradeIn, Sale};
}

namespace IMS.Builder
{
    /// <summary>
    /// Parses the stored invoices to build either an addon, trade-in or sales 
    /// report based off of user inputs.
    /// </summary>
    public class ReportBuilder
    {
        private string _name;
        private DateTime _periodStart;
        private DateTime _periodEnd;
        private ReportType _reportType;

        private double _totalPrice;
        private int _amountOfSale;

        Report.Report _report;
        Dictionary<string, IManager> _manager;

        public ReportBuilder(Dictionary<string, IManager> manager)
        {
            _manager = manager;
        }

        public void Period(string start, string end)
        {
            try
            {

                _periodStart = Convert.ToDateTime(start);
                _periodEnd = Convert.ToDateTime(end);
            }
            catch
            {
                _periodStart.AddYears(1);
                _periodEnd.AddYears(1);
            }
        }

        public string Name
        {
            set
            {
                if (ValidateIMS.IsBad(value, @"^[a-zA-Z0-9]+$"))
                {
                    _name = null;
                }
                _name = value;
            }
        }
        public ReportType Type
        {
            set
            {
                _reportType = value;
            }
        }
        public string Prepare()
        {
            if (_periodStart.Year == 1 || _periodEnd.Year == 1 || String.IsNullOrEmpty(_name))
            {
                return "Fail.Need to enter correct values for report building.";
            }

            List<DbObject> lInvoiceList = _manager["Invoice"].RetrieveMany("tax");
            _amountOfSale = lInvoiceList.Count();

            foreach (Tax tInvoice in lInvoiceList)
            {
                if (!ValidDateRangeCheck(tInvoice, _periodStart, _periodEnd)) continue;
                switch (_reportType)
                {
                    case ReportType.Addon:
                        _totalPrice += tInvoice.AddonCost;
                        break;
                    case ReportType.Sale:
                        _totalPrice += tInvoice.TotalCost;
                        break;
                    case ReportType.TradeIn:
                        _totalPrice += tInvoice.TradeRebateCost;
                        break;
                }

            }

            _report = new Report.Report(IdGenerator.UniqueId(), _name, _reportType, _periodStart, _periodEnd);
            _report.TotalSalePrice = _totalPrice;
            _report.AmountOfSale = _amountOfSale;
            return "Success";

        }

        private bool ValidDateRangeCheck(Invoice.Invoice t, DateTime start, DateTime end)
        {
            int lStart = t.Date.CompareTo(start);
            int lEnd = t.Date.CompareTo(end);

            // Less than zero ; earlier date
            // Greater than zero; later date
            if (lStart >= 0 && lEnd <= 0) return true;
            return false;
        }

        public Report.Report Report
        {
            get
            {
                return _report;
            }
        }
    }
}
