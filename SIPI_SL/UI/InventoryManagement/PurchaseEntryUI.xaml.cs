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
    /// Interaction logic for PurchaseEntryUI.xaml
    /// </summary>
    public partial class PurchaseEntryUI : Window
    {
        List<ProductMasterEntry_inventory> productMasterEntryList;
        InventorymasterEntryManager inventorymasterEntryManagerObj = new InventorymasterEntryManager();
        ProductMasterEntry_inventory _modelObj;

        PurchaseEntry purchaseEntryObj;
        List<PurchaseEntry> purchaseEntryList;

        List<RInventoryPurchageEntry> _RPurchageEntryList = new List<RInventoryPurchageEntry>();
         

        public PurchaseEntryUI()
        {
            InitializeComponent();
            LoadAllProductMasterEntry();
            StockEntryDate.SelectedDate = DateTime.Today;
            LoadAllProductPurchageEntry();
            LoadSystemSerialNumber();
        }

        private void LoadAllProductPurchageEntry()
        {
            purchaseEntryList = new List<PurchaseEntry>();
            purchaseEntryList = inventorymasterEntryManagerObj.GetAllProductPurchageEntry();
            purchageListDetailsList.Items.Clear();
            if (purchaseEntryList.Count > 0)
            {
                foreach (var item in purchaseEntryList)
                {
                    purchageListDetailsList.Items.Add(item);
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

        private void productMasterEntryListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

                _modelObj = new ProductMasterEntry_inventory();
                ProductMasterEntry_inventory _productMasterEntryObj = (ProductMasterEntry_inventory)productMasterEntryListView.SelectedItem;
                productNameTextBox.Text =  _productMasterEntryObj.Product_Name ;
                productIdTextBox.Text = _productMasterEntryObj.Id.ToString() ;

                categoryNameTextBox.Text = _productMasterEntryObj.CategoryName;
                categoryIdTextBox.Text = _productMasterEntryObj.Category_Id.ToString();

                brandNameTextbox.Text = _productMasterEntryObj.BrabdName;
                brandIdTextbox.Text = _productMasterEntryObj.Brabd_Id.ToString();

                unitTypeNameTextbox.Text = _productMasterEntryObj.UnitTypeName;
                unitTypeIdTextbox.Text = _productMasterEntryObj.UnitType_Id.ToString();
           
        }
        
        private void productQuantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(QuantityPerPackTextBox.Text)))
                {
                    salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(QuantityPerPackTextBox.Text)).ToString();
                }
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(itemPriceTextBox.Text)))
                {
                    totalPriceTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(itemPriceTextBox.Text)).ToString();
                }
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && QuantityPerPackTextBox.Text =="")
                {
                    salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(1)).ToString();
                }
                if (productQuantityTextBox .Text == "" )
                {
                    salableQuantityTextBox.Text = "";
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

        private void QuantityPerPackTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                extraQuantityTextBox.Text = "";
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(QuantityPerPackTextBox.Text)))
                {
                    salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(QuantityPerPackTextBox.Text)).ToString();
                }
                if (QuantityPerPackTextBox.Text == "" && productQuantityTextBox.Text != "")
                {
                    salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(1)).ToString();
                }
                if (QuantityPerPackTextBox.Text == "" && productQuantityTextBox.Text == "")
                {
                    salableQuantityTextBox.Text = "";
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

        private void itemPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(itemPriceTextBox.Text)) && itemPriceTextBox.IsEnabled == true)
                {
                    totalPriceTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(itemPriceTextBox.Text)).ToString();
                }
                //if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)))
                //{
                //    salableQuantityTextBox.Text = (Convert.ToInt32(productQuantityTextBox.Text) * Convert.ToInt32(1)).ToString(); ;
                //}
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

        private void totalPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(totalPriceTextBox.Text)) && totalPriceTextBox.IsEnabled == true)
                {
                    decimal itemPrice;
                    
                    itemPrice = (Convert.ToDecimal(totalPriceTextBox.Text) / Convert.ToDecimal(productQuantityTextBox.Text));
                    itemPriceTextBox.Text = itemPrice.ToString("0.00");

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

        private void ifItempriceChickBox_Checked(object sender, RoutedEventArgs e)
        {
            itemPriceTextBox.IsEnabled = true;
            totalPriceTextBox.Clear();
            itemPriceTextBox.Clear();
            totalPriceTextBox.IsEnabled = false;

        }

        private void ifItempriceChickBox_Unchecked(object sender, RoutedEventArgs e)
        {
            itemPriceTextBox.IsEnabled = false;
            totalPriceTextBox.Clear();
            itemPriceTextBox.Clear();
            totalPriceTextBox.IsEnabled = true;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                purchaseEntryList = new List<PurchaseEntry>();
                purchaseEntryObj = new PurchaseEntry();
                purchaseEntryObj.ProductName = productNameTextBox.Text;
                purchaseEntryObj.ProductId = Convert.ToInt32(productIdTextBox.Text);

                purchaseEntryObj.NumberOfProduct = Convert.ToDecimal(productQuantityTextBox.Text);
                if (QuantityPerPackTextBox.Text != "")
                {
                    purchaseEntryObj.EveryPackQuantity = Convert.ToDecimal(QuantityPerPackTextBox.Text);
                }
                else
                {
                    purchaseEntryObj.EveryPackQuantity = 1;
                }
                purchaseEntryObj.SalableQuantity = Convert.ToDecimal(salableQuantityTextBox.Text);
                if (extraQuantityTextBox.Text != "")
                {
                    purchaseEntryObj.ExtraQuantity = Convert.ToDecimal(extraQuantityTextBox.Text);
                    
                }
                else
                {
                    purchaseEntryObj.ExtraQuantity = 0;
                }
                purchaseEntryObj.ItemPrice = Convert.ToDecimal(itemPriceTextBox.Text);
                purchaseEntryObj.TotalPrice = Convert.ToInt32(totalPriceTextBox.Text);

                purchaseEntryList.Add(purchaseEntryObj);

                if (purchaseEntryList.Count > 0)
                {
                    foreach (var item in purchaseEntryList)
                    {
                        stockEntryListview.Items.Add(item);
                    }
                }
                ///////
                PurchaseEntry _stockOutListviewObj = (PurchaseEntry)stockEntryListview.ItemsSource;
                decimal? tatalprice = 0;
                foreach (PurchaseEntry item in stockEntryListview.Items)
                {
                    tatalprice += item.TotalPrice;
                    grandTotalPriceTextBox.Text = tatalprice.ToString();
                }
                ///////
                AddClear();
                LoadSystemSerialNumber();
            }
            catch (FormatException)
            {

                MessageBox.Show("Please Fill Up the required Value", "No Entry");
            }

        }
        private void LoadSystemSerialNumber()
        {
            string invoiceNumber = inventorymasterEntryManagerObj.GetSystemSerialNumber();
            systemSerialNoTextbox.Text = invoiceNumber;
        }

        private void extraQuantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(QuantityPerPackTextBox.Text)) && (!string.IsNullOrEmpty(extraQuantityTextBox.Text)))
                {
                    salableQuantityTextBox.Text = ((Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(QuantityPerPackTextBox.Text)) + Convert.ToDecimal(extraQuantityTextBox.Text)).ToString();
                }
                if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && QuantityPerPackTextBox.Text == "" && extraQuantityTextBox.Text!="")
                {
                    salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) + Convert.ToDecimal(extraQuantityTextBox.Text)).ToString();
                }
                //if ((!string.IsNullOrEmpty(productQuantityTextBox.Text)) && (!string.IsNullOrEmpty(extraQuantityTextBox.Text)))
                //{
                //    salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) + Convert.ToDecimal(extraQuantityTextBox.Text)).ToString();
                //}
                if (extraQuantityTextBox.Text== "")
                {
                    if (productQuantityTextBox.Text == "" && QuantityPerPackTextBox.Text == "")
                    {
                        salableQuantityTextBox.Text = "";
                    }
                    if (productQuantityTextBox.Text != "" && QuantityPerPackTextBox.Text != "")
                    {
                        salableQuantityTextBox.Text = (Convert.ToDecimal(productQuantityTextBox.Text) * Convert.ToDecimal(QuantityPerPackTextBox.Text)).ToString();
                    }
                    if (productQuantityTextBox.Text != "" && QuantityPerPackTextBox.Text == "")
	                {
		                salableQuantityTextBox.Text = productQuantityTextBox.Text;
                    }
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

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
             try
            {
                purchaseEntryList = new List<PurchaseEntry>();

                for (int i = 0; i < stockEntryListview.Items.Count; i++)
                {
                    purchaseEntryObj = new PurchaseEntry();
                    PurchaseEntry stockEntryObj = (PurchaseEntry)stockEntryListview.Items[i];
                    purchaseEntryObj.ProductName = stockEntryObj.ProductName;
                    purchaseEntryObj.ProductId = stockEntryObj.ProductId;

                    purchaseEntryObj.NumberOfProduct = stockEntryObj.NumberOfProduct;
                    purchaseEntryObj.EveryPackQuantity = stockEntryObj.EveryPackQuantity;

                    purchaseEntryObj.ExtraQuantity = stockEntryObj.ExtraQuantity;
                    purchaseEntryObj.SalableQuantity = stockEntryObj.SalableQuantity;

                    purchaseEntryObj.ItemPrice = stockEntryObj.ItemPrice;
                    purchaseEntryObj.TotalPrice = stockEntryObj.TotalPrice;

                    purchaseEntryObj.InvoiceNo = invoiceNoTextbox.Text;
                    purchaseEntryObj.SystemSerialNo = systemSerialNoTextbox.Text;
                    purchaseEntryObj.PurchaseDate = Convert.ToDateTime(StockEntryDate.Text);
                    purchaseEntryObj.PurchaserInfo = purchaserInfoTextBox.Text;
                    purchaseEntryList.Add(purchaseEntryObj);
                }
                inventorymasterEntryManagerObj.SaveStockDetails(purchaseEntryList);
                inventorymasterEntryManagerObj.UpdateStock(purchaseEntryList);
                MessageBox.Show("Purchase Successful Insert ", "Successful Entry");
                ClearSave();
                LoadAllProductMasterEntry();
                MessageBoxResult result = MessageBox.Show("Are you sure want to print this Document?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    StockEntrySlipPrint();
                }
                systemSerialNoTextbox.Text = "";
                LoadSystemSerialNumber();
            }
            catch (FormatException)
            {
                MessageBox.Show("Empty Invoice Or Date Please Check", "Please Fillup Required Field");
            }
            
        }

        private void StockEntrySlipPrint()
        {
            string Slip = "";
            Slip = systemSerialNoTextbox.Text;
            purchaseEntryList = new List<PurchaseEntry>();
            PurchaseEntry obj = new PurchaseEntry();
            purchaseEntryList = inventorymasterEntryManagerObj.GetPurchageEntrySlip(Slip);
            _RPurchageEntryList.Clear();
            foreach (PurchaseEntry p in purchaseEntryList)
            {
                RInventoryPurchageEntry printSlipReportInfo = new RInventoryPurchageEntry();

                printSlipReportInfo.Id = p.Id;
                printSlipReportInfo.InvoiceNo = p.InvoiceNo;
                printSlipReportInfo.SystemSerialNo = p.SystemSerialNo;

                printSlipReportInfo.ItemPrice = (decimal)p.ItemPrice;
                printSlipReportInfo.ProductName = p.ProductName;
                printSlipReportInfo.SalableQuantity = (decimal)p.SalableQuantity;
                printSlipReportInfo.NumberOfProduct = (decimal)p.NumberOfProduct;
                printSlipReportInfo.EveryPackQuantity = (decimal)p.EveryPackQuantity;
                printSlipReportInfo.ExtraQuantity = (decimal)p.ExtraQuantity;


                printSlipReportInfo.PurchaseDate = (DateTime)p.PurchaseDate;
                printSlipReportInfo.TotalPrice = (decimal)p.TotalPrice;

                printSlipReportInfo.UnitType = p.UnitType;
                printSlipReportInfo.BrandName = p.BrandName;
                printSlipReportInfo.TotalPrice = (decimal)p.TotalPrice;
                printSlipReportInfo.PurchaserInfo = p.PurchaserInfo;

                printSlipReportInfo.OrganizationName = p.OrganizationName;
                printSlipReportInfo.OrganizationAddress = p.OrganizationAddress;
                printSlipReportInfo.OrganizationMobile = p.OrganizationMobile;


                _RPurchageEntryList.Add(printSlipReportInfo);

            }


            if (_RPurchageEntryList.Count > 0)
            {
                PurchageEntryReport report = new PurchageEntryReport();
                ReportUtility.Display_report(report, _RPurchageEntryList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void RemoveSelectedItemContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (stockEntryListview.SelectedIndex != null)
            {
                stockEntryListview.Items.RemoveAt(stockEntryListview.Items.IndexOf(stockEntryListview.SelectedItem));
            }
        }
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearSave();
            AddClear();
        }

        private void AddClear()
        {
            productNameTextBox.Text = "";
            productIdTextBox.Text = "";
            categoryNameTextBox.Text = "";
            categoryIdTextBox.Text = "";
            brandNameTextbox.Text = "";
            brandIdTextbox.Text = "";
            productQuantityTextBox.Text = "";
            QuantityPerPackTextBox.Text = "";
            salableQuantityTextBox.Text = "";
            itemPriceTextBox.Text = "";
            totalPriceTextBox.Text = "";
            unitTypeNameTextbox.Text = "";
            unitTypeIdTextbox.Text = "";

        }

        private void ClearSave()
        {
            stockEntryListview.Items.Clear();
            invoiceNoTextbox.Text = "";
            StockEntryDate.SelectedDate = DateTime.Today;
            purchaserInfoTextBox.Text = "";
        }

        private void SlipContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string Slip = "";
            PurchaseEntry purchageEntryobj = (PurchaseEntry)purchageListDetailsList.SelectedItem;
            Slip = purchageEntryobj.SystemSerialNo;
            purchaseEntryList = new List<PurchaseEntry>();
            PurchaseEntry obj = new PurchaseEntry();
            purchaseEntryList = inventorymasterEntryManagerObj.GetPurchageEntrySlip(Slip);
            _RPurchageEntryList.Clear();
            foreach (PurchaseEntry p in purchaseEntryList)
            {
                RInventoryPurchageEntry printSlipReportInfo = new RInventoryPurchageEntry();

                printSlipReportInfo.Id = p.Id;
                printSlipReportInfo.InvoiceNo = p.InvoiceNo;
                printSlipReportInfo.SystemSerialNo = p.SystemSerialNo;

                printSlipReportInfo.ItemPrice = (decimal)p.ItemPrice;
                printSlipReportInfo.ProductName = p.ProductName;
                
                printSlipReportInfo.NumberOfProduct =(decimal)p.NumberOfProduct;
                printSlipReportInfo.SalableQuantity = (decimal)p.SalableQuantity;
                printSlipReportInfo.EveryPackQuantity = (decimal)p.EveryPackQuantity;
                printSlipReportInfo.ExtraQuantity = (decimal)p.ExtraQuantity;

                printSlipReportInfo.PurchaseDate = (DateTime)p.PurchaseDate;
                printSlipReportInfo.TotalPrice = (decimal)p.TotalPrice;

                printSlipReportInfo.UnitType = p.UnitType;
                printSlipReportInfo.BrandName = p.BrandName;
                printSlipReportInfo.TotalPrice = (decimal)p.TotalPrice;
                printSlipReportInfo.PurchaserInfo = p.PurchaserInfo;
                printSlipReportInfo.OrganizationName = p.OrganizationName;
                printSlipReportInfo.OrganizationAddress = p.OrganizationAddress;
                printSlipReportInfo.OrganizationMobile = p.OrganizationMobile;

                _RPurchageEntryList.Add(printSlipReportInfo);

            }


            if (_RPurchageEntryList.Count > 0)
            {
                PurchageEntryReport report = new PurchageEntryReport();
                ReportUtility.Display_report(report, _RPurchageEntryList, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", " No Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

       
    }
}
