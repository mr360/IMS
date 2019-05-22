using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public interface IManager
    {
        string Add(DbObject item);
        List<string> ViewAll { get; }
        List<DbObject> RetrieveMany(string id);
        DbObject Retrieve(string id);
        string Update(DbObject item);
        string Delete(string id);
        List<string> GetIDs { get; }

    }
}
