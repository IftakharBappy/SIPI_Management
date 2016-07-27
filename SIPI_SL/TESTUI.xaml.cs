using SIPI_SL.UI.Admission;
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


using System.Windows.Navigation;
using SIPI_SL.Report.UI;
using SIPI_SL.Report.UI.Admission;
using SIPI_SL.UI.StudentManagement;
using SIPI_SL.Report.Crystal.Admission;



namespace SIPI_SL
{
    /// <summary>
    /// Interaction logic for TESTUI.xaml
    /// </summary>
    public partial class TESTUI : Window
    {
        public TESTUI()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            DepartmentUI obj = new DepartmentUI();
            obj.Show();

        }

       

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AdmissonOfficeUI admissionOfficeObj = new AdmissonOfficeUI();
            admissionOfficeObj.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CampusUI campusInfo = new CampusUI();
            campusInfo.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ProgramUI programUIobj = new ProgramUI();
            programUIobj.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            StudentAdmissionInformation studentAdmissionInformationobj = new StudentAdmissionInformation();
            studentAdmissionInformationobj.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            BatchUI batchUIObj = new BatchUI();
            batchUIObj.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ReligionUI religionUIObj = new ReligionUI();
            religionUIObj.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            DistrictUI districtUIObj = new DistrictUI();
            districtUIObj.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ThanaUI thanaUIObj = new ThanaUI();
            thanaUIObj.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            PostUI postUIObj = new PostUI();
            postUIObj.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

            BloodGroupUI bloodgroupUIObj = new BloodGroupUI();
            bloodgroupUIObj.Show();


        }

        ////// manue

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            PostUI postUIObj = new PostUI();
            postUIObj.Show();

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ThanaUI thanaUIObj = new ThanaUI();
            thanaUIObj.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            DistrictUI districtUIObj = new DistrictUI();
            districtUIObj.Show();

        }


        ////// Pre setup

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            SIPI_ProgramUI sipi_programUIobj = new SIPI_ProgramUI();
            sipi_programUIobj.Show();

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            SIPI_DepartmentUI obj = new SIPI_DepartmentUI();
            obj.Show();

        }
 
        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            CampusUI campusInfo = new CampusUI();
            campusInfo.Show();

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            BatchUI batchUIObj = new BatchUI();
            batchUIObj.Show();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            AdmissonOfficeUI admissionOfficeObj = new AdmissonOfficeUI();
            admissionOfficeObj.Show();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            ReligionUI religionUIObj = new ReligionUI();
            religionUIObj.Show();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            BloodGroupUI bloodgroupUIObj = new BloodGroupUI();
            bloodgroupUIObj.Show();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            BatchUI batchUIObj = new BatchUI();
            batchUIObj.Show();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            StudentAdmissionInformation studentAdmissionInformationobj = new StudentAdmissionInformation();
            studentAdmissionInformationobj.Show();
        }

 
        private void MenuItem_Reporting_Click(object sender, RoutedEventArgs e)
        {
            StudentAdmissionReport studentAdmissionReportViewerUIbj = new StudentAdmissionReport();
            studentAdmissionReportViewerUIbj.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            CourseUI courseUIObj = new CourseUI();
            courseUIObj.Show();
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            BanglaReportBoard boardReport = new BanglaReportBoard();
            

        }
    }
}
