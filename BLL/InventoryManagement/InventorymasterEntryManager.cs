using DAL.InventoryManagement;
using ENTITY.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.InventoryManagement
{
    public class InventorymasterEntryManager
    {
        ProductMasterEntry_inventoryGetway inventoryGrtway_inventoryGetwayObj = new ProductMasterEntry_inventoryGetway();
        public void SaveProductMasterEntry(ProductMasterEntry_inventory productMasterEntryEntity_inventoryObj)
        {
            inventoryGrtway_inventoryGetwayObj.SaveProductMasterEntry(productMasterEntryEntity_inventoryObj);
        }

        public List<ProductMasterEntry_inventory> GetAllProductMasterEntry()
        {
            return inventoryGrtway_inventoryGetwayObj.GetAllProductMasterEntry();
        }

        public void SaveStockDetails(List<PurchaseEntry> purchaseEntryList)
        {
            inventoryGrtway_inventoryGetwayObj.SaveStockDetails(purchaseEntryList);
        }

        public void UpdateStock(List<PurchaseEntry> purchaseEntryList)
        {
            inventoryGrtway_inventoryGetwayObj.UpdateStock(purchaseEntryList);

        }

        public List<PurchaseEntry> GetAllProductPurchageEntry()
        {
            return inventoryGrtway_inventoryGetwayObj.GetAllProductPurchageEntry();
        }

        public void SaveStockOutDetails(List<StockOut> stockOutList)
        {
            inventoryGrtway_inventoryGetwayObj.SaveStockOutDetails(stockOutList);
        }

        public void UpdateAfterStockOut(List<StockOut> stockOutList)
        {
            inventoryGrtway_inventoryGetwayObj.UpdateAfterStockOut(stockOutList);
        }

        public List<StockOut> GetAllstockOutList()
        {
            return inventoryGrtway_inventoryGetwayObj.GetAllstockOutList();
        }

        public string GetAinvoiceNumber()
        {
            return inventoryGrtway_inventoryGetwayObj.GetAinvoiceNumber();
        }
        public string GetSystemSerialNumber()
        {
            return inventoryGrtway_inventoryGetwayObj.GetSystemSerialNumber();
        }

        public List<StockOut> GetstockOutSlip(string Slip)
        {
            return inventoryGrtway_inventoryGetwayObj.GetstockOutSlip(Slip);

        }

        public List<PurchaseEntry> GetPurchageEntrySlip(string Slip)
        {
            return inventoryGrtway_inventoryGetwayObj.GetPurchageEntrySlip(Slip);

        }

        public List<InventoryReporting> GetinventoryReposrt(DateTime strat, DateTime end, string searchType)
        {
            return inventoryGrtway_inventoryGetwayObj.GetinventoryReposrt(strat, end, searchType);
        }
    }
}
