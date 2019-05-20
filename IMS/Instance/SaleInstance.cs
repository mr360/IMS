using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;

namespace IMS
{
    public enum IdType {  Addon, Vehicle};
}

namespace IMS.Instance
{
    public class SaleInstance
    {
        public SaleInstance(Staff s)
        {
            if (s.Role != JobRole.Sale)
            {
                throw new System.ArgumentException("Invalid User! Cannot create instance!");
            }
        }
        public bool Add(IdType id, string vehicleId)
        {
            //add vehicle id ; add addon id
            //check if duplication is there
            return false;
        }

        public string Add(Vehicle tradeIn)
        {
            // TODO make vehicle manager check validatity of vehicle
            return "";
        }

        public string ViewSelection
        {
            get
            {
                return "Order Selection";
            }
        }

        public string CreateSale()
        {
            // Validate everything / run vehiclebuilder , if error return err result
            // Validate everything / run invoicebuilder , if error return err result
            // Add sale invoice to invoice db
            // Output the sale invoice id
            return "";
        }

    }
}
