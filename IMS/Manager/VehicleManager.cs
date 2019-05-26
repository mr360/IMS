using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class VehicleManager : Manager, IManager
    {
        /// <summary>
        /// Interacts with the database through the vehicle manager
        /// Allows accessing of vehicle specific methods
        /// Add, delete, remove, update and retreival of vehicles done via this manager 
        /// </summary>
        public VehicleManager(string vtable, Database db) : base(vtable, db)
        {

        }
        public override string Add(DbObject item)
        {
            Vehicle v = item as Vehicle;

            if (v == null)
            {
                throw new NullReferenceException("Not of type Vehicle");
            }

            if (_db.Create(item))
            {
                return "Successfully added vehicle.";
            }

            return "Duplication! Vehicle already exists. ID:" + item.Id;
        }

        public override List<DbObject> RetrieveMany(string id)
        {
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                Vehicle v = _db.Read(ids) as Vehicle;

                switch (id.ToLower())
                {
                    case "unsold":
                        if (!(v.Sold)) output.Add(v);
                        break;
                    case "sold":
                        if (v.Sold) output.Add(v);
                        break;
                    case "all":
                        output.Add(v);
                        break;
                    default:
                        throw new ArgumentException("Needs to be either unsold / sold or all");
                }
            }
            return output;
        }
    }
}
