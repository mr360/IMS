using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    /// <summary>
    /// Interacts with the database through the bay manager
    /// Add, delete, remove, update and retreival of vehicle bays done via this manager 
    /// </summary>
    public sealed class BayManager : Manager, IManager
    {
        private static BayManager _instance;

        public static BayManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("Bay manager not created");
                }
                return _instance;
            }
        }

        public static void Create(string btable, Database db)
        {
            if (_instance == null)
            {
                _instance = new BayManager(btable, db);
            }
        }

        private BayManager(string btable, Database db) : base(btable, db)
        {
        }

        public override string Add(DbObject item)
        {
            Bay b = item as Bay;

            if (b == null)
            {
                throw new NullReferenceException("Not of type Bay");
            }

            if (_db.Create(item))
            {
                return "Successfully added bay";
            }

            return "Duplication! Bay already exists. ID:" + item.Id;
        }

        /// <summary>
        /// Reterives bays based on the current occupation status
        /// </summary>
        public override List<DbObject> RetrieveMany(string id)
        {
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                Bay b = _db.Read(ids) as Bay;

                switch (id.ToLower())
                {
                    case "occupied":
                        if (!(b.Available)) output.Add(b);
                        break;
                    case "free":
                        if (b.Available) output.Add(b);
                        break;
                    case "all":
                        output.Add(b);
                        break;
                    default:
                        throw new ArgumentException("Needs to be either occupied / free or all");
                }
            }

            return output;
        }
    }
}
