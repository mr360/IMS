using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;

namespace IMS
{
    public struct Order
    {
        public Vehicle buyVehicle;
        public List<Addon> addons;
    }
}

namespace IMS.Builder
{
    public class VehicleBuilder
    {
        Order _order;
        Dictionary<string, IManager> _manager;

        public VehicleBuilder(IManager vm, IManager am)
        {
            _manager = new Dictionary<string, IManager>();
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);

            _order.addons = new List<Addon>();
        }

        public string Add(string vehicleId)
        {
            // Use the manager to look for the vehicle id
            // if not found send msg
            // if found save in order

            _order.buyVehicle = _manager["Vehicle"].Retrieve(vehicleId) as Vehicle;

            if (_order.buyVehicle != null)
            {
                return "Success.";
            }

            return "Cannot find the vehicle.";
        }

        public string Add(List<string> addon)
        {
            // if vehicle has not been added stop adding addons
            // Use the manager to look for the addon ids
            // if not found send msg
            // if found save in order via loop

            if (_order.buyVehicle == null) 
            {
                return "No vehicle selected.";
            }

            foreach( string id in addon)
            {
                Addon a = _manager["Addon"].Retrieve(id) as Addon;
                if (a == null)
                {
                    _order.addons.Clear();
                    return "The list of addons is corrupt.";
                }

                _order.addons.Add(a);
            }

            return "Success.";
        }

        public  Order Prepare()
        {
            if (_order.buyVehicle == null)
            {
                throw new System.ArgumentException("Invalid code path. Need to declare builder parameters!");
            }

            return _order;    
        }


    }
}
