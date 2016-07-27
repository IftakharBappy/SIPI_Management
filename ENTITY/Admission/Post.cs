using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
    public class Post
    {
       

        public int Id { get; set; }
        public string PostName {get; set;}
        public int? ThanaId { get; set; }
        public string ThanaName { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string PostCode { get; set; }
        public string BanglaPostName { get; set; }

        
        
    }
}
