using SIPI_SL.Report.UI.Admission;
using SIPI_SL.Report.UI.AttendenceSystem;
using SIPI_SL.Report.UI.CourseManagement;
using SIPI_SL.Report.UI.Routine;
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
using ENTITY.Login;
using BLL.Login;

namespace SIPI_SL.UI.ReportManager
{
    /// <summary>
    /// Interaction logic for ReportDashBoard.xaml
    /// </summary>
    public partial class ReportDashBoard : Window
    {
        private BMenuPermissionManager objBMenuPermission = new BMenuPermissionManager();
        public ReportDashBoard()
        {
            InitializeComponent();
        }

        public ReportDashBoard(EUser _eUserObj)
            : this()
        {
            LoadMenuInTree(_eUserObj.UserGroupId);
        }

        private void LoadMenuInTree(long userGroupId)
        {
            try
            {
                foreach (MenuItem it in reportMainMenu.Items)
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

        private void admissionInfo_Click(object sender, RoutedEventArgs e)
        {
            StudentAdmissionReport obj = new StudentAdmissionReport();
            obj.BoardReport.Content = "Student Info";
            obj.ShowDialog();
        }

        private void studentRepostBoard_Click(object sender, RoutedEventArgs e)
        {
            StudentAdmissionReport obj = new StudentAdmissionReport();
            obj.ShowDialog();
        }

        private void AttendenceReport_Click(object sender, RoutedEventArgs e)
        {
            AttendenceSystemReport obj = new AttendenceSystemReport();
            obj.ShowDialog();
        }

        private void courseDetails_Click(object sender, RoutedEventArgs e)
        {
            CourseReportUI obj = new CourseReportUI();
            obj.ShowDialog();
        }

        private void departmentWaiseRoutine_Click(object sender, RoutedEventArgs e)
        {
            RoutineReposrt obj = new RoutineReposrt();
            obj.previewReportButton_department.Content = "Department wise Routine";
            obj.ShowDialog();
        }

        private void semesterWaiseRoutine_Click(object sender, RoutedEventArgs e)
        {
            RoutineReposrt obj = new RoutineReposrt();
            obj.previewReportButton_department.Content = "Semester wise Routine";
            obj.ShowDialog();
        }


        internal Menu GetAllreportMainMenu()
        {
            return reportMainMenu;
        }
    }
}
