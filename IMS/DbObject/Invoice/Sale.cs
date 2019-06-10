using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMS.Invoice
{
    public class Sale : Invoice
    {
        private Vehicle _buyVehicle;
        private Vehicle _tradeVehicle;
        private List<Addon> _addon = new List<Addon>();

        public Sale(string id, Staff saleRep, Vehicle buy) : base(id, saleRep)
        {
            _buyVehicle = buy;
        }

        public Sale(string id, Staff saleRep, Vehicle buy, Vehicle trade) : this(id, saleRep, buy)
        {
            _tradeVehicle = trade;
        }


        public override string View
        {
            get
            {
                string s1 = "********SALE INVOICE************\n";
                s1 += base.View;
                s1 += "----------------------------------------------------------\n";
                s1 += "Base Vehicle : " + _buyVehicle.View;
                
                if (_tradeVehicle != null)
                {
                    s1 += "TradeIn Vehicle : " + _tradeVehicle.View;
                } 

                s1 += "Addons: \n" + ViewAllAddon;

                s1 += "\nSubTotal: \n"  
                    + "    Base: " + VehicleCost + "\n"
                    + "    Rebate: " + TradeRebateCost + "\n"
                    + "    Addon(s): " + AddonCost + "\n";
                s1 += "Sale Total: " + TotalCost;
                return s1;
            }
        }



        public bool Add(Addon a)
        {
            if (_buyVehicle == null || _addon.Contains(a)) return false;
            _addon.Add(a);
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
        public override double TotalCost
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
                foreach (Addon a in Addon)
                {
                    s1 += a.View;
                }

                return s1;
            }
        }

        public  double VehicleCost
        {
            get
            {
                return _buyVehicle.Price;
            }
        }


        public  double AddonCost
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
