using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;

namespace IMS.Instance
{
    public class Instance
    {
        protected Dictionary<string, IManager> _manager = new Dictionary<string, IManager>();
        public Instance(VehicleManager vm, AddonManager am, InvoiceManager im)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);
            _manager.Add("Invoice", im);
        }

        public Instance(InvoiceManager im, UserManager um)
        {
            _manager.Add("Invoice", im);
            _manager.Add("User", um);
        }

        public Instance(ReportManager rm)
        {
            _manager.Add("Report", rm);
        }

        public Instance(VehicleManager vm, AddonManager am, BayManager bm, InvoiceManager im)
        {
            _manager.Add("Vehicle", vm);
            _manager.Add("Addon", am);
            _manager.Add("Bay", bm);
        }
    }
}
