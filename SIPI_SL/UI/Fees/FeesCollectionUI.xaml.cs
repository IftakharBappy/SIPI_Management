using BLL.Fees;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.Fees;
using ENTITY.StudentManagement;
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
using SIPI_SL.Report.Entity;
using ENTITY.Report.Fees;
using BLL.Admission;
using SIPI_SL.Report.Entity.Fees;
using SIPI_SL.Report.Crystal.Fees;

namespace SIPI_SL.UI.Fees
{
    /// <summary>
    /// Interaction logic for FeesCollectionUI.xaml
    /// </summary>
    public partial class FeesCollectionUI : Window
    {
        StudentInfo _studentInfoObj = new StudentInfo();
        List<Semester> _semesterList;
        SemesterManager semesterManagerObj = new SemesterManager();
        List<FeesSetup> _feesSetupListObj = new List<FeesSetup>();
        List<FeesDetails> _feesDetailsListObj = new List<FeesDetails>();
        FeesCollectionManager _feesCollectionManagerObj = new FeesCollectionManager();
        CampusManager _campusManager = new CampusManager();
        string caption = "Setup Fees";
        int? campusId = 0;
        public FeesCollectionUI()
        {
            InitializeComponent();
            LoadSemesterCombobox();
            LoadYear();
            collectionDateDatePicker.SelectedDate = DateTime.Now;
            
        }

        

        private void LoadSemesterCombobox()
        {
            _semesterList = new List<Semester>();
            semesterCombobax.Items.Clear();
            _semesterList = semesterManagerObj.GetAllSemester();
            foreach (Semester a in _semesterList)
            {
                semesterCombobax.ItemsSource = _semesterList;
            }
        }


        private void getStudentPopupButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Fees.StudentListUI _getstudentInfoUI = new UI.Fees.StudentListUI();
            if (_getstudentInfoUI.ShowDialog() == true)
            {
                this._studentInfoObj = _getstudentInfoUI.studentInofListView.SelectedItem as StudentInfo;
                nameTextBox.Text = this._studentInfoObj.ApplicantName;
                DepartmentTextBox.Text = this._studentInfoObj.DepartmentName;
                studentIdTextBox.Text = Convert.ToString(this._studentInfoObj.Id);
                campusId = this._studentInfoObj.CampusId;
                _getstudentInfoUI.Close();
            }
        }

        private void LoadYear()
        {
            try
            {
                FeesCommonBAL feesCommonBALobj = new FeesCommonBAL();
                yearCombobox.Items.Clear();
                foreach (var userGroup in feesCommonBALobj.GetAllYear())
                {
                    yearCombobox.Items.Add(userGroup);
                }
                //YearComboBox.DisplayMemberPath = "EducationResultName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Year name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void semesterCombobax_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                 FeesCollectionDataGrid.Items.Clear();
                if (semesterCombobax.SelectedIndex > -1)
                {
                    FeesDetails obj = new FeesDetails();
                    obj.StudentId = Convert.ToInt32(studentIdTextBox.Text);
                    obj.SemesterId = (((Semester)(semesterCombobax.SelectedItem)).Id);
                    obj.CampusId = campusId;
                    if (yearCombobox.SelectedItem != null)
                    {
                        obj.Year = Convert.ToInt32(yearCombobox.SelectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Firstly select the year Please");
                        semesterCombobax.SelectedIndex = -1;

                    }
                    _feesDetailsListObj = _feesCollectionManagerObj.GetSemesterFeesDetails(obj);
                    if (_feesDetailsListObj.Count > 0)
                    {
                        foreach (FeesDetails item in _feesDetailsListObj)
                        {
                            FeesCollectionDataGrid.Items.Add(item);
                            totalTextBox.Text = item.TotalPayableAmount.ToString();
                            paidAmountTextBox.Text = item.PaidAmount.ToString();
                            receiveAmount.Text = "";
                            receivableAmount.Text = item.DueAmount.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No student To Assigned Fees");
                    }
                   
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void feesCollectionDaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FeesCollection obj = new FeesCollection();
                obj.StudentId = Convert.ToInt32(studentIdTextBox.Text);
                obj.SemesterId = (((Semester)(semesterCombobax.SelectedItem)).Id);
                obj.Year = Convert.ToInt32(yearCombobox.SelectedItem);
                obj.ReceiveAmount = Convert.ToInt32(receiveAmount.Text);
                obj.ReceivableAmount = Convert.ToInt32(receiveAmount.Text);
                obj.DueAmount = Convert.ToInt32(dueAmountTextBox.Text);
                obj.CollectionDate = Convert.ToDateTime(collectionDateDatePicker.SelectedDate);
                _feesCollectionManagerObj.SaveFeesCollectionDetails(obj);
               // MessageBox.Show();
                List<ENTITY.Report.Fees.RStudentFees> reportList = _feesCollectionManagerObj.GetCollectionReportDetails(obj);

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
                    reportListObj.Add(_obj);
                }


                if (reportListObj.Count > 0)
                {
                    moneyReceiptCrystalReport employeeInfoCrystalReport = new moneyReceiptCrystalReport();
                    ReportUtility.Display_report(employeeInfoCrystalReport, reportListObj, this);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void receiveAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            int rec = 0, due = 0, payable = 0, total = 0;

            rec = Convert.ToInt32(receiveAmount.Text);
            payable = Convert.ToInt32(receivableAmount.Text);
           // due = Convert.ToInt32(dueAmountTextBox.Text);

            total = payable - rec;
            dueAmountTextBox.Text = total.ToString();
        }
    }
}
