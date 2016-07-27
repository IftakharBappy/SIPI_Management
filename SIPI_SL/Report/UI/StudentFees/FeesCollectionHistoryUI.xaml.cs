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
using BLL.Fees;
using ENTITY.Fees;
using ENTITY.Report.Fees;
using SIPI_SL.Report.Crystal.Fees;
using SIPI_SL.Report.Entity.Fees;
using BLL.Admission;
using ENTITY.Admission;
using SIPI_SL.Report.Crystal;

namespace SIPI_SL.Report.UI.StudentFees
{
    /// <summary>
    /// Interaction logic for FeesCollectionHistoryUI.xaml
    /// </summary>
    public partial class FeesCollectionHistoryUI : Window
    {
        FeesCollectionManager _manager = new FeesCollectionManager();
        List<FeesCollection> _FeesCollectionList;
        CampusManager _campusManager = new CampusManager();
        List<RstudentReportHistry> listStudentHistry  ;


        public FeesCollectionHistoryUI()
        {
            InitializeComponent();
            LoadAllCollection();
            LoadCampus();
        }
        private void LoadCampus()
        {
            CampusComboBox.Items.Clear();
            foreach (var userGroup in _campusManager.GetAllCampus())
            {
                CampusComboBox.Items.Add(userGroup);
            }
            CampusComboBox.DisplayMemberPath = "CampusName";
        }
        private void LoadAllCollection()
        {
            _FeesCollectionList = new List<FeesCollection>();
            _FeesCollectionList = _manager.GetAllCollection();
            feesCollectionlistView.Items.Clear();
            if (_FeesCollectionList.Count > 0)
            {
                foreach (var item in _FeesCollectionList)
                {
                    feesCollectionlistView.Items.Add(item);
                }
            }
        }

        private void getStudentPopupButton_Click(object sender, RoutedEventArgs e)
        {

            _FeesCollectionList = new List<FeesCollection>();
            DateTime startDate = Convert.ToDateTime(startDateDatepicker.SelectedDate);
            DateTime endDate = Convert.ToDateTime(endDateDatepicker.SelectedDate);
            int campus = ((Campus)CampusComboBox.SelectedItem).Id;
            _FeesCollectionList = _manager.GetCollection(startDate, endDate, campus);
            feesCollectionlistView.Items.Clear();
            if (_FeesCollectionList.Count > 0)
            {
                foreach (var item in _FeesCollectionList)
                {
                    feesCollectionlistView.Items.Add(item);
                }
            }
        }

        private void EditThanaContextMenu_Click(object sender, RoutedEventArgs e)
        {
            FeesCollection obj = new FeesCollection();
            obj = ((FeesCollection)feesCollectionlistView.SelectedItem);
            List<RStudentFees> reportList = _manager.GetCollectionReportDetails(obj);

            List<StudentFeesReport> reportListObj = new List<StudentFeesReport>();

            foreach (RStudentFees item in reportList)
            {
                StudentFeesReport _obj = new StudentFeesReport();
                _obj.InstituteName = item.InstituteName;
                _obj.InstituteAddress = item.InstituteAddress;
                _obj.StudentName = item.StudentName;
                _obj.Department = item.Department;
                _obj.Semester = item.Semester;
                _obj.FeesDetailsName = item.FeesDetailsName;
                _obj.FeesDetailsAmount = (int)item.FeesDetailsAmount;
                _obj.ReceiveAmount = (int)item.ReceiveAmount;
                _obj.ReceiveDate = (DateTime)item.ReceiveDate;
                _obj.StudentRoll = item.StudentRoll;
                reportListObj.Add(_obj);
            }

            if (reportListObj.Count > 0)
            {
                moneyReceiptCrystalReport employeeInfoCrystalReport = new moneyReceiptCrystalReport();
                ReportUtility.Display_report(employeeInfoCrystalReport, reportListObj, this);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<RstudentReportHistry> reportListObj = new List<RstudentReportHistry>();
                foreach (FeesCollection item in _FeesCollectionList)
                {
                    RstudentReportHistry _obj = new RstudentReportHistry();

                    _obj.InstituteName = item.CampusName;
                    //_obj.InstituteAddress = item.c;
                    _obj.StudentName = item.StudentName;
                    _obj.Department = item.Department;
                    _obj.Semester = item.Semester;
                    _obj.FeesDetailsName = item.FeesDetailsName;
                    _obj.ReceiveAmount = (int)item.ReceiveAmount;
                    _obj.ReceiveDate =(DateTime)item.CollectionDate;
                    _obj.CampusName = item.CampusName;
                    reportListObj.Add(_obj);
                }

                if (reportListObj.Count > 0)
                {
                    StudentRepotCrystalHistry employeeInfoCrystalReport = new StudentRepotCrystalHistry();
                    ReportUtility.Display_report(employeeInfoCrystalReport, reportListObj, this);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
