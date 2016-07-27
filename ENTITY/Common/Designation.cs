using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Common
{
    public class Designation
    {
        public Guid GDesignationInfoID { get; set; }
        public string StrDesignationName { get; set; }
        public Guid GGradeInfoID { get; set; }
        public string StrDesignationCode { get; set; }
    }
}
