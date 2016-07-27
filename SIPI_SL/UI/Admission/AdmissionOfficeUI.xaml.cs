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
    /// Interaction logic for AdmissionOfficeUI.xaml
    /// </summary>
    public partial class AdmissonOfficeUI : Window
    {
        AdmissionOffice _admissionOfficeObj;
        AdmissionOfficeManager _admissionOfficeManagerobj = new AdmissionOfficeManager();
        CampusManager _campusManager = new CampusManager();
        List<AdmissionOffice> admissionOfficeList;
        List<Campus> _campusList;
        




        public AdmissonOfficeUI()
        {
            InitializeComponent();
            LoadAllAdmissionOffice();
            LoadCampusComboBox();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {        

            if (submitButton.Content.ToString() == "Save")
            {
                _admissionOfficeObj = new AdmissionOffice();
                _admissionOfficeObj.CampusId = ((Campus)campusCombobax.SelectedItem).Id;
                _admissionOfficeObj.OfficeName = officeNameTextBox.Text;
                _admissionOfficeManagerobj.SaveAdmissionOffice(_admissionOfficeObj);
                LoadAllAdmissionOffice();
            }

            if (submitButton.Content.ToString() == "Update")
            {
                try
                {
                    _admissionOfficeObj.CampusId = ((Campus)campusCombobax.SelectedItem).Id;
                    _admissionOfficeObj.OfficeName = officeNameTextBox.Text;
                    _admissionOfficeManagerobj.UpdateAdmissionOffice(_admissionOfficeObj);
                    LoadAllAdmissionOffice();
                    submitButton.Content = "Save";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid data") ;
                }
               
            }

          
        }

        private void LoadAllAdmissionOffice()
        {
            admissionOfficeList = new List<AdmissionOffice>();
            admissionOfficeList = _admissionOfficeManagerobj.LoadAllAdmissionOffice();
            admissionOfficeView.Items.Clear();
            if (admissionOfficeList.Count > 0)
            {
                foreach (var item in admissionOfficeList)
                {
                    admissionOfficeView.Items.Add(item);
                }

            }
        }
        private void LoadCampusComboBox()
        {
            _campusList = new List<Campus>();
            campusCombobax.Items.Clear();
            _campusList = _campusManager.GetAllCampus();
            foreach (Campus campus in _campusList)
            {
                campusCombobax.ItemsSource = _campusList;
            }
        }  

        
        private void EditProgramContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _admissionOfficeObj = new AdmissionOffice();
            _admissionOfficeObj = ((AdmissionOffice)admissionOfficeView.SelectedItem);
            officeNameTextBox.Text = _admissionOfficeObj.OfficeName;
            campusCombobax.Text = _admissionOfficeObj.OfficeAddress;
            submitButton.Content = "Update";
        }
             

        private void RemoveProgramContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            
            _admissionOfficeObj = new AdmissionOffice();
            _admissionOfficeObj = ((AdmissionOffice)admissionOfficeView.SelectedItem);
            _admissionOfficeManagerobj.DeleteAdmissionOffice(_admissionOfficeObj);
            LoadAllAdmissionOffice();
      
        }
    }
}