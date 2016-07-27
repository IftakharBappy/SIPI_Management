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
using BLL.StudentManagement;
using ENTITY.StudentManagement;
using ENTITY.TeacherManagement;

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for AssignTeacherUI.xaml
    /// </summary>
    public partial class AssignTeacherUI : Window
    {
        TeacherInfo _teacherInfo = new TeacherInfo();
        public AssignTeacherUI()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, RoutedEventArgs e)
        {
            UI.TeacherManagement.TeacherInfoUI _teacherInfoUI = new TeacherManagement.TeacherInfoUI();
            if (_teacherInfoUI.ShowDialog() == true)
            {
                this._teacherInfo = _teacherInfoUI.teacherInfoListView.SelectedItem as TeacherInfo;
                // Setting popupwindow data to main window control  
                //patientSystemId.Text = this._objPatient.SystemId;
                txtTeacherName.Text = this._teacherInfo.TeacherName;
                cmbDepertment.Text = this._teacherInfo.DepartmentName;
                cmbDepertment.SelectedIndex = this._teacherInfo.DepartmentId;
                //patientPKey.Content = this._objPatient.Id;

                _teacherInfoUI.Close();
            }
        }

        
    }
}
