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
        private double _totalCost;
        private Staff _salerep;
        
        private Vehicle _buyVehicle;
        private Vehicle _tradeVehicle;
        private List<Addon> _addon;

        public Invoice(string id, Staff saleRep, Vehicle buy) : base(id)
        {
            _date = DateTime.Now;
            _buyVehicle = buy;
            _salerep = saleRep;
        }

        public string Date
        {
            get
            {
               return _date.ToShortDateString();
            }
        }

        public virtual double Cost
        {
            get
            {
                return _totalCost = VehicleCost;
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

        public double VehicleCost
        {
            get
            {
                return _buyVehicle.Price;
            }
        }

        public double TradeRebateCost
        {
            get
            {
                return (-(_tradeVehicle.Price * 0.25));
            }
        }

        public double AddonCost
        {
            get
            {
                double c = 0.0;
                foreach(Addon a in _addon)
                {
                    c += a.Price;
                }

                return c;
            }
        }
    }
}
