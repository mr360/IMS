using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Manager;
using IMS.Invoice;

namespace IMS.Instance
{
    public class GarageInstance : Instance
    {
        string _vehicleId;
        string _addonId;

        public GarageInstance(Staff s, VehicleManager vm, AddonManager am, BayManager bm, InvoiceManager im) : base(vm, am, im, bm)
        {
            if (s.Role != JobRole.Garage)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create instance!");
            }
        }

        // Lot Class Candidate
        public List<string> GetOpenBayList
        {
            get
            {
                // Select bays that are unoccupied 
                List<DbObject> bList = _manager["Bay"].RetrieveMany("free");
                List<string> allBay = new List<string>();
                foreach (Bay b in bList)
                {
                    allBay.Add(b.Id);
                }

                return allBay;
            }
        }
        public List<string> GetSoldVehicleList
        {
            get
            {
                // Check each vehicle in inventory, to see if it is in a bay
                List<DbObject> vList = _manager["Vehicle"].RetrieveMany("sold");
                List<string> soldVehicle = new List<string>();

                // foreach vehicle in the inventory check if it is linked in a bay, if it is not then it is unallocated
                foreach (Vehicle v in vList)
                {
                    soldVehicle.Add(v.Id);
                }

                return soldVehicle;
            }
        }

        public List<string> GetUnallocatedVehicleList
        {
            get
            {
                // Check each vehicle in inventory, to see if it is in a bay
                List<string> vList = _manager["Vehicle"].GetIDs;
                List<DbObject> bList = _manager["Bay"].RetrieveMany("occupied");
                List<string> unallocatedVehicle = new List<string>(vList);

                // foreach vehicle in the inventory check if it is linked in a bay, if it is not then it is unallocated
                foreach (string v in vList)
                {
                    foreach (Bay b in bList)
                    {
                        if (v == b.Vehicle)
                        {
                            unallocatedVehicle.Remove(v);
                        }
                    }
                }

                return unallocatedVehicle;
            }
        }






        public string ViewAddAddon
        {
            get
            {
                Addon a = _manager["Addon"].Retrieve(_addonId) as Addon;
                if(a == null) return "";
                return a.View;
            }
        }

        public string ViewAddVehicle
        {
            get
            {
                Vehicle v = _manager["Vehicle"].Retrieve(_vehicleId) as Vehicle;
                if (v == null) return "";
                return v.View;
            }
        }

        public string Add(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return "Fail. No vehicle(null)";
            }

            if (ValidateIMS.IsBad(vehicle.Id, @"^[a-zA-Z0-9]+$") || ValidateIMS.IsBad(vehicle.Model, @"^[a-zA-Z0-9-]+$") || vehicle.Price < 0.00)
            {
                return "Fail. Not right format";
            }

            Vehicle v = _manager["Vehicle"].Retrieve(vehicle.Id) as Vehicle;
            if (v != null)
            {
                return "Fail. Already exists within system";
            }

            // If vehicle fails to be added to database we can try to find it in db when ViewVehicle
            _vehicleId = vehicle.Id;

            return _manager["Vehicle"].Add(vehicle);
        }

        public string Add(Addon addon)
        {
            if (addon == null)
            {
                return "Fail. No addon(null)";
            }

            if (ValidateIMS.IsBad(addon.Id, @"^[a-zA-Z0-9]+$") || ValidateIMS.IsBad(addon.Name, @"^[a-zA-Z0-9-]+$") || addon.Price < 0.00)
            {
                return "Fail. Not right format";
            }

            if (_manager["Vehicle"].Retrieve(addon.Compatible) == null)
            {
                return "Fail. No vehicle in inventory is compatible.";
            }

            // If addon fails to be added to database we can try to find it in db when ViewAddon
            _addonId = addon.Id;

            return _manager["Addon"].Add(addon);
        }


        public string AssignVehicleToBay(string vehicleId, string bayId)
        {
            Bay b = _manager["Bay"].Retrieve(bayId) as Bay;
            if (_manager["Vehicle"].Retrieve(vehicleId) == null || b == null)
            {
                return "Fail.One or more of the items does not exist within the system.";
            }
            
            b.Vehicle = vehicleId;
            return _manager["Bay"].Update(b);
        }

        private string RemoveVehicleFromBay(string vehicleId)
        {
            // remove vehicle id from bay
            List<DbObject> bList = _manager["Bay"].RetrieveMany("occupied");
            foreach( Bay b in bList)
            {
                if(b.Vehicle == vehicleId)
                {
                    b.Vehicle = null;
                    return _manager["Bay"].Update(b);
                }
            }

            return "Fail.Vehicle not stored in bay.";
        }

        public string RemoveSoldVehicle(string vehicleId)
        {  
            if (GetSoldVehicleList.Contains(vehicleId))
            {
                //remove vehicle from inventory
                _manager["Vehicle"].Delete(vehicleId);
                return RemoveVehicleFromBay(vehicleId);
            }
            
            return "Fail.Vehicle has not been sold or doesn't exist.";
        }
        
    }
}
