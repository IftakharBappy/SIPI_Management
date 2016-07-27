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

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for StudentManagementMainUI.xaml
    /// </summary>
    public partial class StudentManagementMainUI : Window
    {
        public StudentManagementMainUI()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SemesterUI obj =new SemesterUI(); 
            obj.Show();
            
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
           CourseUI courseObj = new CourseUI();
            courseObj.Show();
        }

        private void MenuItem_Click_Program(object sender, RoutedEventArgs e)
        {
            UI.Admission.ProgramUI ProgramObj = new UI.Admission.ProgramUI();
            ProgramObj.Show();
        }

        private void MenuItem_Click_Department(object sender, RoutedEventArgs e)
        {
            UI.Admission.DepartmentUI departmentObj = new UI.Admission.DepartmentUI();
            departmentObj.Show();
        }

        private void MenuItem_Click_Batch(object sender, RoutedEventArgs e)
        {
            UI.Admission.BatchUI departmentObj = new UI.Admission.BatchUI();
            departmentObj.Show();
        }

        private void MenuItem_Click_Time(object sender, RoutedEventArgs e)
        {
            UI.StudentManagement.ClassPeriodUI classPeriodObj = new UI.StudentManagement.ClassPeriodUI();
            classPeriodObj.Show();
        }

        private void MenuItem_Click_RutinCreate(object sender, RoutedEventArgs e)
        {
            UI.StudentManagement.ClassRoutineCreateUI classRoutineObj = new UI.StudentManagement.ClassRoutineCreateUI();
            classRoutineObj.Show();
        }
        ///////////////////Kazi Obaydollah////////////////////

        private void MenuItem_Click_AssignTeacher(object sender, RoutedEventArgs e)
        {
            AssignTeacherUI assignTeacher = new AssignTeacherUI();
            assignTeacher.Show();
        }

        private void MenuItem_Click_AddTeacher(object sender, RoutedEventArgs e)
        {
            UI.TeacherManagement.TeacherInfoUI TeacherInfoObj = new TeacherManagement.TeacherInfoUI();
            TeacherInfoObj.Show();
        }

        
    }
}
