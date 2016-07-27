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
using BLL.TeacherManagement;
using BLL.Admission;
using ENTITY.TeacherManagement;
using ENTITY.Admission;

namespace SIPI_SL.UI.TeacherManagement
{
    /// <summary>
    /// Interaction logic for TeacherInfoUI.xaml
    /// </summary>
    public partial class TeacherInfoUI : Window
    {
        TeacherInfo _teacherInfoObj = new TeacherInfo();
        TeacherInfoManager _teacherInfoManager = new TeacherInfoManager();
        SIPI_DepartmentManager _Sipi_departmentInfoManager = new SIPI_DepartmentManager();
        List<TeacherInfo> _teacherInfoList = new List<TeacherInfo>();
        List<SIPI_Department> _departmentInfoList = new List<SIPI_Department>();
        List<Campus> _campusInfoList = new List<Campus>();
        CampusManager _campusInfoManager = new CampusManager();
        public TeacherInfoUI()
        {
            InitializeComponent();
            LoadAllTeacherInfo();
            LoadDepartmentComboBox();
            LoadCampusComboBox();
            btnSave.IsEnabled = false;
        }

        private void LoadCampusComboBox()
        {
            //_campusList = new List<Campus>();
            courseComboBox.Items.Clear();
            _campusInfoList = _campusInfoManager.GetAllCampus();
            foreach (Campus campus in _campusInfoList)
            {
                courseComboBox.ItemsSource = _campusInfoList;
            }
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "Save")
            {
                _teacherInfoObj.DepartmentId = ((SIPI_Department)depertmentComboBox.SelectedItem).Id;

                _teacherInfoObj.CampusId = ((Campus)courseComboBox.SelectedItem).Id;
                _teacherInfoObj.TeacherName = txtTeacherName.Text;

                if (_teacherInfoManager.SaveTeacherInfo(_teacherInfoObj) == true)
                {
                    MessageBox.Show("Teacher information is successfully saved", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Duplicate Data Insert ! Please check your Teacher Name", "Confirmation");
                }

                txtTeacherName.Text = "";
                depertmentComboBox.Text = "";


                LoadAllTeacherInfo();
                btnSave.IsEnabled = false;
            }
            if (btnSave.Content.ToString() == "Update")
            {

                _teacherInfoObj.DepartmentId = ((SIPI_Department)depertmentComboBox.SelectedItem).Id;
                _teacherInfoObj.CampusId = ((Campus)courseComboBox.SelectedItem).Id;

                _teacherInfoObj.TeacherName = txtTeacherName.Text;

                _teacherInfoManager.UpdateTeacherInfo(_teacherInfoObj);

                txtTeacherName.Text = "";
                depertmentComboBox.Text = "";

                MessageBoxResult msgResult = MessageBox.Show("Teacher information is successfully Update", "Confirmation");
                btnSave.Content = "Save";
                LoadAllTeacherInfo();
                btnSave.IsEnabled = false;

            }
        }

        private void EditProgramContextMenu_Click(object sender, RoutedEventArgs e)
        {
                if (teacherInfoListView.Items.Count > 0)
                {

                    _teacherInfoObj = new TeacherInfo();
                    _teacherInfoObj = ((TeacherInfo)teacherInfoListView.SelectedItem );

                    for (int i = 0; i < depertmentComboBox.Items.Count; i++)
                    {
                        SIPI_Department sipiDepartment = (SIPI_Department)depertmentComboBox.Items[i];
                        if (_teacherInfoObj.DepartmentId == sipiDepartment.Id)
                        {
                            depertmentComboBox.SelectedIndex = i;
                            break;
                        }
                    }

                    for (int i = 0; i < courseComboBox.Items.Count; i++)
                    {
                        Campus campus = (Campus)courseComboBox.Items[i];
                        if (_teacherInfoObj.CampusId == campus.Id)
                        {
                            courseComboBox.SelectedIndex = i;
                            break;
                        }
                    }

                    txtTeacherName.Text = _teacherInfoObj.TeacherName;


                    //cmbDepertment.Text = _teacherInfoObj.DepartmentName;                    
                    //cmbDepertment.SelectedIndex = _teacherInfoObj.DepartmentId;

                    btnSave.Content = "Update";
                    btnSave.IsEnabled = true;
                }
        }


        private void RemoveProgramContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (teacherInfoListView.Items.Count > 0)
            {
                _teacherInfoObj = ((TeacherInfo)teacherInfoListView.SelectedItem);
                _teacherInfoManager.DeleteTeacherInfo(_teacherInfoObj);
                LoadAllTeacherInfo();
            }
        }

        private void LoadAllTeacherInfo()
        {
            _teacherInfoList = _teacherInfoManager.LoadAllTeacherInfo();
            teacherInfoListView.Items.Clear();

            if (_teacherInfoList.Count > 0)
            {
                foreach (var item in _teacherInfoList)
                {
                    teacherInfoListView.Items.Add(item);
                }
            }
        }

        private void LoadDepartmentComboBox()
        {
            //_campusList = new List<Campus>();
            depertmentComboBox.Items.Clear();
            _departmentInfoList = _Sipi_departmentInfoManager.GetAll_SIPIDepartment();
            foreach (SIPI_Department department in _departmentInfoList)
            {
                depertmentComboBox.ItemsSource = _departmentInfoList;
            }
        }

        private void txtTeacherName_KeyUp(object sender, KeyEventArgs e)
        {
            btnSave.IsEnabled = true;
        }

        private void TeacherInfoListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (teacherInfoListView.SelectedIndex > -1)
            {
                this.DialogResult = true;
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
