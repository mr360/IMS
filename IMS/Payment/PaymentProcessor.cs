using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public struct CreditCard
    {
        public string cardNumber;
        public int expirationDate;
        public int cardCode;
    }

}

namespace IMS.Payment
{
    /// <summary>
    /// Deals with the processing of payment.
    /// Processes payment details and payment process using online vendor.
    /// </summary>
    public class PaymentProcessor
    {
        /// <summary>
        /// Processes the credit card details with an online vendor
        /// Vendor automatically checks whether it is a Visa, Mastercard..ect
        /// </summary>
        public string SetPaymentDetail(CreditCard c)
        {
            // Authorise with online retailer
            // https://developer.authorize.net/api/reference/index.html
            return "VALID";

        }

        public string Pay(double price)
        {
            // Pay with online retailer
            // https://developer.authorize.net/api/reference/index.html
            return "PAYID-1223456-Example";
        }
    }
}
