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
    /// Interaction logic for Campus.xaml
    /// </summary>
    public partial class CampusUI : Window
    {
        Campus _campusObj;
        CampusManager campusManager = new CampusManager();
        List<Campus> campusList;
        public CampusUI()
        {
            InitializeComponent();
            LoadAllCampus();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (saveButton.Content.ToString() == "save")
            {
                _campusObj = new Campus();
                _campusObj.CampusName = campusNameTextBox.Text;
                _campusObj.CampusAddress = campusAddressTextBox.Text;
                _campusObj.ContactPerson = contactPersonTextBox.Text;
                _campusObj.MobileNumber = mobileNumberTextBox.Text;
                _campusObj.BanglaCampus =  banglaCampusTextbox.Text;
                campusManager.SaveCampus(_campusObj);
                MessageBox.Show("Data insurted successfully");
                LoadAllCampus();
            }
            if (saveButton.Content.ToString() == "Update")
            {
                _campusObj.CampusName = campusNameTextBox.Text;
                _campusObj.CampusAddress = campusAddressTextBox.Text;
                _campusObj.ContactPerson = contactPersonTextBox.Text;
                _campusObj.MobileNumber = mobileNumberTextBox.Text;
                _campusObj.BanglaCampus = banglaCampusTextbox.Text;
                campusManager.UpdateCampus(_campusObj);
                MessageBox.Show("Data Update successfully");
                saveButton.Content = "save";
                LoadAllCampus();
            }

        }  

        
        private void LoadAllCampus()
        {
            campusList = new List<Campus>();
            campusList = campusManager.GetAllCampus();
            campusListView.Items.Clear();
            if (campusList.Count > 0)
            {
                foreach (var item in campusList)
                {
                    campusListView.Items.Add(item);
                }
                 
            }
        }

        private void EditCampusContextMenu_Click_1(object sender, RoutedEventArgs e)
        {

            _campusObj = new Campus();
            _campusObj = ((Campus)campusListView.SelectedItem);
            campusNameTextBox.Text = _campusObj.CampusName;
            campusAddressTextBox.Text = _campusObj.CampusAddress;
            contactPersonTextBox.Text = _campusObj.ContactPerson;
            mobileNumberTextBox.Text = _campusObj.MobileNumber;
            banglaCampusTextbox.Text = _campusObj.BanglaCampus;
            saveButton.Content = "Update";

            

        }

        private void RemoveCampusContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _campusObj = new Campus();
            _campusObj = ((Campus)campusListView.SelectedItem);
            campusManager.DeleteCampus(_campusObj);
            LoadAllCampus();
            MessageBox.Show("Selected Item Removed");


   
        }
    }
}
