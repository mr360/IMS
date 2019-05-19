using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class Bay : DbObject
    {
        private string _vehicleId; 
        public Bay(string id) : base(id)
        {
            _vehicleId = null;
        }

        public override string View
        {
            get
            {
                // BayID | Available 
                return "Bay: " + Id + " | " + "Availablity: " + Available + "\n";
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

        public bool Available
        {
            get
            {
                return (_vehicleId == null); 
            }
        }

    }
}
