using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;

namespace IMS
{
    public struct Order
    {
        public Vehicle buyVehicle;
        public List<Addon> addons;
        public Vehicle tradeVehicle;
    }

    public enum VehicleType { Trade, New};
}

namespace IMS.Builder
{
    /// <summary>
    /// Assembles the vehicle order based off of the inputted data.
    /// </summary>
    public class OrderBuilder
    {
        private Order _order;

        public OrderBuilder()
        {
            _order.addons = new List<Addon>();
        }

        public void Add(Vehicle vehicle, VehicleType vType)
        {
            switch(vType)
            {
                case VehicleType.New:
                    _order.buyVehicle = vehicle;
                    break;
                case VehicleType.Trade:
                    _order.tradeVehicle = vehicle;
                    break;
                default: throw new ArgumentException("Not valid argument");
            }
            
        }

        public void SetDiscount(PriceRate discount)
        {
            if (_order.buyVehicle == null)
            {
                throw new ArgumentNullException("Can't apply discount to null vehicle");
            }
            _order.buyVehicle.Price *= ((int)discount * 0.01);
        }

        public void Add(List<string> addonSelected, List<Addon> availableAddon)
        {
            _order.addons.Clear();

            foreach (string id in addonSelected)
            {
                foreach (Addon a in availableAddon)
                {
                    if (addonSelected.Contains(a.Id))
                    {
                        _order.addons.Add(a);
                    }
                }
            }

        }

        public Order Prepare()
        {
            if (_order.buyVehicle == null)
            {
                throw new System.ArgumentException("Invalid code path. Need to declare builder parameters!");
            }

            return _order;
        }

    }
}
