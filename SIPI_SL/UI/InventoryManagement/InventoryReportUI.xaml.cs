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
    /// Interaction logic for InventoryReportUI.xaml
    /// </summary>
    public partial class InventoryReportUI : Window
    {
        public InventoryReportUI()
        {
            InitializeComponent();
        }

        List<ProductMasterEntry_inventory> productMasterEntryList;
        InventorymasterEntryManager inventorymasterEntryManagerObj = new InventorymasterEntryManager();

        List<RInventoryStockOutER> _RStockOutSlipList = new List<RInventoryStockOutER>();

        private void stockStatusReport_Click(object sender, RoutedEventArgs e)
        {
            StockReport();
        }
        private void StockReport()
        {
            productMasterEntryList = new List<ProductMasterEntry_inventory>();
            productMasterEntryList = inventorymasterEntryManagerObj.GetAllProductMasterEntry();
            _RStockOutSlipList.Clear();
            foreach (ProductMasterEntry_inventory p in productMasterEntryList)
            {
                RInventoryStockOutER printSlipReportInfo = new RInventoryStockOutER();
                printSlipReportInfo.Id = p.Id;
                printSlipReportInfo.ProductName = p.Product_Name;
                printSlipReportInfo.Quantity = (decimal)p.Stock_InHand;
                printSlipReportInfo.CategoryName = p.CategoryName;
                printSlipReportInfo.BrandName = p.BrabdName;
                if (printSlipReportInfo.Quantity > 0)
                {
                    _RStockOutSlipList.Add(printSlipReportInfo);
                }
            }
            if (_RStockOutSlipList.Count > 0)
            {
                AlldetailsReport report = new AlldetailsReport();
                ReportUtility.Display_report(report, _RStockOutSlipList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
