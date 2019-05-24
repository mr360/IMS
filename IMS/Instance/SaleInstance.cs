using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Builder;
using IMS.Invoice;
using IMS.Manager;
using System.Text.RegularExpressions;

namespace IMS
{
    public enum PriceRate { Standard = 100, FiveOff = 95, TenOff = 90, FifteenOff = 85, TwentyOff = 80 };

    public class ValidateIMS
    {
        public static bool IsBad(string t, string regex)
        {
            return !(Regex.IsMatch(t, regex));
        }
    }
}

namespace IMS.Instance
{
    public class SaleInstance : Instance
    {
        private Vehicle _vehicle;
        private List<Addon> _addon;
        private List<string> _addonIds = new List<string>();
        private Vehicle _tradeIn;
        Staff _saleRep;
        Sale _sInvoice;

        public SaleInstance(Staff s, VehicleManager vm, AddonManager am, InvoiceManager im, BayManager bm) : base(vm, am, im, bm)
        {
            if (s.Role != JobRole.Sale)
            {
                throw new System.InvalidOperationException("Invalid User! Cannot create instance!");
            }

            _saleRep = s;
        }


        // Lot Class Candidate
        public List<string> AllBays
        {
            get
            {
                // Vehicles should have a bool called Sold ; select vehicles that are unsold
                List<DbObject> vList = _manager["Vehicle"].RetrieveMany("UnSold") ;
                // Select bays that are occupied 
                List<DbObject> bList = _manager["Bay"].RetrieveMany("Occupied");

                List<string> allBay = new List<string>();
                foreach (Bay b in bList)
                {
                    foreach (Vehicle v in vList)
                    {
                        if (b.Vehicle == v.Id)
                        {
                            allBay.Add(b.Id);
                        }
                    }
                }

                return allBay;
            }
        }





        public string ViewSelectedVehicle
        {
            get
            {
                if (_vehicle == null) return "No vehicle to view!";
                return _vehicle.View;
            }
        }

        public List<Addon> GetSelectedVehicleAvailableAddons
        {
            get
            {
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
            Bay b = _manager["Bay"].Retrieve(bayId) as Bay;
            if (b == null)
            {
                return false;
            }
            
            _vehicle = _manager["Vehicle"].Retrieve(b.Vehicle) as Vehicle;
            _addon = new List<Addon>();
            
            List<DbObject> addonList = _manager["Addon"].RetrieveMany(_vehicle.Id);
            if (addonList != null)
            {
                foreach (Addon a in addonList)
                {
                    _addon.Add(a);
                }
            }

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
            if (tradeIn == null)
            {
                return "Fail. No trade-in vehicle(null)";    
            }

            if (ValidateIMS.IsBad(tradeIn.Id, @"^[a-zA-Z0-9]+$") || ValidateIMS.IsBad(tradeIn.Model, @"^[a-zA-Z0-9-]+$") || tradeIn.Price < 0.00)
            {
                return "Fail. Not right format";
            }

            Vehicle v = _manager["Vehicle"].Retrieve(tradeIn.Id) as Vehicle;
            if ( v != null )
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
                // Once the sale invoice has been created then the summary will be show here.
                // the winform will be able to show the summary. Msg user saying that it will be available once
                // CreateSale is done.
                return _sInvoice.View;
            }
        }

        public string CreateSale(PriceRate priceRate)
        {
            if (_vehicle == null || _addon == null || _addonIds == null)
            {
                return "Missing key sales details";
            }
                // Validate everything / run vehiclebuilder , if error return err result
                // Validate everything / run invoicebuilder , if error return err result
                // Add sale invoice to invoice db
                // Output the sale invoice id

            VehicleBuilder vBuild = new VehicleBuilder();
            vBuild.Add(_vehicle, priceRate);
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
