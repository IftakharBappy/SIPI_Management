using BLL.Admission;
using BLL.ResultManagement;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.ResultManagement;
using ENTITY.StudentManagement;
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

namespace SIPI_SL.UI.ResultManagement
{
    /// <summary>
    /// Interaction logic for CourseAssignToStudentUI.xaml
    /// </summary>
    public partial class CourseAssignToStudentUI : Window
    {
        List<StudentInfo> studentInfoList;
        StudentResult _studentResultObj;

        StudentInfoManager studentInfoManager = new StudentInfoManager();

        List<SIPI_Department> _SIPIDepartmentList;
        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();
        //StudentInfo studentinfoObj = new StudentInfo();
        

        List<Semester> SemesterList;
        List<Campus> campusList;
        List<Day> dayList;
        List<Year> YearList;
        List<Course> courseInfoList;
        List<StudentResult> _studentResultList;
        CampusManager _campusManagerObj = new CampusManager();
        SemesterManager semesterManagerObj = new SemesterManager();
        DayManager _dayManager = new DayManager();
        CourseManager _courseManager = new CourseManager();
        StudentInfoManager _studentInfoManagerObj = new StudentInfoManager();
        StudentResultManager studentresultManagerObj = new StudentResultManager();
        public CourseAssignToStudentUI()
        {
            InitializeComponent();
            LoadYearComboBox();
            LoadDepartmentComboBox();
            LoadAllSemester();
            LoadSemesterAssignCmbBox();
            LoadAssignCourse();
        }

        private void LoadAssignCourse()
        {
            try
            {
                _studentResultList = _courseManager.GetAssignedCourse();
                assignStudent.Items.Clear();
                if (_studentResultList.Count > 0)
                {
                    foreach (var item in _studentResultList)
                    {
                        assignStudent.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void callChecked(object sender, RoutedEventArgs e)
        {
            ((StudentInfo)studentListDataGrid.SelectedItem).IsChecked = true;
        }

        private void callUnChecked(object sender, RoutedEventArgs e)
        {
            ((StudentInfo)studentListDataGrid.SelectedItem).IsChecked = false;
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
        private void LoadSemesterAssignCmbBox()
        {
            SemesterList = new List<Semester>();
            semesterAssignCmbBox.Items.Clear();
            SemesterList = semesterManagerObj.GetAllSemester();
            foreach (Semester semester in SemesterList)
            {
                semesterAssignCmbBox.ItemsSource = SemesterList;
            }
            semesterAssignCmbBox.DisplayMemberPath = "SemesterNo";
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

        private void LoadYearComboBox()
        {
            dayList = new List<Day>();
            yearCombobox.Items.Clear();
            dayList = _dayManager.GetAllYear();
            foreach (Day days in dayList)
            {
                yearCombobox.ItemsSource = dayList;
            }
            yearCombobox.DisplayMemberPath = "Year";
        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

            if (departmentCombobox.Text != "" && semesterCombobox.Text != "" && yearCombobox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string dept = departmentCombobox.Text.Trim();
                string sem = semesterCombobox.Text.Trim();
                string year = yearCombobox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentForAssignSemester(dept, sem, year);
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
        }

        private void semesterAssignCmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (semesterAssignCmbBox.SelectedIndex > -1)
                {
                    courseInfoList = new List<Course>();
                    string dept = ((SIPI_Department)departmentCombobox.SelectedItem).SIPI_DepartmentName.Trim();
                    string sem = ((Semester)semesterAssignCmbBox.SelectedItem).SemesterNo.Trim();
                    courseInfoList = _courseManager.GetCourseBydeptSemester(dept, sem);
                    CourseListDataGrid.Items.Clear();
                    if (courseInfoList.Count > 0)
                    {
                        foreach (var item in courseInfoList)
                        {
                            CourseListDataGrid.Items.Add(item);
                        }
                    }
                    if (courseInfoList.Count == 0)
                    {
                        MessageBox.Show("Here Is no Course");
                        semesterAssignCmbBox.SelectedIndex =-1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
           

        }


        private void assignButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _studentResultList = new List<StudentResult>();
                
                for (int i = 0; i < studentListDataGrid.Items.Count; i++)
                {
                    
                    StudentInfo obj = new StudentInfo();
                    obj = (StudentInfo)studentListDataGrid.Items[i];

                    if (obj.IsChecked == true)
                    {
                      
                        foreach (Course j in CourseListDataGrid.Items)
                        {
                            _studentResultObj = new StudentResult();
                            _studentResultObj.DepartmentId = ((SIPI_Department)departmentCombobox.SelectedItem).Id;
                            _studentResultObj.SemesterId = ((Semester)semesterAssignCmbBox.SelectedItem).Id;
                            _studentResultObj.YearNo = Convert.ToInt32(yearCombobox.Text);
                            _studentResultObj.StudentPKId = obj.Id;
                            _studentResultObj.CourseId = j.Id;
                            _studentResultList.Add(_studentResultObj);
                        }
                    }
                }
                studentresultManagerObj.SaveAssignedStudent(_studentResultList);
                _studentInfoManagerObj.UpdateSemesterStatus(_studentResultObj);
                MessageBox.Show("The Student's are Assinged On" + Environment.NewLine + ((Semester)semesterAssignCmbBox.SelectedItem).SemesterNo + "-Semester");
                studentListDataGrid.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void EditZoneInfoContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void RemoveZoneInfoContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");
        }


    }
}
