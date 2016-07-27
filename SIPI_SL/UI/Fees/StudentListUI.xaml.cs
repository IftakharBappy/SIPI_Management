using BLL.Admission;
using ENTITY.Admission;
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

namespace SIPI_SL.UI.Fees
{
    /// <summary>
    /// Interaction logic for StudentListUI.xaml
    /// </summary>
    public partial class StudentListUI : Window
    {
        public StudentListUI()
        {
            InitializeComponent();
            LoadAllStudentInfo();
        }

        List<StudentInfo> studentInfoList;
        StudentInfoManager studentInfoManager = new StudentInfoManager();

        private void LoadAllStudentInfo()
        {
            studentInfoList = new List<StudentInfo>();
            studentInfoList = studentInfoManager.GetAllStudentInfo();
            studentInofListView.Items.Clear();
            if (studentInfoList.Count > 0)
            {
                foreach (var item in studentInfoList)
                {
                    studentInofListView.Items.Add(item);
                }

            }
        }

        private void studentInofListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (studentInofListView.SelectedIndex > -1)
            {
                this.DialogResult = true;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (studentIdTextbox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string studentId = studentIdTextbox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByStudentID(studentId);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {

                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }
            else
            {
                LoadAllStudentInfo();

            }

        }
    }
}
