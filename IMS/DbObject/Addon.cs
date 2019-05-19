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
        private List<string> _compatibleVehicle;

        public Addon(string id, string name, string desc, double price) : base(id)
        {
            _name = name;
            _desc = desc;
            _price = price;
            _compatibleVehicle = new List<string>();
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
            return (!_compatibleVehicle.Contains(id) && id != "");
        }

        public bool AddCompatible(string id)
        {
            if (IsCompatible(id))
            {
                _compatibleVehicle.Add(id);
                return true;
            }
            return false;
        }
        public bool RemoveCompatible(string id)
        {
            if (IsCompatible(id))
            {
                _compatibleVehicle.Remove(id);
                return true;
            }
            return false;
        }

    }
}
