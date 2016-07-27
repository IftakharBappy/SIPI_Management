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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL.Login;
using ENTITY.Login;
using SIPI_SL.UI.Admission;
using SIPI_SL.UI.Fees;
using SIPI_SL.UI.Login;
using SIPI_SL.UI.PIS;
using SIPI_SL.UI.StudentManagement;
using SIPI_SL.UI.AttendenceSystem;
using SIPI_SL.UI.ReportManager;
using SIPI_SL.UI.ResultManagement;
using SIPI_SL.UI.SMSManagement;
using SIPI_SL.UI.LibraryManagement;
using SIPI_SL.UI.ScholarshipManagement;
using SIPI_SL.UI.InventoryManagement;

namespace SIPI_SL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EUser anUser = new EUser();

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(EUser objUser)
            : this()
        {
            anUser = objUser;

            if (objUser.UserGroupName != "Super Admin")
            {
                DashBoardAdmissionButton.IsEnabled = false;
                DashBoardAccountButton.IsEnabled = false;
                DashBoardHRandPayrollButton.IsEnabled = false;

                DashBoardResultButton.IsEnabled = false;
                DashBoardAttendenceButton.IsEnabled = false;
                DashBoardStudentButton.IsEnabled = false;

                DashBoardCourseButton.IsEnabled = false;
                DashBoardReportButton.IsEnabled = false;
                dashBoardSecurityButton.IsEnabled = false;

                DashBoardScolarshipButton.IsEnabled = false;
                DashBoardJobButton.IsEnabled = false;

                LoadUserRoleControl();
            }
        }

        private void LoadUserRoleControl()
        {
            try
            {
                BSModulePermissionManager objBModule = new BSModulePermissionManager();
                List<ESModulePermission> listModule = objBModule.GetPermittedModule(anUser.UserGroupId);
                foreach (var item in listModule)
                {
                    if (item.ModuleName == "Admission")
                    {
                        DashBoardAdmissionButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Account Management")
                    {
                        dashBoardSecurityButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "HR & Payroll")
                    {
                        DashBoardHRandPayrollButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Result Management")
                    {
                        DashBoardResultButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Attendence")
                    {
                        DashBoardAttendenceButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Student")
                    {
                        DashBoardStudentButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Course")
                    {
                        DashBoardCourseButton.IsEnabled = true;
                    }

                    else if (item.ModuleName == "Report")
                    {
                        DashBoardReportButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Security")
                    {
                        dashBoardSecurityButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Scholarship")
                    {
                        DashBoardScolarshipButton.IsEnabled = true;
                    }
                    else if (item.ModuleName == "Job Placement")
                    {
                        DashBoardJobButton.IsEnabled = true;
                    }
                }
            }
            catch (Exception)
            {
            }  
        }

        private void dashBoardSecurityButton_Click(object sender, RoutedEventArgs e)
        {
            SecurityDashBoardUI securityDashBoard;
            if (anUser.UserGroupName == "Super Admin")
            {
                securityDashBoard = new SecurityDashBoardUI();
            }
            else
            {
                securityDashBoard = new SecurityDashBoardUI(anUser.UserGroupId);
            }
            securityDashBoard.ShowDialog();
        }

        private void searchPatientButton_Click(object sender, RoutedEventArgs e)
        {
            PISDashBoardUI pisDashBoard;
            if (anUser.UserGroupName == "Super Admin")
            {
                pisDashBoard = new PISDashBoardUI();
            }
            else
            {
                pisDashBoard = new PISDashBoardUI(anUser.UserGroupId);
            }
            pisDashBoard.ShowDialog();
        }

        private void surgeryButton_Click(object sender, RoutedEventArgs e)
        {
            FeesDashBoardUI feeDashBoard;
            if (anUser.UserGroupName == "Super Admin")
            {
                feeDashBoard = new FeesDashBoardUI();
            }
            else
            {
                feeDashBoard = new FeesDashBoardUI(anUser);
            }
            feeDashBoard.ShowDialog();
           
        }

        private void newPatientMainButton_Click(object sender, RoutedEventArgs e)
        {
            AdmissionDashBoard pisDashBoard;
            if (anUser.UserGroupName == "Super Admin")
            {
                pisDashBoard = new AdmissionDashBoard();
            }
            else
            {
                pisDashBoard = new AdmissionDashBoard(anUser);
            }
            pisDashBoard.ShowDialog();
        }

        

        private void courseManagementButtonClick(object sender, RoutedEventArgs e)
        {
            CourseDashBoardUI CourseDashBoard;
            if (anUser.UserGroupName == "Super Admin")
            {
                CourseDashBoard = new CourseDashBoardUI();
            }
            else
            {
                CourseDashBoard = new CourseDashBoardUI(anUser);
            }
            CourseDashBoard.ShowDialog();


        }

        private void mainPatientHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            AttendenceSystemDashBoardUI AttendenceDashBoard;
            if (anUser.UserGroupName == "Super Admin")
            {
                AttendenceDashBoard = new AttendenceSystemDashBoardUI();
            }
            else
            {
                AttendenceDashBoard = new AttendenceSystemDashBoardUI(anUser);
            }
            AttendenceDashBoard.ShowDialog();
        }

        private void dashBoardReportButton_Click(object sender, RoutedEventArgs e)
        {
            ReportDashBoard ReportDashBoardObj;
            if (anUser.UserGroupName == "Super Admin")
            {
                ReportDashBoardObj = new ReportDashBoard();
            }
            else
            {
                ReportDashBoardObj = new ReportDashBoard(anUser);
            }
            ReportDashBoardObj.ShowDialog();

        }

        private void logOut_click(object sender, RoutedEventArgs e)
        {

        }

        private void DashBoardResultButton_Click(object sender, RoutedEventArgs e)
        {
            ResultManagementDeshBoard obj = new ResultManagementDeshBoard();
            obj.ShowDialog();
        }

        private void smsManager_Click(object sender, RoutedEventArgs e)
        {
            SMSManagementDeshboard obj = new SMSManagementDeshboard();
            obj.ShowDialog();
        }

        private void libertyManagementButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryMamagementDashBoardUI obj = new LibraryMamagementDashBoardUI();
            obj.ShowDialog();
        }

        private void DashBoardScolarshipButton_Click(object sender, RoutedEventArgs e)
        {
            ScholarshipMamagementDashBoardUI obj = new ScholarshipMamagementDashBoardUI();
            obj.ShowDialog();
        }

        private void inventoryManagementButton_Click(object sender, RoutedEventArgs e)
        {
            InventoryManagementDashBoardUI obj = new InventoryManagementDashBoardUI();
            obj.ShowDialog();
        }

      
    }
}
