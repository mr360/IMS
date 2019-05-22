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
                s1 = base.View;
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

    }
}
