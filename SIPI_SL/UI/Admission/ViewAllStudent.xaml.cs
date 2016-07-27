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

namespace SIPI_SL.UI.Admission
{
    /// <summary>
    /// Interaction logic for ViewAllStudent.xaml
    /// </summary>
    public partial class ViewAllStudent : Window
    {
        public ViewAllStudent()
        {
            InitializeComponent();
            LoadAllStudentInfo();
        }
        StudentInfo _studentInfo;
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
    }
}
