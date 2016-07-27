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
using ENTITY.StudentManagement;
using BLL.StudentManagement;


namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for SemesterUI.xaml
    /// </summary>
    public partial class SemesterUI : Window
    {
        Semester _semesterObj;
        SemesterManager semesterManagerobj = new SemesterManager();

        List<Semester> SemesterList;
        public SemesterUI()
        {
            InitializeComponent();
            LoadAllSemester();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

            if (saveButton.Content.ToString() == "Save")
            {
                _semesterObj = new Semester();
                _semesterObj.SemesterNo = semesterNoTextBox.Text;
                _semesterObj.BanglaSemesterNo = banglaSenesterNoTextBox.Text;
                if (semesterManagerobj.SaveSemester(_semesterObj) == true)
                {
                    MessageBox.Show("Teacher information is successfully saved", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Duplicate Data Insert ! Please check your Teacher Name", "Confirmation");
                }

                LoadAllSemester();
            }

            if (saveButton.Content.ToString() == "Update")
            {

                _semesterObj.SemesterNo = semesterNoTextBox.Text;
                _semesterObj.BanglaSemesterNo = banglaSenesterNoTextBox.Text;
                semesterManagerobj.SaveUpdate(_semesterObj);
                LoadAllSemester();
                MessageBox.Show("Data Update Succcessfull");
                saveButton.Content = "Save";
            }
        }

        private void LoadAllSemester()
        {
            SemesterList = new List<Semester>();
            SemesterList = semesterManagerobj.GetAllSemester();
            semesterlistView.Items.Clear();
            if (SemesterList.Count > 0)
            {
                foreach (var item in SemesterList)
                {
                    semesterlistView.Items.Add(item);
                }
            }
        }


        private void EditSemesterContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _semesterObj = new Semester();
            _semesterObj = ((Semester)semesterlistView.SelectedItem);
            semesterNoTextBox.Text = _semesterObj.SemesterNo;
            banglaSenesterNoTextBox.Text = _semesterObj.BanglaSemesterNo;
            saveButton.Content = "Update";
        }

        private void RemoveSemesterContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _semesterObj = new Semester();
            _semesterObj = ((Semester)semesterlistView.SelectedItem);
            semesterManagerobj.DeleteSemester(_semesterObj);
            MessageBox.Show("Data Update successfully");
            LoadAllSemester();
        }
    }
}
