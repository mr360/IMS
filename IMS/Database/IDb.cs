using System;
using IMS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    /// <summary>
    /// Interface to access the database.
    /// </summary>
    /// <remarks>
    /// Can allow for different databases to be used with the current
    /// system without requiring major changes.
    /// </remarks>
    public interface IDb
    {
        bool Create(DbObject item);
        DbObject Read(string id);
        bool Update(DbObject item);
        bool Delete(string id);
        List<string> GetIDs { get; }
    }
}
