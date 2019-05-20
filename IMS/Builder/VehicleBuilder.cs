using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;

namespace IMS
{
    struct Order
    {
        public Vehicle vehicle;
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
            _manager.Add("Bay", bm);
        }

        public string Add(string vehicleId)
        {
            // Use the manager to look for the vehicle id
            // if not found send msg
            // if found save in order

        }

        public string Add(List<string> addon)
        {
            // if vehicle has not been added stop adding addons
            if (_order.vehicle == null) 
            {
                return "No vehicle selected.";
            }

            foreach( string id in addon)
            {
                _order.addons.Add()
            }
            
           
            // Use the manager to look for the addon ids
            // if not found send msg
            // if found save in order via loop

        }

        public override Object Prepare()
        {
            throw new NotImplementedException();
        }


    }
}
