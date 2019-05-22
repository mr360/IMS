using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMS.Invoice
{
    public class Tax : Invoice
    {
        string _paymentId;

        public  Tax(Sale saleInvoice, Customer customer, string paymentId) : base(saleInvoice.Id,saleInvoice.SaleRep)
        {
            _paymentId = paymentId;
            _customer = customer;

            _date = saleInvoice.Date;
            _buyVehicle = saleInvoice.BuyVehicle;
            _tradeVehicle = saleInvoice.TradeVehicle;
            _addon = saleInvoice.Addon;
        }

        public override string View
        {
            get
            {
                string s1 = "********TAX INVOICE************\n";
                s1 = base.View;
                s1 += "CUSTOMER DETAILS: " + _customer.View + "\n";
                s1 += "----------------------------------------------------------\n";
                s1 += "Payment ID: " + _paymentId + "\n"
                    + "Payment Status: PAID\n";
                s1 += "----------------------------------------------------------\n";
                s1 += "\nSubTotal: \n"
                    + "    Base (inc GST): " + VehicleCost + "\n"
                    + "    Rebate: " + TradeRebateCost + "\n"
                    + "    Addon(s) (inc GST): " + AddonCost + "\n";
                s1 += "Tax Total (inc GST): " + TotalCost;            
                return s1;
            }
        }

        public string PaymentId
        {
            get
            {
                return _paymentId;
            }
        }

        public override double VehicleCost
        {
            get
            {
                return base.VehicleCost * 1.10;
            }
        }

        public override double AddonCost
        {
            get
            {
                return base.AddonCost * 1.10;
            }
        }

    }
}
