using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Manager;

namespace IMS.Instance
{
    public class GarageInstance : Instance
    {
        public GarageInstance(Staff s, VehicleManager vm, AddonManager am, BayManager bm) : base(vm, am, bm)
        {
            if (s.Role != JobRole.Garage)
            {
                throw new System.ArgumentException("Invalid User! Cannot create instance!");
            }
        }

        public string Add(Vehicle v)
        {
            // put this in the VehicleManager Add section
            if (v.Id == "" || v.Model == "" || v.Price == 0.00 || v.Year == "")
            {
                return "The vehicle does not have all information detailed.";
            }

            return _manager["Vehicle"].Add(v);
        }

        public string Add(Addon a)
        {
            // put this in the AddonManager Add section
            if (a.Id == "" || a.Name == "" || a.Desc == "")
            {
                return "The addon does not have all information details.";
            }
            return _manager["Addon"].Add(a);
        }

        public string ViewTasks
        {
            get
            {
                string ss = "";
                ss += "SOLD VEHICLES THAT NEED TO BE REMOVED: \n";
                // foreach vehicle in Vehicle Manager and tax-invoice vehicles, show as sold and need to remove from bay
                ss += "UNALLOCATED VEHICLES THAT NEED TO BE ADDED TO BAYS: \n";
                // foreach vehicle in Vehicle Manager and Bay Manager that does not have allocation, show and need to add to bay
                ss += "TRADE-IN VEHICLES THAT NEED TO BE ADDED TO INVENTORY: \n";
                // foreach each trade in vehicle in tax-invoices not in vehicle manager, show and add to system

                return ss;
            }
        }


        List<string> SoldVehicle
        {
            get
            {
                // foreach vehicle in Vehicle Manager and tax-invoice vehicles, show as sold and need to remove from bay
                throw new NotImplementedException();
            }
        }

        List<string> UnallocatedVehicle
        {
            get
            {
                // foreach vehicle in Vehicle Manager and Bay Manager that does not have allocation, show and need to add to bay
                throw new NotImplementedException();
            }
        }

        List<string> NonProcessedTradeInVehicle
        {
            get
            {
                // foreach each trade in vehicle in tax-invoices not in vehicle manager, show and add to system
                throw new NotImplementedException();
            }
        }

        public string ViewOpenBays
        {
            get
            {
                // show bays that are open
                return "";
            }
        }

        public string AssignVehicleToBay(string bayId, string vehicleId)
        {
            // Check if vehicleid of vehicle exists (vehicle manager)
            // Check if bayid exists in Bay Manager (bay manager)
            // Get vehicle id and bayId
            // check if bay has the vehicle and check if vehicle isn't in multiple bays (probs do this in BayManager)
        }

        public bool RemoveVehicleFromBay(string bayId)
        {
            // remove vehicle id from bay

        }

        public bool RemoveSoldVehicle(string bayId)
        {
            //remove vehicle from inventory
            // remove vehicle from bay
            RemoveVehicleFromBay(bayId);
        }
    }
}
