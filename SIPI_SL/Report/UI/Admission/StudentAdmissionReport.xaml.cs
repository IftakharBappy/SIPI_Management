using BLL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SIPI_SL.Report.Entity;
using SIPI_SL.Report.Crystal.Admission;

namespace SIPI_SL.Report.UI.Admission
{
    /// <summary>
    /// Interaction logic for StudentAdmissionReport.xaml
    /// </summary>
    public partial class StudentAdmissionReport : Window
    {

        public StudentAdmissionReport()
        {
            InitializeComponent();
            LoadAllStudentInfo();
        }
        //StudentInfo _studentInfo;
        List<StudentInfo> studentInfoList;
        StudentInfoManager studentInfoManager = new StudentInfoManager();
        List<RStudentInfo> employeeInfoList = new List<RStudentInfo>();
        List<StudentInfoForBoard> studentInfoBoardList = new List<StudentInfoForBoard>();

        List<RStudentInfo> searchEmployeeInfoList = new List<RStudentInfo>();
        private void LoadAllStudentInfo()
        {
            studentInfoList = new List<StudentInfo>();
            studentInfoList = studentInfoManager.GetAllStudentInfo();
            studentInofListView.Items.Clear();
            if (studentInfoList.Count > 0)
            {
                foreach (var item in studentInfoList)
                {
                    studentInofListView.Items.Add(item);
                }

            }
        }

      

        private void preview_Click(object sender, RoutedEventArgs e)
        {
           
            foreach (StudentInfo p in studentInfoList)
            {
                RStudentInfo studentInfo = new RStudentInfo();

                studentInfo.Id = p.Id;
                studentInfo.StudentID = p.StudentID;
                //studentInfo.ProgramId = p.ProgramId;
                //studentInfo.DepartmentId = p.DepartmentId;
                //studentInfo.CampusId = p.CampusId;
                //studentInfo.Session = p.Session;
                //studentInfo.BatchId = p.BatchId;
                studentInfo.ProgramName = p.ProgramName;
                studentInfo.DepartmentName = p.DepartmentName;


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
                //studentInfo.BloodGroupId = p.BloodGroup;
                //studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                //studentInfo.FreedomFighter = p.FreedomFighter;
                //studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                //studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                //studentInfo.BanglaTribal = p.BanglaTribal;

                ///address
                ///



                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;

                studentInfo.PermanentPostName = p.PermanentPostName;
                studentInfo.PermanentThanaName = p.PermanentThanaName;
                studentInfo.PermanentDistrictName = p.PermanentDistrictName;

               
                ///bangla
                ///
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.PresentPostName = p.PresentPostName;
                studentInfo.PresentThanaName = p.PresentThanaName;
                studentInfo.PresentDistrictName = p.PresentDistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                //studentInfo.GuardianPost = p.GuardianPostId;
                //studentInfo.GuardianThana = p.GuardianThanaId;
                //studentInfo.GuardianDistrict = p.GuardianDistrictId;

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
                //studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNoR;
                //studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                employeeInfoList.Add(studentInfo);
            }
           
            if (employeeInfoList.Count > 0)
            {
                studentAdmissionCrystalReport employeeInfoCrystalReport = new studentAdmissionCrystalReport();
                ReportUtility.Display_report(employeeInfoCrystalReport, employeeInfoList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }  

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {


            if (nameTextBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string name = nameTextBox.Text.Trim();
                string mobileNo = mobileNoTestBox.Text.Trim();

                studentInfoList = studentInfoManager.GetAllStudentInfoByName(name);


                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {

                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }
                }
            }

            else
            {
                LoadAllStudentInfo();
            }

            if (mobileNoTestBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string Mobile = mobileNoTestBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByMobile(Mobile);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }
                }
            }

