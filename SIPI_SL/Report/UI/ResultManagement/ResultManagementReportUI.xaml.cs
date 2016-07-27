using BLL.Admission;
using BLL.ResultManagement;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.ResultManagement;
using ENTITY.StudentManagement;
using SIPI_SL.Report.Crystal.ResultManagement;
using SIPI_SL.Report.Entity.ResultManagement;
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

namespace SIPI_SL.Report.UI.ResultManagement
{
    /// <summary>
    /// Interaction logic for ResultManagementReportUI.xaml
    /// </summary>
    public partial class ResultManagementReportUI : Window
    {
        List<StudentResult> _studentResultMkaDistributionList;

        List<SIPI_Department> _SIPIDepartmentList;
        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();

        List<ENTITY.StudentManagement.Day> dayList;
        DayManager _dayManager = new DayManager();

        List<Semester> SemesterList;
        SemesterManager semesterManagerObj = new SemesterManager();


        List<Course> courseListForMKS_Distribution;
        CourseManager courseManagerObj = new CourseManager();
        StudentResultManager studentResultManagerObj = new StudentResultManager();
        StudentResult _model;
        List<StudentResultReport> studentResultInfoList = new List<StudentResultReport>();

        public ResultManagementReportUI()
        {
            InitializeComponent();
            LoadYearComboBox();
            LoadDepartmentComboBox();
            LoadAllSemester();
        }

        private void LoadYearComboBox()
        {
            dayList = new List<ENTITY.StudentManagement.Day>();
            yearCombobox.Items.Clear();
            dayList = _dayManager.GetAllYear();
            foreach (ENTITY.StudentManagement.Day days in dayList)
            {
                yearCombobox.ItemsSource = dayList;
            }
            yearCombobox.DisplayMemberPath = "Year";
        }

        private void LoadDepartmentComboBox()
        {
            _SIPIDepartmentList = new List<SIPI_Department>();
            departmentCombobox.Items.Clear();
            _SIPIDepartmentList = sIPI_DepartmentManagerObj.GetAll_SIPIDepartment();
            foreach (SIPI_Department department in _SIPIDepartmentList)
            {
                departmentCombobox.ItemsSource = _SIPIDepartmentList;
            }
            departmentCombobox.DisplayMemberPath = "SIPI_DepartmentName";
        }

