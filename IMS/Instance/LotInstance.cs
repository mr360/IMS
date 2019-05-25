using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;
using IMS;

namespace IMS.Instance
{
    public class LotInstance : Instance
    {
        public LotInstance(VehicleManager vm, BayManager bm) : base(vm,bm)
        {

        }

        public  List<string> BaysWithNonSoldVehicles
        {
            get
            {
                // Get all the bays of unsold vehicles
                List<DbObject> vList = _manager["Vehicle"].RetrieveMany("UnSold");
                List<DbObject> bList = _manager["Bay"].RetrieveMany("Occupied");

                List<string> nonSoldVehicleBay = new List<string>();
                foreach (Bay b in bList)
                {
                    foreach (Vehicle v in vList)
                    {
                        if (b.Vehicle == v.Id)
                        {
                            nonSoldVehicleBay.Add(b.Id);
                        }
                    }
                }

                return nonSoldVehicleBay;
            }
        }

        public List<string> OpenBays
        {
            get
            {
                // Get all the unoccupied bays
                List<DbObject> bList = _manager["Bay"].RetrieveMany("free");
                List<string> openBay = new List<string>();
                foreach (Bay b in bList)
                {
                    openBay.Add(b.Id);
                }

                return openBay;
            }
        }

        public List<string> SoldVehicles
        {
            get
            {
                // Get a list of all vehicles that have been sold.
                List<DbObject> vList = _manager["Vehicle"].RetrieveMany("sold");
                List<string> soldVehicle = new List<string>();

                foreach (Vehicle v in vList)
                {
                    soldVehicle.Add(v.Id);
                }

                return soldVehicle;
            }
        }

        public List<string> UnallocatedVehicles
        {
            get
            {
                // Loop through vehicles in inventory and note down vehicles without a bay
                List<string> vList = _manager["Vehicle"].GetIDs;
                List<DbObject> bList = _manager["Bay"].RetrieveMany("occupied");
                List<string> unallocatedVehicle = new List<string>(vList);

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
    }
}
