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

namespace SIPI_SL.UI.ScholarshipManagement
{
    /// <summary>
    /// Interaction logic for ScholarshipMamagementDashBoardUI.xaml
    /// </summary>
    public partial class ScholarshipMamagementDashBoardUI : Window
    {
        public ScholarshipMamagementDashBoardUI()
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
                        case "AccademicScholarshipApplicationUI":
                            AccademicScholarshipApplicationUI _ccademicScholarshipApplication = new AccademicScholarshipApplicationUI();
                            _ccademicScholarshipApplication.Owner = this;
                            _ccademicScholarshipApplication.Show();
                            break;
                        case "OldScholarsListUI":
                            OldScholarsListUI _oldScholarsListUI = new OldScholarsListUI();
                            _oldScholarsListUI.Owner = this;
                            _oldScholarsListUI.Show();
                            break;
                        case "OtherScholarshipScoreUI":
                            OtherScholarshipScoreUI _otherScholarshipScoreUI = new OtherScholarshipScoreUI();
                            _otherScholarshipScoreUI.Owner = this;
                            _otherScholarshipScoreUI.Show();
                            break;
                        case "OthersScholarshipApplicationUI":
                            OthersScholarshipApplicationUI _othersScholarshipApplicationUI = new OthersScholarshipApplicationUI();
                            _othersScholarshipApplicationUI.Owner = this;
                            _othersScholarshipApplicationUI.Show();
                            break;
                        case "ScholarshipCriteriaUI":
                            ScholarshipCriteriaUI _scholarshipCriteriaUI = new ScholarshipCriteriaUI();
                            _scholarshipCriteriaUI.Owner = this;
                            _scholarshipCriteriaUI.Show();
                            break;
                        case "ScholarshipScoreProvideUI":
                            ScholarshipScoreProvideUI _scholarshipScoreProvideUI = new ScholarshipScoreProvideUI();
                            _scholarshipScoreProvideUI.Owner = this;
                            _scholarshipScoreProvideUI.Show();
                            break;
                        case "SelectedScholarsListUI":
                            SelectedScholarsListUI _selectedScholarsListUI = new SelectedScholarsListUI();
                            _selectedScholarsListUI.Owner = this;
                            _selectedScholarsListUI.Show();
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

        private void accademicScholarshipForm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("AccademicScholarshipApplicationUI");
        }

        private void OthersScholarshipForm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("OthersScholarshipApplicationUI");
        }

        private void accademicscholarshipScore_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("ScholarshipScoreProvideUI");
        }

        private void OthersScholarshipScore_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("OtherScholarshipScoreUI");

        }

        private void scholarshipCriteria_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("ScholarshipCriteriaUI");

        }

        private void selectedScholarsList_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("SelectedScholarsListUI");

        }

        private void precviousScholarsList_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("OldScholarsListUI");

        }

        //private void bookIssue_Click(object sender, RoutedEventArgs e)
        //{

        //    ShowWindow("BookIssue");
        //}


        internal Menu GetAllScholarshipMenu()
        {
            return ScholarshipMenu;
        }
    }
}
