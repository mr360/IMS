using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public struct CreditCard
    {
        string cardNumber;
        int expirationDate;
        int cardCode;
    }

}

namespace IMS.Payment
{
    public class PaymentProcessor
    {
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
