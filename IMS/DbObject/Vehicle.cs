using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public enum Brand { Ford, Holden, Jeep, Chrysler, Volvo, Tesla, Lexus, Audi, Toyota, Chevrolet, BMW, GM };

}

namespace IMS
{
    public class Vehicle : DbObject
    {
        private Brand _brand;
        private string _model;
        private int _year;
        private double _price;

        public Vehicle(string id, Brand brand, string model, DateTime year, double price) : base(id)
        {
            _brand = brand;
            _model = model;
            _year = year.Year;
            _price = Math.Abs(price);
            
        }

        public override string View
        {
            get
            {
                return ("Brand: " + Brand + " | Model: " + Model + " | Year: " + Year + " | Price: " + Price + "\n");
            }
        }

        public Brand Brand
        {
            get
            {
                return _brand;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
        }

        public string Year
        {
            get
            {
                return _year.ToString();
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
    }
}
