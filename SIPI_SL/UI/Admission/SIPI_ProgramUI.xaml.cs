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
    /// Interaction logic for SIPI_ProgramUI.xaml
    /// </summary>
    public partial class SIPI_ProgramUI : Window
    {
        SIPI_Program _sIPI_ProgramObj;
        SIPI_ProgramManager sIPI_ProgramManagerObj = new SIPI_ProgramManager();

        List<SIPI_Program> sipi_programList;

        public SIPI_ProgramUI()
        {
            InitializeComponent();
            LoadAllSIPI_Program();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            if (submitButton.Content.ToString() == "Save")
            {

                _sIPI_ProgramObj = new SIPI_Program();
                _sIPI_ProgramObj.SIPI_ProgramName = SipiProgramNameTextBox.Text;
                _sIPI_ProgramObj.SIPI_ProgramTime = SipiProgramTimeTextBox.Text;
                _sIPI_ProgramObj.BanglaSIPI_ProgramName = banglaSipiProgramTextBox.Text;

                if (sIPI_ProgramManagerObj.SaveSIPI_Program(_sIPI_ProgramObj) == true)
                {
                    MessageBox.Show("Data saved successfully ", "Confirmation");
                    LoadAllSIPI_Program();
                    SIPI_ProgramClean();
                }
                else
                {

                    MessageBox.Show("Duplicate Data Insert ! Please check your Data", "Confirmation");
                    LoadAllSIPI_Program();
                    
                }

            }
            ////////
            if (submitButton.Content.ToString() == "Update")
            {
                _sIPI_ProgramObj.SIPI_ProgramName = SipiProgramNameTextBox.Text;
                _sIPI_ProgramObj.SIPI_ProgramTime = SipiProgramTimeTextBox.Text;
                _sIPI_ProgramObj.BanglaSIPI_ProgramName = banglaSipiProgramTextBox.Text;

                sIPI_ProgramManagerObj.UpdateSIPI_Program(_sIPI_ProgramObj);
                LoadAllSIPI_Program();
                submitButton.Content = "Save";
                MessageBox.Show("Data Update successfully");
                SIPI_ProgramClean();

            }


        }

        private void SIPI_ProgramClean()
        {
            SipiProgramNameTextBox.Text = "";
            SipiProgramTimeTextBox.Text = "";
            banglaSipiProgramTextBox.Text = "";
        }
        private void LoadAllSIPI_Program()
        {
            sipi_programList = new List<SIPI_Program>();
            sipi_programList = sIPI_ProgramManagerObj.GetAllSIPI_Program();
            sIPI_programlistView.Items.Clear();
            if (sipi_programList.Count > 0)
            {
                foreach (var item in sipi_programList)
                {
                    sIPI_programlistView.Items.Add(item);
                }


            }
        }
   

        private void EditSipiProgramContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _sIPI_ProgramObj = new SIPI_Program();
            _sIPI_ProgramObj = ((SIPI_Program)sIPI_programlistView.SelectedItem);
            SipiProgramNameTextBox.Text = _sIPI_ProgramObj.SIPI_ProgramName;
            SipiProgramTimeTextBox.Text = _sIPI_ProgramObj.SIPI_ProgramTime;
            banglaSipiProgramTextBox.Text = _sIPI_ProgramObj.BanglaSIPI_ProgramName;
            submitButton.Content = "Update";
        }

        private void RemoveSipiProgramContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _sIPI_ProgramObj = new SIPI_Program();
            _sIPI_ProgramObj = ((SIPI_Program)sIPI_programlistView.SelectedItem);
            sIPI_ProgramManagerObj.DeleteSipiProgram(_sIPI_ProgramObj);
            MessageBox.Show("Selected Item Removed");
            LoadAllSIPI_Program();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            SipiProgramNameTextBox.Text = "";
            SipiProgramTimeTextBox.Text = "";
            banglaSipiProgramTextBox.Text = "";
        }
    }
}
