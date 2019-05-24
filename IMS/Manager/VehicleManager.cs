using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class VehicleManager : Manager, IManager
    {
        public VehicleManager(string vtable, Database db) : base(vtable, db)
        {

        }
        public override string Add(DbObject item)
        {
            Vehicle v = item as Vehicle;
            try
            {
                if (String.IsNullOrEmpty(v.Id) || String.IsNullOrEmpty(v.Model) || String.IsNullOrEmpty(v.Year) || v.Price < 0.00)
                {
                    return "The Vehicle does not have all information details.";
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Not of type Vehicle", e);
            }

            return _db.Create(item);
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
                    default:
                        output.Add(v);
                        break;
                }
            }
            return output;
        }

        // Use ReterieveMany("nonsold")
        // returns non sold vehicles
        // add a sold bool to vehicle


    }
}
