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
    /// Interaction logic for DistrictUI.xaml
    /// </summary>
    public partial class DistrictUI : Window
    {
        

        DistrictManager DistrictManagerObj = new DistrictManager();
        District _DistrictObj;
        List<District> DistrictList;
        public DistrictUI()
        {
            InitializeComponent();
            LoadAllDistrict();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            if (submitButton.Content.ToString() == "Save")
            {
                _DistrictObj = new District();
                _DistrictObj.DistrictName = districtNameTextBox.Text;
                _DistrictObj.BanglaDistrict = banglaDistrictTextBox.Text;
                DistrictManagerObj.SaveDistrict(_DistrictObj);
                LoadAllDistrict();
                MessageBox.Show("Data insurted successfully");

            }

            if (submitButton.Content.ToString() == "Update")
            {
                _DistrictObj.DistrictName = districtNameTextBox.Text;
                _DistrictObj.BanglaDistrict = banglaDistrictTextBox.Text;
                DistrictManagerObj.UpdateDistrict(_DistrictObj);
                LoadAllDistrict();
                MessageBox.Show("Data Update successfully");
                submitButton.Content = "Save";

            }
          
        }
       
        private void LoadAllDistrict()
        {
            DistrictList = new List<District>();
            DistrictList = DistrictManagerObj.GetAllDistrict();
            DistrictlistView.Items.Clear();
            if (DistrictList.Count > 0)
            {
                foreach (var item in DistrictList)
                {
                    DistrictlistView.Items.Add(item);
                }

            }
        }

        private void EditDistrictContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _DistrictObj = new District();
            _DistrictObj = ((District)DistrictlistView.SelectedItem);
            districtNameTextBox.Text = _DistrictObj.DistrictName;
            banglaDistrictTextBox.Text = _DistrictObj.BanglaDistrict;
            submitButton.Content = "Update";
        }
        private void RemoveDistrictContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _DistrictObj = new District();
            _DistrictObj = ((District)DistrictlistView.SelectedItem);
            DistrictManagerObj.DeleteDistrict(_DistrictObj);
            MessageBox.Show("Data Update successfully");
            LoadAllDistrict();

        }
    }
}
