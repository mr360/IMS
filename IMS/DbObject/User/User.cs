using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.User
{
    public abstract class User : DbObject
    {
        private string _name;

        public User(string id, string name) : base(id)
        {
            _name = name;
        }

        public string Name 
        { 
            get
            {
                return _name;
            }
        }


    }
}
