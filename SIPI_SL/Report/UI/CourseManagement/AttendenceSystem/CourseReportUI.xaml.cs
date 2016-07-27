using BLL.Admission;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.StudentManagement;
using SIPI_SL.Report.Crystal.CourseManagement;
using SIPI_SL.Report.Entity;
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

namespace SIPI_SL.Report.UI.CourseManagement
{
    /// <summary>
    /// Interaction logic for CourseReportUI.xaml
    /// </summary>
    public partial class CourseReportUI : Window
    {
       List<Semester> SemesterList;
       List<SIPI_Department> _SIPIDepartmentList;
       SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();
       SemesterManager semesterManagerObj = new SemesterManager();
       CourseManager _courseManager = new CourseManager();
        List<Course> createCourseList = new List<Course>();
        List<CourseR> _RCourseList = new List<CourseR>();
       

        public CourseReportUI()
        {
            InitializeComponent();
            LoadSemesterComboBox();
            LoadDepartmentComboBox();
            LoadAllCourse();
        }
        private void LoadSemesterComboBox()
        {
            SemesterList = new List<Semester>();
            semesterCombobox.Items.Clear();
            SemesterList = semesterManagerObj.GetAllSemester();
            foreach (Semester semester in SemesterList)
            {
                semesterCombobox.ItemsSource = SemesterList;
            }
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
        }

        private void LoadAllCourse()
        {
            createCourseList = new List<Course>();
            createCourseList = _courseManager.GetAllCourse();
            courselistView.Items.Clear();
            if (createCourseList.Count > 0)
            {
                foreach (Course item in createCourseList)
                {
                    courselistView.Items.Add(item);
                }


            }
        }

        private void previewReportButton_Click(object sender, RoutedEventArgs e)
        {

            _RCourseList.Clear();
            foreach (Course p in createCourseList)
            {
                CourseR courseInfo = new CourseR();
                courseInfo.Id = p.Id;
                courseInfo.DepartmentName = p.DepartmentName;
                courseInfo.ProgramName = p.ProgramName;
                courseInfo.SemesterNo = p.SemesterNo;
                courseInfo.CourseName = p.CourseName;
                courseInfo.BanglaCourseName = p.BanglaCourseName;
                courseInfo.CourseCode = p.CourseCode;
                courseInfo.TheoryCredit = p.TheoryCredit;
                courseInfo.PracticalCredit= p.PracticalCredit;
                courseInfo.TotalCredit = p.TotalCredit;
                courseInfo.TheoryMarkasContinuousAssessment = p.TheoryMarkasContinuousAssessment;
                courseInfo.TheoryMarkasFinalExam = p.TheoryMarkasFinalExam;
                courseInfo.PracticalMarkasContinuousAssessment = p.PracticalMarkasContinuousAssessment;
                courseInfo.PracticalMarkasFinalExam = p.PracticalMarkasFinalExam;
                courseInfo.TotalMarks = p.TotalMarks;
                

                _RCourseList.Add(courseInfo);

            }


            if (_RCourseList.Count > 0)
            {
                CourseReport riport = new CourseReport();
                ReportUtility.Display_report(riport, _RCourseList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
           
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (departmentCombobox.Text != "")
            {
                createCourseList = new List<Course>();
                string dept = departmentCombobox.Text.Trim();
                string semester = semesterCombobox.Text.Trim();
                createCourseList = _courseManager.GetAllCourseByDepartment(dept, semester);
                courselistView.Items.Clear();
                if (createCourseList.Count > 0)
                {
                    foreach (var item in createCourseList)
                    {
                        courselistView.Items.Add(item);
                    }
                }
            }
        }


        
    }
}
