using System;
using IMS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    /// <summary>
    ///  An object representation of the database tables stored within
    ///  the database.
    /// </summary>
    public class DbTable : DbObject, IDb
    {
        private string _name;
        private List<DbObject> _table;

        public DbTable(string id, string name) : base(id)
        {
            _name = name.ToUpper();
            _table = new List<DbObject>();
        }

        public List<string> GetIDs
        {
            get
            {
                List<string> temp = new List<string>();
                foreach (DbObject itm in _table)
                {
                    temp.Add(itm.Id);
                }
                return temp;
            }
        }

        public override string View
        {
            get
            {
                return _name;
            }
        }

        public bool Create(DbObject item)
        {
            if (item == null || _table.Contains(item))
            {
                return false;
            }

            foreach (DbObject element in _table)
            {
                if (item.Id == element.Id)
                {
                    return false;
                }
            }

            _table.Add(item);
            return true;
        }

        public bool Delete(string id)
        {
            if (id == null) return false;
            foreach (DbObject itm in _table)
            {
                if (itm.Id == id.ToUpper())
                {
                    _table.Remove(itm);
                    return true;
                }
            }

            return false;
        }

        public DbObject Read(string id)
        {
            if (id == null) return null;
            foreach (DbObject item in _table)
            {
                if (item.Id == id.ToUpper())
                {
                    return item;
                }
            }

            return null;
        }

        public bool Update(DbObject item)
        {
            if (item == null) return false;
            if (Delete(item.Id))
            {
                Create(item);
                return true;
            }

            return false;

        }
    }
}
