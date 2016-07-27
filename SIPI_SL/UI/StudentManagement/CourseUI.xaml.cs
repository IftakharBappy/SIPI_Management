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
using BLL.Admission;
using ENTITY.Admission;
using BLL.StudentManagement;
using ENTITY.StudentManagement;
using System.IO;

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for CourseUI.xaml
    /// </summary>
    public partial class CourseUI : Window
    {
        SIPI_DepartmentManager sipiDepartmenatManagerObj = new SIPI_DepartmentManager();
        SIPI_ProgramManager sipi_ProgarmManagerObj = new SIPI_ProgramManager();
        SemesterManager semesterManagerObj = new SemesterManager();

        //List<Department> _DepartmentList;
        //List<Program> _ProgrameList;

       
        List<Semester> _semesterList;
        List<Course> _courseList;

        List<SIPI_Department> _Sipi_DepartmentList;
        List<SIPI_Program> _sipi_ProgrameList;

        Course _courseObj;
        CourseManager _courseManager = new CourseManager();

        //Department _departmentObj;
        //Program _program;

        SIPI_Department _sipi_departmentObj;
        SIPI_Program _sipi_program;
        Semester _semester;
        public CourseUI()
        {
            InitializeComponent();
            LoadSIPI_ProgramCombobox();
            LoadSIPIDepartmentCombobox();
            LoadSemesterCombobox();
            LoadAllCourse();
            TotalCreditTextBox.IsEnabled = false;
            totalMarksTextbox.IsEnabled = false;
        }

        private void LoadAllCourse()
        {
            _courseList = new List<Course>();
            _courseList = _courseManager.GetAllCourse();
            courselistView.Items.Clear();
            if (_courseList.Count > 0)
            {
                foreach (Course item in _courseList)
                {
                    courselistView.Items.Add(item);
                }


            }
        }


        private void LoadSIPI_ProgramCombobox()
        {
            _sipi_ProgrameList = new List<SIPI_Program>();
            programNameCombobax.Items.Clear();
            _sipi_ProgrameList = sipi_ProgarmManagerObj.GetAllSIPI_Program();
            foreach (SIPI_Program a in _sipi_ProgrameList)
            {
                programNameCombobax.ItemsSource = _sipi_ProgrameList;
            }
        }
        private void LoadSemesterCombobox()
        {
            _semesterList = new List<Semester>();
            semesterCombobax.Items.Clear();
            _semesterList = semesterManagerObj.GetAllSemester();
            foreach (Semester a in _semesterList)
            {
                semesterCombobax.ItemsSource = _semesterList;
            }
           
        }
        private void LoadSIPIDepartmentCombobox()
        {


            _Sipi_DepartmentList = new List<SIPI_Department>();
            departmentNameCombobax.Items.Clear();
            _Sipi_DepartmentList = sipiDepartmenatManagerObj.GetAll_SIPIDepartment();
            foreach (SIPI_Department a in _Sipi_DepartmentList)
            {
                departmentNameCombobax.ItemsSource = _Sipi_DepartmentList;
            }
            
        }
        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (submitButton.Content.ToString() == "Save")
                {

                    _courseObj = new Course();

                    _courseObj.CourseName = courseNameTextBox.Text;
                    _courseObj.BanglaCourseName = banglaCourseNameTextBox.Text;

                    _sipi_program = new SIPI_Program();
                    _sipi_program = ((SIPI_Program)programNameCombobax.SelectedItem);
                    _courseObj.ProgramId = _sipi_program.Id;

                    _sipi_departmentObj = new SIPI_Department();
                    _sipi_departmentObj = ((SIPI_Department)departmentNameCombobax.SelectedItem);
                    _courseObj.DepartmentId = _sipi_departmentObj.Id;

                    _semester = new Semester();
                    _semester = ((Semester)semesterCombobax.SelectedItem);
                    _courseObj.SemesterId = _semester.Id;
                    _courseObj.CourseCode = courseCodeTextBox.Text;
                    _courseObj.TheoryCredit = Convert.ToDouble(theoryCreditTextBox.Text);
                    _courseObj.PracticalCredit = Convert.ToDouble(precticalCreditTextBox.Text);
                    _courseObj.TotalCredit = Convert.ToDouble(TotalCreditTextBox.Text);

                    _courseObj.TheoryMarkasContinuousAssessment = Convert.ToDouble(theoryMarkasContinuousAssessmentTextbox.Text);
                    _courseObj.TheoryMarkasFinalExam = Convert.ToDouble(theoryMarkasFinalExamTextBox.Text);

                    _courseObj.PracticalMarkasContinuousAssessment = Convert.ToDouble(PracticalMarkasContinuousAssessmentTextBox.Text);
                    _courseObj.PracticalMarkasFinalExam = Convert.ToDouble(PracticalMarkasFinalExamTextBox.Text);

                    _courseObj.TotalMarks = Convert.ToDouble(totalMarksTextbox.Text);

                    _courseManager.SaveCourse(_courseObj);
                    LoadAllCourse();
                    MessageBox.Show("Data insurted successfully");

                }

                if (submitButton.Content.ToString() == "Update")
                {


                    _courseObj.CourseName = courseNameTextBox.Text;
                    _courseObj.BanglaCourseName = banglaCourseNameTextBox.Text;

                    _sipi_program = new SIPI_Program();
                    _sipi_program = ((SIPI_Program)programNameCombobax.SelectedItem);
                    _courseObj.ProgramId = _sipi_program.Id;

                    _sipi_departmentObj = new SIPI_Department();
                    _sipi_departmentObj = ((SIPI_Department)departmentNameCombobax.SelectedItem);
                    _courseObj.DepartmentId = _sipi_departmentObj.Id;

                    _semester = new Semester();
                    _semester = ((Semester)semesterCombobax.SelectedItem);
                    _courseObj.SemesterId = _semester.Id;

                    _courseObj.CourseCode = courseCodeTextBox.Text;
                    _courseObj.TheoryCredit = Convert.ToDouble(theoryCreditTextBox.Text);
                    _courseObj.PracticalCredit = Convert.ToDouble(precticalCreditTextBox.Text);
                    _courseObj.TotalCredit = Convert.ToDouble(TotalCreditTextBox.Text);

                    _courseObj.TheoryMarkasContinuousAssessment = Convert.ToDouble(theoryMarkasContinuousAssessmentTextbox.Text);
                    _courseObj.TheoryMarkasFinalExam = Convert.ToDouble(theoryMarkasFinalExamTextBox.Text);

                    _courseObj.PracticalMarkasContinuousAssessment = Convert.ToDouble(PracticalMarkasContinuousAssessmentTextBox.Text);
                    _courseObj.PracticalMarkasFinalExam = Convert.ToDouble(PracticalMarkasFinalExamTextBox.Text);

                    _courseObj.TotalMarks = Convert.ToDouble(totalMarksTextbox.Text);

                    _courseManager.UpdateCourse(_courseObj);
                    LoadAllCourse();
                    MessageBox.Show("Data insurted successfully");
                    submitButton.Content = "Save";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void EditCourseContextMenu_Click(object sender, RoutedEventArgs e)
        { 
            _courseObj = new Course();
            _courseObj = ((Course)courselistView.SelectedItem);

            courseNameTextBox.Text = _courseObj.CourseName;
            banglaCourseNameTextBox.Text = _courseObj.BanglaCourseName;

            for (int i = 0; i < programNameCombobax.Items.Count; i++)
            {
                SIPI_Program sipi_program = (SIPI_Program)programNameCombobax.Items[i];
                if (_courseObj.ProgramId == sipi_program.Id)
                {
                    programNameCombobax.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < departmentNameCombobax.Items.Count; i++)
            {
                SIPI_Department sipi_Department = (SIPI_Department)departmentNameCombobax.Items[i];
                if (_courseObj.DepartmentId == sipi_Department.Id)
                {
                    departmentNameCombobax.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < departmentNameCombobax.Items.Count; i++)
            {
                Semester semester = (Semester)semesterCombobax.Items[i];
                if (_courseObj.SemesterId == semester.Id)
                {
                    semesterCombobax.SelectedIndex = i;
                    break;
                }
            }
            
            //departmentNameCombobax.SelectedIndex = (int)_courseObj.DepartmentId;
            //programNameCombobax.SelectedIndex = (int)_courseObj.ProgramId;
            //semesterCombobax.SelectedIndex = (int)_courseObj.SemesterId;

            courseCodeTextBox.Text = _courseObj.CourseCode;
            theoryCreditTextBox.Text = _courseObj.TheoryCredit.ToString();
            precticalCreditTextBox.Text = _courseObj.PracticalCredit.ToString();
            TotalCreditTextBox.Text = _courseObj.TotalCredit.ToString();
            theoryMarkasContinuousAssessmentTextbox.Text = _courseObj.TheoryMarkasContinuousAssessment.ToString();
            theoryMarkasFinalExamTextBox.Text = _courseObj.TheoryMarkasFinalExam.ToString();
            PracticalMarkasContinuousAssessmentTextBox.Text = _courseObj.PracticalMarkasContinuousAssessment.ToString();

            PracticalMarkasFinalExamTextBox.Text = _courseObj.PracticalMarkasFinalExam.ToString();
            totalMarksTextbox.Text = _courseObj.TotalMarks.ToString();

            submitButton.Content = "Update";
            //clearButton.IsEnabled = false;
            clearButton.Content = "Cancle";
        }

        private void RemoveCourseContextMenu_Click(object sender, RoutedEventArgs e)
        {
            _courseObj = new Course();
            _courseObj = ((Course)courselistView.SelectedItem);
            _courseManager.DeleteSemester(_courseObj);
            MessageBox.Show("Data Update successfully");
            LoadAllCourse();

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            if (clearButton.Content.ToString() == "Clear")
            {
                programNameCombobax.Text = "";
                departmentNameCombobax.Text = "";
                courseCodeTextBox.Text = "";
                courseNameTextBox.Text = "";
                banglaCourseNameTextBox.Text = "";
                courseCodeTextBox.Text = "";
                theoryCreditTextBox.Text = "";
                precticalCreditTextBox.Text = "";
                TotalCreditTextBox.Text = "";
                theoryMarkasContinuousAssessmentTextbox.Text = "";
                theoryMarkasFinalExamTextBox.Text = "";
                PracticalMarkasContinuousAssessmentTextBox.Text = "";
                PracticalMarkasFinalExamTextBox.Text = "";
                totalMarksTextbox.Text = "";
                semesterCombobax.Text = "";
            }
            if (clearButton.Content.ToString() == "Cancle")
            {
                submitButton.Content = "Save";
                clearButton.Content = "Clear";

                programNameCombobax.Text = "";
                departmentNameCombobax.Text = "";
                courseCodeTextBox.Text = "";
                courseNameTextBox.Text = "";
                banglaCourseNameTextBox.Text = "";
                courseCodeTextBox.Text = "";
                theoryCreditTextBox.Text = "";
                precticalCreditTextBox.Text = "";
                TotalCreditTextBox.Text = "";
                theoryMarkasContinuousAssessmentTextbox.Text = "";
                theoryMarkasFinalExamTextBox.Text = "";
                PracticalMarkasContinuousAssessmentTextBox.Text = "";
                PracticalMarkasFinalExamTextBox.Text = "";
                totalMarksTextbox.Text = "";
                semesterCombobax.Text = "";
            }

        }

        /////////TotalCredit Count//
        
        private void theoryCreditTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(theoryCreditTextBox.Text)) && (!string.IsNullOrEmpty(precticalCreditTextBox.Text)))
            {
                TotalCreditTextBox.Text = (Convert.ToInt32(theoryCreditTextBox.Text) + Convert.ToInt32(precticalCreditTextBox.Text)).ToString();
            }
        }

        private void precticalCreditTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(theoryCreditTextBox.Text)) && (!string.IsNullOrEmpty(precticalCreditTextBox.Text)))
            {
                TotalCreditTextBox.Text = (Convert.ToInt32(theoryCreditTextBox.Text) + Convert.ToInt32(precticalCreditTextBox.Text)).ToString();
            }
        }

        
        /////////TotalCredit Count End//
        private void theoryMarkasContinuousAssessmentTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(theoryMarkasContinuousAssessmentTextbox.Text)) && (!string.IsNullOrEmpty(theoryMarkasFinalExamTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasContinuousAssessmentTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasFinalExamTextBox.Text)))
                {
                    try
                    {
                        totalMarksTextbox.Text = (Convert.ToInt32(theoryMarkasContinuousAssessmentTextbox.Text) + Convert.ToInt32(theoryMarkasFinalExamTextBox.Text) + Convert.ToInt32(PracticalMarkasContinuousAssessmentTextBox.Text) + Convert.ToInt32(PracticalMarkasFinalExamTextBox.Text)).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalide Data.. ! Please insert Valide Data....");
                    }
                }
        }

        private void theoryMarkasFinalExamTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(theoryMarkasContinuousAssessmentTextbox.Text)) && (!string.IsNullOrEmpty(theoryMarkasFinalExamTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasContinuousAssessmentTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasFinalExamTextBox.Text)))
            {
                try
                {
                    totalMarksTextbox.Text = (Convert.ToInt32(theoryMarkasContinuousAssessmentTextbox.Text) + Convert.ToInt32(theoryMarkasFinalExamTextBox.Text) + Convert.ToInt32(PracticalMarkasContinuousAssessmentTextBox.Text) + Convert.ToInt32(PracticalMarkasFinalExamTextBox.Text)).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalide Data.. ! Please insert Valide Data....");
                }
            }
        }

        private void PracticalMarkasContinuousAssessmentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(theoryMarkasContinuousAssessmentTextbox.Text)) && (!string.IsNullOrEmpty(theoryMarkasFinalExamTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasContinuousAssessmentTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasFinalExamTextBox.Text)))
            {
                try
                {
                    totalMarksTextbox.Text = (Convert.ToInt32(theoryMarkasContinuousAssessmentTextbox.Text) + Convert.ToInt32(theoryMarkasFinalExamTextBox.Text) + Convert.ToInt32(PracticalMarkasContinuousAssessmentTextBox.Text) + Convert.ToInt32(PracticalMarkasFinalExamTextBox.Text)).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalide Data.. ! Please insert Valide Data....");
                }
            }
        }

        private void PracticalMarkasFinalExamTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                if ((!string.IsNullOrEmpty(theoryMarkasContinuousAssessmentTextbox.Text)) && (!string.IsNullOrEmpty(theoryMarkasFinalExamTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasContinuousAssessmentTextBox.Text)) && (!string.IsNullOrEmpty(PracticalMarkasFinalExamTextBox.Text)))
                {
                        try 
	                    {
                            totalMarksTextbox.Text = (Convert.ToInt32(theoryMarkasContinuousAssessmentTextbox.Text) + Convert.ToInt32(theoryMarkasFinalExamTextBox.Text) + Convert.ToInt32(PracticalMarkasContinuousAssessmentTextBox.Text) + Convert.ToInt32(PracticalMarkasFinalExamTextBox.Text)).ToString();
	                    }
	                    catch (Exception)
	                    {
                            MessageBox.Show("Invalide Data.. ! Please insert Valide Data....");
	                    }
                }
        }

    }
}
