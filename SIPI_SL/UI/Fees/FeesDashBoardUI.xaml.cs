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
using BLL.Login;
using ENTITY.Login;
using SIPI_SL.Report.UI.StudentFees;

namespace SIPI_SL.UI.Fees
{
    /// <summary>
    /// Interaction logic for FeesDashBoardUI.xaml
    /// </summary>
    public partial class FeesDashBoardUI : Window
    {
        private BMenuPermissionManager objBMenuPermission = new BMenuPermissionManager();


        public FeesDashBoardUI()
        {
            InitializeComponent();
        }

        public FeesDashBoardUI(EUser _eUserObj)
            : this()
        {
            LoadMenuInTree(_eUserObj.UserGroupId);
        }

        private void LoadMenuInTree(long userGroupId)
        {
            try
            {
                foreach (MenuItem it in feesMenu.Items)
                {
                    if (objBMenuPermission.IsExistParentMenu(it.Name, userGroupId))
                    {
                        ProcessTree(it, userGroupId);
                    }
                    else
                    {
                        it.Visibility = Visibility.Collapsed;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Available Menu", "Report", MessageBoxButton.OK, MessageBoxImage.Error);
            };
        }
        private void ProcessTree(MenuItem it, long userGroupId)
        {
            foreach (MenuItem obj in it.Items)
            {
                if (objBMenuPermission.IsExistChildMenu(obj.Name, userGroupId))
                {
                    ProcessTree(obj, userGroupId);
                }
                else
                {
                    obj.Visibility = Visibility.Collapsed;
                }
            }
        }



        private Window[] childWindows;
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
                        case "FeesDetailsUI":
                            FeesDetailsUI employeeInfo = new FeesDetailsUI();
                            employeeInfo.Owner = this;
                            employeeInfo.Show();
                            break;
                        case "SetupUpFeesUI":
                            SetupUpFeesUI calendarSetup = new SetupUpFeesUI();
                            calendarSetup.Owner = this;
                            calendarSetup.Show();
                            break;
                        case "FeesDiscountUI":
                            FeesDiscountUI _FeesDiscountUI = new FeesDiscountUI();
                            _FeesDiscountUI.Owner = this;
                            _FeesDiscountUI.Show();
                            break;
                        case "FeesCollectionUI":
                            FeesCollectionUI _FeesCollectionUI = new FeesCollectionUI();
                            _FeesCollectionUI.Owner = this;
                            _FeesCollectionUI.Show();
                            break;

                        case "FeesCollectionHistoryUI":
                            FeesCollectionHistoryUI _FeesCollectionHistoryUI = new FeesCollectionHistoryUI();
                            _FeesCollectionHistoryUI.Owner = this;
                            _FeesCollectionHistoryUI.Show();
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
        private void mnuFeesDetailsSetup_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("FeesDetailsUI");
            
        }

        private void mnuAssignFeesSetup_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("SetupUpFeesUI");
            
        }

        private void DiscountFees_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("FeesDiscountUI");
           
        }
         
        private void feesCollection_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("FeesCollectionUI");
           
        }

        internal Menu GetAllfeesMenuMenu()
        {
            return feesMenu;
        }

        private void collectionHistory_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("FeesCollectionHistoryUI");
        }
    }
}
