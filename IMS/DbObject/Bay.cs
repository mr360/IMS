using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject
{
    public class Bay : DbObject
    {
        private string _vehicleId; 
        public Bay(string id) : base(id)
        {

        }

        public override string View
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Vehicle 
        {
            get 
            {
                    return _vehicleId;
            }

            set 
            {
                    _vehicleId = value;
            }
        }

    }
}
