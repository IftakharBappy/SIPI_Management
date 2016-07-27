using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.InventoryManagement
{
    public class BrandCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        
        public int? BrabdId { get; set; }
        public string BrandName { get; set; }
        public string BrandDiscription { get; set; }
        public string ContactInfo { get; set; }
    }
}
