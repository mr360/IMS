using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject
{
    public  abstract class DbObject
    {
        private string _id;

        public DbObject(string id)
        {
            _id = id;
        }

        public string Id
        {
            get 
            {
                return _id;
            }
        }

        public abstract string View { get; }
         
    }
}
