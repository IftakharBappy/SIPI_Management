using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Fees
{
   public class FeesCollection
    {
        public int Id { get; set; }
        public string FeesName { get; set; }
        public int FeesAmount { get; set; }
        public int? StudentId { get; set; }
        public int? Year { get; set; }

        public int? CampusId { get; set; }
        public string CampusName { get; set; }


        public Nullable<int> SemesterId { get; set; }


        public int? FeesDetailsId { get; set; }

        public int? Amount { get; set; }

        public int? Total { get; set; }

        public int? DiscountAmount { get; set; }

        public int? DiscountPercent { get; set; }

        public int? TotalPayableAmount { get; set; }

        public int? DueAmount { get; set; }

        public string PaidStatus { get; set; }

        public string FeesDetailsName { get; set; }



        public Nullable<DateTime> CollectionDate { get; set; }


        public int ReceivableAmount { get; set; }

        public string StudentName { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public Nullable<int> ReceiveAmount { get; set; }
    }
}
