using SIPI_SL.Report.UI.AttendenceSystem;
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



namespace SIPI_SL.UI.AttendenceSystem
{
    /// <summary>
    /// Interaction logic for AttendenceSystemDashBoardUI.xaml
    /// </summary>
    public partial class AttendenceSystemDashBoardUI : Window
    {


        private BMenuPermissionManager objBMenuPermission = new BMenuPermissionManager();

        public AttendenceSystemDashBoardUI()
        {
            InitializeComponent();
        }

        public AttendenceSystemDashBoardUI(EUser _eUserObj)
            : this()
        {
            LoadMenuInTree(_eUserObj.UserGroupId);
        }


        private void LoadMenuInTree(long userGroupId)
        {
            try
            {
                foreach (MenuItem it in AttendenceMainMenu.Items)
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

        private void attendenceSystemStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentAttendenceUI obj = new StudentAttendenceUI();
            obj.ShowDialog();
        }


        private void allStudentAttendencereport_Click(object sender, RoutedEventArgs e)
        {
            AttendenceSystemReport obj = new AttendenceSystemReport();
            obj.ShowDialog();
        }

        internal Menu GetAllAttendenceMainMenu()
        {
            return AttendenceMainMenu;
        }
    }
}
