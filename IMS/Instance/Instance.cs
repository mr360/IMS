using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;

namespace IMS.Instance
{
    /// <summary>
    ///  Adds the managers (database table operators) needed for reading and writing
    ///  and doing work on the database data.
    /// </summary>
    public abstract class Instance
    {
        protected Dictionary<string, IManager> _manager = new Dictionary<string, IManager>();

        /// <summary>
        ///  Managers used by the Accounting Instance
        /// </summary>
        public Instance(InvoiceManager im, UserManager um, VehicleManager vm)
        {
            _manager.Add("Invoice", im);
            _manager.Add("User", um);
            _manager.Add("Vehicle", vm);
        }

        /// <summary>
        ///  Managers used by the Reporting Instance
        /// </summary>
        public Instance(ReportManager rm, InvoiceManager im)
        {
            _manager.Add("Report", rm);
            _manager.Add("Invoice", im);
        }

        /// <summary>
        ///  Managers used by the Garage Instance
        /// </summary>
        public Instance(VehicleManager vm, AddonManager am, BayManager bm)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);
            _manager.Add("Bay", bm);
        }

        /// <summary>
        /// Managers used by the Sales Instance
        /// </summary>
        public Instance(VehicleManager vm, AddonManager am, InvoiceManager im, BayManager bm)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);
            _manager.Add("Bay", bm);
            _manager.Add("Invoice", im);
        }

        /// <summary>
        /// Managers used by the Lot Instance 
        /// </summary>
        public Instance(VehicleManager vm, BayManager bm)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Bay", bm);
        }
    }
}
