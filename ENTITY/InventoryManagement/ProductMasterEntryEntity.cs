using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.InventoryManagement
{
    public class ProductMasterEntryEntity
    {
        public int Id { get; set; }
        public decimal StockInHand { get; set; }
        /////public int ProductId { get; set; }
        public string ProductName { get; set; }


        public int? UnitTypeId { get; set; }
        public string UnitType { get; set; }
        public string UnitTypeDetails { get; set; }
        public string UnitTypeNote { get; set; }

        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int? BrabdId { get; set; }
        public string BrandName { get; set; }
        public string BrandDiscription { get; set; }
        public string ContactInfo { get; set; }
    }
}
