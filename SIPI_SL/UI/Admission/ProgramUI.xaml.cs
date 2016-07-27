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
    /// Interaction logic for ProgramUI.xaml
    /// </summary>
    public partial class ProgramUI : Window
    {
        ProgarmManager programManagerObj = new ProgarmManager();
        DepartmentManager departmentManagerObj = new DepartmentManager();
        Program _programObj;
        Department _department;
        List<Department> _departmentList;
        List<Program> programList;

        public ProgramUI()
        {
            InitializeComponent();
            LoadDepartmentComboBox();
            LoadAllProgram();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            ///if (saveButton.Content  == "Save" (can't work the button. ))
            
            if (saveButton.Content.ToString() == "Save")
            {
                // very importent solution for ComboBox Reload
                _programObj = new Program();

                _department = new Department();
                _department = ((Department)departmentCombobax.SelectedItem);

                _programObj.DepartmentId = _department.Id;
                //_programObj.DeparimentName = departmentCombobax.Text;
                _programObj.ProgramName = programNameTextBox.Text;
                _programObj.ProgramCode = programCodeTextBox.Text;
                _programObj.BanglaProgram = banglaProgramTextBox.Text;

                if (programManagerObj.SaveProgram(_programObj) == true)
                {
                    MessageBox.Show("Data saved successfully ", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Duplicate Data Insert ! Please check your Data", "Confirmation");
                }
                
                LoadAllProgram();
            }
            if (saveButton.Content.ToString() == "Update")
            {
                _department = new Department();
                _department = ((Department)departmentCombobax.SelectedItem);
                _programObj.DepartmentId = _department.Id;
                _programObj.ProgramName = programNameTextBox.Text;
                _programObj.ProgramCode = programCodeTextBox.Text;
                _programObj.BanglaProgram = banglaProgramTextBox.Text;
                programManagerObj.UpdateDEpartment(_programObj);
                MessageBox.Show("Data Update successfully");

                LoadAllProgram();
                saveButton.Content = "Save";                 
            }


        }

        private void LoadDepartmentComboBox()
        {
            _departmentList = new List<Department>();
            departmentCombobax.Items.Clear();
            _departmentList = departmentManagerObj.GetAllDepartment();
            foreach (Department department in _departmentList)
            {
                departmentCombobax.ItemsSource = _departmentList;
            }
        }  

         private void LoadAllProgram()
        {
            programList = new List<Program>();
            programList = programManagerObj.GetAllProgram();
            programlistView.Items.Clear();
            if (programList.Count>0)
            {
                foreach (Program item in programList)
                {
                    programlistView.Items.Add(item);
                }

                
            }
        }

         private void EditProgramContextMenu_Click_1(object sender, RoutedEventArgs e)
         {
             _programObj = new Program();
             _programObj = ((Program)programlistView.SelectedItem);
             for (int i = 0; i < departmentCombobax.Items.Count; i++)
             {
                 Department dep = (Department)departmentCombobax.Items[i];
                 if (_programObj.DepartmentId==dep.Id)
                 {
                     departmentCombobax.SelectedIndex = i;
                     break;
                 }
                 
             }

            // departmentCombobax.Text = _programObj.DeparimentName;
             programNameTextBox.Text = _programObj.ProgramName;
             programCodeTextBox.Text = _programObj.ProgramCode; 
             banglaProgramTextBox.Text = _programObj.BanglaProgram;
             saveButton.Content = "Update";

         }

         private void RemoveProgramContextMenu_Click_1(object sender, RoutedEventArgs e)
         {
             _programObj = new Program();
             _programObj = ((Program)programlistView.SelectedItem);
             programManagerObj.DeleteProgram(_programObj);
             MessageBox.Show("Selected Item Removed");             
             LoadAllProgram();

         }
    
    }
}