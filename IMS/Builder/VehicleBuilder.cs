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
    public class VehicleBuilder : Builder
    {
        Dictionary<string, IManager> _manager;
        Order _order;

        public VehicleBuilder(VehicleManager vm,AddonManager am, BayManager bm)
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
                return "Successfully added.";
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

            return "Successfully added.";
        }

        public override Object Prepare()
        {
            if (_order.buyVehicle == null && _order.addons.Count == 0)
            {
                return null;
            }

            return _order;    
        }


    }
}
