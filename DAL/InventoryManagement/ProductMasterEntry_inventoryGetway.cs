using DATA;
using ENTITY.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.InventoryManagement
{
    public class ProductMasterEntry_inventoryGetway
    {

        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void SaveProductMasterEntry(ProductMasterEntry_inventory productMasterEntryEntity_inventoryObj)
        {

            var newProductMasterEntry = new INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY
            {
                ProductName = productMasterEntryEntity_inventoryObj.Product_Name,
                BrandId = productMasterEntryEntity_inventoryObj.Brabd_Id,
                CategoryId = productMasterEntryEntity_inventoryObj.Category_Id,
                UnitTypeId = productMasterEntryEntity_inventoryObj.UnitType_Id,
                UnitTypeNote = productMasterEntryEntity_inventoryObj.UnitType_Note,
                StockInHand = 0,
            };
            datacontextObj.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.Add(newProductMasterEntry);
            datacontextObj.SaveChanges();
            
        }



        public List<ProductMasterEntry_inventory> GetAllProductMasterEntry()
        {
            List<ProductMasterEntry_inventory> productMasterEntryList = new List<ProductMasterEntry_inventory>();
            datacontextObj = new SIPIDBEntities();
            foreach (var p in (from j in datacontextObj.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY select j).Distinct())
            {
                ProductMasterEntry_inventory productMasterEntryObj = new ProductMasterEntry_inventory();
                
                productMasterEntryObj.Id = p.Id;
                productMasterEntryObj.Product_Name = p.ProductName;
                productMasterEntryObj.Brabd_Id = p.BrandId;
                productMasterEntryObj.BrabdName = p.INVENTORY_BRAND_NAME.BrandName;

                productMasterEntryObj. Category_Id= p.CategoryId;
                productMasterEntryObj.CategoryName= p.INVENTORY_BRAND_CATEGORY.CategoryName;

                productMasterEntryObj.UnitType_Id = p.UnitTypeId;
                productMasterEntryObj.UnitTypeName = p.INVENTORY_UNIT_TYPE.UnitType;

                productMasterEntryObj.UnitType_Note = p.UnitTypeNote;
                productMasterEntryObj.Stock_InHand = p.StockInHand;
                productMasterEntryObj.StockOutPrice = p.StockPrice;

                productMasterEntryList.Add(productMasterEntryObj);
            }
            return productMasterEntryList;
        }

        public void SaveStockDetails(List<PurchaseEntry> purchaseEntryList)
        {
            foreach (PurchaseEntry item in purchaseEntryList)
            {
                var newPurchaseDetails = new INVENTORY_PURCHAGE_DETAILS
                {
                    InvoiceNo = item.InvoiceNo,
                    SystemSerialNo = item.SystemSerialNo,
                    PurchaseDate = item.PurchaseDate,
                    PurchaserInfo = item.PurchaserInfo,
                    ProductName = item.ProductName,
                    ProductId = item.ProductId,
                    NumberOfProduct = item.NumberOfProduct,
                    EveryPackQuantity = item.EveryPackQuantity,
                    ExtraQuantity = item.ExtraQuantity,
                    SalableQuantity = item.SalableQuantity,
                    ItemPrice = item.ItemPrice,
                    TotalPrice = item.TotalPrice,
                };
                datacontextObj.INVENTORY_PURCHAGE_DETAILS.Add(newPurchaseDetails);
                datacontextObj.SaveChanges();
            }

            
        }

        public void UpdateStock(List<PurchaseEntry> purchaseEntryList)
        {
            foreach (PurchaseEntry item in purchaseEntryList)
            {
                var quantityUpdate = datacontextObj.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.First(c => c.Id == item.ProductId);
                decimal? updateStock = quantityUpdate.StockInHand + item.SalableQuantity;
                quantityUpdate.StockInHand = updateStock;
                datacontextObj.SaveChanges();
             }
        }

        public List<PurchaseEntry> GetAllProductPurchageEntry()
        {

            List<PurchaseEntry> productPurchageEntryList = new List<PurchaseEntry>();
            datacontextObj = new SIPIDBEntities();
            foreach (var p in (from j in datacontextObj.INVENTORY_PURCHAGE_DETAILS select new { j.SystemSerialNo, j.PurchaseDate, j.PurchaserInfo, j.InvoiceNo }).Distinct())
            {
                PurchaseEntry purchaseEntryObj = new PurchaseEntry();
                purchaseEntryObj.SystemSerialNo = p.SystemSerialNo;
                purchaseEntryObj.PurchaseDate = p.PurchaseDate;
                purchaseEntryObj.PurchaserInfo = p.PurchaserInfo;
                purchaseEntryObj.InvoiceNo = p.InvoiceNo;
                productPurchageEntryList.Add(purchaseEntryObj);
            }
            return productPurchageEntryList;
        }

        public void UpdateAfterStockOut(List<StockOut> stockOutList)
        {
            foreach (StockOut item in stockOutList)
            {
                var inventoryStockQuantity = datacontextObj.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.First(c => c.Id == item.ProductId);
                decimal? updateBookStockQuantity = inventoryStockQuantity.StockInHand - item.Quantity;
                inventoryStockQuantity.StockInHand = updateBookStockQuantity;
                datacontextObj.SaveChanges();
            }
        }

        public void SaveStockOutDetails(List<StockOut> stockOutList)
        {
            foreach (StockOut item in stockOutList)
            {
                var newStockOutDetails = new INVENTORY_STOCKOUT_DETAILS
                {
                    InvoiceNo = item.InvoiceNo,
                    StockOutDate = item.StockOutDate,
                    StockOutInfo= item.StockOutInfo,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    ItemPrice = item.ItemPrice,
                    TotalPrice = item.TotalPrice,
                };
                datacontextObj.INVENTORY_STOCKOUT_DETAILS.Add(newStockOutDetails);
                datacontextObj.SaveChanges();
            }
        }

        public List<StockOut> GetAllstockOutList()
        {
            List<StockOut> stockOutList = new List<StockOut>();
            datacontextObj = new SIPIDBEntities();

            foreach (var p in (from j in datacontextObj.INVENTORY_STOCKOUT_DETAILS
                               select new { j.InvoiceNo, j.StockOutDate, j.StockOutInfo }).Distinct())
            {
                StockOut stockOutObj = new StockOut();
                stockOutObj.InvoiceNo = p.InvoiceNo;
                stockOutObj.StockOutDate = p.StockOutDate;
                stockOutObj.StockOutInfo = p.StockOutInfo;
                stockOutList.Add(stockOutObj);
            }
            return stockOutList;

        }
        

        public string GetAinvoiceNumber()
        { 
            string invoiveNumber = "";
            for (var x = 0; x < 100000000; x++)
            {
                if (x > 0)
                {
                    string chq = "";

                    chq = x.ToString();
                    var invoiceNoChick = (from s in datacontextObj.INVENTORY_STOCKOUT_DETAILS where s.InvoiceNo == chq select s).Count();
                    if (invoiceNoChick == 0)
                    {
                        invoiveNumber = x.ToString();
                        break;
                    }
                }
            }
            return invoiveNumber;

        }
        public string GetSystemSerialNumber()
        {
            string invoiveNumber = "";
            for (var x = 0; x < 100000000; x++)
            {
                if (x > 0)
                {
                    string chq = "";

                    chq = x.ToString();
                    var invoiceNoChick = (from s in datacontextObj.INVENTORY_PURCHAGE_DETAILS where s.SystemSerialNo == chq select s).Count();
                    if (invoiceNoChick == 0)
                    {
                        invoiveNumber = x.ToString();
                        break;
                    }
                }
            }
            return invoiveNumber;

        }

        public List<StockOut> GetstockOutSlip(string Slip)
        {
            List<StockOut> stockOutList = new List<StockOut>();
            datacontextObj = new SIPIDBEntities();

            foreach (var p in (from j in datacontextObj.INVENTORY_STOCKOUT_DETAILS where
                               j.InvoiceNo.Equals(Slip)  select j).Distinct())
            {
                StockOut stockOutObj = new StockOut();

                stockOutObj.Id = p.Id;

                stockOutObj.InvoiceNo = p.InvoiceNo;
                stockOutObj.StockOutDate = p.StockOutDate;
                stockOutObj.StockOutInfo = p.StockOutInfo;

                stockOutObj.ItemPrice = p.ItemPrice;
                stockOutObj.TotalPrice = p.TotalPrice;
                stockOutObj.Quantity = p.Quantity;
                stockOutObj.ProductName = p.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.ProductName;
                
                stockOutList.Add(stockOutObj);
            }

            foreach (var p in (from j in datacontextObj.ORGANIZATION_INFO select j).Distinct())
            {
                foreach (var item in stockOutList)
                {
                    item.OrganizationName = p.OrganizationName;
                    item.OrganizationAddress = p.OrganizationAddress;
                    item.OrganizationMobile = p.OrganizationMobile;
                }
            }
            return stockOutList;
        }

        public List<PurchaseEntry> GetPurchageEntrySlip(string Slip)
        {
            List<PurchaseEntry> purchageEntryList = new List<PurchaseEntry>();
            datacontextObj = new SIPIDBEntities();

            foreach (var p in (from j in datacontextObj.INVENTORY_PURCHAGE_DETAILS
                               where j.SystemSerialNo.Equals(Slip)
                               select j).Distinct())
            {
                PurchaseEntry stockOutObj = new PurchaseEntry();

                stockOutObj.Id = p.Id;

                stockOutObj.InvoiceNo = p.InvoiceNo;
                stockOutObj.SystemSerialNo = p.SystemSerialNo;
                stockOutObj.PurchaseDate = p.PurchaseDate;

                stockOutObj.ItemPrice = p.ItemPrice;
                stockOutObj.TotalPrice = p.TotalPrice;
                stockOutObj.NumberOfProduct = p.NumberOfProduct;
                stockOutObj.SalableQuantity = p.SalableQuantity;
                stockOutObj.EveryPackQuantity = p.EveryPackQuantity;
                stockOutObj.ExtraQuantity = p.ExtraQuantity;
                stockOutObj.NumberOfProduct = p.NumberOfProduct;
                stockOutObj.ProductName = p.ProductName;
                stockOutObj.PurchaserInfo = p.PurchaserInfo;
                stockOutObj.UnitType = p.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.INVENTORY_UNIT_TYPE.UnitType;
                stockOutObj.BrandName = p.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.INVENTORY_BRAND_NAME.BrandName;
                

                purchageEntryList.Add(stockOutObj);
            }
            foreach (var p in (from j in datacontextObj.ORGANIZATION_INFO select j).Distinct())
            {
                foreach (var item in purchageEntryList)
                {
                    item.OrganizationName = p.OrganizationName;
                    item.OrganizationAddress = p.OrganizationAddress;
                    item.OrganizationMobile = p.OrganizationMobile;
                }
            }
            return purchageEntryList;
        }

       
        public List<InventoryReporting> GetinventoryReposrt(DateTime strat, DateTime end, string searchType)
        {
             List<InventoryReporting> inventoryRepportList = new List<InventoryReporting>();
            datacontextObj = new SIPIDBEntities();

            foreach (var p in (from j in datacontextObj.INVENTORY_PURCHAGE_DETAILS
                               where j.PurchaseDate >= strat && j.PurchaseDate <= end select j))
            {
                InventoryReporting stockOutObj = new InventoryReporting();

                stockOutObj.Id = p.Id;

                stockOutObj.InvoiceNo = p.InvoiceNo;
                stockOutObj.SystemSerialNo = p.SystemSerialNo;
                stockOutObj.PurchaseDate = p.PurchaseDate;

                stockOutObj.ItemPrice = p.ItemPrice;
                stockOutObj.TotalPrice = p.TotalPrice;
                stockOutObj.NumberOfProduct = p.NumberOfProduct;
                stockOutObj.SalableQuantity = p.SalableQuantity;
                stockOutObj.EveryPackQuantity = p.EveryPackQuantity;
                stockOutObj.ExtraQuantity = p.ExtraQuantity;
                stockOutObj.NumberOfProduct = p.NumberOfProduct;
                stockOutObj.ProductName = p.ProductName;
                stockOutObj.PurchaserInfo = p.PurchaserInfo;
                stockOutObj.UnitType = p.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.INVENTORY_UNIT_TYPE.UnitType;
                stockOutObj.BrandName = p.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.INVENTORY_BRAND_NAME.BrandName;

                inventoryRepportList.Add(stockOutObj);
            }
            foreach (var p in (from j in datacontextObj.INVENTORY_STOCKOUT_DETAILS
                               where j.StockOutDate >= strat && j.StockOutDate <= end
                               select j))
            {
                foreach (var item in inventoryRepportList)
                {
                    item.StockOutDate = p.StockOutDate;
                    item.StockOutInfo = p.StockOutInfo;
                    item.StockOutInvoiceNo = p.InvoiceNo;
                    item.StockOutItemPrice = p.ItemPrice;
                    item.StockOutProductId = p.ProductId;
                    item.StockOutProductName = p.INVENTORY_PRODUCT_MASTER_ENTRY_INVENTORY.ProductName;
                    item.StockOutQuantity = p.Quantity;
                    item.StockOutTotalPrice = p.TotalPrice;
                }

                return inventoryRepportList;

            }       

            foreach (var p in (from j in datacontextObj.ORGANIZATION_INFO select j).Distinct())
            {
                foreach (var item in inventoryRepportList)
                {
                    item.OrganizationName = p.OrganizationName;
                    item.OrganizationAddress = p.OrganizationAddress;
                    item.OrganizationMobile = p.OrganizationMobile;
                }
            }
            return inventoryRepportList;
        }
    }
}
