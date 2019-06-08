using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Tools;

namespace IMS.Manager
{
    /// <summary>
    /// Interacts with the database through the addon manager.
    /// Allows accessing of addon specific methods.
    /// Add, delete, remove, update and retreival of addons done via this manager.
    /// </summary>
    public sealed class AddonManager : Manager, IManager
    {
        private static AddonManager _instance;

        public static AddonManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("Addon manager not created");
                }
                return _instance;
            }
        }

        public static void Create(string atable, Database db)
        {
            if (_instance == null)
            {
                _instance = new AddonManager(atable, db);
            }
        }
        private AddonManager(string atable, Database db) : base(atable, db)
        {
        }

        public override string Add(DbObject item)
        {
            Addon a = item as Addon;
            
            if(a == null)
            {
                throw new NullReferenceException(StringTable.EnumToString(EnumMsg.MSG_NULL_EXCEPTION_NOT_ADDON));
            }

            if (_db.Create(item))
            {
                return StringTable.EnumToString(EnumMsg.MSG_SUCCESS_ADD_ADDON);
            }

            return StringTable.EnumToString(EnumMsg.MSG_ERROR_DUPLICATE_ADDON);
        }

        /// <summary>
        /// Gets all addons that are compatible with a specified vehicle id.
        /// </summary>
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
