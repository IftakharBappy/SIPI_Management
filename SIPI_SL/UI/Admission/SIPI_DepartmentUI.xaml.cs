using BLL.Admission;
using ENTITY.Admission;
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

namespace SIPI_SL.UI.Admission
{
    /// <summary>
    /// Interaction logic for SIPI_DepartmentUI.xaml
    /// </summary>
    public partial class SIPI_DepartmentUI : Window
    {
        SIPI_Program _sIPIProgramObj;
        SIPI_DepartmentManager _sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();

        SIPI_ProgramManager _sIPI_ProgramManagerobj = new SIPI_ProgramManager();

        SIPI_Department _sIPI_DepartmentObj;

        List<SIPI_Program> _sIPI_ProgramList;
        List<SIPI_Department> _sIPI_DepartmentList;

        public SIPI_DepartmentUI()
        {
            InitializeComponent();
            LoadSIPI_ProgramComboBox();
            LoadAll_SIPIDepartment();
            regulationEntryDateDatePicker.SelectedDate = DateTime.Now;
        }

        private void LoadSIPI_ProgramComboBox()
        {
            _sIPI_ProgramList = new List<SIPI_Program>();
            sipi_ProgramCombobax.Items.Clear();
            _sIPI_ProgramList = _sIPI_ProgramManagerobj.GetAllSIPI_Program();
            foreach (SIPI_Program sipi_program in _sIPI_ProgramList)
            {
                sipi_ProgramCombobax.ItemsSource = _sIPI_ProgramList;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        { 
            if (saveButton.Content.ToString() == "Save")
            {
                 
                _sIPI_DepartmentObj = new SIPI_Department();

                if (sipi_ProgramCombobax.Text == "")
                {
                    sipi_ProgramCombobax.Text = null;
                }
                else
                { 
                    _sIPI_DepartmentObj.SIPI_ProgramId = ((SIPI_Program)sipi_ProgramCombobax.SelectedItem).Id;
                }
 
                //_sIPI_DepartmentObj.SIPI_ProgramId = _sIPIProgramObj.Id;

                _sIPI_DepartmentObj.SIPI_DepartmentName = departmentNameTextBox.Text;
                _sIPI_DepartmentObj.SIPI_DepartmentCode = departmentCodeTextBox.Text;
                _sIPI_DepartmentObj.BanglaSIPI_DepartmentName = bangladepartmentTextBox.Text;
                _sIPI_DepartmentObj.Regulation = regulationTextBox.Text;
                _sIPI_DepartmentObj.SIPI_DepartmentEntryDate = DateTime.Parse(regulationEntryDateDatePicker.Text);

                if (_sIPI_DepartmentManagerObj.SaveSIPI_Department(_sIPI_DepartmentObj) == true)
                {
                    MessageBox.Show("Data saved successfully ", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Duplicate Data Insert ! Please check your Data", "Confirmation");
                }

                LoadAll_SIPIDepartment();
            }
            if (saveButton.Content.ToString() == "Update")
            {
                if (sipi_ProgramCombobax.Text == "")
                {
                    sipi_ProgramCombobax.Text = null;
                }
                else
                {
                    _sIPI_DepartmentObj.SIPI_ProgramId = ((SIPI_Program)sipi_ProgramCombobax.SelectedItem).Id;
                }

                //_sIPI_DepartmentObj.SIPI_ProgramId = _sIPIProgramObj.Id;

                _sIPI_DepartmentObj.SIPI_DepartmentName = departmentNameTextBox.Text;
                _sIPI_DepartmentObj.SIPI_DepartmentCode = departmentCodeTextBox.Text;
                _sIPI_DepartmentObj.BanglaSIPI_DepartmentName = bangladepartmentTextBox.Text;
                _sIPI_DepartmentObj.Regulation = regulationTextBox.Text;
                _sIPI_DepartmentObj.SIPI_DepartmentEntryDate = DateTime.Parse(regulationEntryDateDatePicker.Text);
                _sIPI_DepartmentManagerObj.UpdateSIPI_Department(_sIPI_DepartmentObj);
                MessageBox.Show("Data Update successfully");

                LoadAll_SIPIDepartment();
                saveButton.Content = "Save";
            }


        }

        private void LoadAll_SIPIDepartment()
        {
            _sIPI_DepartmentList = new List<SIPI_Department>();
            _sIPI_DepartmentList = _sIPI_DepartmentManagerObj.GetAll_SIPIDepartment();
            sIPIDepartmentListView.Items.Clear();
            if (_sIPI_DepartmentList.Count > 0)
            {
                foreach (SIPI_Department item in _sIPI_DepartmentList)
                {
                    sIPIDepartmentListView.Items.Add(item);
                }
             }
        }
         
        private void RemoveSIPI_DeprtmentContextMenu_Click(object sender, RoutedEventArgs e)
        {
            _sIPI_DepartmentObj = new SIPI_Department();
            _sIPI_DepartmentObj = ((SIPI_Department)sIPIDepartmentListView.SelectedItem);
            _sIPI_DepartmentManagerObj.DeleteSIPI_Deprtment(_sIPI_DepartmentObj);
            MessageBox.Show("Selected Item Removed");
            LoadAll_SIPIDepartment();

        }

       
        private void EditSIPI_DeprtmentContextMenu_Click(object sender, RoutedEventArgs e)
        {
            _sIPI_DepartmentObj = new SIPI_Department();
            _sIPI_DepartmentObj = ((SIPI_Department)sIPIDepartmentListView.SelectedItem);
            for (int i = 0; i < sipi_ProgramCombobax.Items.Count; i++)
            {
                SIPI_Program sipi_program = (SIPI_Program)sipi_ProgramCombobax.Items[i];
                if (_sIPI_DepartmentObj.SIPI_ProgramId == sipi_program.Id)
                {
                    sipi_ProgramCombobax.SelectedIndex = i;
                    break;
                }

            }


            departmentNameTextBox.Text = _sIPI_DepartmentObj.SIPI_DepartmentName;
            departmentCodeTextBox.Text = _sIPI_DepartmentObj.SIPI_DepartmentCode;
            bangladepartmentTextBox.Text = _sIPI_DepartmentObj.BanglaSIPI_DepartmentName;
            regulationTextBox.Text = _sIPI_DepartmentObj.Regulation;
            //regulationEntryDateDatePicker.Text = Convert.ToDateTime(SIPI_DepartmentEntryDate);
            saveButton.Content = "Update";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            sipi_ProgramCombobax.Text = "";
            departmentNameTextBox.Text = "";
            departmentCodeTextBox.Text = "";
            bangladepartmentTextBox.Text = "";
            regulationTextBox.Text = "";
            regulationEntryDateDatePicker.SelectedDate = DateTime.Now;


        }

        private void ViewStudent(string className)
        {
            bool isOpen = false;
            Window objWindowName = new Window();
            foreach (Window objWindow in Application.Current.Windows)
                {
                    string[] splitedNamespace = (objWindow.ToString()).Split('.');
                    string aClassNameFromCollection = splitedNamespace[splitedNamespace.Length - 1];

                    if (aClassNameFromCollection == className)
                    {
                        isOpen = true;
                        objWindowName = objWindow;
                        break;
                    }

                }

            if (isOpen == false)
            {
                #region SHOW DESIRED WINDOW
                switch (className)
                {
                    case "EmployeeSetupUI":
                        StudentInfoViewUI employeeInfo = new StudentInfoViewUI();
                        
                         _sIPI_DepartmentObj = new SIPI_Department();
                        _sIPI_DepartmentObj = ((SIPI_Department)sIPIDepartmentListView.SelectedItem);
                        employeeInfo.apiilicantNameLable.Content = _sIPI_DepartmentObj.SIPI_DepartmentCode;
                        employeeInfo.fatherNameLable.Content = _sIPI_DepartmentObj.SIPI_DepartmentEntryDate;



                        employeeInfo.Owner = this;
                        employeeInfo.Show();
                        break;
                }
                #endregion SHOW DESIRED WINDOW
            }
            if (isOpen)
            {
                foreach (Window objWindow in Application.Current.Windows)
                {
                    string[] splitedNamespace = (objWindow.ToString()).Split('.');
                    string aClassNameFromCollection = splitedNamespace[splitedNamespace.Length - 1];

                    if (aClassNameFromCollection == className)
                    {
                        objWindowName.WindowState = WindowState.Normal;
                        objWindowName.Activate();
                        break;
                    }
                }
            }
            

        }

        private void ViewContextMenu_Click(object sender, RoutedEventArgs e)
        {
            ViewStudent("EmployeeSetupUI");
        }

        
    
         
    }
}
