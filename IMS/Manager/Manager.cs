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
                throw new System.ArgumentException("The table does not exist. Cannot be null");
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

        public string Add(DbObject item)
        {
            return _db.Create(item);
        }

        public string Delete(string id)
        {
            return _db.Delete(id);
        }

        public virtual List<DbObject> Retrieve(string id)
        {
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
            return _db.Update(item);
        }
    }
}
