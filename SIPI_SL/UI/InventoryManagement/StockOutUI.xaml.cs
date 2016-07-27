using BLL.InventoryManagement;
using ENTITY.InventoryManagement;
using ENTITY.Validations;
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
    /// Interaction logic for StockOutUI.xaml
    /// </summary>
    public partial class StockOutUI : Window
    {
        List<ProductMasterEntry_inventory> productMasterEntryList;
        InventorymasterEntryManager inventorymasterEntryManagerObj = new InventorymasterEntryManager();

        ProductMasterEntry_inventory _modelObj;

        List<StockOut> stockOutList;
        StockOut stockOutObj;

        List<RInventoryStockOutER> _RStockOutSlipList = new List<RInventoryStockOutER>();

        public StockOutUI()
        {
            InitializeComponent();
            LoadAllProductMasterEntry();
            StockOutDate.SelectedDate = DateTime.Today;
            LoadAllStockOutDetails();
            LoadInvoiceNumber();
           
        }

        private void StockOutSlipPrint()
        {
            string Slip = "";
            Slip = invoiceNoTextbox.Text ;
            stockOutList = new List<StockOut>();
            StockOut obj = new StockOut();
            stockOutList = inventorymasterEntryManagerObj.GetstockOutSlip(Slip);
            _RStockOutSlipList.Clear();
            foreach (StockOut p in stockOutList)
            {
                RInventoryStockOutER printSlipReportInfo = new RInventoryStockOutER();

                printSlipReportInfo.Id = p.Id;
                printSlipReportInfo.InvoiceNo = p.InvoiceNo;

                printSlipReportInfo.ItemPrice = (decimal)p.ItemPrice;
                printSlipReportInfo.ProductName = p.ProductName;
                printSlipReportInfo.Quantity =(decimal) p.Quantity;
                printSlipReportInfo.StockOutDate =(DateTime) p.StockOutDate;
                printSlipReportInfo.TotalPrice =(decimal) p.TotalPrice;

                printSlipReportInfo.OrganizationAddress = p.OrganizationAddress;
                printSlipReportInfo.OrganizationName = p.OrganizationName;
                printSlipReportInfo.OrganizationMobile = p.OrganizationMobile;

                _RStockOutSlipList.Add(printSlipReportInfo);

            }


            if (_RStockOutSlipList.Count > 0)
            {
                InventoryStockOut report = new InventoryStockOut();
                ReportUtility.Display_report(report, _RStockOutSlipList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void LoadInvoiceNumber()
        {
            string invoiceNumber = inventorymasterEntryManagerObj.GetSystemSerialNumber();
            invoiceNoTextbox.Text = invoiceNumber;
        }

        private void LoadAllStockOutDetails()
        {
            stockOutList = new List<StockOut>();
            StockOut obj = new  StockOut();
            stockOutList = inventorymasterEntryManagerObj.GetAllstockOutList();
            stockOutListDetailsList.Items.Clear();
            if (stockOutList.Count > 0)
            {
                foreach (var item in stockOutList)
                {
                    stockOutListDetailsList.Items.Add(item);
                }
            }
        }

        private void LoadAllProductMasterEntry()
        {
            productMasterEntryList = new List<ProductMasterEntry_inventory>();
            productMasterEntryList = inventorymasterEntryManagerObj.GetAllProductMasterEntry();
            productMasterEntryListView.Items.Clear();
            if (productMasterEntryList.Count > 0)
            {
                foreach (var item in productMasterEntryList)
                {
                    productMasterEntryListView.Items.Add(item);
                }
            }
        }
        private void StockReport()
        {
            productMasterEntryList = new List<ProductMasterEntry_inventory>();
            productMasterEntryList = inventorymasterEntryManagerObj.GetAllProductMasterEntry();
            _RStockOutSlipList.Clear();
            foreach (StockOut p in stockOutList)
            {
                RInventoryStockOutER printSlipReportInfo = new RInventoryStockOutER();

                printSlipReportInfo.Id = p.Id;
                printSlipReportInfo.InvoiceNo = p.InvoiceNo;

                printSlipReportInfo.ItemPrice = (decimal)p.ItemPrice;
                printSlipReportInfo.ProductName = p.ProductName;
                printSlipReportInfo.Quantity = (decimal)p.Quantity;
                printSlipReportInfo.StockOutDate = (DateTime)p.StockOutDate;
                printSlipReportInfo.TotalPrice = (decimal)p.TotalPrice;

                printSlipReportInfo.OrganizationAddress = p.OrganizationAddress;
                printSlipReportInfo.OrganizationName = p.OrganizationName;
                printSlipReportInfo.OrganizationMobile = p.OrganizationMobile;

                if (printSlipReportInfo.Quantity > 0)
                {
                    _RStockOutSlipList.Add(printSlipReportInfo);
                }

            }


            if (_RStockOutSlipList.Count > 0)
            {
                StockOutReport report = new StockOutReport();
                ReportUtility.Display_report(report, _RStockOutSlipList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void productMasterEntryListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
                    productQuantityTextBox.Text = "";
                    _modelObj = new ProductMasterEntry_inventory();
                    ProductMasterEntry_inventory _productMasterEntryObj = (ProductMasterEntry_inventory)productMasterEntryListView.SelectedItem;
                    productNameTextBox.Text = _productMasterEntryObj.Product_Name;
                    productIdTextBox.Text = _productMasterEntryObj.Id.ToString();

                    categoryNameTextBox.Text = _productMasterEntryObj.CategoryName;
                    categoryIdTextBox.Text = _productMasterEntryObj.Category_Id.ToString();

                    brandNameTextbox.Text = _productMasterEntryObj.BrabdName;
                    brandIdTextbox.Text = _productMasterEntryObj.Brabd_Id.ToString();

                    unitTypeNameTextbox.Text = _productMasterEntryObj.UnitTypeName;
                    unitTypeIdTextbox.Text = _productMasterEntryObj.UnitType_Id.ToString();
                    itemPriceTextBox.Text = _productMasterEntryObj.StockOutPrice.ToString();
                    productQuantityTextBox.Text = Convert.ToString(1);
               
        }

        private void RemoveSelectedItemContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (stockOutListview.SelectedIndex != null)
            {
                stockOutListview.Items.RemoveAt(stockOutListview.Items.IndexOf(stockOutListview.SelectedItem));
                
                StockOut _stockOutListviewObj = (StockOut)stockOutListview.ItemsSource;
                if (stockOutListview.Items.Count > 0)
                {
                    decimal? tatalprice = 0;
                    foreach (StockOut item in stockOutListview.Items)
                    {
                        tatalprice += item.TotalPrice;
                        totalAmountTextBox.Text = tatalprice.ToString();
                    }
                }
                else
                {
                    totalAmountTextBox.Text = "";
                }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                stockOutList = new List<StockOut>();
                stockOutObj = new StockOut();
                stockOutObj.ProductName = productNameTextBox.Text;
                stockOutObj.ProductId = Convert.ToInt32(productIdTextBox.Text);

                stockOutObj.Quantity = Convert.ToDecimal(productQuantityTextBox.Text);
               
                stockOutObj.ItemPrice = Convert.ToDecimal(itemPriceTextBox.Text);
               
                stockOutObj.TotalPrice = Convert.ToDecimal(totalPriceTextBox.Text);

                stockOutList.Add(stockOutObj);
                if (stockOutList.Count > 0)
                {

                    foreach (var item in stockOutList)
                    {
                      stockOutListview.Items.Add(item);
                    }
                }

                StockOut _stockOutListviewObj = (StockOut)stockOutListview.ItemsSource;
                decimal? tatalprice = 0;
                foreach (StockOut item in stockOutListview.Items)
                {
                    tatalprice += item.TotalPrice;
                    totalAmountTextBox.Text = tatalprice.ToString();
                }
                ClearAll();

                


            }
            catch (FormatException)
            {

                MessageBox.Show("Please Fill Up the required Value", "No Entry");
            }

        }

        private void ClearAll()
        {
            productQuantityTextBox.Text = "";
            productNameTextBox.Text = "";
            productIdTextBox.Text = "";
            categoryNameTextBox.Text = "";
            categoryIdTextBox.Text = "";
            brandNameTextbox.Text = "";
            brandIdTextbox.Text = "";
            unitTypeNameTextbox.Text = "";
            unitTypeIdTextbox.Text = "";
            itemPriceTextBox.Text = "";
            totalPriceTextBox.Text = "";
        }

        private void productQuantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {   
                //////////////
                stockOutList = new List<StockOut>();
                int product_id = Convert.ToInt32(productIdTextBox.Text);
                decimal? quantitylistViewChq = 0;
                decimal? availableQuantity = 0;

                foreach (StockOut item in stockOutListview.Items)
                {
                    if (item.ProductId == product_id)
                    {
                        quantitylistViewChq +=item.Quantity;
                    }
                }
                foreach (ProductMasterEntry_inventory item in productMasterEntryListView.Items)
                {
                    if (item.Id == product_id)
                    {
                        availableQuantity = item.Stock_InHand - quantitylistViewChq;
                    }
                }
                //////////////
                if (productQuantityTextBox.Text != "")
                {
                    if (availableQuantity < Convert.ToInt32(productQuantityTextBox.Text))
                    {
                        if (availableQuantity>0)
                        {
                            MessageBox.Show("You Only take " + availableQuantity + " Numbrt Of Products ");
                            productQuantityTextBox.Text = availableQuantity.ToString();
                        }
                        else
                        {
                            MessageBox.Show("This Product Out Of Stock");
                            ClearAll();
                        }
                        
                    }
                }
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(itemPriceTextBox.Text) && productQuantityTextBox.Text != ""))
                {
                    totalPriceTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(itemPriceTextBox.Text)).ToString();
                }
                if (productQuantityTextBox.Text == "")
                {
                    totalPriceTextBox.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Product Quantity must be a Numeric number", "Insert Only Number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please Don't insert the Larger Number", "Larger Value");
            }
        }

        private void clearButtonAllTextBox_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        private void stckOutButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                stockOutList = new List<StockOut>();

                for (int i = 0; i < stockOutListview.Items.Count; i++)
                {
                    stockOutObj = new StockOut();
                    StockOut stockOutListObj = (StockOut)stockOutListview.Items[i];
                    stockOutObj.ProductName = stockOutListObj.ProductName;
                    stockOutObj.ProductId = stockOutListObj.ProductId;

                    stockOutObj.Quantity = stockOutListObj.Quantity;
                    stockOutObj.ItemPrice = stockOutListObj.ItemPrice;

                    stockOutObj.TotalPrice = stockOutListObj.TotalPrice;
                    stockOutObj.ItemPrice = stockOutListObj.ItemPrice;
                    
                    stockOutObj.InvoiceNo = invoiceNoTextbox.Text;
                    stockOutObj.StockOutDate = Convert.ToDateTime(StockOutDate.Text);
                    stockOutObj.StockOutInfo = StockOutInfoTextBox.Text;
                    stockOutList.Add(stockOutObj);
                }
                inventorymasterEntryManagerObj.SaveStockOutDetails(stockOutList);
                inventorymasterEntryManagerObj.UpdateAfterStockOut(stockOutList);
                MessageBox.Show("StockOut Successful", "Successful StockOut");
                ClearSave();
                totalAmountTextBox.Text = "";
                LoadAllProductMasterEntry();
                MessageBoxResult result = MessageBox.Show("Are you sure want to print this Document?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    StockOutSlipPrint();
                }
                invoiceNoTextbox.Text = "";
                LoadInvoiceNumber();

            }
            catch (FormatException)
            {
                MessageBox.Show("Empty Invoice Or Date Please Check", "Please Fillup Required Field");
            }

           
        }

        private void ClearSave()
        {
            
            StockOutDate.SelectedDate = DateTime.Today;
            StockOutInfoTextBox.Text = "";
            stockOutListview.Items.Clear();
        }

        private void SlipContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string Slip = "";
            StockOut stockOutobj = (StockOut)stockOutListDetailsList.SelectedItem;
            Slip = stockOutobj.InvoiceNo;
            stockOutList = new List<StockOut>();
            StockOut obj = new StockOut();
            stockOutList = inventorymasterEntryManagerObj.GetstockOutSlip(Slip);
            _RStockOutSlipList.Clear();
            foreach (StockOut p in stockOutList)
            {
                RInventoryStockOutER printSlipReportInfo = new RInventoryStockOutER();

                printSlipReportInfo.Id = p.Id;
                printSlipReportInfo.InvoiceNo = p.InvoiceNo;

                printSlipReportInfo.ItemPrice = (decimal)p.ItemPrice;
                printSlipReportInfo.ProductName = p.ProductName;
                printSlipReportInfo.Quantity = (decimal)p.Quantity;
                printSlipReportInfo.StockOutDate = (DateTime)p.StockOutDate;
                printSlipReportInfo.TotalPrice = (decimal)p.TotalPrice;


                printSlipReportInfo.OrganizationAddress = p.OrganizationAddress;
                printSlipReportInfo.OrganizationName = p.OrganizationName;
                printSlipReportInfo.OrganizationMobile = p.OrganizationMobile;
                _RStockOutSlipList.Add(printSlipReportInfo);

            }


            if (_RStockOutSlipList.Count > 0)
            {
                InventoryStockOut report = new InventoryStockOut();
                ReportUtility.Display_report(report, _RStockOutSlipList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void totalPriceTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validations.IsInteger(e.Text);
            base.OnPreviewTextInput(e);
        }
    }
}
