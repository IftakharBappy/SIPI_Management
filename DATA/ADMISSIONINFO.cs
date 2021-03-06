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
    
    public partial class ADMISSIONINFO
    {
        public ADMISSIONINFO()
        {
            this.BOOK_ISSUE = new HashSet<BOOK_ISSUE>();
            this.COURSE_ASSIGN_TO_STUDENT = new HashSet<COURSE_ASSIGN_TO_STUDENT>();
            this.SCHOOL_FEES_COLLECTION = new HashSet<SCHOOL_FEES_COLLECTION>();
            this.SCHOOL_MARKS_DISTRIBUTION = new HashSet<SCHOOL_MARKS_DISTRIBUTION>();
            this.STUDENT_ATTENDENCE = new HashSet<STUDENT_ATTENDENCE>();
            this.STUDENT_RESULT = new HashSet<STUDENT_RESULT>();
            this.STUDENTFEESCOLLECTIONs = new HashSet<STUDENTFEESCOLLECTION>();
        }
    
        public string StudentStatus { get; set; }
        public int Id { get; set; }
        public string FathersMonthlyIncome { get; set; }
        public string StudentID { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> CampusId { get; set; }
        public string Session { get; set; }
        public string AccadamicYear { get; set; }
        public Nullable<int> BatchId { get; set; }
        public Nullable<int> BanglaProgram { get; set; }
        public Nullable<int> BangDepartment { get; set; }
        public Nullable<int> BanglaCampas { get; set; }
        public string BanglaSession { get; set; }
        public string BanglaAccadamicYear { get; set; }
        public Nullable<int> BanglaBatch { get; set; }
        public string ApplicantName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> BanglaDateOfBirth { get; set; }
        public string Nationality { get; set; }
        public Nullable<int> BloodGroup { get; set; }
        public Nullable<int> ReligionId { get; set; }
        public string Interest { get; set; }
        public string OthersInfo { get; set; }
        public string BanglaApplicantName { get; set; }
        public string BanglaGender { get; set; }
        public string BanglaNationality { get; set; }
        public Nullable<int> BanglaReligion { get; set; }
        public string BanglaHobby { get; set; }
        public string BanglaInterest { get; set; }
        public string BanglaOthersInfo { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Nullable<bool> FreedomFighter { get; set; }
        public Nullable<bool> Tribal { get; set; }
        public string FathersMobileNo { get; set; }
        public string MothersMobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string PermanentHouserNo { get; set; }
        public string PermanentRoadNo { get; set; }
        public string PermanentBlock { get; set; }
        public string PermanentSector { get; set; }
        public Nullable<int> PermanentPostId { get; set; }
        public Nullable<int> PermanentThanaId { get; set; }
        public Nullable<int> PermanentDistrictid { get; set; }
        public string PresentHouserNo { get; set; }
        public string PresentRoadNo { get; set; }
        public string PresentBlock { get; set; }
        public string PresentSector { get; set; }
        public Nullable<int> PresentPostId { get; set; }
        public Nullable<int> PresentThanaId { get; set; }
        public Nullable<int> PresentDistrictId { get; set; }
        public string BanglaFatherName { get; set; }
        public string BanglaMotherName { get; set; }
        public Nullable<bool> BanglaFreedomFighter { get; set; }
        public Nullable<bool> BanglaTribal { get; set; }
        public string BanglaPermanentHouserNo { get; set; }
        public string BanglaPermanentRoadNo { get; set; }
        public string BanglaPermanentBlock { get; set; }
        public string BanglaPermanentSector { get; set; }
        public Nullable<int> BanglaPermanentPost { get; set; }
        public Nullable<int> BanglaPermanentThana { get; set; }
        public Nullable<int> BanglaPermanentDistrict { get; set; }
        public string BanglaPresentHouserNo { get; set; }
        public string BanglaPresentRoadNo { get; set; }
        public string BanglaPresentBlock { get; set; }
        public string BanglaPresentSector { get; set; }
        public Nullable<int> BanglaPresentPost { get; set; }
        public Nullable<int> BanglaPresentThana { get; set; }
        public Nullable<int> BanglaPresentDistrict { get; set; }
        public string GuardianName { get; set; }
        public string GuardianMobileNo { get; set; }
        public string GuardianEmail { get; set; }
        public string GuardianHouserNo { get; set; }
        public string GuardianRoadNo { get; set; }
        public string GuardianBlock { get; set; }
        public string GuardianSector { get; set; }
        public Nullable<int> GuardianPostId { get; set; }
        public Nullable<int> GuardianThanaId { get; set; }
        public Nullable<int> GuardianDistrictId { get; set; }
        public string BanglaGuardianName { get; set; }
        public string BanglaGuardianHouserNo { get; set; }
        public string BanglaGuardianRoadNo { get; set; }
        public string BanglaGuardianBlock { get; set; }
        public string BanglaGuardianSector { get; set; }
        public Nullable<int> BanglaGuardianPost { get; set; }
        public Nullable<int> BanglaGuardianThana { get; set; }
        public Nullable<int> BanglaGuardianDistrict { get; set; }
        public byte[] Student_Photo { get; set; }
        public byte[] Student_Signature { get; set; }
        public string AccadamicInfo_ExamNme { get; set; }
        public string AccadamicInfo_Group { get; set; }
        public string AccadamicInfo_Board { get; set; }
        public string AccadamicInfo_SchoolName { get; set; }
        public Nullable<int> AccadamicInfo_RollNo { get; set; }
        public Nullable<int> AccadamicInfo_RegistrationNo { get; set; }
        public Nullable<int> AccadamicInfo_PassingYear { get; set; }
        public string AccadamicInfo_GPA { get; set; }
        public Nullable<int> CurrentSemester { get; set; }
        public Nullable<int> BoardRollNo { get; set; }
        public Nullable<int> BoardRegistrationNo { get; set; }
    
        public virtual BATCH BATCH { get; set; }
        public virtual CAMPUSINFO CAMPUSINFO { get; set; }
        public virtual CAMPUSINFO CAMPUSINFO1 { get; set; }
        public virtual DISTRICT DISTRICT { get; set; }
        public virtual DISTRICT DISTRICT1 { get; set; }
        public virtual POST POST { get; set; }
        public virtual THANA THANA { get; set; }
        public virtual POST POST1 { get; set; }
        public virtual DISTRICT DISTRICT2 { get; set; }
        public virtual POST POST2 { get; set; }
        public virtual THANA THANA1 { get; set; }
        public virtual RELIGION RELIGION { get; set; }
        public virtual SEMESTER SEMESTER { get; set; }
        public virtual SIPI_PROGRAM SIPI_PROGRAM { get; set; }
        public virtual SIPI_DEPARTMENT SIPI_DEPARTMENT { get; set; }
        public virtual THANA THANA2 { get; set; }
        public virtual ICollection<BOOK_ISSUE> BOOK_ISSUE { get; set; }
        public virtual ICollection<COURSE_ASSIGN_TO_STUDENT> COURSE_ASSIGN_TO_STUDENT { get; set; }
        public virtual ICollection<SCHOOL_FEES_COLLECTION> SCHOOL_FEES_COLLECTION { get; set; }
        public virtual ICollection<SCHOOL_MARKS_DISTRIBUTION> SCHOOL_MARKS_DISTRIBUTION { get; set; }
        public virtual ICollection<STUDENT_ATTENDENCE> STUDENT_ATTENDENCE { get; set; }
        public virtual ICollection<STUDENT_RESULT> STUDENT_RESULT { get; set; }
        public virtual ICollection<STUDENTFEESCOLLECTION> STUDENTFEESCOLLECTIONs { get; set; }
    }
}
