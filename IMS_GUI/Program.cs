using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.User;
using IMS;
using IMS.Manager;

namespace IMS_GUI
{
    static class Program
    {
        public static Staff staffAccount;

        public static BayManager bm;
        public static VehicleManager vm;
        public static AddonManager am;
        public static UserManager um;
        public static InvoiceManager im;
        public static ReportManager rm;

        static Database FakeData(int amount)
        {
            // Database
            Database db = new Database("HTV");

            // DbTable
            DbTable dbTableBay = new DbTable("bay", "Bay Table");
            DbTable dbTableVehicle = new DbTable("vehicle", "Vehicle Table");
            DbTable dbTableAddon = new DbTable("addon", "Addon Table");
            DbTable dbTableUser = new DbTable("user", "User Table");

            DbTable dbTableInvoice = new DbTable("invoice", "Invoice Table");
            DbTable dbTableReport = new DbTable("report", "Report Table");


            // Bays
            for (int i = 0; i < amount + 20; i++)
            {
                dbTableBay.Create(new Bay("B000" + (i.ToString())));
            }

            // Vehicle
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < amount; i++)
            {
                string model = (chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)]).ToString();
                dbTableVehicle.Create(new Vehicle("VIN0000" + (i.ToString()), (Brand)new Random().Next(0, 11), model, new DateTime(new Random().Next(1990, 2019), 01, 01), new Random().Next(30000, 150000)));
            }

            // Addon
            for (int i = 0; i < amount; i++)
            {
                Addon a = new Addon("A000" + (i.ToString()), "AddonT10" + (i.ToString()), "Addon is xyz blah", new Random().Next(100, 3500));
                a.AddCompatible("VIN0000" + (i.ToString()));
                dbTableAddon.Create(a);
            }

            // Users 
            for (int i = 0; i < amount; i++)
            {
                string name = (chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)]).ToString();
                Staff s = new Staff("S00" + (i.ToString()), name, (JobRole)new Random().Next(0, 0));
                Customer c = new Customer("C00" + (i.ToString()), name, "25 Makaby Street, VIC, 3752");

                dbTableUser.Create(s);
                dbTableUser.Create(c);
            }

            db.Create(dbTableBay);
            db.Create(dbTableVehicle);
            db.Create(dbTableAddon);
            db.Create(dbTableUser);
            db.Create(dbTableInvoice);
            db.Create(dbTableReport);

            return db;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database db = FakeData(10);

            bm = new BayManager("bay", db);
            vm = new VehicleManager("vehicle", db);
            am = new AddonManager("addon", db);
            um = new UserManager("user", db);
            im = new InvoiceManager("invoice", db);
            rm = new ReportManager("report", db);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
