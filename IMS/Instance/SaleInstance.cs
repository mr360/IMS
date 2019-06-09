using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Builder;
using IMS.Invoice;
using IMS.Manager;
using IMS.Tools;

namespace IMS
{
    public enum PriceRate { Standard = 100, FiveOff = 95, TenOff = 90, FifteenOff = 85, TwentyOff = 80 };
}

namespace IMS.Instance
{
    /// <summary>
    /// Supports the tasks that the Sale staff are required to handle at HTV, 
    /// such as adding of trade-in vehicles, selecting of vehicles/addons and
    /// price negotiations as well as sales invoice creation.
    /// </summary>
    public class SaleInstance : Instance
    {
        private Vehicle _vehicle;
        private List<Addon> _addon;
        private List<string> _addonIds;
        private Vehicle _tradeIn;
        private Staff _saleRep;
        private Sale _sInvoice;

        public SaleInstance(Staff s, VehicleManager vm, AddonManager am, InvoiceManager im, BayManager bm) : base(vm, am, im, bm)
        {
            if (s.Role != JobRole.Sale)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create sale instance!");
            }

            _saleRep = s;
            _addon = new List<Addon>();
            _addonIds = new List<string>();
        }

        public string ViewSelectedVehicle
        {
            get
            {
                if (_vehicle == null) return "No vehicle selected. No vehicle to view!";
                return _vehicle.View;
            }
        }

        public List<Addon> GetSelectedVehicleAvailableAddons
        {
            get
            {
                _addon.Clear();

                List<DbObject> addonList = _manager["Addon"].RetrieveMany(_vehicle.Id);
                if (addonList != null)
                {
                    foreach (Addon a in addonList)
                    {
                        _addon.Add(a);
                    }
                }
                return _addon;
            }
        }

        public Addon ViewSelectedAddon(string id)
        {
            
            foreach (Addon a in _addon)
            {
                if (a.Id != id) continue;
                return a;
            }

            return null;
        }

        public bool SelectBaseVehicle(string bayId)
        {
            if (!(_manager["Bay"].Contain(bayId)))
            {
                return false;
            }

            Bay bay = _manager["Bay"].Retrieve(bayId) as Bay;
            _vehicle = _manager["Vehicle"].Retrieve(bay.Vehicle) as Vehicle;
            return true;
        }

        public void SelectAddon(string addonId)
        {
            if (!(_addonIds.Contains(addonId)))
            {
                _addonIds.Add(addonId);
            }
        }

        public string GetTradeVehicle(Vehicle tradeIn)
        {
            if (!ValidateIMS.IsValid(tradeIn))
            {
                return "Fail. Not right format";
            }

            // Requires an explicit check because the vehicle is not being entered into the database
            // at this moment. It will be added once sale has been processed.
            if (_manager["Vehicle"].Contain(tradeIn.Id))
            {
                return "Fail. Already exists within system";
            }

            _tradeIn = tradeIn;
            return "Success.";

        }

        public string ViewInvoice
        {
            get
            {
                return _sInvoice.View;
            }
        }

        public string RemoveInvoice()
        {
            if (_sInvoice == null)
            {
                return "Fail. No invoice currently.";
            }

            if (!_manager["Invoice"].Contain(_sInvoice.Id))
            {
                return "Fail. No invoice"; 
            }

            _manager["Invoice"].Delete(_sInvoice.Id);
            _sInvoice = null;

            return "Success.";
        }

        public string CreateSale(PriceRate discount)
        {
            if (_vehicle == null || _addon == null || _addonIds == null)
            {
                return "Missing key sales details";
            }

            VehicleBuilder vBuild = new VehicleBuilder();
            vBuild.Add(_vehicle, VehicleType.New);
            vBuild.Add(_tradeIn, VehicleType.Trade);
            vBuild.SetDiscount(discount);
            vBuild.Add(_addonIds, _addon);
            Order orders = vBuild.Prepare();

            InvoiceBuilder iBuild = new InvoiceBuilder();
            iBuild.Staff = _saleRep;
            iBuild.Order = orders;
            iBuild.TradeVehicle = _tradeIn;
            _sInvoice = iBuild.Prepare() as Sale;

            return _manager["Invoice"].Add(_sInvoice);
        }

    }
}
