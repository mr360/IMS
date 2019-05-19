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

        public Customer(string id, string name, string address) : base(id, name)
        {
            _address = address;
        }

        public override string View
        {
            get
            {
                return "Customer :" + Name + " | Address: " + Address + "\n";
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }
    }
}
