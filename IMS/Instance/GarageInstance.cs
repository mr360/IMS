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
        public GarageInstance(Staff s, VehicleManager vm, AddonManager am, BayManager bm, InvoiceManager im) : base(vm, am, bm, im)
        {
            if (s.Role != JobRole.Garage)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create instance!");
            }
        }

        public string Add(Vehicle v)
        {
            // put this in the VehicleManager Add section
            if (v.Id == "" || v.Model == "" || v.Price < 0.00 || v.Year == "")
            {
                return "The vehicle does not have all information detailed.";
            }

            return _manager["Vehicle"].Add(v);
        }

        public string Add(Addon a)
        {
            // put this in the AddonManager Add section
            /*if (a.Id == "" || a.Name == "" || a.Desc == "")
            {
                return "The addon does not have all information details.";
            }*/
            return _manager["Addon"].Add(a);
        }

        public string ViewTasks
        {
            get
            {
                string ss = "";
                // foreach vehicle in Vehicle Manager and tax-invoice vehicles, show as sold and need to remove from bay
                ss += "SOLD VEHICLES THAT NEED TO BE REMOVED: \n";
                foreach(string id in SoldVehicleID)
                {
                    Vehicle v = _manager["Vehicle"].Retrieve(id) as Vehicle;
                    ss += v.View;
                }
                // foreach vehicle in Vehicle Manager and Bay Manager that does not have allocation, show and need to add to bay
                ss += "UNALLOCATED VEHICLES THAT NEED TO BE ADDED TO BAYS: \n";
                foreach (string id in UnallocatedVehicleID)
                {
                    Vehicle v = _manager["Vehicle"].Retrieve(id) as Vehicle;
                    ss += v.View;
                }
                // foreach each trade in vehicle in tax-invoices not in vehicle manager, show and add to system
                ss += "TRADE-IN VEHICLES THAT NEED TO BE ADDED TO INVENTORY: \n";
                foreach (string id in NonProcessedTradeInVehicleID)
                {
                    Vehicle v = _manager["Vehicle"].Retrieve(id) as Vehicle;
                    ss += v.View;
                }

                return ss;
            }
        }

        List<string> SoldVehicleID
        {
            get
            {
                // foreach vehicle in Vehicle Manager and tax-invoice vehicles, show as sold and need to remove from bay
                List<string> invoiceIds = _manager["Invoice"].GetIDs;
                List<string> vehicleIds = _manager["Vehicle"].GetIDs;
                List<string> soldVehicle = new List<string>();

                foreach(string vId in vehicleIds)
                {
                    foreach(string iId in invoiceIds)
                    {
                        Tax tInvoice = _manager["Invoice"].Retrieve(iId) as Tax;
                        if (tInvoice == null) continue;
                        Vehicle v = tInvoice.BuyVehicle;
                        if (v.Id == vId)
                        {
                            soldVehicle.Add(vId);
                        } 
                    }
                }
                return soldVehicle;
            }
        }

        List<string> UnallocatedVehicleID
        {
            get
            {
                // foreach vehicle in Vehicle Manager and Bay Manager that does not have allocation, show and need to add to bay
                List<string> bayIds = _manager["Bay"].GetIDs;
                List<string> vehicleIds = _manager["Vehicle"].GetIDs;

                foreach (string bId in bayIds)
                {
                    Bay bay = _manager["Bay"].Retrieve(bId) as Bay;
                    if (vehicleIds.Contains(bay.Vehicle)) continue;
                    {
                        vehicleIds.Remove(bay.Vehicle);
                    }
                }

                return vehicleIds;
            }
        }

        List<string> NonProcessedTradeInVehicleID
        {
            get
            {
                // foreach each trade in vehicle in tax-invoices not in vehicle manager, show and add to system
                List<string> invoiceIds = _manager["Invoice"].GetIDs;
                List<string> vehicleIds = _manager["Vehicle"].GetIDs;
                List<string> tradeVehicle = new List<string>();

                foreach (string vId in vehicleIds)
                {
                    foreach (string iId in invoiceIds)
                    {
                        Tax tInvoice = _manager["Invoice"].Retrieve(iId) as Tax;
                        if (tInvoice == null) continue;
                        Vehicle v = tInvoice.BuyVehicle;
                        if (v.Id == vId)
                        {
                            tradeVehicle.Add(vId);
                        }
                    }
                }
                return tradeVehicle;
            }
        }

        public string ViewOpenBays
        {
            get
            {
                // show bays that are open
                List<string> bayIds = _manager["Bay"].GetIDs;
                string openBay = "";
                foreach (string bId in bayIds)
                {
                    Bay bay = _manager["Bay"].Retrieve(bId) as Bay;
                    if (bay.Vehicle != null) continue;
                    openBay += bay.Id + "\n";
                }

                return openBay;
            }
        }

        public string AssignVehicleToBay(string bayId, string vehicleId)
        {
            // Check if vehicleid of vehicle exists (vehicle manager)
            // Check if bayid exists in Bay Manager (bay manager)
            // Get vehicle id and bayId
            // check if bay has the vehicle and check if vehicle isn't in multiple bays (probs do this in BayManager)
            throw new NotImplementedException();
        }

        string RemoveVehicleFromBay(string bayId)
        {
            // remove vehicle id from bay
            Bay b = _manager["Bay"].Retrieve(bayId) as Bay;
            if(b == null)
            {
                return "Invalid bay";
            }
            b.Vehicle = null;
            
            return _manager["Bay"].Update(b);

        }

        public string RemoveSoldVehicle(string vehicleId)
        {  
            if (SoldVehicleID.Contains(vehicleId))
            {
                //remove vehicle from inventory
            }
            //RemoveVehicleFromBay(bayId);

            throw new NotImplementedException();
        }
    }
}
