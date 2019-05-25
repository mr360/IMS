using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
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
            if (_db.Update(item))
            {
                return "Successfully updated.";
            }

            return "No such item found";
        }

        public DbObject Retrieve(string id)
        {
            return _db.Read(id);
        }

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
