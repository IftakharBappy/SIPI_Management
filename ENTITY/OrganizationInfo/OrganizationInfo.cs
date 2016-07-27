using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.OrganizationInfo
{
     public class OrganizationInfo
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAddress { get; set; }
        public string OrganizationMobile { get; set; }
        public string BasicInfo { get; set; }
        public string DateOfEstablishment { get; set; }
    }
}
