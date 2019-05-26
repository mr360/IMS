using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.User
{
    public class Customer : User
    {
        private string _address;
        private string _phone;

        public Customer(string id, string name, string address, string phone) : base(id, name)
        {
            _address = address;
            _phone = phone;
        }

        public override string View
        {
            get
            {
                return "Customer :" + Name + " | Address: " + Address + " | Phone: " + Phone + "\n";
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
    }
}
