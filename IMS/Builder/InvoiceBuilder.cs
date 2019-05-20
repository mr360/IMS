using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Invoice;

namespace IMS
{
    public enum InvoiceType { Sale, Tax};
}

namespace IMS.Builder
{
    public class InvoiceBuilder
    {
        private Order _order;
        private Vehicle _tradeVehicle;
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

        public Vehicle TradeVehicle
        {
            set
            {
                _tradeVehicle = value;
            }

        }

        public Object Prepare()
        {
            switch(_invoiceType)
            {
                case InvoiceType.Sale : 
                    return GenerateSale();
                case InvoiceType.Tax : 
                    return GenerateTax();
                default: 
                    return null;
            }
        }

        private Sale GenerateSale()
        {
            // Sale Invoice Generation Check
            if (_order.buyVehicle == null || _order.addons.Count == 0 || _saleRep == null)
            {
                throw new System.ArgumentException("Invalid code path. Need to declare builder parameters!");
            }

            Sale sInvoice = new Sale(UniqueId(),_saleRep,_order.buyVehicle,_tradeVehicle);
            foreach (Addon a in _order.addons)
            {
                sInvoice.Add(a);
            }
            
            return sInvoice;
        }

        private Tax GenerateTax()
        {
            // Tax Invoice Generation Check
            if (_saleInvoice == null || _customer == null || _paymentId == null)
            {
                throw new System.ArgumentException("Invalid code path. Need to declare builder parameters!");
            }

            Tax tInvoice = new Tax(_saleInvoice,_customer,_paymentId);
            return tInvoice;
        }

        // https://stackoverflow.com/questions/11313205/generate-a-unique-id
        // Author: Ashraf Ali
        private string UniqueId()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(11)
                .ToList().ForEach(e => builder.Append(e));
            return builder.ToString();
        }
    }
}
