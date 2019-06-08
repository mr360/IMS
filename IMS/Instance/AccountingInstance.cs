using IMS.User;
using IMS.Manager;
using IMS.Invoice;
using IMS.Payment;
using IMS.Builder;
using IMS.Tools;

namespace IMS.Instance
{
    /// <summary>
    ///  Supports the entering of sales invoices, retrieving/creating of new/existing customers, 
    ///  processing of payment and development of a tax invoice.
    /// </summary>
    public class AccountingInstance : Instance
    {
        private Sale _sInvoice;
        private Customer _customer;
        private Tax _tInvoice;

        public AccountingInstance(Staff s, InvoiceManager im, UserManager um, VehicleManager vm) : base (im, um, vm)
        {
            if (s.Role != JobRole.Accounting)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create accounting instance!");
            }
        }

        /// <summary>
        ///  Get the the users invoice id so that the sales invoice can be retreived.
        /// </summary>
        public string Invoice(string invoiceId)
        {
            _sInvoice = _manager["Invoice"].Retrieve(invoiceId) as Sale;

            if (_sInvoice == null)
            {
                return "The sale invoice cannot be found.";
            }

            return "Success.";
        }

        public Customer Customer
        {
            set
            {
                _customer = value;
            }
        }

        /// <summary>
        /// Process the payment and produces a tax invoice  
        /// </summary>
        public string CreatePayment(CreditCard card)
        {
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

            string msg = _manager["Invoice"].Update(_tInvoice);

            if (msg != "Successfully updated.")
            {
                return msg;
            }
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
