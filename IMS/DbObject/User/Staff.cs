using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public enum JobRole {Sale, Garage, Accounting, Management};
}
namespace IMS.User
{
    public class Staff : User
    {
        private JobRole _role;

        public Staff(string id, string name, JobRole role) : base(id, name)
        {
            _role = role;
        }

        public override string View
        {
            get
            {
                return "Staff :" + Name + " | Role: " + Role + "\n";
            }
        }

        public JobRole Role
        {
            get 
            {
                return _role;
            }
        }
    }
}
