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
    /// Interaction logic for BrandCategoryUI.xaml
    /// </summary>
    public partial class BrandCategoryUI : Window
    {
        List<BrandName> brandNameList;
        List<BrandCategory> brandCategoryList;

        InventoryManager inventoryManagerObj = new InventoryManager();

        BrandCategory _brandCategory;
        public BrandCategoryUI()
        {
            InitializeComponent();
            LoadAllBrandName();
            LoadAllBrandCategory();
        }
        private void LoadAllBrandName()
        {
            brandNameList = new List<BrandName>();
            brandNameList = inventoryManagerObj.GetAllBrandName();
            brandNameComboBox.Items.Clear();
            if (brandNameList.Count > 0)
            {
                foreach (var item in brandNameList)
                {
                    brandNameComboBox.Items.Add(item);
                }
            }
            brandNameComboBox.DisplayMemberPath = "InventoryBrandName";

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            _brandCategory = new BrandCategory();

            _brandCategory.CategoryName = categoryTextbox.Text;
            _brandCategory.BrabdId = ((BrandName)brandNameComboBox.SelectedItem).Id;

            inventoryManagerObj.SaveBrandCategory(_brandCategory);
            LoadAllBrandCategory();
            MessageBox.Show("Data insurted successfully");
        }

        private void LoadAllBrandCategory()
        {
            brandCategoryList = new List<BrandCategory>();
            brandCategoryList = inventoryManagerObj.LoadAllBrandCategory();
            BrandCategoryListView.Items.Clear();
            if (brandCategoryList.Count > 0)
            {
                foreach (var item in brandCategoryList)
                {
                    BrandCategoryListView.Items.Add(item);
                }
            }
        }
    }
}
