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

        // Lot Class Candidate (Refactor first)
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
                if(a == null) return "No addon to show. No addon has been added yet.";
                return a.View;
            }
        }

        public string ViewAddVehicle
        {
            get
            {
                Vehicle v = _manager["Vehicle"].Retrieve(_vehicleId) as Vehicle;
                if (v == null) return "No vehicle to show. No vehicle has been added yet.";
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

            if (_manager["Vehicle"].Contain(vehicle.Id))
            {
                return "Fail. Already exists within system";
            }

            // If vehicle fails to be added to database we can try to find it in db when ViewVehicle
            //_vehicleId = vehicle.Id;

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

            if (_manager["Vehicle"].Contain(addon.Compatible))
            {
                return "Fail. No vehicle in inventory is compatible.";
            }

            // If addon fails to be added to database we can try to find it in db when ViewAddon
            //_addonId = addon.Id;

            return _manager["Addon"].Add(addon);
        }


        public string AssignVehicleToBay(string vehicleId, string bayId)
        {
            if (!(_manager["Vehicle"].Contain(vehicleId)) || !(_manager["Bay"].Contain(bayId)))
            {
                return "Fail.One or more of the items does not exist within the system.";
            }

            Bay selectedBay = _manager["Bay"].Retrieve(bayId) as Bay;
            selectedBay.Vehicle = vehicleId;
            return _manager["Bay"].Update(selectedBay);
        }

        private string RemoveVehicleFromBay(string vehicleId)
        {
            List<DbObject> bList = _manager["Bay"].RetrieveMany("occupied");
            foreach( Bay bay in bList)
            {
                if(bay.Vehicle == vehicleId)
                {
                    bay.Vehicle = null;
                    return _manager["Bay"].Update(bay);
                }
            }

            return "Fail.Vehicle not stored in bay.";
        }

        public string RemoveVehicle(string vehicleId)
        {  
            if (_manager["Vehicle"].Contain(vehicleId))
            {
                _manager["Vehicle"].Delete(vehicleId);
                return RemoveVehicleFromBay(vehicleId);
            }
            
            return "Fail.Vehicle does not exist.";
        }
        
    }
}
