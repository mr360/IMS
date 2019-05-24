using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;

namespace IMS.Instance
{
    public abstract class Instance
    {
        protected Dictionary<string, IManager> _manager = new Dictionary<string, IManager>();
        public Instance(VehicleManager vm, AddonManager am, InvoiceManager im)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);
            _manager.Add("Invoice", im);
        }

        public Instance(InvoiceManager im, UserManager um, VehicleManager vm)
        {
            _manager.Add("Invoice", im);
            _manager.Add("User", um);
            _manager.Add("Vehicle", vm);
        }

        public Instance(ReportManager rm, InvoiceManager im)
        {
            _manager.Add("Report", rm);
            _manager.Add("Invoice", im);
        }

        public Instance(VehicleManager vm, AddonManager am, InvoiceManager im, BayManager bm)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);
            _manager.Add("Invoice", im);
            _manager.Add("Bay", bm);
        }
    }
}
