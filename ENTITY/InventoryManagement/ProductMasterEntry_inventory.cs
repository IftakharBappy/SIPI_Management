using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.InventoryManagement
{
    public class ProductMasterEntry_inventory
    {
        public int Id { get; set; }
        public decimal? Stock_InHand { get; set; }
        public string Product_Name { get; set; }
        public int? UnitType_Id { get; set; }
        public string UnitTypeName { get; set; }
        public int? Category_Id { get; set; }
        public string CategoryName { get; set; }
        public int? Brabd_Id { get; set; }
        public string BrabdName { get; set; }
        public string UnitType_Note { get; set; }
        public decimal? StockOutPrice { get; set; }

       
    }
}
