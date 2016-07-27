using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Fees
{
    public class FeesSetup
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
        public int? Year { get; set; }
       
        public int? Amount { get; set; }
        public int? FeesDetailsId { get; set; }
        public int? Total { get; set; }




        public int CampusId { get; set; }
    }
}
