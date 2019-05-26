using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    /// <summary>
    /// Interacts with the database through the manager and provides a 
    /// "buffer" between the database implementation and the application.
    /// Allows for type specific manipulation and validation of data types
    /// Add, delete, remove, update and retreival of database items done via this manager 
    /// </summary>
    public abstract class Manager : IManager
    {
       protected IDb _db;
       public Manager(string table, Database db)
       {
            _db = db.Read(table) as IDb;
            if (_db == null)
            {
                throw new System.NullReferenceException("The table does not exist. Cannot be null");
            }
        }

        /// <summary>
        /// Allows for the type specific validation and adding of sub-types of DbObject
        /// </summary>
        public abstract string Add(DbObject item);

        public string Delete(string id)
        {
            if (_db.Delete(id))
            {
                return "Successfully deleted.";
            }
            else 
            {
                return "No such item found.";
            }
        }

        /// <summary>
        /// Retreives all the items stored within the managed table
        /// </summary>
        public virtual List<DbObject> RetrieveMany(string id)
        {
            if (id.ToLower() != "all")
            {
                throw new ArgumentException("Needs to include an 'all' quantifier");
            }
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                output.Add(_db.Read(ids));
            }
            return output;
        }

        public string Update(DbObject item)
        {
            if (Delete(item.Id) == "Successfully deleted.")
            {
                return Add(item);
            }
            /*if (_db.Update(item))
            {
                return "Successfully updated.";
            }*/

            return "No such item found";
        }

        /// <summary>
        /// Retrieves a single item from the database 
        /// </summary>
        public DbObject Retrieve(string id)
        {
            return _db.Read(id);
        }

        /// <summary>
        /// Retrieves ID's of all the items within the database table
        /// </summary>
        public List<string> GetIDs 
        { 
            get
            {
                return _db.GetIDs;
            } 
        }

        public bool Contain(string id)
        {
            return GetIDs.Contains(id);
        }

    }
}
