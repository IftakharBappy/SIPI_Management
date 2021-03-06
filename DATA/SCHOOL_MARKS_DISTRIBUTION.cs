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
    
    public partial class SCHOOL_MARKS_DISTRIBUTION
    {
        public int Id { get; set; }
        public Nullable<int> ClassId { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public Nullable<int> TermId { get; set; }
        public string TermName { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<decimal> Theory { get; set; }
        public Nullable<decimal> MCQ { get; set; }
        public Nullable<decimal> Practical { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Grade { get; set; }
        public Nullable<decimal> GradePoint { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> StudentPKId { get; set; }
        public string StudentName { get; set; }
        public Nullable<decimal> FullMarks { get; set; }
    
        public virtual ADMISSIONINFO ADMISSIONINFO { get; set; }
        public virtual COURSE_ENTRY COURSE_ENTRY { get; set; }
        public virtual SEMESTER SEMESTER { get; set; }
        public virtual SIPI_DEPARTMENT SIPI_DEPARTMENT { get; set; }
    }
}
