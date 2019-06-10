using IMS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMS.Invoice
{
    public class Tax : Sale
    {
        private const double GST = 1.10;
        private Customer _customer;
        private string _paymentId;

        public  Tax(Sale saleInvoice, Customer customer, string paymentId) : base(saleInvoice.Id,saleInvoice.SaleRep, saleInvoice.BuyVehicle,saleInvoice.TradeVehicle)
        {
            _paymentId = paymentId;
            _customer = customer;

            foreach (Addon a in saleInvoice.Addon)
            {
                Add(a);
            } 
        }

        public override string View
        {
            get
            {
                string s1 = base.View;
                s1 += "\n\n********TAX INVOICE************\n";
                s1 += "CUSTOMER DETAILS: " + Customer.View;
                s1 += "----------------------------------------------------------\n"; 
                s1 += "Payment ID: " + PaymentId + "\n"
                    + "Payment Status: PAID\n";
                s1 += "----------------------------------------------------------\n";
                s1 += "\nSubTotal: \n"
                    + "    Base (inc GST): " + VehicleCost + "\n"
                    + "    Rebate: " + base.TradeRebateCost + "\n"
                    + "    Addon(s) (inc GST): " + AddonCost + "\n";
                s1 += "Tax Total (inc GST): " + TotalCost + "\n";        
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

        public new double VehicleCost
        {
            get
            {
                return base.VehicleCost * GST;
            }
        }

        public new double AddonCost
        {
            get
            {
                return base.AddonCost * GST;
            }
        }

        public Customer Customer
        {
            get
            {
                return _customer;
            }
        }

        public new double TotalCost
        {
            get
            {
                return base.TotalCost * GST;
            }
        }
    }
}
