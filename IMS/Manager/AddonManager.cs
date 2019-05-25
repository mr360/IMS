using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class AddonManager : Manager, IManager
    {
        public AddonManager(string atable, Database db) : base(atable, db)
        {
        }

        public override string Add(DbObject item)
        {
            Addon a = item as Addon;
            
            if(a == null)
            {
                throw new NullReferenceException("Not of type Addon");
            }

            if (_db.Create(item))
            {
                return "Successfully added addon. ID:" + item.Id;
            }

            return "Duplication! Addon already exists. ID:" + item.Id;
            
        }

        public override List<DbObject> RetrieveMany(string id)
        {
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                Addon a = _db.Read(ids) as Addon;
                if (!(a.IsCompatible(id))) continue;
                output.Add(_db.Read(ids));
            }
            return output;
        }
    }
}
