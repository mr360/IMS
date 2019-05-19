﻿using System;
using IMS.DbObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DbObject
{
    public class DbTable : DbObject, IDb
    {
        private string _name; 
        private List<DbObject.DbObject> _table;

        public DbTable(string id, string name) : base(id)
        {
            _name = name;
        }

        public int Count
        {
            get
            {
                return _table.Count;
            }
        }

        public override string View
        {
            get
            {
                string temp = "";
                foreach(DbObject.DbObject itm in _table)
                {
                    temp += itm.Id;
                }
                return temp;
            }
        }

        public string Create(DbObject.DbObject item)
        {
            if (item == null)
            {
                return "Not valid item.";
            }
            if(_table.Contains(item))
            {
                return "Duplication! Item already exists.";
            }

            _table.Add(item);
            return "Successfully added.";
        }

        public string Delete(string id)
        {
            foreach (DbObject.DbObject itm in _table)
            {
                if (itm.Id == id)
                {
                    _table.Remove(itm);
                    return "Successfully deleted.";
                }
            }

            return "No such item found.";
        }

        public DbObject.DbObject Read(string id)
        {
            foreach (DbObject.DbObject item in _table)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public string Update(DbObject.DbObject item)
        {
            int index = _table.IndexOf(Read(item.Id));

            if (!(index == -1))
            {
                _table[index] = item;
                return "Successfully updated.";
            }

            return "No such item found";
        }
    }
}
