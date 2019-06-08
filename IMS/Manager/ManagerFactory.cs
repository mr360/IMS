using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public sealed class ManagerFactory
    {
        public static IManager GetManager(Type manager)
        {
            IManager instance = null;

            switch (manager.Name)
            {
                case nameof(BayManager):
                    instance = BayManager.Instance;
                    break;
                case nameof(VehicleManager):
                    instance = VehicleManager.Instance;
                    break;
                case nameof(InvoiceManager):
                    instance = InvoiceManager.Instance;
                    break;
                case nameof(AddonManager):
                    instance = AddonManager.Instance;
                    break;
                case nameof(ReportManager):
                    instance = ReportManager.Instance;
                    break;
                case nameof(UserManager):
                    instance = UserManager.Instance;
                    break;
                default: throw new Exception("Manager does not exist or not created");
            }

            return instance;
        }

        public static void Create(Type manager, string name,Database db)
        {
            switch (manager.Name)
            {
                case nameof(BayManager):
                    BayManager.Create(name, db);
                    break;
                case nameof(VehicleManager):
                    VehicleManager.Create(name, db);
                    break;
                case nameof(InvoiceManager):
                    InvoiceManager.Create(name, db);
                    break;
                case nameof(AddonManager):
                    AddonManager.Create(name, db);
                    break;
                case nameof(ReportManager):
                    ReportManager.Create(name, db);
                    break;
                case nameof(UserManager):
                    UserManager.Create(name, db);
                    break;
                default: throw new Exception("Manager of that type does not exist");
            }
        }
    }
}
