using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class BayManager : Manager, IManager
    {
        //private IDb _db;
        public BayManager(string btable, Database db) : base(btable, db)
        {
            //_db = db;
        }

        public override string Add(DbObject item)
        {
            Bay b = item as Bay;
            try
            {
                if (String.IsNullOrEmpty(b.Id))
                {
                    return "The bay does not have all information details.";
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Not of type Bay", e);
            }

            return _db.Create(item);
        }
    }
}
