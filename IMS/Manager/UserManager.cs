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
            //_db = db;
        }
        public override string Add(DbObject item)
        {
            User.User u = item as User.User;
            try
            {
                if (String.IsNullOrEmpty(u.Id) || String.IsNullOrEmpty(u.Name))
                {
                    return "The addon does not have all information details.";
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Not of type Invoice", e);
            }

            return _db.Create(item);
        }

        public override List<DbObject> RetrieveMany(string id)
        {
            // Staff / Customer
            throw new NotImplementedException();
        }
    }
}

