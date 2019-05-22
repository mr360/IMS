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
        protected DateTime _date;
        protected Staff _salerep;
        protected Customer _customer;
        
        protected Vehicle _buyVehicle;
        protected Vehicle _tradeVehicle;
        protected List<Addon> _addon = new List<Addon>();

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

        public Customer Customer
        {
            get
            {
                return _customer;
            }
        }

        public bool Add(Addon a)
        {
            if (_buyVehicle == null || _addon.Contains(a)) return false;
            _addon.Add(a);
            return true;
        }

        public bool Add(VType type, Vehicle vehicle)
        {
            if ((type != VType.New && type != VType.TradeIn) || vehicle == null)
            {
                return false;
            }

            if (type == VType.New)
            {
                _buyVehicle = vehicle;
            }
            else
            {
                _tradeVehicle = vehicle;
            }

            return true;
        }

        public Vehicle TradeVehicle
        {
            get
            {
                return _tradeVehicle;
            }
        }

        public Vehicle BuyVehicle
        {
            get
            {
                return _buyVehicle;
            }
        }

        public List<Addon> Addon
        {
            get
            {
                return _addon;
            }
        }
        public  double TotalCost
        {
            get
            {
                return VehicleCost + TradeRebateCost + AddonCost;
            }
        }
        public double TradeRebateCost
        {
            get
            {
                if (_tradeVehicle == null)
                {
                    return 0.00;
                }
                return (-(_tradeVehicle.Price * 0.25));
            }
        }

        public string ViewAllAddon
        {
            get
            {
                string s1 = "";
                foreach (Addon a in _addon)
                {
                    s1 += a.View;
                }

                return s1;
            }
        }

        public virtual double VehicleCost
        {
            get
            {
                return _buyVehicle.Price;
            }
        }


        public virtual double AddonCost
        {
            get
            {
                double c = 0.0;
                foreach (Addon a in _addon)
                {
                    c += a.Price;
                }

                return c;
            }
        }

    }
}
