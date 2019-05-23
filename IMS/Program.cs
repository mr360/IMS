using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.Invoice;
using IMS.User;
using IMS.Manager;
using IMS.Instance;

namespace IMS
{
    class Program
    {
        static Database FakeData(int amount)
        {
            // Database
            Database db = new Database("HTV");

            // DbTable
            DbTable dbTableBay = new DbTable("bay", "Bay Table");
            DbTable dbTableVehicle = new DbTable("vehicle", "Vehicle Table");
            DbTable dbTableAddon = new DbTable("addon", "Addon Table");
            DbTable dbTableUser  = new DbTable("user", "User Table");

            DbTable dbTableInvoice = new DbTable("invoice", "Invoice Table");
            DbTable dbTableReport  = new DbTable("report", "Report Table");
            

            // Bays
            for(int i = 0; i < amount+20; i++)
            {
                dbTableBay.Create(new Bay("B000" + (i.ToString())));
            }

            // Vehicle
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < amount; i++)
            {
                string model = (chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)] + chars[new Random().Next(chars.Length)]).ToString();
                dbTableVehicle.Create(new Vehicle("VIN0000"+(i.ToString()), (Brand)new Random().Next(0, 11), model, new DateTime(new Random().Next(1990, 2019), 01, 01), new Random().Next(30000, 150000)));
            }

            // Addon
            for(int i = 0; i < amount; i++)
            {
                Addon a = new Addon("A000" + (i.ToString()),"AddonT10"+ (i.ToString()), "Addon is xyz blah", new Random().Next(100, 3500));
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
        static int Main(string[] args)
        {
            Database db = FakeData(10);

            BayManager bm = new BayManager("bay", db);
            VehicleManager vm = new VehicleManager("vehicle", db);
            AddonManager am = new AddonManager("addon", db);
            UserManager um = new UserManager("user", db);
            InvoiceManager im = new InvoiceManager("invoice", db);
            ReportManager rm = new ReportManager("report", db);

            // Start of application 
            Console.WriteLine("Enter IMS Staff username: ");
            string username = Console.ReadLine();
            Staff staffAccount = um.Retrieve(username) as Staff;
            while (staffAccount == null)
            {
                Console.WriteLine("Account does not exist");
                Console.ReadLine();
                return 0;  
            }

            Console.WriteLine("Welcome {0}", staffAccount.Name);
            /*
            switch (staffAccount.Role)
            {
                case JobRole.Accounting:
                    AccountingInstance aInstance = new AccountingInstance(staffAccount,im,um);
                    break;
                case JobRole.Sale:
                    SaleInstance sInstance = new SaleInstance(staffAccount, vm, am, im);
                    break;
                case JobRole.Garage:
                    GarageInstance gInstance = new GarageInstance(staffAccount, vm, am, bm, im);
                    break;
                case JobRole.Management:
                    ReportInstance rInstance = new ReportInstance(staffAccount, rm);
                    break;
                default: 
                    throw new ArgumentException("Unknown user! Unknown instance to create!");
            }
            */
            // LotInstance.ViewAvailableVehicles
            /*
             LotInstance.ViewVehicles
             LotInstance.ViewAddons
             LotInstance.ViewAddons(vehicleId)
             LotInstance.ViewSoldVehicles
             LotInstance.ViewUnallocatedVehicles
             */
            //////////////////////////////////////////////////////////////////

            // LotInstance.ViewAvailableVehicles
            /* List<string> vIdList = vm.GetIDs;
             foreach(string vId in vIdList)
             {
                 Vehicle temp = vm.Retrieve(vId) as Vehicle;
                 Console.Write(temp.Id + " : " + temp.View);
             }

             SaleInstance sInstance = new SaleInstance(staffAccount, vm, am, im);
             string selection = Console.ReadLine();
             if (sInstance.Add(IdType.Vehicle, selection))
             {
                 // LotInstance.ViewAddons(vehicleId)
                 dynamic aList = am.RetrieveMany(selection) as dynamic;
                 if (aList != null)
                 {
                     foreach (Addon a in aList)
                     {
                         Console.Write(a.Id + " : " + a.View);
                     }


                 }


             }
             
            sInstance.Add(IdType.Addon, "A001");
            Console.ReadLine();*/
            return 0;
            
        }

    }
}
