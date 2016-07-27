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
    /// Interaction logic for ThanaUI.xaml
    /// </summary>
    public partial class ThanaUI : Window
    {
         ThanaManager ThanaManagerObj = new ThanaManager();
         DistrictManager districtManagerObj = new DistrictManager();
        Thana _ThanaObj;
        District _DistrictObj;
        List<Thana> ThanaList;
        List<District> DistrictList;


        public ThanaUI()
        {
            InitializeComponent();
            LoadAllThana();
            LoadDistrictComboBox();
            
        }


        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            if (submitButton.Content.ToString() == "Save")
            {
                _ThanaObj = new Thana();

                _DistrictObj = new District();
                _DistrictObj = ((District)districtCombobax.SelectedItem);
                _ThanaObj.DistrictId = _DistrictObj.Id;

                _ThanaObj.ThanaName = ThanaNameTextBox.Text;
                _ThanaObj.BanglaThanaName = banglaThanaNameTextBox.Text;

                ThanaManagerObj.SaveThana(_ThanaObj);
                MessageBox.Show("Data insurted successfully");
                LoadAllThana();
            }

            if (submitButton.Content.ToString() == "Update")
            {
                _DistrictObj = new District();
                _DistrictObj = ((District)districtCombobax.SelectedItem);
                _ThanaObj.DistrictId = _DistrictObj.Id;

                _ThanaObj.ThanaName = ThanaNameTextBox.Text;
                _ThanaObj.BanglaThanaName = banglaThanaNameTextBox.Text;

                ThanaManagerObj.UpdateThana(_ThanaObj);
                MessageBox.Show("Data Update successfully");
                LoadAllThana();

                submitButton.Content = "Save";
            }
          
        }
        private void LoadDistrictComboBox()
        {
            DistrictList = new List<District>();
            districtCombobax.Items.Clear();
            DistrictList = districtManagerObj.GetAllDistrict();
            foreach (District didtrict in DistrictList)
            {
                districtCombobax.ItemsSource = DistrictList;
            }
        }  

        private void LoadAllThana()
        {
            ThanaList = new List<Thana>();
            ThanaList = ThanaManagerObj.GetAllThana();
            ThanalistView.Items.Clear();
            if (ThanaList.Count > 0)
            {
                foreach (var item in ThanaList)
                {
                    ThanalistView.Items.Add(item);
                }

            }
        }

        private void EditThanaContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _ThanaObj = new Thana();
            _ThanaObj = ((Thana)ThanalistView.SelectedItem);
            for (int i = 0; i < districtCombobax.Items.Count; i++)
            {
                District dis = (District)districtCombobax.Items[i];
                if (_ThanaObj.DistrictId == dis.Id)
                {
                    districtCombobax.SelectedIndex = i;
                    break;

                }

            }

            ThanaNameTextBox.Text = _ThanaObj.ThanaName;
            banglaThanaNameTextBox.Text = _ThanaObj.BanglaThanaName;
   
            submitButton.Content = "Update";
        }
        private void RemoveThanaContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _ThanaObj = new Thana();
            _ThanaObj = ((Thana)ThanalistView.SelectedItem);
            ThanaManagerObj.DeleteThana(_ThanaObj);
            MessageBox.Show("Selected Item Removed");
            LoadAllThana();

        }
    }
}
