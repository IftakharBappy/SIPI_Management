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
    /// Interaction logic for ReligionUI.xaml
    /// </summary>
    public partial class ReligionUI : Window
    {
        
        ReligionManager ReligionManagerObj = new ReligionManager();
        Religion _ReligionObj;
        List<Religion> ReligionList;

        public ReligionUI()
        {
            InitializeComponent();
            LoadAllReligion();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            if (submitButton.Content.ToString() == "Save")
            {
                _ReligionObj = new Religion();
                _ReligionObj.ReligionName = religionNameTextBox.Text;
                _ReligionObj.BanglaReligionName = BanglaReligionTextBox.Text;
                if (ReligionManagerObj.SaveReligion(_ReligionObj))
                {

                    MessageBox.Show("Religion Saved successfully", "Religion");
                    LoadAllReligion();
                    clear();
                }
                else
                {
                    MessageBox.Show("This Religion alrady exist", "Duplicate protect");
                }
                
                

            }

            if (submitButton.Content.ToString() == "Update")
            {
                _ReligionObj.ReligionName = religionNameTextBox.Text;
                _ReligionObj.BanglaReligionName = BanglaReligionTextBox.Text;
                ReligionManagerObj.UpdateReligion(_ReligionObj);
                MessageBox.Show("Data Update successfully");
                LoadAllReligion();
                submitButton.Content = "Save";
                clear();
            }
            
        }

        private void LoadAllReligion()
        {
            ReligionList = new List<Religion>();
            ReligionList = ReligionManagerObj.GetAllReligion();
            ReligionlistView.Items.Clear();
            if (ReligionList.Count > 0)
            {
                foreach (var item in ReligionList)
                {
                    ReligionlistView.Items.Add(item);
                }

            }
        }

        public void clear()
        {
            religionNameTextBox.Text = "" ;
            BanglaReligionTextBox.Text = "";
        }

        private void EditReligionContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _ReligionObj = new Religion();
            _ReligionObj = ((Religion)ReligionlistView.SelectedItem);
            religionNameTextBox.Text = _ReligionObj.ReligionName;
            BanglaReligionTextBox.Text = _ReligionObj.BanglaReligionName;
            submitButton.Content = "Update";
        }
        private void RemoveReligionContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            
            _ReligionObj = new Religion();
            _ReligionObj = ((Religion)ReligionlistView.SelectedItem);
            ReligionManagerObj.DeleteReligion(_ReligionObj);
            LoadAllReligion();
            MessageBox.Show("Selected Item Removed");


        }
    }
}
