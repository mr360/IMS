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
            _sInvoice = _manager["Invoice"].Retrieve(invoiceId) as Sale;

            if (_sInvoice == null)
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

        public string CreatePayment(CreditCard card)
        {
            // check everything is ready // validate
            // use invoice to get price total 
            // send to pay
            // get payid
            // create invoice thro invoicebuilder tax
            // get invoice tax id
            if (_customer == null || _sInvoice == null)
            {
                return "Need to declare payment parameters!";
            }

            string lResult = "";
            PaymentProcessor pProcessor = new PaymentProcessor();
            lResult = pProcessor.SetPaymentDetail(card);
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
            iBuild.Invoice = InvoiceType.Tax;
            iBuild.SaleInvoice = _sInvoice;
            iBuild.Customer = _customer;
            iBuild.PaymentId = paymentId;
            _tInvoice = iBuild.Prepare() as Tax;

            UpdateVehicleInventoryState();

            _manager["Invoice"].Add(_tInvoice);

            return "Payment Success.";
        }

        private void UpdateVehicleInventoryState()
        {
            // Add trade-in vehicle to vehicle list
            if (_tInvoice.TradeVehicle != null)
            {
                _manager["Vehicle"].Add(_tInvoice.TradeVehicle);
            }

            // Set vehicle as sold
            Vehicle baseVehicle = _manager ["Vehicle"].Retrieve(_tInvoice.BuyVehicle.Id) as Vehicle;
            baseVehicle.Sold = true;
            _manager ["Vehicle"].Update(baseVehicle);
        }

        public double ViewTotal
        {
            get
            {
                return _sInvoice.TotalCost * 1.10;
            }
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
