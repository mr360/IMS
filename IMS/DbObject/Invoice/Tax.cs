using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.DbObject.User;

namespace IMS.DbObject.Invoice
{
    public class Tax : Invoice
    {
        string _paymentId;
        Sale _saleInvoice;
        Customer _customer;

        public  Tax(Sale saleInvoice, Customer customer, string paymentId) : base(saleInvoice.Id,saleInvoice.SaleRep)
        {
            _paymentId = paymentId;
            _saleInvoice = saleInvoice;
            _customer = customer;
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
                    + "Payment Status: PAID\n"
                    + "Tax Total (inc GST): " + TotalCost;
            
                return s1;
            }
        }

        public override double TotalCost
        {
            get
            {
                return _saleInvoice.TotalCost + (_saleInvoice.TotalCost * 1.10);
            }
        }
    }
}