            if (campusTextBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string Campus = campusTextBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByCampus(Campus);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }
                }
            }

            if (departmentTextBox.Text != "" && mobileNoTestBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string dep = departmentTextBox.Text.Trim();
                string Mobile = mobileNoTestBox.Text.Trim();
                //studentInfoList = studentInfoManager.GetAllStudentInfoByDepartment(dep, Mobile);

                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }

            if (studentIdTextBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string StudentId = studentIdTextBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByStudentID(StudentId);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }
            
            
        }

        private void BoardReport_Click(object sender, RoutedEventArgs e)
        {
            if (BoardReport.Content.ToString() == "Board report")
            {
                foreach (StudentInfo p in studentInfoList)
                {
                    StudentInfoForBoard studentInfo = new StudentInfoForBoard();

                    studentInfo.Id = p.Id;
                    //studentInfo.ProgramId = p.ProgramId;
                    //studentInfo.DepartmentId = p.DepartmentId;
                    //studentInfo.CampusId = p.CampusId;
                    //studentInfo.Session = p.Session;
                    //studentInfo.BatchId = p.BatchId;
                    studentInfo.ProgramName = p.ProgramName;
                    studentInfo.DepartmentName = p.DepartmentName;
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
                    //studentInfo.BloodGroupId = p.BloodGroup;
                    studentInfo.BanglaReligion = p.BanglaReligion;
                    studentInfo.Interest = p.Interest;
                    studentInfo.OthersInfo = p.OthersInfo;
                    studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                    studentInfo.BanglaNationality = p.BanglaNationality;
                    studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                    studentInfo.BanglaInterest = p.BanglaInterest;
                    studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                    studentInfo.FatherName = p.FatherName;
                    studentInfo.MotherName = p.MotherName;
                    //studentInfo.FreedomFighter = p.FreedomFighter;
                    //studentInfo.Tribal = p.Tribal;

                    studentInfo.FathersMobileNo = p.FathersMobileNo;
                    studentInfo.MothersMobileNo = p.MothersMobileNo;
                    studentInfo.TelephoneNo = p.TelephoneNo;
                    studentInfo.BanglaFatherName = p.BanglaFatherName;
                    studentInfo.BanglaMotherName = p.BanglaMotherName;
                    //studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                    //studentInfo.BanglaTribal = p.BanglaTribal;

                    ///address
                    ///



                    studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                    studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                    studentInfo.PermanentBlock = p.PermanentBlock;
                    studentInfo.PermanentSector = p.PermanentSector;




                    ///bangla
                    ///
                    studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                    studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                    studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                    studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;


                    studentInfo.BanglaPermanentPost = p.BanglaPermanentPost;
                    studentInfo.BanglaPermanentThana = p.BanglaPermanentThana;
                    studentInfo.BanglaPermanentDistrict = p.BanglaPermanentDistrict;

                    studentInfo.PresentHouserNo = p.PresentHouserNo;
                    studentInfo.PresentRoadNo = p.PresentRoadNo;
                    studentInfo.PresentBlock = p.PresentBlock;
                    studentInfo.PresentSector = p.PresentSector;

                    studentInfo.BanglaPresentPost = p.BanglaPresentPost;
                    studentInfo.BanglaPresentThana = p.BanglaPresentThana;
                    studentInfo.BanglaPresentDistrict = p.BanglaPresentDistrict;

                    ///bangla
                    ///
                    studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                    studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                    studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                    studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                    //studentInfo.GuardianPost = p.GuardianPostId;
                    //studentInfo.GuardianThana = p.GuardianThanaId;
                    //studentInfo.GuardianDistrict = p.GuardianDistrictId;

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
                    //studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                    studentInfo.AccadamicInfo_RegistrationNo = (int)p.AccadamicInfo_RegistrationNoR;
                    //studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                    studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                    studentInfoBoardList.Add(studentInfo);
                }


                if (studentInfoBoardList.Count > 0)
                {
                    BanglaReportBoard banglaRiport = new BanglaReportBoard();
                    ReportUtility.Display_report(banglaRiport, studentInfoBoardList, this);
                }
                else
                {
                    MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }  

            }

            if (BoardReport.Content.ToString() == "Student Info")
            {
               foreach (StudentInfo p in studentInfoList)
            {
                RStudentInfo studentInfo = new RStudentInfo();

                studentInfo.Id = p.Id;
                //studentInfo.ProgramId = p.ProgramId;
                //studentInfo.DepartmentId = p.DepartmentId;
                //studentInfo.CampusId = p.CampusId;
                //studentInfo.Session = p.Session;
                //studentInfo.BatchId = p.BatchId;
                studentInfo.ProgramName = p.ProgramName;
                studentInfo.DepartmentName = p.DepartmentName;


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
                //studentInfo.BloodGroupId = p.BloodGroup;
                //studentInfo.ReligionId = p.ReligionId;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                //studentInfo.FreedomFighter = p.FreedomFighter;
                //studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                //studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                //studentInfo.BanglaTribal = p.BanglaTribal;

                ///address
                ///



                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;

                studentInfo.PermanentPostName = p.PermanentPostName;
                studentInfo.PermanentThanaName = p.PermanentThanaName;
                studentInfo.PermanentDistrictName = p.PermanentDistrictName;

               
                ///bangla
                ///
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.PresentPostName = p.PresentPostName;
                studentInfo.PresentThanaName = p.PresentThanaName;
                studentInfo.PresentDistrictName = p.PresentDistrictName;
                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                //studentInfo.GuardianPost = p.GuardianPostId;
                //studentInfo.GuardianThana = p.GuardianThanaId;
                //studentInfo.GuardianDistrict = p.GuardianDistrictId;

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
                //studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = p.AccadamicInfo_RegistrationNoR;
                //studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                employeeInfoList.Add(studentInfo);
            }
           
            if (employeeInfoList.Count > 0)
            {
                studentAdmissionCrystalReport employeeInfoCrystalReport = new studentAdmissionCrystalReport();
                ReportUtility.Display_report(employeeInfoCrystalReport, employeeInfoList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }   
            }
           
        }

        private void idcard_Click(object sender, RoutedEventArgs e)
        {
            foreach (StudentInfo p in studentInfoList)
            {
                StudentInfoForBoard studentInfo = new StudentInfoForBoard();

                studentInfo.Id = p.Id;
                //studentInfo.ProgramId = p.ProgramId;
                //studentInfo.DepartmentId = p.DepartmentId;
                //studentInfo.CampusId = p.CampusId;
                //studentInfo.Session = p.Session;
                //studentInfo.BatchId = p.BatchId;
                studentInfo.ProgramName = p.ProgramName;
                studentInfo.DepartmentName = p.DepartmentName;


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
                //studentInfo.BloodGroupId = p.BloodGroup;
                studentInfo.BanglaReligion = p.BanglaReligion;
                studentInfo.Interest = p.Interest;
                studentInfo.OthersInfo = p.OthersInfo;
                studentInfo.BanglaApplicantName = p.BanglaApplicantName;
                studentInfo.BanglaNationality = p.BanglaNationality;
                studentInfo.BanglaDateOfBirth = Convert.ToDateTime(p.BanglaDateOfBirth);
                studentInfo.BanglaInterest = p.BanglaInterest;
                studentInfo.BanglaOthersInfo = p.BanglaOthersInfo;


                studentInfo.FatherName = p.FatherName;
                studentInfo.MotherName = p.MotherName;
                //studentInfo.FreedomFighter = p.FreedomFighter;
                //studentInfo.Tribal = p.Tribal;

                studentInfo.FathersMobileNo = p.FathersMobileNo;
                studentInfo.MothersMobileNo = p.MothersMobileNo;
                studentInfo.TelephoneNo = p.TelephoneNo;
                studentInfo.BanglaFatherName = p.BanglaFatherName;
                studentInfo.BanglaMotherName = p.BanglaMotherName;
                //studentInfo.BanglaFreedomFighter = p.BanglaFreedomFighter;
                //studentInfo.BanglaTribal = p.BanglaTribal;

                ///address
                ///



                studentInfo.PermanentHouserNo = p.PermanentHouserNo;
                studentInfo.PermanentRoadNo = p.PermanentRoadNo;
                studentInfo.PermanentBlock = p.PermanentBlock;
                studentInfo.PermanentSector = p.PermanentSector;




                ///bangla
                ///
                studentInfo.BanglaPermanentHouserNo = p.BanglaPermanentHouserNo;
                studentInfo.BanglaPermanentRoadNo = p.BanglaPermanentRoadNo;
                studentInfo.BanglaPermanentBlock = p.BanglaPermanentBlock;
                studentInfo.BanglaPermanentSector = p.BanglaPermanentSector;


                studentInfo.BanglaPermanentPost = p.BanglaPermanentPost;
                studentInfo.BanglaPermanentThana = p.BanglaPermanentThana;
                studentInfo.BanglaPermanentDistrict = p.BanglaPermanentDistrict;

                studentInfo.PresentHouserNo = p.PresentHouserNo;
                studentInfo.PresentRoadNo = p.PresentRoadNo;
                studentInfo.PresentBlock = p.PresentBlock;
                studentInfo.PresentSector = p.PresentSector;

                studentInfo.BanglaPresentPost = p.BanglaPresentPost;
                studentInfo.BanglaPresentThana = p.BanglaPresentThana;
                studentInfo.BanglaPresentDistrict = p.BanglaPresentDistrict;

                ///bangla
                ///
                studentInfo.BanglaPresentHouserNo = p.BanglaPresentHouserNo;
                studentInfo.BanglaPresentRoadNo = p.BanglaPresentRoadNo;
                studentInfo.BanglaPresentBlock = p.BanglaPresentBlock;
                studentInfo.BanglaPresentSector = p.BanglaPresentSector;

                //studentInfo.GuardianPost = p.GuardianPostId;
                //studentInfo.GuardianThana = p.GuardianThanaId;
                //studentInfo.GuardianDistrict = p.GuardianDistrictId;

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
                //studentInfo.AccadamicInfo_RollNo = p.AccadamicInfo_RollNo;
                studentInfo.AccadamicInfo_RegistrationNo = (int)p.AccadamicInfo_RegistrationNoR;
                //studentInfo.AccadamicInfo_PassingYear = p.AccadamicInfo_PassingYear;
                studentInfo.AccadamicInfo_GPA = p.AccadamicInfo_GPA;
                studentInfoBoardList.Add(studentInfo);
            }


            if (studentInfoBoardList.Count > 0)
            {
                report riport = new report();
                ReportUtility.Display_report(riport, studentInfoBoardList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
        }
         
    }
}
 