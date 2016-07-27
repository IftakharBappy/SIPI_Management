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
    /// Interaction logic for DepartmentUI.xaml
    /// </summary>
    public partial class DepartmentUI : Window
    {
        DepartmentManager departmentManagerObj = new DepartmentManager();
        Department _departmentObj;
        List<Department> departmentList;

        public DepartmentUI()
        {
            InitializeComponent();
            LoadAllDepartment();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {




            if (submitButton.Content.ToString() == "Save")
            {

                _departmentObj = new Department();
                _departmentObj.DepartmentName = departmentNameTextBox.Text;
                _departmentObj.DepartmentCode = departmentCodeTextBox.Text;
                _departmentObj.BanglaDepartment = banglaDepartmentTextBox.Text;

                if (departmentManagerObj.SaveDepartment(_departmentObj) == true)
                {
                    MessageBox.Show("Data saved successfully ", "Confirmation");
                    LoadAllDepartment();
                }
                else
                {
 
                    MessageBox.Show("Duplicate Data Insert ! Please check your Data", "Confirmation");
                    LoadAllDepartment();
                }
                 
            }

            if (submitButton.Content.ToString() == "Update")
            {
                _departmentObj.DepartmentName = departmentNameTextBox.Text;
                _departmentObj.DepartmentCode = departmentCodeTextBox.Text;
                _departmentObj.BanglaDepartment = banglaDepartmentTextBox.Text;
                departmentManagerObj.UpdateDepartment(_departmentObj);
                LoadAllDepartment();
                submitButton.Content = "Save";
                MessageBox.Show("Data Update successfully");

            }   
           
          
        }

        private void LoadAllDepartment()
        {
            departmentList = new List<Department>();
            departmentList = departmentManagerObj.GetAllDepartment();
            departmentlistView.Items.Clear();
            if (departmentList.Count>0)
            {
                foreach (var item in departmentList)
                {
                    departmentlistView.Items.Add(item);
                }

               
            }
        }

        private void EditDepartmentContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _departmentObj = new Department();
            _departmentObj = ((Department)departmentlistView.SelectedItem);
            departmentNameTextBox.Text = _departmentObj.DepartmentName;
            departmentCodeTextBox.Text = _departmentObj.DepartmentCode;
            banglaDepartmentTextBox.Text = _departmentObj.BanglaDepartment;
            submitButton.Content = "Update";
        }

        private void RemoveDepartmentContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _departmentObj = new Department();
            _departmentObj = ((Department)departmentlistView.SelectedItem);
            departmentManagerObj.DeleteDepartment(_departmentObj);
            MessageBox.Show("Selected Item Removed");
            LoadAllDepartment();

        }
    }
}
