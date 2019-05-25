using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;

namespace IMS.Manager
{
    public class UserManager : Manager,IManager
    {
        /// <summary>
        /// Interacts with the database through the user manager
        /// Allows accessing of user specific methods
        /// Add, delete, remove, update and retreival of users done via this manager 
        /// </summary>
        public UserManager(string utable, Database db) : base(utable, db)
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
                return "Successfully added user. ID:" + item.Id;
            }

            return "Duplication! User already exists. ID:" + item.Id;
        }
    }
}

