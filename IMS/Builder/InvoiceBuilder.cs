using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Invoice;
using IMS.Tools;

namespace IMS
{
    public enum InvoiceType { Sale, Tax };
}

namespace IMS.Builder
{
    /// <summary>
    /// Tasked with assembling the either a tax or sale invoice based off
    /// of the inputted data.
    /// </summary>
    public class InvoiceBuilder
    {
        private Order _order;
        private Staff _saleRep;
        private Customer _customer;
        private InvoiceType _invoiceType;
        private string _paymentId;
        private Sale _saleInvoice;

        public InvoiceBuilder()
        {
            _order.addons = new List<Addon>();
        }

        public string PaymentId
        {
            set
            {
                if (value != "")
                {
                    _paymentId = value;
                }
            }
        }
        public InvoiceType Invoice
        {
            set
            {
                _invoiceType = value;
            }
        }
        public Staff Staff
        {
            set
            {
                if (value.Role == JobRole.Sale)
                {
                    _saleRep = value;
                }
            }
        }

        public Customer Customer
        {
            set
            {
                _customer = value;
            }
        }
        public Order Order
        {
            set
            {
                _order = value;
            }
        }

        public Sale SaleInvoice
        {
            set
            {
                _saleInvoice = value;
            }
        }

        public Object Prepare()
        {
            switch (_invoiceType)
            {
                case InvoiceType.Sale:
                    return GenerateSale();
                case InvoiceType.Tax:
                    return GenerateTax();
                default:
                    return null;
            }
        }

        private Sale GenerateSale()
        {
            if (_order.buyVehicle == null || _saleRep == null)
            {
                throw new System.ArgumentException("Invalid code path. Need to declare builder parameters!");
            }

            Sale sInvoice = new Sale(IdGenerator.UniqueId(), _saleRep, _order.buyVehicle, _order.tradeVehicle);
            foreach (Addon a in _order.addons)
            {
                sInvoice.Add(a);
            }

            return sInvoice;
        }

        private Tax GenerateTax()
        {
            if (_saleInvoice == null || _customer == null || String.IsNullOrEmpty(_paymentId))
            {
                throw new System.ArgumentException("Invalid code path. Need to declare builder parameters!");
            }

            Tax tInvoice = new Tax(_saleInvoice, _customer, _paymentId);
            return tInvoice;
        }
    }
}
