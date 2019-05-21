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
                if (String.IsNullOrEmpty(v.Id) || String.IsNullOrEmpty(v.Model) || String.IsNullOrEmpty(v.Year))
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
    }
}
