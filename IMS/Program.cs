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
    public sealed class Singleton
    {
        private static Singleton INSTANCE = new Singleton();
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return INSTANCE;
            }
        }
    }

    class Program
    {
        static int Main(string[] args)
        {
            return 0;

        }

    }
}
