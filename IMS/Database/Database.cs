﻿using System;
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
            _name = name.ToUpper();
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

        public bool Create(DbObject item)
        {
            if (item == null || _table.Contains(item))
            {
                throw new ArgumentException("Either the table is null or it already exists within database.");
            }

            _table.Add(item as DbTable);
            return true;
        }

        public bool Delete(string id)
        {
            foreach (DbObject itm in _table)
            {
                if (itm.Id == id.ToUpper())
                {
                    _table.Remove(itm as DbTable);
                    return true;
                }
            }

            return false;
        }

        public DbObject Read(string id)
        {
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
            int index = _table.IndexOf(Read(item.Id) as DbTable);

            if (!(index == -1))
            {
                _table[index] = item as DbTable;
                return true;
            }

            return false;
        }
    }
}
