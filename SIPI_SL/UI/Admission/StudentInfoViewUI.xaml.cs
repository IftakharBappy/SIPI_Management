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
    /// Interaction logic for StudentInfoViewUI.xaml
    /// </summary>
    public partial class StudentInfoViewUI : Window
    {
        StudentInfo _studentInfoObj;
        public StudentInfoViewUI()
        {
            InitializeComponent();
            loadStudentView();
        }

        private void loadStudentView()
        {
            
            _studentInfoObj = new StudentInfo();
            //_sIPI_ProgramObj = ((SIPI_Program)sIPI_programlistView.SelectedItem);

            //_sIPI_ProgramObj = new SIPI_Program();
            //_sIPI_ProgramObj = ((SIPI_Program)sIPI_programlistView.SelectedItem);
            //SipiProgramNameTextBox.Text = _sIPI_ProgramObj.SIPI_ProgramName;
            //SipiProgramTimeTextBox.Text = _sIPI_ProgramObj.SIPI_ProgramTime;
            //banglaSipiProgramTextBox.Text = _sIPI_ProgramObj.BanglaSIPI_ProgramName;
            //submitButton.Content = "Update";
        }

       
    }
}
