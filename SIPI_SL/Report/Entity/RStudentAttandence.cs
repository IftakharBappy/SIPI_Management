using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPI_SL.Report.Entity
{
    public class RStudentAttandence
    {
        public int ID { get; set; }
        public int StudentPKId { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int CampusId { get; set; }
        public string CampusName { get; set; }
        public string SemesterNo { get; set; }
        public string StudentName { get; set; }
        public string DepartmentName { get; set; }
    }
}
