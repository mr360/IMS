using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            DbObject.Bay x = new DbObject.Bay("ddd");
            DbObject.User.Staff s1 = new DbObject.User.Staff("S000001", "Jack Jones",JobRole.Sale);
            Console.WriteLine(s1.AccountType);
            Console.ReadLine();
        }
    }
}
