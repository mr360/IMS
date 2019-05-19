﻿using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public enum VType { TradeIn, New};
}

namespace IMS.Invoice
{
    public class Sale : Invoice
    {
        protected Vehicle _buyVehicle;
        protected Vehicle _tradeVehicle;
        protected List<Addon> _addon;

        public Sale(string id, Staff saleRep, Vehicle buy) : base(id, saleRep)
        {
            _buyVehicle = buy;
        }

        public Sale(string id, Staff saleRep, Vehicle buy, Vehicle trade) : this(id, saleRep, buy)
        {
            _tradeVehicle = trade;
        }

        public bool Add(Addon a)
        {
            if (_buyVehicle == null || _addon.Contains(a)) return false;
            _addon.Add(a);
            return true;
        }

        public bool Add(VType type, Vehicle vehicle)
        {
            if (type != VType.New || type != VType.TradeIn || vehicle == null)
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

        public override double TotalCost
        {
            get
            {
                return VehicleCost + TradeRebateCost + AddonCost;
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
                foreach (Addon a in _addon)
                {
                    c += a.Price;
                }

                return c;
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

        public override string View
        {
            get
            {
                string s1 = "********SALE INVOICE************\n";
                s1 = base.View;
                s1 += "----------------------------------------------------------\n";
                s1 += "Base Vehicle : " + _buyVehicle.View + 
                      "TradeIn Vehicle" + _tradeVehicle.View + 
                      "Addons: " + ViewAllAddon;

                s1 += "SubTotal: \n"  
                    + "    Base: " + VehicleCost + "\n"
                    + "    Rebate: " + TradeRebateCost + "\n"
                    + "    Addon(s): " + AddonCost + "\n";
                s1 += "Sale Total: " + TotalCost;
                return s1;
            }
        }

    }
}
