using BLL.Admission;
using BLL.AttendenceSystem;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.AttendenceSystem;
using ENTITY.StudentManagement;
using SIPI_SL.Report.Crystal.AttendenceSystem;
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

namespace SIPI_SL.Report.UI.AttendenceSystem
{
    /// <summary>
    /// Interaction logic for AttendenceSystemReport.xaml
    /// </summary>
    public partial class AttendenceSystemReport : Window
    {
        List<Semester> SemesterList;
        List<SIPI_Department> _SIPIDepartmentList;
        SemesterManager semesterManagerObj = new SemesterManager();
        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();
        AttendenceSystemManager attendenceSystemManagerObj = new AttendenceSystemManager();
        List<StudentAttendence> _studentAttendenceList;
        List<RStudentAttandence> createAttandanceRList = new List<RStudentAttandence>();

        public AttendenceSystemReport()
        {
            InitializeComponent();
            LoadDepartmentComboBox();
            LoadSemesterComboBox();
            reportSearchDatepicker.SelectedDate = DateTime.Now;
            LoadAllAttendence();
        }

        private void LoadAllAttendence()
        {
            _studentAttendenceList = new List<StudentAttendence>();
            _studentAttendenceList = attendenceSystemManagerObj.GetAllStudentAttendence();
            allStudentAttendenceListView.Items.Clear();
            if (_studentAttendenceList.Count > 0)
            {
                foreach (var item in _studentAttendenceList)
                {
                    allStudentAttendenceListView.Items.Add(item);
                }


            }
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

        private void previewReportButton_Click(object sender, RoutedEventArgs e)
        {
            createAttandanceRList.Clear();
            foreach (StudentAttendence p in _studentAttendenceList)
            {
                RStudentAttandence studentAttandanceInfo = new RStudentAttandence();
                studentAttandanceInfo.ID = p.ID;
                //studentAttandanceInfo.StudentPKId = p.StudentPKId;
                studentAttandanceInfo.StudentName = p.StudentName;
                //studentAttandanceInfo.DepartmentId = p.DepartmentId;
                studentAttandanceInfo.DepartmentName = p.DepartmentName;
                studentAttandanceInfo.SemesterNo = p.SemesterNo;
                studentAttandanceInfo.Date = p.Date;
                //studentAttandanceInfo.Year = p.Year;
                studentAttandanceInfo.Status = p.Status;
                studentAttandanceInfo.CampusName = p.CampusName;

                createAttandanceRList.Add(studentAttandanceInfo);

            }


            if (createAttandanceRList.Count > 0)
            {
                StudentAttendenceRepost riport = new StudentAttendenceRepost();
                ReportUtility.Display_report(riport, createAttandanceRList, this);
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

                _studentAttendenceList = new List<StudentAttendence>();
                string dept = departmentCombobox.Text.Trim();
                string semester = semesterCombobox.Text.Trim();
                string year = yearTextBox.Text.Trim();
                string date = reportSearchDatepicker.Text.Trim();
                _studentAttendenceList = attendenceSystemManagerObj.GetSearchStudents(dept, semester, year, date);
                allStudentAttendenceListView.Items.Clear();
                if (_studentAttendenceList.Count > 0)
                {

                    foreach (var item in _studentAttendenceList)
                    {
                        allStudentAttendenceListView.Items.Add(item);

                    }

                }
            }
            else
            {
                MessageBox.Show("No data here");
            }
        }


    }
}
