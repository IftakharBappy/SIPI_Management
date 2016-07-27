using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.InventoryManagement
{
    public class StockOut
    {
        public int Id { get; set; }

        public int StockInHand { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? ItemPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? StockOutDate { get; set; }
        public string StockOutInfo { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationMobile { get; set; }
        public string OrganizationAddress { get; set; }

        


    }
}
