using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.Invoice;
using IMS.User;

namespace IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Bay x = new Bay("ddd");
            User.Staff s1 = new User.Staff("S000001", "Jack Jones",JobRole.Sale);
             Vehicle v01 = new Vehicle("V00001", Brand.Audi, "MX-60", new DateTime(2008, 01, 01), 125000.00);
             Staff s01 = new Staff("S0001", "Steve", JobRole.Sale);
            Sale si01 = new Sale("SI0001", s01, v01);
            Console.WriteLine(s1.AccountType);
            Console.ReadLine();
        }
    }
}
