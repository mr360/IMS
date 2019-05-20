using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.Invoice;
using IMS.User;
using IMS.Manager;

namespace IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database("DbOne");
            DbTable dbT = new DbTable("dbVT001","Vehicle Table");
            Vehicle v01 = new Vehicle("V00001", Brand.Audi, "MX-60", new DateTime(2008, 01, 01), 125000.00);
            Vehicle v02 = new Vehicle("V00002", Brand.Audi, "MX-90", new DateTime(2012, 01, 01), 105000.00);
            dbT.Create(v01);
            db.Create(dbT);

            VehicleManager vm01 = new VehicleManager("dbVT001", db);
            vm01.Add(v02);
            vm01.ViewAll.ForEach(Console.Write);
            Bay x = new Bay("ddd");
            User.Staff s1 = new User.Staff("S000001", "Jack Jones", JobRole.Sale);
            
            Staff s01 = new Staff("S0001", "Steve", JobRole.Sale);
            Sale si01 = new Sale("SI0001", s01, v01);
            si01.Add(VType.TradeIn, v01);
            Addon a1 = new Addon("A0001", "BodyKit3", "The latest bodykit with seven carbon atoms", 155.0);
            si01.Add(a1);
            Console.WriteLine(si01.View);
            Console.WriteLine(s1.AccountType);
            Console.ReadLine();
        }
    }
}
