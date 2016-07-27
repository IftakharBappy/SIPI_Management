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
    /// Interaction logic for CategorySalarySalary.xaml
    /// </summary>
    public partial class CategorySalaryUI : Window
    {
       CategorySalaryBAL _aBuserGroup = new CategorySalaryBAL();
        Guid UserGroupIdModify;
        private string caption = "CategorySalary";
        public CategorySalaryUI()
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
                lvUserGroup.ItemsSource = _aBuserGroup.GetAllCategorySalary();
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
            if (_aBuserGroup.DoesExistCategorySalaryinUpdateMode(txtUserGroupName.Text.Trim(), UserGroupIdModify) == false)
            {
                CategorySalary anUserGroup = new CategorySalary();
                anUserGroup.CategorySalaryID = UserGroupIdModify;
                anUserGroup.CategorySalaryName = txtUserGroupName.Text.Trim();
                stat = _aBuserGroup.UpdateUserGroup(anUserGroup);
                if (stat)
                {
                    MessageBox.Show("CategorySalary Name has been Updated", caption, MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            else
            {
                MessageBox.Show("CategorySalary Name Already Exist.", caption, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void SaveOperationofUserGroup()
        {
            bool stat = false;
            if (_aBuserGroup.DoesExistCategorySalaryinSaveMode(txtUserGroupName.Text.Trim()) == false)
            {
                 
                CategorySalary anUserGroup = new CategorySalary();
                anUserGroup.CategorySalaryID = Guid.NewGuid();
                anUserGroup.CategorySalaryName = txtUserGroupName.Text.Trim();
                stat = _aBuserGroup.SaveCategorySalary(anUserGroup);
                if (stat)
                {
                    MessageBox.Show("CategorySalary Name has been Saved", caption, MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            else
            {
                MessageBox.Show("CategorySalary Name Already Exist.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private bool CheckFieldofUserGroup()
        {
            if (txtUserGroupName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter CategorySalary Name.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
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
                    if ((lvUserGroup.SelectedItem as CategorySalary).CategorySalaryName.ToLower() == "Super Admin".ToLower())
                    {
                        MessageBox.Show(" This CategorySalary can not be Modified.", caption, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        CategorySalary anCategorySalary = lvUserGroup.SelectedItem as CategorySalary;
                        UserGroupIdModify = anCategorySalary.CategorySalaryID;
                        txtUserGroupName.Text = anCategorySalary.CategorySalaryName;
                        btnAddUserGroup.Content = "Modify";
                    }
                }
                else
                {
                    MessageBox.Show("Select an User CategorySalary First.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
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
                    if ((lvUserGroup.SelectedItem as CategorySalary).CategorySalaryName.ToLower() == "Super Admin".ToLower())
                    {
                        MessageBox.Show(" This CategorySalary can not be Removed.", caption, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure want to Delete the Record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            if (MessageBox.Show("After Deletion You will Lost  This CategorySalary Related All Information.", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                            {
                                bool stat = false;
                                CategorySalary anCategorySalary = lvUserGroup.SelectedItem as CategorySalary;
                                stat = _aBuserGroup.DeleteUserGroup(anCategorySalary.CategorySalaryID);
                                if (stat)
                                {
                                    MessageBox.Show("CategorySalary Information has been Deleted", caption, MessageBoxButton.OK, MessageBoxImage.Information);
                                    // InitialTaskforUserGroup();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select an CategorySalary First.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
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
