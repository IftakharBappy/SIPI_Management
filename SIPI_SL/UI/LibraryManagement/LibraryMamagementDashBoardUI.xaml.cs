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

namespace SIPI_SL.UI.LibraryManagement
{
    /// <summary>
    /// Interaction logic for LibraryMamagementDashBoardUI.xaml
    /// </summary>
    public partial class LibraryMamagementDashBoardUI : Window
    {
        public LibraryMamagementDashBoardUI()
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
                        case "BookIssue":
                            BookIssue _BookIssue = new BookIssue();
                            _BookIssue.Owner = this;
                            _BookIssue.Show();
                            break;
                        case "BookEntry":
                            BookEntry _BookEntry = new BookEntry();
                            _BookEntry.Owner = this;
                            _BookEntry.Show();
                            break;
                        case "BookReturnUI":
                            BookReturnUI _BookReturn = new BookReturnUI();
                            _BookReturn.Owner = this;
                            _BookReturn.Show();
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
        private void bookEntry_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("BookEntry");
        }

        private void bookIssue_Click(object sender, RoutedEventArgs e)
        {

            ShowWindow("BookIssue");
        }

        private void bookReturn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("BookReturnUI");
        }
    }
}
