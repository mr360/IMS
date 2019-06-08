using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;

namespace IMS.Manager
{
    public sealed class UserManager : Manager,IManager
    {
        /// <summary>
        /// Interacts with the database through the user manager
        /// Allows accessing of user specific methods
        /// Add, delete, remove, update and retreival of users done via this manager 
        /// </summary>
        /// 
        private static UserManager _instance;
        public static UserManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("User Manager not created");
                }
                return _instance;
            }
        }

        public static void Create(string utable, Database db)
        {
            if (_instance == null)
            {
                _instance = new UserManager(utable, db);
            }
        }
        private UserManager(string utable, Database db) : base(utable, db)
        {
        }

        public override string Add(DbObject item)
        {
            User.User u = item as User.User;
            
            if (u == null)
            {
                throw new NullReferenceException("Not of type User");
            }

            if (_db.Create(item))
            {
                return "Successfully added user.";
            }

            return "Duplication! User already exists. ID:" + item.Id;
        }
    }
}

