using BLL.Admission;
using BLL.AttendenceSystem;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.AttendenceSystem;
using ENTITY.StudentManagement;
using SIPI_SL.UI.Admission;
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

namespace SIPI_SL.UI.AttendenceSystem
{
    /// <summary>
    /// Interaction logic for StudentAttendenceUI.xaml
    /// </summary>
    public partial class StudentAttendenceUI : Window
    {

        List<StudentInfo> studentInfoList;
        StudentInfoManager studentInfoManager = new StudentInfoManager();
        List<SIPI_Department> _SIPIDepartmentList;
        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();
        //StudentInfo studentinfoObj = new StudentInfo();
        List<Semester> SemesterList;
        List<Campus> campusList;
        List<Day> dayList;
        List<Year> YearList;

        CampusManager _campusManagerObj = new CampusManager();
        SemesterManager semesterManagerObj = new SemesterManager();
        StudentAttendence _studentAttendenceObj;
        AttendenceSystemManager attendenceSystemManagerObj = new AttendenceSystemManager();
        List<StudentAttendence> _studentAttendenceList;
        StudentAttendence _studentAttendencrObj;
        DayManager _dayManager = new DayManager();
        public StudentAttendenceUI()
        {
            InitializeComponent();
            //LoadAllStudentInfo();
            LoadDepartmentComboBox();
            LoadCampusComboBox();
            loadAllSemester();
            LoadYearComboBox();
            attendenceDatePicker.SelectedDate = DateTime.Now;
        }
        private void insertAttendenceButton_Click(object sender, RoutedEventArgs e)
        {

             _studentAttendenceList = new List<StudentAttendence>();

            for (int i = 0; i < studentListDataGrid.Items.Count; i++)
            {
               _studentAttendenceObj = new StudentAttendence();
                StudentInfo obj = new StudentInfo();
                obj = (StudentInfo)studentListDataGrid.Items[i];

                //studentListDataGrid.chchkDiscontinue
                if (obj.IsChecked==true)
                {
                    _studentAttendenceObj.DepartmentId = (int)obj.DepartmentId;
                    _studentAttendenceObj.CampusId = (int)obj.CampusId;
                    _studentAttendenceObj.StudentPKId = obj.Id;
                    _studentAttendenceObj.SemesterId = ((Semester)semesterCombobox.SelectedItem).Id;
                    _studentAttendenceObj.Year = (int)((Day)yearCombobox.SelectedItem).Year;
                    _studentAttendenceObj.Date = DateTime.Parse(attendenceDatePicker.Text);
                    _studentAttendenceObj.Status = "Present";
                    _studentAttendenceList.Add(_studentAttendenceObj);
                }
                if (obj.IsChecked == false)
                {
                    _studentAttendenceObj.DepartmentId = (int)obj.DepartmentId;
                    _studentAttendenceObj.CampusId = (int)obj.CampusId;
                    _studentAttendenceObj.StudentPKId = obj.Id;
                    _studentAttendenceObj.SemesterId = ((Semester)semesterCombobox.SelectedItem).Id;
                    _studentAttendenceObj.Year = ((Day)yearCombobox.SelectedItem).Id;
                    _studentAttendenceObj.Date = DateTime.Parse(attendenceDatePicker.Text);
                    _studentAttendenceObj.Status="Absent";
                    _studentAttendenceList.Add(_studentAttendenceObj);
                }
            }
            attendenceSystemManagerObj.SaveStudentAttendence(_studentAttendenceList);
            MessageBox.Show("Attendance Complete");
            studentListDataGrid.Items.Clear();
        }
        private void LoadYearComboBox()
        {
            dayList = new List<Day>();
            yearCombobox.Items.Clear();
            dayList = _dayManager.GetAllYear();
            foreach (Day days in dayList)
            {
                yearCombobox.ItemsSource = dayList;
            }
        }
      
        private void LoadCampusComboBox()
        {
            campusCombobox.Items.Clear();
            campusList = _campusManagerObj.GetAllCampus();
            foreach (Campus campus in campusList)
            {
                campusCombobox.ItemsSource = campusList;
            }
        }

        private void loadAllSemester()
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
        private void LoadAllStudentInfo()
        {
            studentInfoList = new List<StudentInfo>();
            studentInfoList = studentInfoManager.GetAllStudentInfo();
            studentListDataGrid.Items.Clear();
            if (studentInfoList.Count > 0)
            {
                foreach (var item in studentInfoList)
                {
                    studentListDataGrid.Items.Add(item);
                }

            }
        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (departmentCombobox.Text != "" && semesterCombobox.Text != "" && campusCombobox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string dept = departmentCombobox.Text.Trim();
                string sem = semesterCombobox.Text.Trim();
                string camp = campusCombobox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentDepartmentSemester(dept, sem, camp);
                //studentInfoList = studentInfoManager.GetAllStudentDepartment(dept);
                studentListDataGrid.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    foreach (var item in studentInfoList)
                    {
                        studentListDataGrid.Items.Add(item);
                    }
                }
            }
            //else
            //{
            //    LoadAllStudentInfo();
            //}
        }

        private void callChecked(object sender, RoutedEventArgs e)
        {
            ((StudentInfo)studentListDataGrid.SelectedItem).IsChecked = true;
        }

        private void callUnChecked(object sender, RoutedEventArgs e)
        {
            ((StudentInfo)studentListDataGrid.SelectedItem).IsChecked = false;
        }


        
    }
}
