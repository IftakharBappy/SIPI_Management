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
using SIPI_SL.Report.Crystal.Admission;
using SIPI_SL.Report.UI.Admission;
using SIPI_SL.UI.StudentManagement;
using ENTITY.Login;

namespace SIPI_SL.UI.Admission
{
    /// <summary>
    /// Interaction logic for AdmissionDashBoard.xaml
    /// </summary>
    public partial class AdmissionDashBoard : Window
    {
        private BMenuPermissionManager objBMenuPermission = new BMenuPermissionManager();
        public AdmissionDashBoard()
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

                        case "DepartmentUI":
                            DepartmentUI _departmentobj = new DepartmentUI();
                            _departmentobj.Owner = this;
                            _departmentobj.Show();
                            break;
                        case "AdmissonOfficeUI":
                            AdmissonOfficeUI _admissonOfficeObj = new AdmissonOfficeUI();
                            _admissonOfficeObj.Owner = this;
                            _admissonOfficeObj.Show();
                            break;
                        case "CampusUI":
                            CampusUI _CampusUIObj = new CampusUI();
                            _CampusUIObj.Owner = this;
                            _CampusUIObj.Show();
                            break;
                        case "StudentAdmissionInformation":
                            StudentAdmissionInformation _studentAdmissionInformationObj = new StudentAdmissionInformation();
                            _studentAdmissionInformationObj.Owner = this;
                            _studentAdmissionInformationObj.Show();
                            break;

                        case "BatchUI":
                            BatchUI _batchUIObj = new BatchUI();
                            _batchUIObj.Owner = this;
                            _batchUIObj.Show();
                            break;
                        case "ReligionUI":
                            ReligionUI _religionUIObj = new ReligionUI();
                            _religionUIObj.Owner = this;
                            _religionUIObj.Show();
                            break;
                        case "DistrictUI":
                            DistrictUI _DistrictUIObj = new DistrictUI();
                            _DistrictUIObj.Owner = this;
                            _DistrictUIObj.Show();
                            break;
                        case "ThanaUI":
                            ThanaUI _ThanaUIObj = new ThanaUI();
                            _ThanaUIObj.Owner = this;
                            _ThanaUIObj.Show();
                            break;

                        case "PostUI":
                            PostUI _PostUIObj = new PostUI();
                            _PostUIObj.Owner = this;
                            _PostUIObj.Show();
                            break;
                        case "BloodGroupUI":
                            BloodGroupUI _BloodGroupUIObj = new BloodGroupUI();
                            _BloodGroupUIObj.Owner = this;
                            _BloodGroupUIObj.Show();
                            break;
                        case "SIPI_ProgramUI":
                            SIPI_ProgramUI _SIPI_ProgramUIObj = new SIPI_ProgramUI();
                            _SIPI_ProgramUIObj.Owner = this;
                            _SIPI_ProgramUIObj.Show();
                            break;

                        case "SIPI_DepartmentUI":
                            SIPI_DepartmentUI _SIPI_DepartmentUIObj = new SIPI_DepartmentUI();
                            _SIPI_DepartmentUIObj.Owner = this;
                            _SIPI_DepartmentUIObj.Show();
                            break;
                        case "CourseUI":
                            CourseUI _CourseUIObj = new CourseUI();
                            _CourseUIObj.Owner = this;
                            _CourseUIObj.Show();
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

        public AdmissionDashBoard(EUser _eUserObj)
            : this()
        {
            LoadMenuInTree(_eUserObj.UserGroupId);
        }

        private void LoadMenuInTree(long userGroupId)
        {
            try
            {
                foreach (MenuItem it in AdmissionMainMenu.Items)
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowWindow("DepartmentUI");

        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ShowWindow("AdmissonOfficeUI");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ShowWindow("CampusUI");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ProgramUI programUIobj = new ProgramUI();
            programUIobj.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ShowWindow("StudentAdmissionInformation");

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ShowWindow("BatchUI");

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ShowWindow("ReligionUI");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ShowWindow("DistrictUI");

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ShowWindow("ThanaUI");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ShowWindow("PostUI");

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.ShowDialog();

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ShowWindow("BloodGroupUI");
        }

        ////// manue

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ShowWindow("PostUI");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ShowWindow("ThanaUI");

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            ShowWindow("DistrictUI");


        }


        ////// Pre setup

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            ShowWindow("SIPI_ProgramUI");

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ShowWindow("SIPI_DepartmentUI");

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            ShowWindow("CampusUI");

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            ShowWindow("BatchUI");
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            ShowWindow("AdmissonOfficeUI");
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            ShowWindow("ReligionUI");
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            ShowWindow("BloodGroupUI");
        }


        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            ShowWindow("StudentAdmissionInformation");
        }


        private void MenuItem_Reporting_Click(object sender, RoutedEventArgs e)
        {
            StudentAdmissionReport obj = new StudentAdmissionReport();
            obj.BoardReport.Content = "Student Info";
            obj.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("CourseUI");

        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            StudentAdmissionReport obj = new StudentAdmissionReport();
            obj.ShowDialog();
        }


        internal Menu GetAllAdmissionMainMenu()
        {
            return AdmissionMainMenu;
        }



    }
}
