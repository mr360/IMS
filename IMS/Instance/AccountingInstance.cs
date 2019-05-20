using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;

namespace IMS.Instance
{
    public class AccountingInstance
    {
        public AccountingInstance(Staff s)
        {
            if (s.Role != JobRole.Accounting)
            {
                throw new System.ArgumentException("Invalid User! Cannot create instance!");
            }
        }

        public string Invoice(string invoiceId)
        {
            //get invoice ; make sure its not empty
            // get from manager ; if no found return err
        }

        public string CustomerLocate(string customerId)
        {
            // get customer id ; make sure its not empty
            // get frin manger; if no found return err
        }

        public string CreateCustomer(Customer c)
        {
            // get customer ; make sure not null
            // send to manager ; if err return err
        }

        public string CreatePayment()
        {
            // check everything is ready // validate
            // use invoice to get price total 
            // send to pay
            // get payid
            // create invoice thro invoicebuilder tax
            // get invoice tax id


        }

        public string ViewTax
        {
            get
            {
                return "Tax Reciept";
            }
        }
    }
}
