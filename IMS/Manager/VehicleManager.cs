using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class VehicleManager : Manager, IManager
    {
        public VehicleManager(string vtable, Database db) : base(vtable, db)
        {

        }

    }
}
