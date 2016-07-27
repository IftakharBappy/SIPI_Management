using SIPI_SL.Report.UI.CourseManagement;
using SIPI_SL.Report.UI.Routine;
using SIPI_SL.UI.LibraryManagement;
using SIPI_SL.UI.TeacherManagement;
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

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for CourseDashBoardUI.xaml
    /// </summary>
    public partial class CourseDashBoardUI : Window
    {
        private BMenuPermissionManager objBMenuPermission = new BMenuPermissionManager();

        public CourseDashBoardUI()
        {
            InitializeComponent();
        }
        public CourseDashBoardUI(EUser _eUserObj)
            : this()
        {
            LoadMenuInTree(_eUserObj.UserGroupId);
        }

        private void LoadMenuInTree(long userGroupId)
        {
            try
            {
                foreach (MenuItem it in courseMainMenu.Items)
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



        private void courseEntrySetup_Click(object sender, RoutedEventArgs e)
        {
            CourseUI pisDashBoard = new CourseUI();
            pisDashBoard.ShowDialog();
        }

        private void routineGenerate_Click(object sender, RoutedEventArgs e)
        {
            ClassRoutineCreateUI obj = new ClassRoutineCreateUI();
            obj.ShowDialog();

        }

        private void teacherEntry_Click(object sender, RoutedEventArgs e)
        {
            TeacherInfoUI Obj = new TeacherInfoUI();
            Obj.ShowDialog();
        }

        private void routineRepost_Click(object sender, RoutedEventArgs e)
        {
            RoutineReposrt Obj = new RoutineReposrt();
            Obj.ShowDialog();
        }

        private void timeSchedule_Click(object sender, RoutedEventArgs e)
        {
            ClassPeriodUI Obj = new ClassPeriodUI();
            Obj.ShowDialog();
        }

        private void library_Click(object sender, RoutedEventArgs e)
        {
            LibraryMamagementDashBoardUI obj = new LibraryMamagementDashBoardUI();
            obj.ShowDialog();
        }

        private void Year_DayClick(object sender, RoutedEventArgs e)
        {
            DayUI obj = new DayUI();
            obj.ShowDialog();
        }

        private void courseRepost_Click(object sender, RoutedEventArgs e)
        {
            CourseReportUI obj = new CourseReportUI();
            obj.ShowDialog();
        }


        internal Menu GetAllcourseMainMenu()
        {
            return courseMainMenu;
        }

        private void semesterEntry_Click(object sender, RoutedEventArgs e)
        {
            SemesterUI obj = new SemesterUI();
            obj.ShowDialog();
        }


        
    }
}
