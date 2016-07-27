using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.Fees;
using ENTITY.ResultManagement;

namespace DAL.Admission
{
    public class StudentInfoGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        int id = 0;
        public void SaveStudentInfo(StudentInfo _studentInfo)
        {

            try
            {
                datacontextObj = new SIPIDBEntities();
                var newStudentInfo = new ADMISSIONINFO
                {
                     
///////////////////// It is working////////////////

                    ProgramId = _studentInfo.ProgramId,
                    Session = _studentInfo.Session,
                    StudentID = _studentInfo.StudentID,
                    CampusId = _studentInfo.CampusId,
                    DepartmentId = _studentInfo.DepartmentId,
                    AccadamicYear = _studentInfo.AccadamicYear,
                    //AccadamicYear = Convert.ToInt16(_studentInfo.AccadamicYear), //problem is here
                    BatchId = _studentInfo.BatchId,
                    BanglaSession = _studentInfo.BanglaSession,
                    BanglaAccadamicYear = _studentInfo.BanglaAccadamicYear,
                     

                    //// 2nd tab
                    Student_Photo = _studentInfo.Student_Photo,
                    Student_Signature = _studentInfo.Student_Signature,

                    ApplicantName = _studentInfo.ApplicantName,
                    MobileNo = _studentInfo.MobileNo,
                    Email = _studentInfo.Email,
                    Gender = _studentInfo.Gender,
                    DateOfBirth = _studentInfo.DateOfBirth,
                   
                    Nationality = _studentInfo.Nationality,
                    BloodGroup = _studentInfo.BloodGroupId,
                    ReligionId = _studentInfo.ReligionId,
                    Interest = _studentInfo.Interest,
                    OthersInfo = _studentInfo.OthersInfo,

                    BanglaApplicantName = _studentInfo.BanglaApplicantName,
                    BanglaGender = _studentInfo.BanglaGender,
                    BanglaDateOfBirth = _studentInfo.BanglaDateOfBirth,
                    BanglaNationality = _studentInfo.BanglaNationality,
                    BanglaInterest = _studentInfo.BanglaInterest,
                    BanglaOthersInfo = _studentInfo.OthersInfo,

                    //// 3rd tab
                    //// sub tab 1st
                    FatherName = _studentInfo.FatherName,
                    MotherName = _studentInfo.MotherName,
                    FreedomFighter = _studentInfo.FreedomFighter,
                    Tribal = _studentInfo.Tribal,
                    FathersMobileNo = _studentInfo.FathersMobileNo,
                    MothersMobileNo = _studentInfo.MothersMobileNo,
                    TelephoneNo = _studentInfo.TelephoneNo,
                    BanglaFatherName = _studentInfo.BanglaFatherName,
                    BanglaMotherName = _studentInfo.BanglaMotherName,
                    BanglaFreedomFighter = _studentInfo.BanglaFreedomFighter,
                    BanglaTribal = _studentInfo.BanglaTribal,

                    //// sub tab 2nd
                    //////////////////English address////////////////
                    /////Permanent/////
                    PermanentHouserNo = _studentInfo.PermanentHouserNo,
                    PermanentRoadNo = _studentInfo.PermanentRoadNo,
                    PermanentBlock = _studentInfo.PermanentBlock,
                    PermanentSector = _studentInfo.PermanentSector,
                    PermanentPostId = _studentInfo.PostId,
                    PermanentThanaId = _studentInfo.ThanaId,
                    PermanentDistrictid = _studentInfo.DistrictId,
                    //////Bangla Permanent
                    BanglaPermanentHouserNo = _studentInfo.BanglaPermanentHouserNo,
                    BanglaPermanentRoadNo = _studentInfo.BanglaPermanentRoadNo,
                    BanglaPermanentBlock = _studentInfo.BanglaPermanentBlock,
                    BanglaPermanentSector = _studentInfo.BanglaPermanentSector,

                    ///////Present Address/////
                    PresentHouserNo = _studentInfo.PresentHouserNo,
                    PresentRoadNo = _studentInfo.PresentRoadNo,
                    PresentBlock = _studentInfo.PresentBlock,
                    PresentSector = _studentInfo.PresentSector,
                    PresentPostId = _studentInfo.PostId,
                    PresentThanaId = _studentInfo.ThanaId,
                    PresentDistrictId = _studentInfo.DistrictId,

                    // Bangla Present Address
                    BanglaPresentHouserNo = _studentInfo.BanglaPresentHouserNo,
                    BanglaPresentRoadNo = _studentInfo.BanglaPresentRoadNo,
                    BanglaPresentBlock = _studentInfo.BanglaPresentBlock,
                    BanglaPresentSector = _studentInfo.BanglaPresentSector,
                    ////                
                    ////// Guardian info
                    GuardianName = _studentInfo.GuardianName,
                    GuardianMobileNo = _studentInfo.GuardianMobileNo,
                    GuardianEmail = _studentInfo.GuardianEmail,
                    //////address Guardian /////
                    GuardianHouserNo = _studentInfo.GuardianHouserNo,
                    GuardianRoadNo = _studentInfo.GuardianRoadNo,
                    GuardianBlock = _studentInfo.GuardianBlock,
                    GuardianSector = _studentInfo.GuardianSector,
                    
                    GuardianPostId = _studentInfo.PostId,
                    GuardianThanaId = _studentInfo.ThanaId,
                    GuardianDistrictId = _studentInfo.DistrictId,

                    ///// bangla Guardian address/////
                    BanglaGuardianName = _studentInfo.BanglaGuardianName,
                    BanglaGuardianHouserNo = _studentInfo.GuardianHouserNo,
                    BanglaGuardianRoadNo = _studentInfo.GuardianRoadNo,
                    BanglaGuardianBlock = _studentInfo.BanglaGuardianBlock,
                    BanglaGuardianSector = _studentInfo.BanglaGuardianSector, 
                     
                    //accadamic info
                    AccadamicInfo_ExamNme = _studentInfo.AccadamicInfo_ExamNme,
                    AccadamicInfo_Group = _studentInfo.AccadamicInfo_Group,
                    AccadamicInfo_Board = _studentInfo.AccadamicInfo_Board,
                    AccadamicInfo_GPA = _studentInfo.AccadamicInfo_GPA,
                    AccadamicInfo_SchoolName = _studentInfo.AccadamicInfo_SchoolName,
                    AccadamicInfo_RollNo = _studentInfo.AccadamicInfo_RollNo,
                    AccadamicInfo_RegistrationNo = _studentInfo.AccadamicInfo_RegistrationNo,
                    AccadamicInfo_PassingYear = _studentInfo.AccadamicInfo_PassingYear,
                    CurrentSemester = 19,   ///19 means "1st" semester

                };
                datacontextObj.ADMISSIONINFOes.Add(newStudentInfo);
                datacontextObj.SaveChanges();
                id = newStudentInfo.Id;
                SaveStudentFeesInfo(id,_studentInfo);
                //SaveStudentCurrentSemester(id);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    
                    //Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    //    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
           
        }

       
        private void SaveStudentFeesInfo(int id, StudentInfo _studentInfo)
        {
            int year = 0;
            year=Convert.ToInt32(_studentInfo.AccadamicYear);
            datacontextObj = new SIPIDBEntities();
            List<FeesSetup> feesList = new List<FeesSetup>();
            foreach (var p in (from j in datacontextObj.FEESSETUPs
                               where j.DepartmentId == _studentInfo.DepartmentId && j.Year == year
                               select j).Distinct())
            {
                FeesSetup feesDetails = new FeesSetup();
                feesDetails.DepartmentId = p.DepartmentId;
                feesDetails.SemesterId = p.SemesterId;
                feesDetails.Year = p.Year;
                feesDetails.FeesDetailsId = p.FeesDetailsId;
                feesDetails.Amount = p.Amount;
                feesDetails.Total = p.Total;
                feesList.Add(feesDetails);
            }
                        
            foreach (FeesSetup item in feesList)
            {
                var fee = new STUDENTFEE
                {
                    DepartmentId = item.DepartmentId,
                    SemesterId = item.SemesterId,
                    Year = item.Year,
                    FeesDetailsId = item.FeesDetailsId,
                    Amount = item.Amount,
                    Total = item.Total,
                    StudentPkId = id,
                    DiscountAmount=0,
                    DiscountPercent=0,
                    PaidAmount=0,
                    TotalPayableAmount = item.Total,
                    DueAmount = item.Total,
                    PaidStatus="Unpaid"
                };
                datacontextObj.STUDENTFEES.Add(fee);
                datacontextObj.SaveChanges();

            }
            // return feesList;
        }

        public List<StudentInfo> GetAllStudentInfo()
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();
         
                 foreach (var p in (from j in datacontextObj.ADMISSIONINFOes select j).Distinct())
            {
             
                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;

                
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;

                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.BanglaReligion = p.RELIGION.BanglaReligion;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;

                     ///address
                     ///
          


                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;

                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.BanglaPermanentPost = p.POST.BanglaPostName;
                
                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPermanentThana = p.THANA.BanglaThanaName;

                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPermanentDistrict = p.DISTRICT.BanglaDistrict;
                     ////bangla
                     ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.BanglaPresentPost = p.POST.BanglaPostName;
 
                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPresentThana = p.THANA.BanglaThanaName;

                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPresentDistrict = p.DISTRICT.BanglaDistrict;

                     ///bangla
                     ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;

                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;

                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                     ///bangla
                     ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfo.SemesterNo = p.SEMESTER.SemesterNo;

                    


                studentInfoList.Add(studentInfo);

            }

            return studentInfoList;
        }

