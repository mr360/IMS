using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;
using IMS;

namespace IMS.Instance
{
    /// <summary>
    ///  
    /// </summary>
    public sealed class LotInstance : Instance
    {
        private static LotInstance _instance;

        public static LotInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("Lot instance not created");
                }
                return _instance;
            }
        }

        public static void Create(VehicleManager vm, BayManager bm)
        {
            if (_instance == null)
            {
                _instance = new LotInstance(vm,bm);
            }
        }

        private LotInstance(VehicleManager vm, BayManager bm) : base(vm,bm)
        {

        }

        /// <summary>
        /// Get all the bays of unsold vehicles
        /// </summary>
        public List<string> BaysWithNonSoldVehicles
        {
            get
            {
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

        /// <summary>
        ///  Get all the unoccupied bays.
        /// </summary>
        public List<string> OpenBays
        {
            get
            {
                List<DbObject> bList = _manager["Bay"].RetrieveMany("free");
                List<string> openBay = new List<string>();
                foreach (Bay b in bList)
                {
                    openBay.Add(b.Id);
                }

                return openBay;
            }
        }

        /// <summary>
        /// Get a list of all vehicles that have been sold.
        /// </summary>
        public List<string> SoldVehicles
        {
            get
            {
                
                List<DbObject> vList = _manager["Vehicle"].RetrieveMany("sold");
                List<string> soldVehicle = new List<string>();

                foreach (Vehicle v in vList)
                {
                    soldVehicle.Add(v.Id);
                }

                return soldVehicle;
            }
        }

        /// <summary>
        /// Loops through vehicles in inventory and note down vehicles without a bay allocation.
        /// </summary>
        public List<string> UnallocatedVehicles
        {
            get
            {
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
