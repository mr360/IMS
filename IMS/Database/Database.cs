using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Database
{
    public class Database : IDb
    {
        private string _name;
        private List<DbTable> _table;

        public Database(string name)
        {
            _name = name;
        }
    }
}
