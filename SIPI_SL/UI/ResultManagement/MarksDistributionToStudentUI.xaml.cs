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
    /// Interaction logic for MarksDistributionToStudentUI.xaml
    /// </summary>
    public partial class MarksDistributionToStudentUI : Window
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
        public MarksDistributionToStudentUI()
        {
            InitializeComponent();
            LoadYearComboBox();
            LoadDepartmentComboBox();
            LoadAllSemester();
            LoadAllCourse();

        }

        private void LoadAllCourse()
        {
            courseListForMKS_Distribution = new List<Course>();
            courseCombobox.Items.Clear();
            courseListForMKS_Distribution = courseManagerObj.GetAllCourse();
            foreach (Course courses in courseListForMKS_Distribution)
            {
                courseCombobox.ItemsSource = courseListForMKS_Distribution;
            }
            courseCombobox.DisplayMemberPath = "CourseName";
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

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (departmentCombobox.Text != "" && semesterCombobox.Text != "" && yearCombobox.Text != "" && courseCombobox.Text != "")
                {
                    _studentResultMkaDistributionList = new List<StudentResult>();
                    string dept = departmentCombobox.Text.Trim();
                    string sem = semesterCombobox.Text.Trim();
                    int year = Convert.ToInt32(yearCombobox.Text.Trim());
                    string course = courseCombobox.Text.Trim();

                    _studentResultMkaDistributionList = studentResultManagerObj.GetStudentForMarks(dept, sem, year, course);
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

        private void marksEntryButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<StudentResult> _StudentResultList = new List<StudentResult>();
                for (int i = 0; i < StudentMarksEntryDataGrid.Items.Count; i++)
                {
                    _model = new StudentResult();
                    StudentResult _StudentResultObj = (StudentResult)StudentMarksEntryDataGrid.Items[i];
                    _model.TheoryMarksConAssess = _StudentResultObj.TheoryMarksConAssess;
                    _model.PracticalMarksConAssess = _StudentResultObj.PracticalMarksConAssess;
                    _model.TheoryMarksFinalExam = _StudentResultObj.TheoryMarksFinalExam;
                    _model.PracticalMarksFinalExam = _StudentResultObj.PracticalMarksFinalExam;
                    _model.TotalMarks = _StudentResultObj.TotalMarks;
                    _model.Id = _StudentResultObj.Id;
                    _model.CourseId = _StudentResultObj.CourseId;
                    _model.DepartmentId = _StudentResultObj.DepartmentId;
                    _model.SemesterId = _StudentResultObj.SemesterId;
                    _model.StudentId = _StudentResultObj.StudentId;
                    _model.StudentPKId = _StudentResultObj.StudentPKId;
                    _model.YearNo = _StudentResultObj.YearNo;
                    _StudentResultList.Add(_model);
                }
                studentResultManagerObj.UpdateMarks(_StudentResultList);
                //feesSetupManagerObj.SaveFees(_feesSetupListObj);
                MessageBox.Show("Marks Entry Successful ", "Marks Entry");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        

        private void theotyConAssesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
            StudentResult chalan = new StudentResult();
            chalan = StudentMarksEntryDataGrid.SelectedItem as StudentResult;
            if (chalan!=null)
            {
                decimal TGBP = 0, theory = 0, practical = 0, finalExam = 0;

                theory = chalan.TheoryMarksConAssess;
                practical = chalan.PracticalMarksConAssess;
                finalExam = chalan.TheoryMarksFinalExam;
                TGBP = theory + practical + finalExam;
                chalan.TotalMarks = TGBP;
                
            }
         
              
        
         
        }

        private void PracticalConAssesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StudentResult chalan = new StudentResult();
            chalan = StudentMarksEntryDataGrid.SelectedItem as StudentResult;
            if (chalan != null)
            {
                decimal TGBP = 0, theory = 0, practical = 0, finalExam = 0;

                theory = chalan.TheoryMarksConAssess;
                practical = chalan.PracticalMarksConAssess;
                finalExam = chalan.TheoryMarksFinalExam;
                TGBP = theory + practical + finalExam;
                chalan.TotalMarks = TGBP;

            }
           
        }

      
        private void theotyFinalExamTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StudentResult chalan = new StudentResult();
            chalan = StudentMarksEntryDataGrid.SelectedItem as StudentResult;
            decimal TGBP = 0;
            for (int i = 0; i < StudentMarksEntryDataGrid.Items.Count; i++)
            {
                StudentResult obj = StudentMarksEntryDataGrid.Items[i] as StudentResult;
                TGBP = obj.TheoryMarksConAssess + obj.PracticalMarksConAssess + obj.theoryMarksFinalExam + obj.PracticalMarksFinalExam;
                obj.TotalMarks = TGBP;
            }
           
        }

        private void practicalFinalExamTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StudentResult chalan = new StudentResult();
            chalan = StudentMarksEntryDataGrid.SelectedItem as StudentResult;
            decimal TGBP = 0;
            for (int i = 0; i < StudentMarksEntryDataGrid.Items.Count; i++)
            {
                StudentResult obj = StudentMarksEntryDataGrid.Items[i] as StudentResult;
                TGBP = obj.TheoryMarksConAssess + obj.PracticalMarksConAssess + obj.theoryMarksFinalExam + obj.PracticalMarksFinalExam;
                obj.TotalMarks = TGBP;
            }
           
        }
    }
}
