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
        //private IDb _db;
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

