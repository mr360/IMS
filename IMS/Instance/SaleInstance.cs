using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;
using IMS.Builder;
using IMS.Invoice;
using IMS.Manager;

namespace IMS
{
    public enum IdType {  Addon, Vehicle};
}

namespace IMS.Instance
{
    public class SaleInstance : Instance
    {
        private string _vehicleId;
        private List<string> _addonIds;
        private Vehicle _tradeIn;
        Staff _saleRep;
        
        public SaleInstance(Staff s, VehicleManager vm, AddonManager am, InvoiceManager im) : base(vm,am,im)
        {
            if (s.Role != JobRole.Sale)
            {
                throw new System.ArgumentException("Invalid User! Cannot create instance!");
            }

            _saleRep = s;
        }

        public bool Add(IdType type, string id)
        {
            //add vehicle id ; add addon id
            //check if duplication is there            
            if (type == IdType.Addon)
            {
                if (_addonIds.Contains(id))
                {
                    return false;
                }
                _addonIds.Add(id);
            }
            else
            {
                _vehicleId = id;
                return true;
            }
            
            return false;
        }

        public string Add(Vehicle tradeIn)
        {
            // optional validate vehicle here
            _tradeIn = tradeIn;
            return "Successfully added.";
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

            VehicleBuilder vBuild = new VehicleBuilder(_manager["Vehicle"], _manager["Addon"]);
            string lMsg = "";

            lMsg = vBuild.Add(_vehicleId);
            if (lMsg != "Success.")
            {
                return lMsg;
            }

            vBuild.Add(_addonIds);
            if (lMsg != "Success.")
            {
                return lMsg;
            }

            Order orders = vBuild.Prepare();

            InvoiceBuilder iBuild = new InvoiceBuilder();
            iBuild.Staff = _saleRep;
            iBuild.Order = orders;
            iBuild.TradeVehicle = _tradeIn;
            Sale sInvoice = iBuild.Prepare() as Sale;

            return _manager["Invoice"].Add(sInvoice);
        }

    }
}
