using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Manager;
using IMS.Invoice;
using IMS.Payment;
using IMS.Builder;

namespace IMS.Instance
{
    public class AccountingInstance : Instance
    {
        Sale _sInvoice;
        Customer _customer;
        Tax _tInvoice;

        public AccountingInstance(Staff s, InvoiceManager im, UserManager um, VehicleManager vm) : base (im, um, vm)
        {
            if (s.Role != JobRole.Accounting)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create instance!");
            }
        }

        public string Invoice(string invoiceId)
        {
            //get invoice ; make sure its not empty
            // get from manager ; if no found return err
            Sale sInvoice = _manager["Invoice"].Retrieve(invoiceId) as Sale;

            if (sInvoice == null)
            {
                return "The sale invoice cannot be found.";
            }

            return "Success.";
        }

        public string CustomerLocate(string customerId)
        {
            // get customer id ; make sure its not empty
            // get frin manger; if no found return err
            _customer = _manager["User"].Retrieve(customerId) as Customer;

            if (_customer == null)
            {
                return "The customer cannot be found.";
            }

            return "Success.";
        }

        public string CreateCustomer(Customer c)
        {
            if (c.Name == "" || c.Address == "" || c.Id == "")
            {
                return "Customer is missing key details.";
            }
            _customer = c;
            return _manager["User"].Add(c);
        }

        public string CreatePayment(CreditCard c)
        {
            // check everything is ready // validate
            // use invoice to get price total 
            // send to pay
            // get payid
            // create invoice thro invoicebuilder tax
            // get invoice tax id
            if (_customer == null || _sInvoice == null)
            {
                throw new System.ArgumentException("Invalid code path. Need to declare payment parameters!");
            }

            string lResult = "";
            PaymentProcessor pProcessor = new PaymentProcessor();
            lResult = pProcessor.SetPaymentDetail(c);
            if (lResult != "VALID")
            {
                return "Payment details are not vaild.";
            }

            string paymentId = pProcessor.Pay(_sInvoice.TotalCost);
            if (paymentId == "ERROR")
            {
                return "An error occoured with the payment system. Unknown!.";
            }

            InvoiceBuilder iBuild = new InvoiceBuilder();
            iBuild.SaleInvoice = _sInvoice;
            iBuild.Customer = _customer;
            iBuild.PaymentId = paymentId;
            Tax tInvoice = iBuild.Prepare() as Tax;

            // Add trade-in vehicle to vehicle list
            _manager["vehicle"].Add(tInvoice.TradeVehicle);

            return _manager["Invoice"].Add(tInvoice);
        }

        public string ViewTax
        {
            get
            {
                if (_tInvoice == null)
                {
                    return "Tax Invoice : Not Available.";
                }
                return _tInvoice.View;
            }
        }
    }
}
