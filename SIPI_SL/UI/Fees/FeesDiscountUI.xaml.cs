using BLL.Fees;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.Fees;
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

namespace SIPI_SL.UI.Fees
{
    /// <summary>
    /// Interaction logic for FeesDiscountUI.xaml
    /// </summary>
    public partial class FeesDiscountUI : Window
    {
        StudentInfo _studentInfoObj = new StudentInfo();
        List<Semester> _semesterList;
        SemesterManager semesterManagerObj = new SemesterManager();
        List<FeesSetup> _feesSetupListObj = new List<FeesSetup>();
        string caption = "Setup Fees";
        public FeesDiscountUI()
        {
            InitializeComponent();
            LoadSemesterCombobox();
            LoadYear();
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
 

        private void getStudentPopupButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Fees.StudentListUI _getstudentInfoUI = new UI.Fees.StudentListUI();
            if (_getstudentInfoUI.ShowDialog() == true)
            {
                this._studentInfoObj = _getstudentInfoUI.studentInofListView.SelectedItem as StudentInfo;
                nameTextBox.Text = this._studentInfoObj.ApplicantName;
                DepartmentTextBox.Text = this._studentInfoObj.DepartmentName;
                idTextBox.Text = Convert.ToString(this._studentInfoObj.Id);
                _getstudentInfoUI.Close();
            }
        }

        private void LoadYear()
        {
            try
            {
                FeesCommonBAL feesCommonBALobj = new FeesCommonBAL();
                yearCombobox.Items.Clear();
                foreach (var userGroup in feesCommonBALobj.GetAllYear())
                {
                    yearCombobox.Items.Add(userGroup);
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Year name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void semesterCombobax_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (semesterCombobax.SelectedIndex>1)
            {

                FeesDiscount obj = new FeesDiscount();
                
                //_feesSetupListObj = AccessKeyManager.getstudentfees();
                
            }
        }
    }
}
