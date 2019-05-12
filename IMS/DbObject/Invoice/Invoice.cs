using IMS.DbObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.Invoice
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

        public string Date
        {
            get
            {
               return _date.ToShortDateString();
            }
        }

        public override string View
        {
            get
            {
                return "INVOICE ID: " + Id + "\n" +
                       "INVOICE DATE: " + Date + "\n" +
                       "SALE REP: " + SaleRep.Name + " " + SaleRep.Id + "\n" +
                       "COMPANY : HTV VEHICLE PTD\n" +
                       "COMPANY ADDRESS : 25 Malvin Street, VIC, 3000\n" +
                       "----------------------------------------------------------\n";
            }
        }

        public Staff SaleRep
        {
            get
            {
                return _salerep;
            }
        }

        public virtual double TotalCost
        {
            get;
        }

    }
}
