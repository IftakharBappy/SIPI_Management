using BLL.InventoryManagement;
using ENTITY.InventoryManagement;
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

namespace SIPI_SL.UI.InventoryManagement
{
    /// <summary>
    /// Interaction logic for BrandNameEntryUI.xaml
    /// </summary>
    public partial class BrandNameEntryUI : Window
    {
        BrandName _brandName;
        InventoryManager inventoryManagerObj = new InventoryManager();

        List<BrandName> brandNameList;
        public BrandNameEntryUI()
        {
            InitializeComponent();
            LoadAllBrandName();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            _brandName = new BrandName();

            _brandName.InventoryBrandName = brandNameTextbox.Text;
            _brandName.BrandDiscription = brandDiscriptionTextBox.Text;
            _brandName.ContactInfo = contactInfoTextbox.Text;
            inventoryManagerObj.SaveBrandName(_brandName);
            LoadAllBrandName();
            MessageBox.Show("Data insurted successfully");
        }

        private void LoadAllBrandName()
        {
            brandNameList = new List<BrandName>();
            brandNameList = inventoryManagerObj.GetAllBrandName();
            brandNameListView.Items.Clear();
            if (brandNameList.Count > 0)
            {
                foreach (var item in brandNameList)
                {
                    brandNameListView.Items.Add(item);
                }
            }
        }
    }
}
