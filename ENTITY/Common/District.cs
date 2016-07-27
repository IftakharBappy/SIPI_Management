using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Common
{
    public class District
    {
        public Guid GDistrictInfoID { get; set; }
        public Guid GCountryNameID { get; set; }
        public string StrDistrictCode { get; set; }
        public string StrDistrictName { get; set; }
        public string StrDistrictDescription { get; set; }
    }
}
