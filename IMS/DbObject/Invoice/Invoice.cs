using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public enum VType { TradeIn, New };
}

namespace IMS.Invoice
{
    public abstract class Invoice : DbObject
    {
        private DateTime _date;
        private Staff _salerep;


        public Invoice(string id, Staff saleRep) : base(id)
        {
            _date = DateTime.Now;
            _salerep = saleRep;
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        public override string View
        {
            get
            {
                return "INVOICE ID: " + Id + "\n" +
                       "INVOICE DATE: " + Date.ToShortDateString() + "\n" +
                       "SALE REP: " + SaleRep.Name + " " + SaleRep.Id + "\n" +
                       "COMPANY : HTV VEHICLE PTD\n" +
                       "COMPANY ADDRESS : 25 Malvin Street, VIC, 3000\n";

            }
        }

        public Staff SaleRep
        {
            get
            {
                return _salerep;
            }
        }

        public abstract double TotalCost {get;}
    }
}
