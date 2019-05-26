using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using System.Text.RegularExpressions;

namespace IMS.Tools
{
    /// <summary>
    /// Provides methods to validate the user inputs
    /// </summary>
    public class ValidateIMS
    {
        public static bool IsBad(string t, string regex)
        {
            return !(Regex.IsMatch(t, regex));
        }

        public static bool IsValid(DbObject item)
        {
            if (item == null)
            {
                return false;
            }

            switch (item.GetType().Name)
            {
                case nameof(Vehicle):
                    return IsVehicleValid(item as Vehicle);
                case nameof(Addon):
                    return IsAddonValid(item as Addon);
                case nameof(Customer):
                    return IsCustomerValid(item as Customer);
                default: return false;
            }
        }

        private static bool IsVehicleValid(Vehicle item)
        {
            if (ValidateIMS.IsBad(item.Id, @"^[a-zA-Z0-9]{1,10}$") || ValidateIMS.IsBad(item.Model, @"^[a-zA-Z0-9-]{1,25}$") || item.Price <= 0.00)
            {
                return false;
            }

            return true;
        }

        private static bool IsAddonValid(Addon item)
        {
            if (ValidateIMS.IsBad(item.Id, @"^[a-zA-Z0-9]{1,10}$") || ValidateIMS.IsBad(item.Name, @"^[a-zA-Z0-9-]{1,25}$") || item.Price <= 0.00)
            {
                return false;
            }

            return true;
        }

        private static bool IsCustomerValid(Customer item)
        {
            if (ValidateIMS.IsBad(item.Id, @"^[a-zA-Z0-9]{1,10}$") || ValidateIMS.IsBad(item.Name, @"^[a-zA-Z ]{1,50}$") || ValidateIMS.IsBad(item.Address, @"^[a-zA-Z0-9, ]{1,70}$") || ValidateIMS.IsBad(item.Phone, @"^\d{10}$"))
            {
                return false;
            }

            return true;
        }
    }
}

