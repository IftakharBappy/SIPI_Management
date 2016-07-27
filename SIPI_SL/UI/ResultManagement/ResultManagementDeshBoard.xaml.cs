using SIPI_SL.Report.UI.ResultManagement;
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

namespace SIPI_SL.UI.ResultManagement
{
    /// <summary>
    /// Interaction logic for ResultManagementDeshBoard.xaml
    /// </summary>
    public partial class ResultManagementDeshBoard : Window
    {
        public ResultManagementDeshBoard()
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
                        case "CourseAssignToStudentUI":
                            CourseAssignToStudentUI _CoueseAssignObj = new CourseAssignToStudentUI();
                            _CoueseAssignObj.Owner = this;
                            _CoueseAssignObj.Show();
                            break;
                        case "MarksDistributionToStudentUI":
                            MarksDistributionToStudentUI _marksDistributionUI = new MarksDistributionToStudentUI();
                            _marksDistributionUI.Owner = this;
                            _marksDistributionUI.Show();
                            break;
                        case "CourseAssignToTracherUI":
                            MarksDistributionToStudentUI _CourseAssignToTeacher = new MarksDistributionToStudentUI();
                            _CourseAssignToTeacher.Owner = this;
                            _CourseAssignToTeacher.Show();
                            break;
                        case "ResultManagementReportUI":
                            ResultManagementReportUI _resultManagementUI = new ResultManagementReportUI();
                            _resultManagementUI.Owner = this;
                            _resultManagementUI.Show();
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
        private void studentAssign_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("CourseAssignToStudentUI");
        }

        private void marksDistribution_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("MarksDistributionToStudentUI");
        }

        private void tracherAssign_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("CourseAssignToTracherUI");
        }

        private void marksSeetRepost_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("ResultManagementReportUI");  
        }

        internal Menu GetAllResultMenu()
        {
            return ResultMainMenue;
        }
    }
}
