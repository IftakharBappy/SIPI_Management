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
    /// Interaction logic for InventoryManagementDashBoardUI.xaml
    /// </summary>
    public partial class InventoryManagementDashBoardUI : Window
    {
        public InventoryManagementDashBoardUI()
        {
            InitializeComponent();
        }
        private void ShowWindow(string className)
        {
            bool isOpen = false;
            Window objWindowName = new Window();
            try
            {
                foreach (Window objWindow in Application.Current.Windows)
                {
                    string[] splitedNamespace = (objWindow.ToString()).Split('.');
                    string aClassNameFromCollection = splitedNamespace[splitedNamespace.Length - 1];

                    if (aClassNameFromCollection == className)
                    {
                        isOpen = true;
                        objWindowName = objWindow;
                        break;
                    }
                }
                if (isOpen == false)
                {
                    #region SHOW DESIRED WINDOW
                    switch (className)
                    {
                        case "PurchaseEntryUI":
                            PurchaseEntryUI _PurchaseEntry = new PurchaseEntryUI();
                            _PurchaseEntry.Owner = this;
                            _PurchaseEntry.Show();
                            break;
                       
                        case "InventoryListUI":
                            InventoryListUI _inventoryList = new InventoryListUI();
                            _inventoryList.Owner = this;
                            _inventoryList.Show();
                            break;

                        case "BrandNameEntryUI":
                            BrandNameEntryUI _brandNameEntry = new BrandNameEntryUI();
                            _brandNameEntry.Owner = this;
                            _brandNameEntry.Show();
                            break;
                        case "BrandCategoryUI":
                            BrandCategoryUI _brandCategoryUI = new BrandCategoryUI();
                            _brandCategoryUI.Owner = this;
                            _brandCategoryUI.Show();
                            break;
                        case "ProductMasterEntry":
                            ProductMasterEntry productMasterEntry = new ProductMasterEntry();
                            productMasterEntry.Owner = this;
                            productMasterEntry.Show();
                            break;
                        case "UnitTypeDetailsUI":
                            UnitTypeDetailsUI unitTypeDetailsUI = new UnitTypeDetailsUI();
                            unitTypeDetailsUI.Owner = this;
                            unitTypeDetailsUI.Show();
                            break;
                        case "StockOutUI":
                            StockOutUI stockOutUI = new StockOutUI();
                            stockOutUI.Owner = this;
                            stockOutUI.Show();
                            break;
                        case "InventoryReportUI":
                            InventoryReportUI inventoryReportUI = new InventoryReportUI();
                            inventoryReportUI.Owner = this;
                            inventoryReportUI.Show();
                            break;
                          
                    }
                    #endregion SHOW DESIRED WINDOW
                }
                if (isOpen)
                {
                    foreach (Window objWindow in Application.Current.Windows)
                    {
                        string[] splitedNamespace = (objWindow.ToString()).Split('.');
                        string aClassNameFromCollection = splitedNamespace[splitedNamespace.Length - 1];

                        if (aClassNameFromCollection == className)
                        {
                            objWindowName.WindowState = WindowState.Normal;
                            objWindowName.Activate();
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Occured While Showing Window.\n" + exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void inventoryEntry_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("InventoryEntryUI");
        }

        private void inventoryUpdate_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("InventoryUpdateUI");
        }

        private void inventoryList_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("InventoryListUI");
        }

        private void brandNameEntry_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("BrandNameEntryUI");
        }

        private void brandCategory_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("BrandCategoryUI");
            
        }

        private void productMasterEntry_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("ProductMasterEntry");
            
        }

        private void UnitTypeDetails_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("UnitTypeDetailsUI");
        }

        private void purchaseEntry_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("PurchaseEntryUI");
        }

        private void stockOut_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("StockOutUI");
        }

        private void stockStatus_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("InventoryReportUI");
        }
    }
}
