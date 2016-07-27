using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.PIS
{
    public class Grade
    {
        public Guid GGradeInfoID { get; set; }
        public Guid GGradeTypeID { get; set; }
        public string StrGradeName { get; set; }
        public string StrGradeDesc { get; set; }
        public decimal numMinimumSalary { get; set; }
        public decimal numMaximumSalary { get; set; }
    }
}
