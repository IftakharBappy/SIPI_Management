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
    /// Interaction logic for BloodGroupUI.xaml
    /// </summary>
    public partial class BloodGroupUI : Window
    {
        BloodGroup _bloodGroupObj;

        BloodGroupsManager bloodGroupManagerObj = new BloodGroupsManager();
         
        List<BloodGroup> bloodGroupList;
    
        public BloodGroupUI()
        {
            InitializeComponent();
            LoadAllBloodGroup();
        }
       
        private void submitButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (submitButton.Content.ToString() == "Save")
            {
                _bloodGroupObj = new BloodGroup();
                _bloodGroupObj.BloodGroupName = bloodGroupTextBox.Text;

                if (bloodGroupManagerObj.SaveBloodGroup(_bloodGroupObj))
                {
                    MessageBox.Show("Data insurted successfully", "BloodGroup");
                    LoadAllBloodGroup();
                }
                else
                {

                    MessageBox.Show("BloodGroup already Exist ! Please check BloodGroup", "Confirmation");
                    
                }
                
                
            }
            if (submitButton.Content.ToString() == "Update")
            {
                _bloodGroupObj.BloodGroupName = bloodGroupTextBox.Text;

                bloodGroupManagerObj.UpdateBloodGroup(_bloodGroupObj);
                MessageBox.Show("Data Update successfully");
                submitButton.Content = "save";
                LoadAllBloodGroup( );
            }
        }


        private void LoadAllBloodGroup()
        {
            bloodGroupList = new List<BloodGroup>();
            bloodGroupList = bloodGroupManagerObj.GetAllBloodGroup();
            bloodGroupListView.Items.Clear();
            if (bloodGroupList.Count > 0)
            {
                foreach (var item in bloodGroupList)
                {
                    bloodGroupListView.Items.Add(item);
                }

            }
        }

        private void EditBloodGroupContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _bloodGroupObj = new BloodGroup();
            _bloodGroupObj = ((BloodGroup)bloodGroupListView.SelectedItem);
            bloodGroupTextBox.Text = _bloodGroupObj.BloodGroupName;
            submitButton.Content = "Update";

        }

        private void RemoveBloodGroupContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _bloodGroupObj = new BloodGroup();
            _bloodGroupObj = ((BloodGroup)bloodGroupListView.SelectedItem);
            bloodGroupManagerObj.DeleteBloodGroup(_bloodGroupObj);
            LoadAllBloodGroup();
            MessageBox.Show("Selected Item Removed");

        }
    }
}
