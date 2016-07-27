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
    /// Interaction logic for UnitTypeDetailsUI.xaml
    /// </summary>
    public partial class UnitTypeDetailsUI : Window
    {
        UnitType _unittypeObj;
        InventoryManager inventoryManagerObj = new InventoryManager();
        List<UnitType> unitTypeList;
        public UnitTypeDetailsUI()
        {
            InitializeComponent();
            LoadAllUnitType(); 

        }

        private void Clear()
        {
            unitTypeDetailsTextBox.Clear();
            InventoryUnitTypeTextBox.Clear();
        }


        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            _unittypeObj = new UnitType();

            _unittypeObj.UnitTypeDetails = unitTypeDetailsTextBox.Text;
            _unittypeObj.InventoryUnitType = InventoryUnitTypeTextBox.Text;
            inventoryManagerObj.SaveUnitType(_unittypeObj);
            LoadAllUnitType();
            MessageBox.Show("Data insurted successfully");
        }

        private void LoadAllUnitType()
        {
            unitTypeList = new List<UnitType>();
            unitTypeList = inventoryManagerObj.LoadAllUnitType();
            UnitTypeListView.Items.Clear();
            if (unitTypeList.Count > 0)
            {
                foreach (var item in unitTypeList)
                {
                    UnitTypeListView.Items.Add(item);
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
