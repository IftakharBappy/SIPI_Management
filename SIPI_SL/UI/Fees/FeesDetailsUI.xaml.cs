using BLL.Fees;
using ENTITY.Fees;
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

namespace SIPI_SL.UI.Fees
{
    /// <summary>
    /// Interaction logic for FeesDetailsUI.xaml
    /// </summary>
    public partial class FeesDetailsUI : Window
    {
        FeesDetails feesDetails =  new FeesDetails();
        FeesDetailsManager feesDetailsManager = new FeesDetailsManager();
        List<FeesDetails> feesDetailsList;
        public FeesDetailsUI()
        {
            InitializeComponent();
            LoadAllFeesDetails();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            
            feesDetails.FeesName = feesNameTextBox.Text;
            feesDetailsManager.SaveFeesDetails(feesDetails);
            MessageBox.Show(" Saved.......");
            LoadAllFeesDetails();
        }

        private void LoadAllFeesDetails()
        {
            feesDetailsList = new List<FeesDetails>();
            feesDetailsList = feesDetailsManager.GetAllFeesDetail();
            feesDetailsListView.Items.Clear();
            if (feesDetailsList.Count > 0)
            {
                foreach (var item in feesDetailsList)
                {
                    feesDetailsListView.Items.Add(item);
                }
            }
        }

        private void RemoveFeesDetailsContextMenu_Click(object sender, RoutedEventArgs e)
        {
            feesDetails = ((FeesDetails)feesDetailsListView.SelectedItem);
            feesDetailsManager.DeleteFeesDetail(feesDetails);
            MessageBox.Show("Delete successfull");
            LoadAllFeesDetails();
        }

    }
}
