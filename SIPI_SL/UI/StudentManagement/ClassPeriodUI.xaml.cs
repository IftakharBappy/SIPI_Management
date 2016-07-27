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

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for ClassPeriodUI.xaml
    /// </summary>
    public partial class ClassPeriodUI : Window
    {

        ClassPeriod _classPeriodObj = new ClassPeriod();
        ClassPeriodManager _classPeriodManager = new ClassPeriodManager();
        List<ClassPeriod> _classPeriodList = new List<ClassPeriod>();
        
        public ClassPeriodUI()
        {
            InitializeComponent();
            LoadAllClassPeriod();
            btnSave.IsEnabled = false; 
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "Save")
            {
                _classPeriodObj.PeriodName = txtPeriodName.Text;
                _classPeriodObj.StartTime = txtStartTime.Text;
                _classPeriodObj.EndTime = txtEndTime.Text;

                _classPeriodManager.SaveClassPeriod(_classPeriodObj);

                txtPeriodName.Text = "";
                txtStartTime.Text = "";
                txtEndTime.Text = "";

                MessageBoxResult msgResult = MessageBox.Show("Class Period is successfully saved", "Confirmation");
                LoadAllClassPeriod();
                btnSave.IsEnabled = false;
            }
            if (btnSave.Content.ToString() == "Update")
            {
                _classPeriodObj.PeriodName = txtPeriodName.Text;
                _classPeriodObj.StartTime = txtStartTime.Text;
                _classPeriodObj.EndTime = txtEndTime.Text;

                _classPeriodManager.UpdateClassPeriod(_classPeriodObj);

                txtPeriodName.Text = "";
                txtStartTime.Text = "";
                txtEndTime.Text = "";

                MessageBoxResult msgResult = MessageBox.Show("Class Period is successfully Update", "Confirmation");
                btnSave.Content = "Save";
                LoadAllClassPeriod();
                btnSave.IsEnabled = false;

            }
        }

        private void EditProgramContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (ClassPeriodListView.Items.Count > 0)
            {
                _classPeriodObj = ((ClassPeriod)ClassPeriodListView.SelectedItem);
                txtPeriodName.Text = _classPeriodObj.PeriodName;
                txtStartTime.Text = _classPeriodObj.StartTime;
                txtEndTime.Text = _classPeriodObj.EndTime;

                btnSave.Content = "Update";
                btnSave.IsEnabled = true;
            }
        }


        private void RemoveProgramContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (ClassPeriodListView.Items.Count > 0)
            {
                _classPeriodObj = ((ClassPeriod)ClassPeriodListView.SelectedItem);
                _classPeriodManager.DeleteClassPeriod(_classPeriodObj);
                LoadAllClassPeriod();
            }
        }

        private void LoadAllClassPeriod()
        {
            _classPeriodList = _classPeriodManager.LoadAllClassPeriod();
            ClassPeriodListView.Items.Clear();

            if (_classPeriodList.Count > 0)
            {
                foreach (var item in _classPeriodList)
                {
                    ClassPeriodListView.Items.Add(item);
                }
            }
        }

        private void txtPeriodName_KeyUp(object sender, KeyEventArgs e)
        {
            btnSave.IsEnabled = true;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtPeriodName.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }

        private void btnClase_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
