using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;

namespace IMS.Instance
{
    public class GarageInstance
    {
        public GarageInstance(Staff s)
        {
            if (s.Role != JobRole.Garage)
            {
                throw new System.ArgumentException("Invalid User! Cannot create instance!");
            }
        }

        public string Add(Vehicle v)
        {

        }

        public string Add(Addon a)
        {

        }

        string ViewTasks
        {
            get;
        }

        string ViewOpenBays
        {
            get;
        }

        public string SetBay(string bayId, string vehicleId)
        {
            // Get vehicle id and bayId
        }

    }
}
