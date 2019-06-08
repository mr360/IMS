using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.Invoice;
using IMS.User;
using IMS.Manager;
using IMS.Instance;
using IMS.Report;


namespace IMS
{
    class Program
    {
        static Database FakeData(int amount)
        {
            // Database
            Database.Create("HTV Database");
            Database db = Database.Instance;

            // DbTable
            DbTable dbTableBay = new DbTable("bay", "Bay Table");
            DbTable dbTableVehicle = new DbTable("vehicle", "Vehicle Table");
            DbTable dbTableAddon = new DbTable("addon", "Addon Table");
            DbTable dbTableUser = new DbTable("user", "User Table");

            DbTable dbTableInvoice = new DbTable("invoice", "Invoice Table");
            DbTable dbTableReport = new DbTable("report", "Report Table");


            // Bays
            for (int i = 0; i < amount; i++)
            {
                Bay x = new Bay("B000" + (i.ToString()));
                if (i < amount / 2)
                {
                    x.Vehicle = "VIN0000" + (i.ToString());
                }

                dbTableBay.Create(x);
            }

            // Vehicle
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < amount; i++)
            {
                string model = (chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)]).ToString();
                Vehicle x = new Vehicle("VIN0000" + (i.ToString()), (Brand)new Random().Next(0, 11), model, new DateTime(new Random().Next(1990, 2019), 01, 01), new Random().Next(30000, 150000));
                if (i < amount / 3)
                {
                    x.Sold = true;
                }
                dbTableVehicle.Create(x);

            }

            // Addon
            for (int i = 0; i < amount; i++)
            {
                Addon a = new Addon("A000" + (i.ToString()), "AddonTA10" + (i.ToString()), "Addon is xyz blah", new Random().Next(100, 3500));
                a.Compatible = "VIN0000" + (i.ToString());
                dbTableAddon.Create(a);

                Addon b = new Addon("A100" + (i.ToString()), "AddonTB10" + (i.ToString()), "Addon is xyz blah", new Random().Next(100, 3500));
                b.Compatible = "VIN0000" + (i.ToString());
                dbTableAddon.Create(b);

                Addon c = new Addon("A200" + (i.ToString()), "AddonTC10" + (i.ToString()), "Addon is xyz blah", new Random().Next(100, 3500));
                c.Compatible = "VIN0000" + (i.ToString());
                dbTableAddon.Create(c);
            }

            // Users 
            for (int i = 0; i < amount; i++)
            {
                string name = (chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)]).ToString();
                Customer c = new Customer("C00" + (i.ToString()), "Customer Name", "25 Makaby Street, VIC, 3752", "0418534687");


                dbTableUser.Create(c);
            }

            Staff s1 = new Staff("S10", "Example Name", JobRole.Sale);
            Staff s2 = new Staff("S20", "Example Name", JobRole.Accounting);
            Staff s3 = new Staff("S30", "Example Name", JobRole.Management);
            Staff s4 = new Staff("S40", "Example Name", JobRole.Garage);

            dbTableUser.Create(s1);
            dbTableUser.Create(s2);
            dbTableUser.Create(s3);
            dbTableUser.Create(s4);

            IMS.Builder.InvoiceBuilder iBuild = new IMS.Builder.InvoiceBuilder();
            Order z;
            z.addons = new List<Addon>() { new Addon("A00001", "AddonTA10", "Addon is xyz blah", 5600.00) };
            z.buyVehicle = new Vehicle("VIN00001", Brand.Audi, "MN-67", new DateTime(new Random().Next(1990, 2019), 01, 01), new Random().Next(30000, 150000));
            iBuild.Order = z;
            iBuild.Staff = new Staff("SR689", "Example Staff", JobRole.Sale);

            IMS.Invoice.Sale iSale = iBuild.Prepare() as IMS.Invoice.Sale;

            dbTableInvoice.Create(iSale);


            Report.InvoiceReport dd = new Report.InvoiceReport("R006", "Test Report Name", ReportType.Sale, new DateTime(2019, 01, 01), new DateTime(2019, 04, 01));
            dd.AmountOfSale = 60;
            dd.TotalSalePrice = 176500.00;

            dbTableReport.Create(dd);

            db.Create(dbTableBay);
            db.Create(dbTableVehicle);
            db.Create(dbTableAddon);
            db.Create(dbTableUser);
            db.Create(dbTableInvoice);
            db.Create(dbTableReport);

            return db;

        }

        static int Main(string[] args)
        {
            Customer c = new Customer("C00" + (1.ToString()), "Customer Name", "25 Makaby Street, VIC, 3752", "0418534687");

            IMS.Builder.InvoiceBuilder iBuild = new IMS.Builder.InvoiceBuilder();
            Order z;
            z.addons = new List<Addon>() { new Addon("A00001", "AddonTA10", "Addon is xyz blah", 5600.00) };
            z.buyVehicle = new Vehicle("VIN00001", Brand.Audi, "MN-67", new DateTime(new Random().Next(1990, 2019), 01, 01), new Random().Next(30000, 150000));
            iBuild.Order = z;
            iBuild.Staff = new Staff("SR689", "Example Staff", JobRole.Sale);

            IMS.Invoice.Sale iSale = iBuild.Prepare() as IMS.Invoice.Sale;


            IMS.Invoice.Tax test = new Invoice.Tax(iSale,c,"1234-PAY-DONE");


            /*
            Database db = FakeData(10);

            ManagerFactory.Create(typeof(BayManager),"bay", db);
            ManagerFactory.Create(typeof(VehicleManager),"vehicle", db);
            ManagerFactory.Create(typeof(AddonManager), "addon", db);
            ManagerFactory.Create(typeof(UserManager), "user", db);
            ManagerFactory.Create(typeof(InvoiceManager), "invoice", db);
            ManagerFactory.Create(typeof(ReportManager), "report", db);

            BayManager bm = ManagerFactory.GetManager(typeof(BayManager)) as BayManager;
            VehicleManager vm = ManagerFactory.GetManager(typeof(VehicleManager)) as VehicleManager;
            AddonManager am = ManagerFactory.GetManager(typeof(AddonManager)) as AddonManager;
            UserManager um = ManagerFactory.GetManager(typeof(UserManager)) as UserManager;
            InvoiceManager im = ManagerFactory.GetManager(typeof(InvoiceManager)) as InvoiceManager;
            ReportManager rm = ManagerFactory.GetManager(typeof(ReportManager)) as ReportManager;
            */
            return 0;
        }

    }
}
