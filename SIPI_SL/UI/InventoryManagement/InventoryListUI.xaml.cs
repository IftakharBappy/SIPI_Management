using BLL.InventoryManagement;
using ENTITY.InventoryManagement;
using SIPI_SL.Report.Crystal.Inventory;
using SIPI_SL.Report.Entity.Inventory;
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
    /// Interaction logic for InventoryListUI.xaml
    /// </summary>
    public partial class InventoryListUI : Window
    {
        List<InventoryReporting> inventoryReposrtList;
        InventorymasterEntryManager inventorymasterEntryManagerObj = new InventorymasterEntryManager();
        List<RInventoryReporting> _RInventoryPurchageEntryList = new List<RInventoryReporting>();
        public InventoryListUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchType = "";
            searchType = typeCombobox.Text;

            inventoryReposrtList = new List<InventoryReporting>();
            inventoryReposrtList = inventorymasterEntryManagerObj.GetinventoryReposrt(Convert.ToDateTime(startDateDatepicker.SelectedDate), Convert.ToDateTime(endDateDatepicker.SelectedDate), searchType);
           
            //productMasterEntryListView.Items.Clear();
            //if (productMasterEntryList.Count > 0)
            //{
            //    foreach (var item in productMasterEntryList)
            //    {
            //        productMasterEntryListView.Items.Add(item);
            //    }
            //}
            _RInventoryPurchageEntryList.Clear();
            foreach (InventoryReporting p in inventoryReposrtList)
            {
                RInventoryReporting printReportInfo = new RInventoryReporting();

                printReportInfo.Id = p.Id;
                printReportInfo.StockOutInvoiceNo = p.InvoiceNo;
                printReportInfo.StockOutItemPrice = (decimal)p.StockOutItemPrice;
                printReportInfo.StockOutProductName = p.StockOutProductName;
                printReportInfo.StockOutQuantity = (decimal)p.StockOutQuantity;
                printReportInfo.StockOutDate = (DateTime)p.StockOutDate;
                printReportInfo.StockOutTotalPrice = (decimal)p.StockOutTotalPrice;
                ////
                printReportInfo.ProductId =(int) p.StockOutProductId;
                printReportInfo.InvoiceNo = p.InvoiceNo;
                printReportInfo.SystemSerialNo = p.SystemSerialNo;
                printReportInfo.ItemPrice = (decimal)p.ItemPrice;
                printReportInfo.ProductName = p.ProductName;
                printReportInfo.SalableQuantity = (decimal)p.SalableQuantity;
                printReportInfo.NumberOfProduct = (decimal)p.NumberOfProduct;
                printReportInfo.EveryPackQuantity = (decimal)p.EveryPackQuantity;
                printReportInfo.ExtraQuantity = (decimal)p.ExtraQuantity;
                printReportInfo.PurchaseDate = (DateTime)p.PurchaseDate;
                printReportInfo.TotalPrice = (decimal)p.TotalPrice;
                printReportInfo.UnitType = p.UnitType;
                printReportInfo.BrandName = p.BrandName;
                printReportInfo.TotalPrice = (decimal)p.TotalPrice;
                printReportInfo.PurchaserInfo = p.PurchaserInfo;
                /////
                printReportInfo.OrganizationAddress = p.OrganizationAddress;
                printReportInfo.OrganizationName = p.OrganizationName;
                printReportInfo.OrganizationMobile = p.OrganizationMobile;

                _RInventoryPurchageEntryList.Add(printReportInfo);
            }
            if (_RInventoryPurchageEntryList.Count > 0)
            {
                AlldetailsReport report = new AlldetailsReport();
                ReportUtility.Display_report(report, _RInventoryPurchageEntryList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        

        }
    }
}
