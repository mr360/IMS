using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class Database : IDb
    {
        private string _name;
        private List<DbTable> _table;

        public Database(string name)
        {
            _name = name;
            _table = new List<DbTable>();
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

        public string Create(DbObject item)
        {
            if (item == null)
            {
                return "Not valid table.";
            }
            if (_table.Contains(item))
            {
                return "Duplication! Table already exists.";
            }

            _table.Add(item as DbTable);
            return "Successfully added.";
        }

        public string Delete(string id)
        {
            foreach (DbObject itm in _table)
            {
                if (itm.Id == id)
                {
                    _table.Remove(itm as DbTable);
                    return "Successfully deleted.";
                }
            }

            return "No such table found.";
        }

        public DbObject Read(string id)
        {
            foreach (DbObject item in _table)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public string Update(DbObject item)
        {
            int index = _table.IndexOf(Read(item.Id) as DbTable);

            if (!(index == -1))
            {
                _table[index] = item as DbTable;
                return "Successfully updated.";
            }

            return "No such table found";
        }
    }
}
