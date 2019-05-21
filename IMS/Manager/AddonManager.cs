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
            //_db = db;
        }

        public override string Add(DbObject item)
        {
            Addon a = item as Addon;
            try
            {
                if (String.IsNullOrEmpty(a.Id) || String.IsNullOrEmpty(a.Name) || String.IsNullOrEmpty(a.Desc))
                {
                    return "The addon does not have all information details.";
                }
            }
            catch(NullReferenceException e)
            {
                throw new NullReferenceException("Not of type Addon", e);
            }

            return _db.Create(item);
        }
    }
}
