using System;
using IMS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public interface IDb
    {
        bool Create(DbObject item);
        DbObject Read(string id);
        bool Update(DbObject item);
        bool Delete(string id);
        List<string> GetIDs { get; }
    }
}