        private void LoadAllSemester()
        {
            SemesterList = new List<Semester>();
            semesterCombobox.Items.Clear();
            SemesterList = semesterManagerObj.GetAllSemester();
            foreach (Semester semester in SemesterList)
            {
                semesterCombobox.ItemsSource = SemesterList;
            }
            semesterCombobox.DisplayMemberPath = "SemesterNo";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (departmentCombobox.Text != "" && semesterCombobox.Text != "" && yearCombobox.Text != "" && studentIdTextBox.Text != "")
                {
                    _studentResultMkaDistributionList = new List<StudentResult>();
                    string dept = departmentCombobox.Text.Trim();
                    string sem = semesterCombobox.Text.Trim();
                    int year = Convert.ToInt32(yearCombobox.Text.Trim());
                    string _studentId = studentIdTextBox.Text.Trim();

                    _studentResultMkaDistributionList = studentResultManagerObj.GetStudentMarksSeetSemesterWise(dept, sem, year, _studentId);
                    StudentMarksEntryDataGrid.Items.Clear();
                    if (_studentResultMkaDistributionList.Count > 0)
                    {
                        foreach (var item in _studentResultMkaDistributionList)
                        {
                            StudentMarksEntryDataGrid.Items.Add(item);
                        }
                    }
                }
                else
                {
                    _studentResultMkaDistributionList = new List<StudentResult>();
                    string dept = departmentCombobox.Text.Trim();
                    string sem = semesterCombobox.Text.Trim();
                    int year = Convert.ToInt32(yearCombobox.Text.Trim());
                    //string _studentId = studentIdTextBox.Text.Trim();

                    _studentResultMkaDistributionList = studentResultManagerObj.GetStudentMarksSeetSemesterWisePerStudent(dept, sem, year);
                    StudentMarksEntryDataGrid.Items.Clear();
                    if (_studentResultMkaDistributionList.Count > 0)
                    {
                        foreach (var item in _studentResultMkaDistributionList)
                        {
                            StudentMarksEntryDataGrid.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void studentResultReportButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (StudentResult p in _studentResultMkaDistributionList)
                {
                    StudentResultReport studentResultInfo = new StudentResultReport();
                    studentResultInfo.Id = p.Id;
                    studentResultInfo.DepartmentId = p.DepartmentId;
                    studentResultInfo.DepartmentName = p.DepartmentName;
                    studentResultInfo.StudentPKId = p.StudentPKId;
                    studentResultInfo.StudentName = p.StudentName;
                    studentResultInfo.StudentId = p.StudentId;
                    studentResultInfo.SemesterId = p.SemesterId;
                    studentResultInfo.SemesterNo = p.SemesterNo;
                    studentResultInfo.CourseId = p.CourseId;
                    studentResultInfo.CourseName = p.CourseName;
                    studentResultInfo.YearId = p.YearId;
                    studentResultInfo.YearNo = p.YearNo;
                    studentResultInfo.TheoryMarksConAssess = p.TheoryMarksConAssess;
                    studentResultInfo.TheoryMarksFinalExam = p.TheoryMarksFinalExam;
                    studentResultInfo.PracticalMarksConAssess = p.PracticalMarksConAssess;
                    studentResultInfo.PracticalMarksFinalExam = p.PracticalMarksFinalExam;
                    studentResultInfo.TotalMarks = p.TotalMarks;
                    studentResultInfo.FatherName = p.FatherName;
                    studentResultInfo.MotherName = p.MotherName;
                    studentResultInfo.BoardRollNo = p.BoardRollNo;
                    studentResultInfo.BoardRegistrationNo = p.BoardRegistrationNo;
                    studentResultInfo.Section = p.Section;
                    studentResultInfo.CourseFullMarks = p.CourseFullMarks;
                    studentResultInfo.CourseFullCredit = p.CourseFullCredit;
                    studentResultInfo.CourseCode = p.CourseCode;
                    studentResultInfo.MarksObtain = p.MarksObtain;


                    // studentResultInfo.HeldIn =  = p.he
                    //studentResultInfo.Shift

                    studentResultInfoList.Add(studentResultInfo);
                }

                if (studentResultInfoList.Count > 0)
                {
                    MarksSheetReport marksSheetCrystalReport = new MarksSheetReport();
                    ReportUtility.Display_report(marksSheetCrystalReport, studentResultInfoList, this);
                }
                else
                {
                    MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void studentBoardResultReportButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (StudentResult p in _studentResultMkaDistributionList)
                {
                    StudentResultReport studentResultInfo = new StudentResultReport();
                    studentResultInfo.Id = p.Id;
                    studentResultInfo.DepartmentId = p.DepartmentId;
                    studentResultInfo.DepartmentName = p.DepartmentName;
                    studentResultInfo.StudentPKId = p.StudentPKId;
                    studentResultInfo.StudentName = p.StudentName;
                    studentResultInfo.StudentId = p.StudentId;
                    studentResultInfo.SemesterId = p.SemesterId;
                    studentResultInfo.SemesterNo = p.SemesterNo;
                    studentResultInfo.CourseId = p.CourseId;
                    studentResultInfo.CourseName = p.CourseName;
                    studentResultInfo.YearId = p.YearId;
                    studentResultInfo.YearNo = p.YearNo;
                    studentResultInfo.TheoryMarksConAssess = p.TheoryMarksConAssess;
                    studentResultInfo.TheoryMarksFinalExam = p.TheoryMarksFinalExam;
                    studentResultInfo.PracticalMarksConAssess = p.PracticalMarksConAssess;
                    studentResultInfo.PracticalMarksFinalExam = p.PracticalMarksFinalExam;
                    studentResultInfo.TotalMarks = p.TotalMarks;
                    studentResultInfo.FatherName = p.FatherName;
                    studentResultInfo.MotherName = p.MotherName;
                    studentResultInfo.BoardRollNo = p.BoardRollNo;
                    studentResultInfo.BoardRegistrationNo = p.BoardRegistrationNo;
                    studentResultInfo.Section = p.Section;
                    studentResultInfo.CourseFullMarks = p.CourseFullMarks;
                    studentResultInfo.CourseFullCredit = p.CourseFullCredit;
                    studentResultInfo.CourseCode = p.CourseCode;
                    studentResultInfo.MarksObtain = p.MarksObtain;


                    // studentResultInfo.HeldIn =  = p.he
                    //studentResultInfo.Shift

                    studentResultInfoList.Add(studentResultInfo);
                }

                if (studentResultInfoList.Count > 0)
                {
                    ResultForBoard marksSheetCrystalReport = new ResultForBoard();
                    ReportUtility.Display_report(marksSheetCrystalReport, studentResultInfoList, this);
                }
                else
                {
                    MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
