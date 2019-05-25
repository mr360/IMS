using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Manager;
using IMS.Invoice;
using IMS.Tools;

namespace IMS.Instance
{
    /// <summary>
    ///  
    /// </summary>
    public class GarageInstance : Instance
    {
        string _vehicleId = "";
        string _addonId = "";

        public GarageInstance(Staff s, VehicleManager vm, AddonManager am, BayManager bm) : base(vm, am, bm)
        {
            if (s.Role != JobRole.Garage)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create garage instance!");
            }
        }

        /// <summary>
        ///  View the recently added addon.
        /// </summary>
        public string ViewAddAddon
        {
            get
            {
                Addon a = _manager["Addon"].Retrieve(_addonId) as Addon;
                if(a == null) return "No addon to show. No addon has been added yet.";
                return a.View;
            }
        }

        /// <summary>
        /// View the recently added vehicle.  
        /// </summary>
        public string ViewAddVehicle
        {
            get
            {
                Vehicle v = _manager["Vehicle"].Retrieve(_vehicleId) as Vehicle;
                if (v == null) return "No vehicle to show. No vehicle has been added yet.";
                return v.View;
            }
        }

        /// <summary>
        ///  Validates and adds the entered vehicle into the vehicle inventory. 
        /// </summary>
        public string Add(Vehicle vehicle)
        {
            if (!ValidateIMS.IsValid(vehicle))
            {
                return "Fail. Not right format";
            }

            if (_manager["Vehicle"].Contain(vehicle.Id))
            {
                return "Fail. Already exists within system";
            }

            _vehicleId = vehicle.Id;

            return _manager["Vehicle"].Add(vehicle);
        }

        /// <summary>
        /// Validates and adds the entered addon into the addon inventory.
        /// </summary>
        public string Add(Addon addon)
        {
            if (!ValidateIMS.IsValid(addon))
            {
                return "Fail. Not right format";
            }

            _addonId = addon.Id;

            return _manager["Addon"].Add(addon);
        }

        /// <summary>
        ///  Adds an ID of the vehicle in the inventory to the given bay.
        /// </summary>
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

        /// <summary>
        ///  Removes an ID of the vehicle in the inventory to the given bay.
        /// </summary>
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

        /// <summary>
        ///  Removes the vehicle from the inventory as well as calling another method which 
        ///  removes the ID of the vehicle in the given bay.
        /// </summary>
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
