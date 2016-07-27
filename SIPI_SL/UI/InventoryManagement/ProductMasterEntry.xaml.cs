using BLL.InventoryManagement;
using ENTITY.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Interaction logic for ProductMasterEntry.xaml
    /// </summary>
    public partial class ProductMasterEntry : Window
    {
        List<BrandName> brandNameList;
        List<BrandCategory> brandCategoryList;
        List<UnitType> unitTypeList;

       List<ProductMasterEntry_inventory> productMasterEntryList;

        InventoryManager inventoryManagerObj = new InventoryManager();

        ProductMasterEntry_inventory productMasterEntryEntity_inventoryObj;
        InventorymasterEntryManager inventorymasterEntryManagerObj = new InventorymasterEntryManager();

        public ProductMasterEntry()
        {
            InitializeComponent();
            LoadAllBrandName();
            LoadAllCategoryName();
            LoadAllUnitTypeName();
            LoadAllProductMasterEntry();

        }

        private void LoadAllUnitTypeName()
        {
            unitTypeList = new List<UnitType>();
            unitTypeList = inventoryManagerObj.LoadAllUnitType();
            UnitTypeNameCombobox.Items.Clear();
            if (unitTypeList.Count > 0)
            {
                foreach (var item in unitTypeList)
                {
                    UnitTypeNameCombobox.Items.Add(item);
                }
            }
            UnitTypeNameCombobox.DisplayMemberPath = "InventoryUnitType";
        }

        private void LoadAllCategoryName()
        {
            brandCategoryList = new List<BrandCategory>();
            brandCategoryList = inventoryManagerObj.LoadAllBrandCategory();
            CategoryNameCombobox.Items.Clear();
            if (brandCategoryList.Count > 0)
            {
                foreach (var item in brandCategoryList)
                {
                    CategoryNameCombobox.Items.Add(item);
                }
            }
            CategoryNameCombobox.DisplayMemberPath = "CategoryName";
        }
        private void LoadAllBrandName()
        {
            brandNameList = new List<BrandName>();
            brandNameList = inventoryManagerObj.GetAllBrandName();
            brandNameCombobox.Items.Clear();
            if (brandNameList.Count > 0)
            {
                foreach (var item in brandNameList)
                {
                    brandNameCombobox.Items.Add(item);
                }
            }
            brandNameCombobox.DisplayMemberPath = "InventoryBrandName";
        }


        private void saveButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                productMasterEntryEntity_inventoryObj = new ProductMasterEntry_inventory();
                productMasterEntryEntity_inventoryObj.Product_Name = ProductNameTextBox.Text;
                productMasterEntryEntity_inventoryObj.Brabd_Id = ((BrandName)brandNameCombobox.SelectedItem).Id;
                productMasterEntryEntity_inventoryObj.Category_Id = ((BrandCategory)CategoryNameCombobox.SelectedItem).Id;
                productMasterEntryEntity_inventoryObj.UnitType_Id = ((UnitType)UnitTypeNameCombobox.SelectedItem).Id;
                productMasterEntryEntity_inventoryObj.UnitType_Note = UnitTypeNoteTextbox.Text;

                inventorymasterEntryManagerObj.SaveProductMasterEntry(productMasterEntryEntity_inventoryObj);
                LoadAllProductMasterEntry();
                MessageBox.Show("Data insurted successfully");
                clear();
            }
                        
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Casting problem ! please ensure the Database Procidure");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("please fill up the required filed");
            }
            
           
        }

        private void LoadAllProductMasterEntry()
        {
            productMasterEntryList = new List<ProductMasterEntry_inventory>();
            productMasterEntryList = inventorymasterEntryManagerObj.GetAllProductMasterEntry();
            productMasterEntryListview.Items.Clear();
            if (productMasterEntryList.Count > 0)
            {
                foreach (var item in productMasterEntryList)
                {
                    productMasterEntryListview.Items.Add(item);
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
               
                    clear();
        }

        private void clear()
        {
            ProductNameTextBox.Text = "";
            brandNameCombobox.SelectedIndex = -1;
            CategoryNameCombobox.SelectedIndex = -1;
            UnitTypeNameCombobox.SelectedIndex = -1;
            UnitTypeNoteTextbox.Text = "";
        }




    }
}
