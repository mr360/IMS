using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class Addon : DbObject
    {
        private string _name;
        private string _desc;
        private double _price;
        private string _compatibleVehicle;

        public Addon(string id, string name, string desc, double price) : base(id)
        {
            _name = name;
            _desc = desc;
            _price = Math.Abs(price);
        }

        public override string View
        {
            get
            {
                return ("Addon Name: " + Name + "| Desc: " + Desc +  "| Price: " + Price + "\n");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Desc
        {
            get
            {
                return _desc;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public bool IsCompatible(string id)
        {
            return (_compatibleVehicle == id);
        }

        public string Compatible
        {
             get
             {
                return _compatibleVehicle;
             }
             set
             {
                _compatibleVehicle = value;
             }           
        }

    }
}