        public void DeletesStudentInfo(StudentInfo _studentInfo)
        {
          
                ADMISSIONINFO studentinfo = datacontextObj.ADMISSIONINFOes.First(c => c.Id == _studentInfo.Id);
                datacontextObj.ADMISSIONINFOes.Remove(studentinfo);
                datacontextObj.SaveChanges();
          
           
        }

        public void UpdateInfo(StudentInfo _studentInfo)
        {
            var studentInfo = datacontextObj.ADMISSIONINFOes.First(c => c.Id == _studentInfo.Id);
            studentInfo.ProgramId = _studentInfo.ProgramId;
            studentInfo.DepartmentId = _studentInfo.DepartmentId;
            studentInfo.CampusId = _studentInfo.CampusId;
            studentInfo.Session = _studentInfo.Session;
             

            studentInfo.AccadamicYear = _studentInfo.AccadamicYear;
            //studentInfo.BanglaProgram = Convert.ToString(p.BanglaProgram);                
            studentInfo.BanglaSession = _studentInfo.BanglaSession;
            //bangla accadamaci change
            studentInfo.BanglaAccadamicYear = _studentInfo.BanglaAccadamicYear;

            /////2nd tab
            

            studentInfo.Student_Photo = _studentInfo.Student_Photo;
            studentInfo.Student_Signature = _studentInfo.Student_Signature;
            studentInfo.ApplicantName = _studentInfo.ApplicantName;
            studentInfo.MobileNo = _studentInfo.MobileNo;
            studentInfo.Email = _studentInfo.Email;
            studentInfo.Gender = _studentInfo.Gender;
            studentInfo.DateOfBirth = Convert.ToDateTime(_studentInfo.DateOfBirth);
            studentInfo.Nationality = _studentInfo.Nationality;
            studentInfo.Interest = _studentInfo.Interest;
            studentInfo.OthersInfo = _studentInfo.OthersInfo;

            studentInfo.BanglaGender = _studentInfo.BanglaGender;
            studentInfo.BanglaApplicantName = _studentInfo.BanglaApplicantName;
            studentInfo.BanglaNationality = _studentInfo.BanglaNationality;
            studentInfo.BanglaDateOfBirth = Convert.ToDateTime(_studentInfo.BanglaDateOfBirth);
            studentInfo.BanglaInterest = _studentInfo.BanglaInterest;
            studentInfo.BanglaOthersInfo = _studentInfo.BanglaOthersInfo;


            studentInfo.FatherName = _studentInfo.FatherName;
            studentInfo.MotherName = _studentInfo.MotherName;
            studentInfo.FreedomFighter = _studentInfo.FreedomFighter;
            studentInfo.Tribal = _studentInfo.Tribal;
            studentInfo.FathersMobileNo = _studentInfo.FathersMobileNo;
            studentInfo.MothersMobileNo = _studentInfo.MothersMobileNo;
            studentInfo.TelephoneNo = _studentInfo.TelephoneNo;
            studentInfo.BanglaFatherName = _studentInfo.BanglaFatherName;
            studentInfo.BanglaMotherName = _studentInfo.BanglaMotherName;
            studentInfo.BanglaFreedomFighter = _studentInfo.BanglaFreedomFighter;
            studentInfo.BanglaTribal = _studentInfo.BanglaTribal;

            ///address
            ///
            studentInfo.PermanentHouserNo = _studentInfo.PermanentHouserNo;
            studentInfo.PermanentRoadNo = _studentInfo.PermanentRoadNo;
            studentInfo.PermanentBlock = _studentInfo.PermanentBlock;
            studentInfo.PermanentSector = _studentInfo.PermanentSector;
            ///bangla
            ///
            studentInfo.BanglaPermanentHouserNo = _studentInfo.BanglaPermanentHouserNo;
            studentInfo.BanglaPermanentRoadNo = _studentInfo.BanglaPermanentRoadNo;
            studentInfo.BanglaPermanentBlock = _studentInfo.BanglaPermanentBlock;
            studentInfo.BanglaPermanentSector = _studentInfo.BanglaPermanentSector;

            studentInfo.PresentHouserNo = _studentInfo.PresentHouserNo;
            studentInfo.PresentRoadNo = _studentInfo.PresentRoadNo;
            studentInfo.PresentBlock = _studentInfo.PresentBlock;
            studentInfo.PresentSector = _studentInfo.PresentSector;
            ///bangla
            ///
            studentInfo.BanglaPresentHouserNo = _studentInfo.BanglaPresentHouserNo;
            studentInfo.BanglaPresentRoadNo = _studentInfo.BanglaPresentRoadNo;
            studentInfo.BanglaPresentBlock = _studentInfo.BanglaPresentBlock;
            studentInfo.BanglaPresentSector = _studentInfo.BanglaPresentSector;

            studentInfo.GuardianName = _studentInfo.GuardianName;
            studentInfo.GuardianMobileNo = _studentInfo.GuardianMobileNo;
            studentInfo.GuardianEmail = _studentInfo.GuardianEmail;

            studentInfo.GuardianHouserNo = _studentInfo.GuardianHouserNo;
            studentInfo.GuardianRoadNo = _studentInfo.GuardianRoadNo;
            studentInfo.GuardianBlock = _studentInfo.GuardianBlock;
            studentInfo.GuardianSector = _studentInfo.GuardianSector;
            ///bangla
            ///
            studentInfo.BanglaGuardianName = _studentInfo.BanglaGuardianName;
            studentInfo.BanglaGuardianHouserNo = _studentInfo.BanglaGuardianHouserNo;
            studentInfo.BanglaGuardianRoadNo = _studentInfo.BanglaGuardianRoadNo;
            studentInfo.BanglaGuardianBlock = _studentInfo.BanglaGuardianBlock;
            studentInfo.BanglaGuardianSector = _studentInfo.BanglaGuardianSector;

            //accadamic info
            studentInfo.AccadamicInfo_ExamNme = _studentInfo.AccadamicInfo_ExamNme;
            studentInfo.AccadamicInfo_Group = _studentInfo.AccadamicInfo_Group;
            studentInfo.AccadamicInfo_Board = _studentInfo.AccadamicInfo_Board;
            studentInfo.AccadamicInfo_GPA = _studentInfo.AccadamicInfo_GPA;
            studentInfo.AccadamicInfo_SchoolName = _studentInfo.AccadamicInfo_SchoolName;
            studentInfo.AccadamicInfo_RollNo = _studentInfo.AccadamicInfo_RollNo;
            studentInfo.AccadamicInfo_RegistrationNo = _studentInfo.AccadamicInfo_RegistrationNo;
            studentInfo.AccadamicInfo_PassingYear = _studentInfo.AccadamicInfo_PassingYear;
            datacontextObj.SaveChanges();
        }

