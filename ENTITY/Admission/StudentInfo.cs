using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
   public class StudentInfo
    {  
       /// <summary>
        /// //program information
       /// </summary>
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private int? programId;

        public int? ProgramId
        {
            get { return programId; }
            set { programId = value; }
        }
        private string programName;

        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }

        private string banglaProgram;

        public string BanglaProgram
        {
            get { return banglaProgram; }
            set { banglaProgram = value; }
        }
        //////////

       /// <summary>
       /// //Department
       /// </summary>
        private int? departmentId;

        public int? DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        private string banglaDepartment;

        public string BanglaDepartment
        {
            get { return banglaDepartment; }
            set { banglaDepartment = value; }
        }
       //////

       /// <summary>
       /// /Campus
       /// </summary>
        private int? campusId;

        public int? CampusId
        {
            get { return campusId; }
            set { campusId = value; }
        }
        private string campusName;

        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }
        private string banglaCampus;

        public string BanglaCampus
        {
            get { return banglaCampus; }
            set { banglaCampus = value; }
        }

        ///////

       /// <summary>
       /// session
       /// </summary>
        private string session;
       
        public string Session
        {
            get { return session; }
            set { session = value; }
        }
        private string banglaSession;

        public string BanglaSession
        {
            get { return banglaSession; }
            set { banglaSession = value; }
        }
        /////

       /// <summary>
        /// //AccadamicYear
       /// </summary>
        private string accadamicYear;

        public string AccadamicYear
        {
            get { return accadamicYear; }
            set { accadamicYear = value; }
        }
 
        private string banglaAccadamicYear;

        public string BanglaAccadamicYear
        {
            get { return banglaAccadamicYear; }
            set { banglaAccadamicYear = value; }
        }

       //////
       /// <summary>
        /// Batch
       /// </summary>
        private int? batchId;

        public int? BatchId
        {
            get { return batchId; }
            set { batchId = value; }
        }

        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }
        private string banglaBatch;

        public string BanglaBatch
        {
            get { return banglaBatch; }
            set { banglaBatch = value; }
        }

        //////
        
        
      


        // personal information

        private string applicantName;

        public string ApplicantName
        {
            get { return applicantName; }
            set { applicantName = value; }
        }
        private string mobileNo;

        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        private int? bloodGroupId;

        public int? BloodGroupId
        {
            get { return bloodGroupId; }
            set { bloodGroupId = value; }
        }

        public byte[] Student_Photo { get; set; }

        public byte[] Student_Signature { get; set; }

       

        
        /// <summary>
        /// ReligionId
        /// </summary>
        private int? religionId;
       
        public int? ReligionId
        {
            get { return religionId; }
            set { religionId = value; }
        }
        private string religionName;

        public string ReligionName
        {
            get { return religionName; }
            set { religionName = value; }

        }
        private string banglaReligion;

        public string BanglaReligion
        {
            get { return banglaReligion; }
            set { banglaReligion = value; }
        }

        
       
       ///////
       
     
        private string hobby;

        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        private string interest;

        public string Interest
        {
            get { return interest; }
            set { interest = value; }
        }
        private string othersInfo;

        public string OthersInfo
        {
            get { return othersInfo; }
            set { othersInfo = value; }
        }

        private string banglaApplicantName;

        public string BanglaApplicantName
        {
            get { return banglaApplicantName; }
            set { banglaApplicantName = value; }
        }
        private string banglaGender;

        public string BanglaGender
        {
            get { return banglaGender; }
            set { banglaGender = value; }
        }
        private string banglaNationality;

        public string BanglaNationality
        {
            get { return banglaNationality; }
            set { banglaNationality = value; }
        }
        private DateTime banglaDateOfBirth;

        public DateTime BanglaDateOfBirth
        {
            get { return banglaDateOfBirth; }
            set { banglaDateOfBirth = value; }
        }
        
        private string banglaInterest;

        public string BanglaInterest
        {
            get { return banglaInterest; }
            set { banglaInterest = value; }
        }
        private string banglaOthersInfo;

        public string BanglaOthersInfo
        {
            get { return banglaOthersInfo; }
            set { banglaOthersInfo = value; }
        }

        
        //Family and contact infor mation

        private string fatherName;

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }
        private string motherName;

        public string MotherName
        {
            get { return motherName; }
            set { motherName = value; }
        }
        private bool? freedomFighter;

        public bool? FreedomFighter
        {
            get { return freedomFighter; }
            set { freedomFighter = value; }
        }

        private bool? tribal;

        public bool? Tribal
        {
            get { return tribal; }
            set { tribal = value; }
        }
        private string fathersMobileNo;

        public string FathersMobileNo
        {
            get { return fathersMobileNo; }
            set { fathersMobileNo = value; }
        }
        private string mothersMobileNo;

        public string MothersMobileNo
        {
            get { return mothersMobileNo; }
            set { mothersMobileNo = value; }
        }
        private string telephoneNo;

        public string TelephoneNo
        {
            get { return telephoneNo; }
            set { telephoneNo = value; }
        }
        // Permanent address
        private string permanentHouserNo;

        public string PermanentHouserNo
        {
            get { return permanentHouserNo; }
            set { permanentHouserNo = value; }
        }
        private string permanentRoadNo;

        public string PermanentRoadNo
        {
            get { return permanentRoadNo; }
            set { permanentRoadNo = value; }
        }
        private string permanentBlock;

        public string PermanentBlock
        {
            get { return permanentBlock; }
            set { permanentBlock = value; }
        }
        private string permanentSector;

        public string PermanentSector
        {
            get { return permanentSector; }
            set { permanentSector = value; }
        }

         

       


        private int? permanentPost;

        public int? PermanentPost
        {
            get { return permanentPost; }
            set { permanentPost = value; }
        }
        public string PermanentPostName { set; get; }

        private int? permanentThana;

        public int? PermanentThana
        {
            get { return permanentThana; }
            set { permanentThana = value; }
        }
        public string PermanentThanaName { set; get; }
        
       private int? permanentDistrict;

        public int? PermanentDistrict
        {
            get { return permanentDistrict; }
            set { permanentDistrict = value; }
        }
        public string PermanentDistrictName { set; get; }

        // Present address
        private string presentHouserNo;

        public string PresentHouserNo
        {
            get { return presentHouserNo; }
            set { presentHouserNo = value; }
        }
        private string presentRoadNo;

        public string PresentRoadNo
        {
            get { return presentRoadNo; }
            set { presentRoadNo = value; }
        }
        private string presentBlock;

        public string PresentBlock
        {
            get { return presentBlock; }
            set { presentBlock = value; }
        }
        private string presentSector;

        public string PresentSector
        {
            get { return presentSector; }
            set { presentSector = value; }
        }
        private int? presentPost;

        public int? PresentPost
        {
            get { return presentPost; }
            set { presentPost = value; }
        }
        public string PresentPostName { set; get; }

        private int? presentThana;

        public int? PresentThana
        {
            get { return presentThana; }
            set { presentThana = value; }
        }
        public string PresentThanaName { set; get; }

        private int? presentDistrict;

        public int? PresentDistrict
        {
            get { return presentDistrict; }
            set { presentDistrict = value; }
        }

        public string PresentDistrictName { set; get; }
       
        // bangla
        private string banglaFatherName;

        public string BanglaFatherName
        {
            get { return banglaFatherName; }
            set { banglaFatherName = value; }
        }
        private string banglaMotherName;

        public string BanglaMotherName
        {
            get { return banglaMotherName; }
            set { banglaMotherName = value; }
        }
        private bool? banglaFreedomFighter;

        public bool? BanglaFreedomFighter
        {
            get { return banglaFreedomFighter; }
            set { banglaFreedomFighter = value; }
        }
        private bool? banglaTribal;

        public bool? BanglaTribal
        {
            get { return banglaTribal; }
            set { banglaTribal = value; }
        }      
        //bangla Permanent address
        private string banglaPermanentHouserNo;

        public string BanglaPermanentHouserNo
        {
            get { return banglaPermanentHouserNo; }
            set { banglaPermanentHouserNo = value; }
        }
        private string banglaPermanentRoadNo;

        public string BanglaPermanentRoadNo
        {
            get { return banglaPermanentRoadNo; }
            set { banglaPermanentRoadNo = value; }
        }
        private string banglaPermanentBlock;

        public string BanglaPermanentBlock
        {
            get { return banglaPermanentBlock; }
            set { banglaPermanentBlock = value; }
        }
        private string banglaPermanentSector;

        public string BanglaPermanentSector
        {
            get { return banglaPermanentSector; }
            set { banglaPermanentSector = value; }
        }
        private string banglaPermanentPost;

        public string BanglaPermanentPost
        {
            get { return banglaPermanentPost; }
            set { banglaPermanentPost = value; }
        }
        private string banglaPermanentThana;

        public string BanglaPermanentThana
        {
            get { return banglaPermanentThana; }
            set { banglaPermanentThana = value; }
        }
        private string banglaPermanentDistrict;

        public string BanglaPermanentDistrict
        {
            get { return banglaPermanentDistrict; }
            set { banglaPermanentDistrict = value; }
        }


        //bangla Present address

        private string banglaPresentHouserNo;

        public string BanglaPresentHouserNo
        {
            get { return banglaPresentHouserNo; }
            set { banglaPresentHouserNo = value; }
        }
        private string banglaPresentRoadNo;

        public string BanglaPresentRoadNo
        {
            get { return banglaPresentRoadNo; }
            set { banglaPresentRoadNo = value; }
        }
        private string banglaPresentBlock;

        public string BanglaPresentBlock
        {
            get { return banglaPresentBlock; }
            set { banglaPresentBlock = value; }
        }
        private string banglaPresentSector;

        public string BanglaPresentSector
        {
            get { return banglaPresentSector; }
            set { banglaPresentSector = value; }
        }
        private string banglaPresentPost;

        public string BanglaPresentPost
        {
            get { return banglaPresentPost; }
            set { banglaPresentPost = value; }
        }
        private string banglaPresentThana;

        public string BanglaPresentThana
        {
            get { return banglaPresentThana; }
            set { banglaPresentThana = value; }
        }
        private string banglaPresentDistrict;

        public string BanglaPresentDistrict
        {
            get { return banglaPresentDistrict; }
            set { banglaPresentDistrict = value; }
        }

        // Imediat Guardian
        private string guardianName;

        public string GuardianName
        {
            get { return guardianName; }
            set { guardianName = value; }
        }
        private string guardianMobileNo;

        public string GuardianMobileNo
        {
            get { return guardianMobileNo; }
            set { guardianMobileNo = value; }
        }
        private string guardianEmail;

        public string GuardianEmail
        {
            get { return guardianEmail; }
            set { guardianEmail = value; }
        }
      /// <summary>
        /// Guardian Address
      /// </summary>

        private string guardianHouserNo;

        public string GuardianHouserNo
        {
            get { return guardianHouserNo; }
            set { guardianHouserNo = value; }
        }
        private string guardianRoadNo;

        public string GuardianRoadNo
        {
            get { return guardianRoadNo; }
            set { guardianRoadNo = value; }
        }
        private string guardianBlock;

        public string GuardianBlock
        {
            get { return guardianBlock; }
            set { guardianBlock = value; }
        }
        private string guardianSector;

        public string GuardianSector
        {
            get { return guardianSector; }
            set { guardianSector = value; }
        }

       /// <summary>
       /// //Post
       /// </summary>


        private int? postId;

        public int? PostId
        {
            get { return postId; }
            set { postId = value; }
        }
        private int? guardianPost;

        public int? GuardianPost
        {
            get { return guardianPost; }
            set { guardianPost = value; }
        }
        /// <summary>
        /// //Thana
        /// </summary>
        private int? thanaId;

        public int? ThanaId
        {
            get { return thanaId; }
            set { thanaId = value; }
        }

        private int? guardianThana;

        public int? GuardianThana
        {
            get { return guardianThana; }
            set { guardianThana = value; }
        }

       /// <summary>
       /// //District
       /// </summary>
       /// 

        private int? districtId;

        public int? DistrictId
        {
            get { return districtId; }
            set { districtId = value; }
        }

        private int? guardianDistrict;

        public int? GuardianDistrict
        {
            get { return guardianDistrict; }
            set { guardianDistrict = value; }
        }
        //bangla
        private string banglaGuardianName;

        public string BanglaGuardianName
        {
            get { return banglaGuardianName; }
            set { banglaGuardianName = value; }
        }
        private string banglaGuardianHouserNo;

        public string BanglaGuardianHouserNo
        {
            get { return banglaGuardianHouserNo; }
            set { banglaGuardianHouserNo = value; }
        }
        private string banglaGuardianRoadNo;

        public string BanglaGuardianRoadNo
        {
            get { return banglaGuardianRoadNo; }
            set { banglaGuardianRoadNo = value; }
        }
        private string banglaGuardianBlock;

        public string BanglaGuardianBlock
        {
            get { return banglaGuardianBlock; }
            set { banglaGuardianBlock = value; }
        }
        private string banglaGuardianSector;

        public string BanglaGuardianSector
        {
            get { return banglaGuardianSector; }
            set { banglaGuardianSector = value; }
        }
        private string banglaGuardianPost;

        public string BanglaGuardianPost
        {
            get { return banglaGuardianPost; }
            set { banglaGuardianPost = value; }
        }
        private string banglaGuardianThana;

        public string BanglaGuardianThana
        {
            get { return banglaGuardianThana; }
            set { banglaGuardianThana = value; }
        }
        private string banglaGuardianDistrict;

        public string BanglaGuardianDistrict
        {
            get { return banglaGuardianDistrict; }
            set { banglaGuardianDistrict = value; }
        }
       /// <summary>
        /// //////////////////accadamicInfo
       /// </summary>
        private string accadamicInfo_ExamNme;

        public string AccadamicInfo_ExamNme
        {
            get { return accadamicInfo_ExamNme; }
            set { accadamicInfo_ExamNme = value; }
        }
        private string accadamicInfo_Group;

        public string AccadamicInfo_Group
        {
            get { return accadamicInfo_Group; }
            set { accadamicInfo_Group = value; }
        }
        private string accadamicInfo_Board;

        public string AccadamicInfo_Board
        {
            get { return accadamicInfo_Board; }
            set { accadamicInfo_Board = value; }
        }
        private string accadamicInfo_SchoolName;

        public string AccadamicInfo_SchoolName
        {
            get { return accadamicInfo_SchoolName; }
            set { accadamicInfo_SchoolName = value; }
        }
        private int? accadamicInfo_RollNo;

        public int? AccadamicInfo_RollNo
        {
            get { return accadamicInfo_RollNo; }
            set { accadamicInfo_RollNo = value; }
        }
        private int? accadamicInfo_RegistrationNo;

        public int? AccadamicInfo_RegistrationNo
        {
            get { return accadamicInfo_RegistrationNo; }
            set { accadamicInfo_RegistrationNo = value; }
        }
     
        public int  AccadamicInfo_RegistrationNoR { get; set;}

        private int? accadamicInfo_PassingYear;

        public int? AccadamicInfo_PassingYear
        {
            get { return accadamicInfo_PassingYear; }
            set { accadamicInfo_PassingYear = value; }
        }

        private string accadamicInfo_GPA;

        public string AccadamicInfo_GPA
        {
            get { return accadamicInfo_GPA; }
            set { accadamicInfo_GPA = value; }
        }

        private int semester;

        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        private string semesterNo;

        public string SemesterNo
        {
            get { return semesterNo; }
            set { semesterNo = value; }
        }
        public bool IsChecked { get; set; }



    }
}
