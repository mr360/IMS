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

        public List<string> ViewAll
        {
            get
            {
                List<string> output = new List<string>();
                List<string> idList = _db.GetIDs;
                foreach(string ids in idList)
                {
                    output.Add(_db.Read(ids).View);
                }
                return output;
            }
        }

        public abstract string Add(DbObject item);

        public string Delete(string id)
        {
            return _db.Delete(id);
        }

        public abstract List<DbObject> RetrieveMany(string id);
        /*{
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                output.Add(_db.Read(ids));
            }
            return output;
        }*/

        public string Update(DbObject item)
        {
            //<Todo>Update is just delete and add</Todo>
            // 
            // if (Delete(item.Id) == "Successfully deleted.")
            // {
            //      Add(item);
            // }
            return _db.Update(item);
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
