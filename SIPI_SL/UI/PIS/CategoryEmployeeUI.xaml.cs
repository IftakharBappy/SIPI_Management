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
using BLL.Login;
using BLL.PIS;
using ENTITY.Login;
using ENTITY.PIS;

namespace SIPI_SL.UI.PIS
{
    /// <summary>
    /// Interaction logic for CategoryEmployeeUI.xaml
    /// </summary>
    public partial class CategoryEmployeeUI : Window
    {
        CategoryEmpEmpBAL _aBuserGroup = new CategoryEmpEmpBAL();
        Guid UserGroupIdModify;
        private string caption = "Category";
        public CategoryEmployeeUI()
        {
            InitializeComponent();
            txtUserGroupName.Text = string.Empty;
            btnAddUserGroup.Content = "Add";
            PopulateUserGroupList();
        }
        private void PopulateUserGroupList()
        {
            try
            {
                lvUserGroup.ItemsSource = _aBuserGroup.GetAllCategoryEmp();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Problem Occur While Retrieving user Group Information." + exception.Message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void BtnAddUserGroupClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckFieldofUserGroup())
                {
                    if (btnAddUserGroup.Content.ToString() == "Add")
                    {
                        SaveOperationofUserGroup();
                        PopulateUserGroupList();
                    }
                    if (btnAddUserGroup.Content.ToString() == "Modify")
                    {
                        UpdateOperationofUserGroup();
                        PopulateUserGroupList();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Storing Information.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void UpdateOperationofUserGroup()
        {
            bool stat = false;
            if (_aBuserGroup.DoesExistCategoryEmpinUpdateMode(txtUserGroupName.Text.Trim(), UserGroupIdModify) == false)
            {
                CategoryEmp anUserGroup = new CategoryEmp();
                anUserGroup.CategoryEmpID = UserGroupIdModify;
                anUserGroup.CategoryEmpName = txtUserGroupName.Text.Trim();
                stat = _aBuserGroup.UpdateUserGroup(anUserGroup);
                if (stat)
                {
                    MessageBox.Show("Category Name has been Updated", caption, MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            else
            {
                MessageBox.Show("Category Name Already Exist.", caption, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void SaveOperationofUserGroup()
        {
            bool stat = false;
            if (_aBuserGroup.DoesExistCategoryEmpinSaveMode(txtUserGroupName.Text.Trim()) == false)
            {

                CategoryEmp anUserGroup = new CategoryEmp();
                anUserGroup.CategoryEmpID = Guid.NewGuid();
                anUserGroup.CategoryEmpName = txtUserGroupName.Text.Trim();
                stat = _aBuserGroup.SaveCategoryEmp(anUserGroup);
                if (stat)
                {
                    MessageBox.Show("Category Name has been Saved", caption, MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            else
            {
                MessageBox.Show("Category Name Already Exist.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private bool CheckFieldofUserGroup()
        {
            if (txtUserGroupName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Category Name.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
                txtUserGroupName.Focus();
                return false;
            }
            return true;
        }
        private void EditUserGroupClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lvUserGroup.SelectedIndex > -1)
                {
                    if ((lvUserGroup.SelectedItem as CategoryEmp).CategoryEmpName.ToLower() == "Super Admin".ToLower())
                    {
                        MessageBox.Show(" This Category can not be Modified.", caption, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        CategoryEmp anCategory = lvUserGroup.SelectedItem as CategoryEmp;
                        UserGroupIdModify = anCategory.CategoryEmpID;
                        txtUserGroupName.Text = anCategory.CategoryEmpName;
                        btnAddUserGroup.Content = "Modify";
                    }
                }
                else
                {
                    MessageBox.Show("Select an User Category First.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
                    lvUserGroup.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Selection.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void RemoveUserGroupClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lvUserGroup.SelectedIndex > -1)
                {
                    if ((lvUserGroup.SelectedItem as CategoryEmp).CategoryEmpName.ToLower() == "Super Admin".ToLower())
                    {
                        MessageBox.Show(" This Category can not be Removed.", caption, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure want to Delete the Record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            if (MessageBox.Show("After Deletion You will Lost  This Category Related All Information.", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                            {
                                bool stat = false;
                                CategoryEmp anCategory = lvUserGroup.SelectedItem as CategoryEmp;
                                stat = _aBuserGroup.DeleteUserGroup(anCategory.CategoryEmpID);
                                if (stat)
                                {
                                    MessageBox.Show("Category Information has been Deleted", caption, MessageBoxButton.OK, MessageBoxImage.Information);
                                    // InitialTaskforUserGroup();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select an Category First.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Deletion.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void groupClosebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
