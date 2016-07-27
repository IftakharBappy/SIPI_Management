using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPI_SL.Report.Entity.Inventory
{
    public class RInventoryStockOutER
    {
        public int Id { get; set; }
        public int StockInHand { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime StockOutDate { get; set; }
        public string StockOutInfo { get; set; }
        public decimal GrandTotal { get; set; }

        public string BrandName { get; set; }
        public string CategoryName { get; set; }

        public string OrganizationName { get; set; }
        public string OrganizationAddress { get; set; }
        public string OrganizationMobile { get; set; }
        public string BasicInfo { get; set; }
        public string DateOfEstablishment { get; set; }

    }
}
