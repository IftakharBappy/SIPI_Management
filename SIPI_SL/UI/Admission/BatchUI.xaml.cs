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
    /// Interaction logic for BatchUI.xaml
    /// </summary>
    public partial class BatchUI : Window
    {
        Batch _batchObj;
        BatchManager batchManagerObj = new BatchManager();
        List<Batch> batchList;

        public BatchUI()
        {
            InitializeComponent();
            LoadAllBatch();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (submitButton.Content.ToString() == "Save")
                {
                    _batchObj = new Batch();
                    _batchObj.BatchNo = batchTextBox.Text;
                    _batchObj.Year = Convert.ToInt32(yearTextBox.Text);
                    _batchObj.BanglaBatch = banglaBatchTextBox.Text;
                    batchManagerObj.SaveBatch(_batchObj);
                    MessageBox.Show("Data insurted successfully");

                    LoadAllBatch();
                }
                if (submitButton.Content.ToString() == "Update")
                {
                    _batchObj.BatchNo = batchTextBox.Text;
                    _batchObj.Year = Convert.ToInt32(yearTextBox.Text);
                    _batchObj.BanglaBatch = banglaBatchTextBox.Text;
                    batchManagerObj.UpdateBatch(_batchObj);
                    LoadAllBatch();
                    MessageBox.Show("Data Update successfully");
                    submitButton.Content = "Save";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadAllBatch()
        {
            batchList = new List<Batch>();
            batchList = batchManagerObj.GetAllBatch();
            batchlistView.Items.Clear();
            if (batchList.Count > 0)
            {
                foreach (var item in batchList)
                {
                    batchlistView.Items.Add(item);
                }

            }
        }

        private void RemoveDepartmentContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _batchObj = new Batch();
            _batchObj = ((Batch)batchlistView.SelectedItem);
            batchManagerObj.DeleteBatch(_batchObj);
            LoadAllBatch();
            MessageBox.Show("Selected Item Removed");

        }

        private void EditDepartmentContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _batchObj = new Batch();
            _batchObj = ((Batch)batchlistView.SelectedItem);
            batchTextBox.Text = _batchObj.BatchNo;
            yearTextBox.Text = Convert.ToString(_batchObj.Year);
            banglaBatchTextBox.Text = _batchObj.BanglaBatch;           
            submitButton.Content = "Update";

        }

    }
}
