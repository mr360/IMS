using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject.User
{
    public abstract class User : DbObject
    {
        private string _name;

        public User(string id, string name) : base(id)
        {
            _name = name;
        }

        public Type AccountType 
        { 
            get
            {
                return this.GetType();
            } 
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
