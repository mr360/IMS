using System;
using IMS.DbObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Database
{
    public class DbTable : IDb
    {
        private string _name; 
        private List<DbObject.DbObject> _table;

        public DbTable(string name)
        {
            _name = name;
        }

    }
}
