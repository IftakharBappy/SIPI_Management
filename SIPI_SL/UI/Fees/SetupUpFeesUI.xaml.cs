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
using BLL.Fees;
using ENTITY.Fees;
using ENTITY.Admission;
using ENTITY.StudentManagement;
using BLL.Admission;

namespace SIPI_SL.UI.Fees
{
    /// <summary>
    /// Interaction logic for SetupUpFees.xaml
    /// </summary>
    public partial class SetupUpFeesUI : Window
    {
        List<FeesDetails> feesDetailsList;
       
        List<FeesSetup> _feesSetupListObj = new List<FeesSetup>();
        FeesDetailsManager feesDetailsManager = new FeesDetailsManager();
        string caption = "Setup Fees";
        FeesSetup _feesSetupObj;
        SIPI_Department _sipi_departmentoObj;
        Semester _semesterObj;
        Campus _campus;
        FeesSetupManager feesSetupManagerObj = new FeesSetupManager();
        CampusManager _campusManager = new CampusManager();
        
        public SetupUpFeesUI()
        {
            InitializeComponent();
            LoadDepartment();
            LoadSemester();
            LoadYear();
            LoadFeesDetails();
            LoadCampus();
        }

        private void LoadCampus()
        {
            
            CampusComboBox.Items.Clear();
            foreach (var userGroup in _campusManager.GetAllCampus())
            {
                CampusComboBox.Items.Add(userGroup);
            }
            CampusComboBox.DisplayMemberPath = "CampusName";
        }
        private void LoadFeesDetails()
        {
            feesDetailsList = new List<FeesDetails>();
            feesDetailsList = feesDetailsManager.GetAllFeesDetail();
            setupFeesDataGrid.Items.Clear();
            if (feesDetailsList.Count > 0)
            {
                foreach (var item in feesDetailsList)
                {
                    setupFeesDataGrid.Items.Add(item);
                }
            }
        }

        private void LoadSemester()
        {
            try
            {
                FeesCommonBAL feesCommonBALobj = new FeesCommonBAL();
                SemesterComboBox.Items.Clear();
                foreach (var userGroup in feesCommonBALobj.GetAllSemester())
                {
                    SemesterComboBox.Items.Add(userGroup);
                }
                SemesterComboBox.DisplayMemberPath = "SemesterNo";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Semester name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadYear()
        {
            try
            {
                FeesCommonBAL feesCommonBALobj = new FeesCommonBAL();
                YearComboBox.Items.Clear();
                foreach (var userGroup in feesCommonBALobj.GetAllYear())
                {
                    YearComboBox.Items.Add(userGroup);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Year name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadDepartment()
        {
            try
            {
                FeesCommonBAL feesCommonBALobj = new FeesCommonBAL();
                DepartmentComboBox.Items.Clear();
                foreach (var userGroup in feesCommonBALobj.GetAllDepartment())
                {
                    DepartmentComboBox.Items.Add(userGroup);
                }
                DepartmentComboBox.DisplayMemberPath = "SIPI_DepartmentName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Year name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _feesSetupListObj = new List<FeesSetup>();

            for (int i = 0; i < setupFeesDataGrid.Items.Count; i++)
            {
                
                _feesSetupObj = new FeesSetup();
                FeesDetails eLeaveApproveObj = (FeesDetails)setupFeesDataGrid.Items[i];
                _sipi_departmentoObj = new SIPI_Department();
                _sipi_departmentoObj = ((SIPI_Department)DepartmentComboBox.SelectedItem);
                _feesSetupObj.DepartmentId = _sipi_departmentoObj.Id;
                _semesterObj = new Semester();
                _semesterObj = ((Semester)SemesterComboBox.SelectedItem);
                _campus = new Campus();
                _campus = ((Campus)CampusComboBox.SelectedItem);
                _feesSetupObj.CampusId = _campus.Id;
                _feesSetupObj.SemesterId = _semesterObj.Id;
                _feesSetupObj.Year = Convert.ToInt32(YearComboBox.Text);
                
                    _feesSetupObj.Total = Convert.ToInt32(totalTextBox.Text);
                    //_feesSetupObj.Total = setupFeesDataGrid.;
             
                _feesSetupObj.FeesDetailsId = eLeaveApproveObj.Id;
                _feesSetupObj.Amount = eLeaveApproveObj.FeesAmount;
                _feesSetupListObj.Add(_feesSetupObj);
            }

            feesSetupManagerObj.SaveFees(_feesSetupListObj);
            MessageBox.Show("Fees Setup Successful ", " Fees Setup");

             
        }

        private void feesAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ///////Atik bhai
            //FeesDetails chalan = new FeesDetails();
            //chalan = setupFeesDataGrid.SelectedItem as FeesDetails;// get selected item

            //// Other i am summarizing grid cell value in a combobox
            //decimal TGBP = 0 ;
            //for (int i = 0; i < setupFeesDataGrid.Items.Count; i++)
            //{
            //    FeesDetails obj = setupFeesDataGrid.Items[i] as FeesDetails;
            //    TGBP += Convert.ToDecimal(obj.FeesAmount); // getting cell value  
            //}

            //totalTextBox.Text = TGBP.ToString("F");  

            ///////Atik bhai

            FeesDetails chalan = new FeesDetails();
            chalan = setupFeesDataGrid.SelectedItem as FeesDetails;// get selected item
            // Other i am summarizing grid cell value in a combobox
            int TGBP = 0;
            for (int i = 0; i < setupFeesDataGrid.Items.Count; i++)
            {
                FeesDetails obj = setupFeesDataGrid.Items[i] as FeesDetails;
                TGBP += obj.FeesAmount; // getting cell value  
            }

            totalTextBox.Text = TGBP.ToString();  
        }
    }
}
