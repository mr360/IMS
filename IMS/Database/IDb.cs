using System;
using IMS.DbObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Database
{
    public interface IDb
    {
        string Create(DbObject.DbObject item);
        DbObject.DbObject Read(string id);
        string Update(DbObject.DbObject item);
        string Delete(string id);
        List<string> View { get; }
    }
}
