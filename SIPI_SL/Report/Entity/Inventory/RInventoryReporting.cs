using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPI_SL.Report.Entity.Inventory
{
    public class RInventoryReporting
    {
        public int Id { get; set; }

        public int ProductMasterEntryId { get; set; }
        public int StockInHand { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal NumberOfProduct { get; set; }
        public decimal EveryPackQuantity { get; set; }
        public decimal SalableQuantity { get; set; }

        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string InvoiceNo { get; set; }
        public string SystemSerialNo { get; set; }
        public decimal GrabdTotal { get; set; }

        public DateTime PurchaseDate { get; set; }
        public string PurchaserInfo { get; set; }


        public int UnitTypeId { get; set; }
        public string UnitType { get; set; }
        public string UnitTypeDetails { get; set; }
        public string UnitTypeNote { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int BrabdId { get; set; }
        public string BrandName { get; set; }
        public string BrandDiscription { get; set; }
        public string ContactInfo { get; set; }

        public decimal ExtraQuantity { get; set; }

        public string OrganizationName { get; set; }
        public string OrganizationMobile { get; set; }
        public string OrganizationAddress { get; set; }




        ///////
        public string StockOutProductName { get; set; }

        public decimal StockOutQuantity { get; set; }

        public decimal StockOutItemPrice { get; set; }
        public decimal StockOutTotalPrice { get; set; }
        public string StockOutInvoiceNo { get; set; }
        public DateTime StockOutDate { get; set; }
        public string StockOutInfo { get; set; }

    }
}