        public List<StudentInfo> GetAllStudentInfoByName(string name)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.ApplicantName.StartsWith(name)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;
                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;
                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;
                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;
                ///address
                ///
                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;
                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;
                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;
                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;
                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;
                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfoList.Add(studentInfo);
            }

            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentInfoByMobile(string Mobile)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.MobileNo.StartsWith(Mobile)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;
                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;
                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;
                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;
                ///address
                ///
                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;
                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;
                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;
                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;
                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;
                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfoList.Add(studentInfo);
            }

            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentInfoByCampus(string campus)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.CAMPUSINFO.CampusName.StartsWith(campus)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.StudentID = p.StudentID;
                studentInfo.Id = p.Id;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;
                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;
                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;
                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;
                ///address
                ///
                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;
                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;
                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;
                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;
                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;
                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfoList.Add(studentInfo);
            }

            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentInfoByDepartment(string dep)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.SIPI_DEPARTMENT.SIPI_DepartmentName.StartsWith(dep)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.StudentID = p.StudentID;
                studentInfo.Id = p.Id;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;
                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;
                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;
                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;
                ///address
                ///
                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;
                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;
                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;
                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;
                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;
                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfoList.Add(studentInfo);
            }

            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentInfoByStudentId(string id)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.StudentID.StartsWith(id)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;
                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;
                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;
                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;
                ///address
                ///
                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;
                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;
                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;
                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;
                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;
                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfoList.Add(studentInfo);
            }

            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentDepartment(string dept)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.SIPI_DEPARTMENT.SIPI_DepartmentName.StartsWith(dept)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;

                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.BanglaReligion = p.RELIGION.BanglaReligion;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;

                ///address
                ///



                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;

                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.BanglaPermanentPost = p.POST.BanglaPostName;

                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPermanentThana = p.THANA.BanglaThanaName;

                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPermanentDistrict = p.DISTRICT.BanglaDistrict;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.BanglaPresentPost = p.POST.BanglaPostName;

                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPresentThana = p.THANA.BanglaThanaName;

                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPresentDistrict = p.DISTRICT.BanglaDistrict;

                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;

                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;

                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;



                studentInfoList.Add(studentInfo);

            }

            return studentInfoList;
        }

        public int GetLastStudentForID(string dept, string year)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            var LastStudent = (from j in datacontextObj.ADMISSIONINFOes where j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept)
                               && j.AccadamicYear.Equals(year) select j).Count();    

            return LastStudent;


        }

        public List<StudentInfo> GetAllStudentInfoByStudentID(string StudentId)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.StudentID.Equals(StudentId)
                               select j).Distinct())
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;

                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.BanglaReligion = p.RELIGION.BanglaReligion;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;

                ///address
                ///



                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;

                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.BanglaPermanentPost = p.POST.BanglaPostName;

                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPermanentThana = p.THANA.BanglaThanaName;

                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPermanentDistrict = p.DISTRICT.BanglaDistrict;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.BanglaPresentPost = p.POST.BanglaPostName;

                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPresentThana = p.THANA.BanglaThanaName;

                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPresentDistrict = p.DISTRICT.BanglaDistrict;

                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;

                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;

                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;



                studentInfoList.Add(studentInfo);

            }

            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentDepartmentSemester(string dept, string sem, string camp)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes where j.SEMESTER.SemesterNo.Equals(sem) && j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept)
                               && j.CAMPUSINFO.CampusName.Equals(camp)
                               select j).Distinct())
                {
                    StudentInfo studentInfo = new StudentInfo();
                    studentInfo.Id = p.Id;
                    studentInfo.StudentID = p.StudentID;
                    studentInfo.ProgramId = p.ProgramId;
                    studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                    studentInfo.DepartmentId = p.DepartmentId;
                    studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                    studentInfo.CampusId = p.CampusId;
                    studentInfo.CampusName = p.CAMPUSINFO.CampusName;

                    studentInfo.Session = p.Session;
                    studentInfo.BatchId = p.BatchId;
                    studentInfo.AccadamicYear = p.AccadamicYear;
                    studentInfo.BanglaSession = p.BanglaSession;
                    //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                    studentInfo.Student_Photo = p.Student_Photo;
                    studentInfo.Student_Signature = p.Student_Signature;
                    studentInfo.ApplicantName = p.ApplicantName;
                    studentInfo.MobileNo = p.MobileNo;
                    studentInfo.Email = p.Email;
                    studentInfo.Gender = p.Gender;
                    studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                    studentInfo.Nationality = p.Nationality;
                    studentInfo.BloodGroupId = p.BloodGroup;
                    studentInfo.ReligionId = p.ReligionId;
                    studentInfo.BanglaReligion = p.RELIGION.BanglaReligion;
                    studentInfo.Interest = p.Interest;
                    studentInfo.OthersInfo = p.OthersInfo;
                    studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                    studentInfo.BanglaNationality = p.BanglaNationality;
                    studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                    studentInfo.BanglaInterest = p.BanglaInterest;
                    studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                    studentInfo.FatherName = p.FatherName;
                    studentInfo.MotherName = p.MotherName;
                    studentInfo.FreedomFighter = p.FreedomFighter;
                    studentInfo.Tribal = p.Tribal;

                    studentInfo.FathersMobileNo = p.FathersMobileNo;
                    studentInfo.MothersMobileNo = p.MothersMobileNo;
                    studentInfo.TelephoneNo = p.TelephoneNo;
                    studentInfo.BanglaFatherName = p.BanglaFatherName;
                    studentInfo.BanglaMotherName = p.BanglaMotherName;
                    studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                    studentInfo.BanglaTribal = p.BanglaTribal;

                    ///address
                    ///



                    studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                    studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                    studentInfo.PermanentBlock = p.PermanentBlock;
                    studentInfo.PermanentSector = p.PermanentSector;

                    studentInfo.PermanentPost = p.PermanentPostId;
                    studentInfo.PermanentPostName = p.POST.PostName;
                    studentInfo.BanglaPermanentPost = p.POST.BanglaPostName;

                    studentInfo.PermanentThana = p.PermanentThanaId;
                    studentInfo.PermanentThanaName = p.THANA.ThanaName;
                    studentInfo.BanglaPermanentThana = p.THANA.BanglaThanaName;

                    studentInfo.PermanentDistrict = p.PermanentDistrictid;
                    studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                    studentInfo.BanglaPermanentDistrict = p.DISTRICT.BanglaDistrict;
                    ////bangla
                    ////
                    studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                    studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                    studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                    studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                    studentInfo.PresentHouserNo = p.PresentHouserNo;
                    studentInfo.PresentRoadNo = p.PresentRoadNo;
                    studentInfo.PresentBlock = p.PresentBlock;
                    studentInfo.PresentSector = p.PresentSector;

                    studentInfo.PresentPost = p.PresentPostId;
                    studentInfo.PresentPostName = p.POST.PostName;
                    studentInfo.BanglaPresentPost = p.POST.BanglaPostName;

                    studentInfo.PresentThana = p.PresentThanaId;
                    studentInfo.PresentThanaName = p.THANA.ThanaName;
                    studentInfo.BanglaPresentThana = p.THANA.BanglaThanaName;

                    studentInfo.PresentDistrict = p.PresentDistrictId;
                    studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                    studentInfo.BanglaPresentDistrict = p.DISTRICT.BanglaDistrict;

                    ///bangla
                    ///
                    studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                    studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                    studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                    studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                    studentInfo.GuardianPost = p.GuardianPostId;
                    studentInfo.GuardianThana = p.GuardianThanaId;
                    studentInfo.GuardianDistrict = p.GuardianDistrictId;

                    studentInfo.GuardianName = p.GuardianName;
                    studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                    studentInfo.GuardianEmail = p.GuardianEmail;

                    studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                    studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                    studentInfo.GuardianBlock = p.GuardianBlock;
                    studentInfo.GuardianSector = p.GuardianSector;
                    ///bangla
                    ///
                    studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                    studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                    studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                    studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                    studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                    /////accadamic info
                    studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                    studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                    studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                    studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                    studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                    studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                    studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                    studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                    studentInfo.Semester = p.SEMESTER.Id;
                    studentInfo.SemesterNo = p.SEMESTER.SemesterNo;

                    studentInfoList.Add(studentInfo);
                }
            return studentInfoList;
        }

        public List<StudentInfo> GetAllStudentForAssignSemester(string dept, string sem, string year)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentInfo> studentInfoList = new List<StudentInfo>();

            foreach (var p in (from j in datacontextObj.ADMISSIONINFOes
                               where j.SEMESTER.SemesterNo.Equals(sem) && j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept)
                                   && j.AccadamicYear.Equals(year)
                               select j).Distinct())
            {
                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                studentInfo.ProgramId = p.ProgramId;
                studentInfo.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                studentInfo.DepartmentId = p.DepartmentId;
                studentInfo.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                studentInfo.CampusId = p.CampusId;
                studentInfo.CampusName = p.CAMPUSINFO.CampusName;

                studentInfo.Session = p.Session;
                studentInfo.BatchId = p.BatchId;
                studentInfo.AccadamicYear = p.AccadamicYear;
                studentInfo.BanglaSession = p.BanglaSession;
                //studentInfo.BanglaAccadamicYear = p.BanglaAccadamicYear;
                studentInfo.Student_Photo = p.Student_Photo;
                studentInfo.Student_Signature = p.Student_Signature;
                studentInfo.ApplicantName = p.ApplicantName;
                studentInfo.MobileNo = p.MobileNo;
                studentInfo.Email = p.Email;
                studentInfo.Gender = p.Gender;
                studentInfo.DateOfBirth = Convert.ToDateTime(p.DateOfBirth);
                studentInfo.Nationality = p.Nationality;
                studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.ReligionId = p.ReligionId;
                studentInfo.BanglaReligion = p.RELIGION.BanglaReligion;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                studentInfo.FreedomFighter = p.FreedomFighter;
                studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                studentInfo.BanglaTribal = p.BanglaTribal;

                ///address
                ///

                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;

                studentInfo.PermanentPost = p.PermanentPostId;
                studentInfo.PermanentPostName = p.POST.PostName;
                studentInfo.BanglaPermanentPost = p.POST.BanglaPostName;

                studentInfo.PermanentThana = p.PermanentThanaId;
                studentInfo.PermanentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPermanentThana = p.THANA.BanglaThanaName;

                studentInfo.PermanentDistrict = p.PermanentDistrictid;
                studentInfo.PermanentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPermanentDistrict = p.DISTRICT.BanglaDistrict;
                ////bangla
                ////
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.PresentPost = p.PresentPostId;
                studentInfo.PresentPostName = p.POST.PostName;
                studentInfo.BanglaPresentPost = p.POST.BanglaPostName;

                studentInfo.PresentThana = p.PresentThanaId;
                studentInfo.PresentThanaName = p.THANA.ThanaName;
                studentInfo.BanglaPresentThana = p.THANA.BanglaThanaName;

                studentInfo.PresentDistrict = p.PresentDistrictId;
                studentInfo.PresentDistrictName = p.DISTRICT.DistrictName;
                studentInfo.BanglaPresentDistrict = p.DISTRICT.BanglaDistrict;

                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                studentInfo.GuardianPost = p.GuardianPostId;
                studentInfo.GuardianThana = p.GuardianThanaId;
                studentInfo.GuardianDistrict = p.GuardianDistrictId;

                studentInfo.GuardianName = p.GuardianName;
                studentInfo.GuardianMobileNo = p.GuardianMobileNo;
                studentInfo.GuardianEmail = p.GuardianEmail;

                studentInfo.GuardianHouserNo = p.GuardianHouserNo;
                studentInfo.GuardianRoadNo = p.GuardianRoadNo;
                studentInfo.GuardianBlock = p.GuardianBlock;
                studentInfo.GuardianSector = p.GuardianSector;
                ///bangla
                ///
                studentInfo.BanglaGuardianName = p.BanglaGuardianName;
                studentInfo.BanglaGuardianHouserNo = p.BanglaGuardianHouserNo;
                studentInfo.BanglaGuardianRoadNo = p.BanglaGuardianRoadNo;
                studentInfo.BanglaGuardianBlock = p.BanglaGuardianBlock;
                studentInfo.BanglaGuardianSector = p.BanglaGuardianSector;

                /////accadamic info
                studentInfo.AccadamicInfo_ExamNme = p.AccadamicInfo_ExamNme;
                studentInfo.AccadamicInfo_Board = p.AccadamicInfo_Board;
                studentInfo.AccadamicInfo_Group = p.AccadamicInfo_Group;
                studentInfo.AccadamicInfo_SchoolName = p.AccadamicInfo_SchoolName;
                studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNo;
                studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfo.Semester = p.SEMESTER.Id;
                studentInfo.SemesterNo = p.SEMESTER.SemesterNo;

                studentInfoList.Add(studentInfo);
            }
            return studentInfoList;
        }

        public void UpdateSemesterStatus(StudentResult _studentResultObj)
        {

            var studentInfo = datacontextObj.ADMISSIONINFOes.First(c => c.Id == _studentResultObj.StudentPKId);
            studentInfo.CurrentSemester = _studentResultObj.SemesterId;
            datacontextObj.SaveChanges();
        }
    }
}
