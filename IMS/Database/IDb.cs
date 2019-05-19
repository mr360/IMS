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
        string Create(DbObject item);
        DbObject Read(string id);
        string Update(DbObject item);
        string Delete(string id);
        int Count { get; }
    }
}
