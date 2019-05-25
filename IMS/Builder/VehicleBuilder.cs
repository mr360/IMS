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
    }
}

namespace IMS.Builder
{
    public class VehicleBuilder
    {
        private Order _order;

        public VehicleBuilder()
        {
            _order.addons = new List<Addon>();
        }

        public void Add(Vehicle vehicle, PriceRate discount)
        {
            vehicle.Price = vehicle.Price * ((int)discount * 0.01);
            _order.buyVehicle = vehicle;
        }

        public void Add(List<string> addonId, List<Addon> addon)
        {
            List<Addon> selectedAddons = new List<Addon>();
            foreach (string id in addonId)
            {
                foreach (Addon a in addon)
                {
                    if (addonId.Contains(a.Id))
                    {
                        selectedAddons.Add(a);
                    }
                }
            }

            _order.addons = selectedAddons;
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
