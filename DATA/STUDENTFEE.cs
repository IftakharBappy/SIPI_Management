//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class STUDENTFEE
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> FeesDetailsId { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> StudentPkId { get; set; }
        public Nullable<int> DiscountAmount { get; set; }
        public Nullable<int> DiscountPercent { get; set; }
        public Nullable<int> TotalPayableAmount { get; set; }
        public Nullable<int> PaidAmount { get; set; }
        public Nullable<int> DueAmount { get; set; }
        public string PaidStatus { get; set; }
    
        public virtual FEESDETAIL FEESDETAIL { get; set; }
    }
}
