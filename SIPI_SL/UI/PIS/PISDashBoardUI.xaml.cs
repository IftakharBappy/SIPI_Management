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

namespace SIPI_SL.UI.PIS
{
    /// <summary>
    /// Interaction logic for PISDashBoardUI.xaml
    /// </summary>
    public partial class PISDashBoardUI : Window
    {

        private BMenuPermissionManager objBMenuPermission = new BMenuPermissionManager();
        public PISDashBoardUI()
        {
            InitializeComponent();
        }

        public PISDashBoardUI(long userGroupId)
            : this()
        {
            LoadMenuInTree(userGroupId);
        }

        private void LoadMenuInTree(long userGroupId)
        {
            try
            {
                foreach (MenuItem it in pisMenu.Items)
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
       

        internal Menu GetAllPisMenu()
        {
            return pisMenu;
        }

        private void viewLog_Click(object sender, RoutedEventArgs e)
        {
            //Window1 log = new Window1();
            //log.Show();
        }

        private void mnuCategorySetup_Click(object sender, RoutedEventArgs e)
        {
            CategoryUI categoryObj = new CategoryUI();
            categoryObj.Show();
        }

        private void mnuCategoryEmpSetup_Click(object sender, RoutedEventArgs e)
        {
            CategoryEmployeeUI categoryEmployeeObj = new CategoryEmployeeUI();
            categoryEmployeeObj.Show();
        }

        private void mnuCategorySalarySetup_Click(object sender, RoutedEventArgs e)
        {
            CategorySalaryUI categorySalaryObj = new CategorySalaryUI();
            categorySalaryObj.Show();
        }

        private void mnuSectionSetup_Click(object sender, RoutedEventArgs e)
        {
            SectionUI  _SectionUIObj = new SectionUI();
            _SectionUIObj.Show();
        }

        private void mnuEmp_Click(object sender, RoutedEventArgs e)
        {
            EmployeeInfoUI empObj = new EmployeeInfoUI();
            empObj.Show();

        }

        private void mnuDepartmentSetup_Click(object sender, RoutedEventArgs e)
        {
            DepartmentUI departmentObj = new DepartmentUI();
            departmentObj.Show();
        }

        private void mnuGradeSetup_Click(object sender, RoutedEventArgs e)
        {
            GradeUI gradeObj = new GradeUI();
            gradeObj.Show();
        }
    }
}
