using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Report.Fees
{
    public class RStudentFees
    {
        public string InstituteName { get; set; }
        public string InstituteAddress { get; set; }
        public int SerialNo { get; set; }
        public DateTime MoneyReceitDate { get; set; }
        public string StudentName { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public string StudentReg { get; set; }
        public string StudentId { get; set; }
        public string StudentRoll { get; set; }
        public string FeesDetailsName { get; set; }

        public Nullable<int> FeesDetailsAmount { get; set; }

        public Nullable<int> ReceiveAmount { get; set; }

        public Nullable<DateTime> ReceiveDate { get; set; }
    }
}
