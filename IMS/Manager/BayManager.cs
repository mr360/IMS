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

        public override List<DbObject> RetrieveMany(string id)
        {
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                Bay b = _db.Read(ids) as Bay;

                switch(id.ToLower())
                {
                    case "occupied":
                        if (!(b.Available)) output.Add(b);
                        break;
                    case "free":
                        if (b.Available) output.Add(b);
                        break;
                    default: 
                        output.Add(b); 
                        break;
                }
            }

            return output;
        }
    }
}
