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
using ENTITY.StudentManagement;
using BLL.StudentManagement;
 

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for DayUI.xaml
    /// </summary>
     public partial class DayUI : Window
    {
        Day _dayObj;
        DayManager dayManagerobj = new DayManager();

        List<Day> dayList;  
       
        public DayUI()
        {
            InitializeComponent();
            LoadAllYear();
            LoadAllDay();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (saveButton.Content.ToString() == "Save")
            {
                _dayObj = new Day();
                _dayObj.DaySeveneven = dayTextBox.Text;
                _dayObj.BanglaDay = banglaDayTextBox.Text;
                dayManagerobj.SaveDay(_dayObj);
                //LoadAllSemester();
                MessageBox.Show("Data insurted successfully");
                LoadAllDay();
            }

            if (saveButton.Content.ToString() == "Update")
            {

                _dayObj.DaySeveneven = dayTextBox.Text;
                _dayObj.BanglaDay = banglaDayTextBox.Text;
                //semesterManagerobj.SaveDay(_dayObj);
                //LoadAllSemester();
                MessageBox.Show("Data Update Succcessfull");
                saveButton.Content = "Save";
                LoadAllDay();
            }
        }
         
        private void LoadAllDay()
        {
            dayList = new List<Day>();
            dayList = dayManagerobj.GetAllDay();
            daylistView.Items.Clear();
            if (dayList.Count > 0)
            {
                foreach (var item in dayList)
                {
                    daylistView.Items.Add(item);
                }
            }
        }
        private void LoadAllYear()
        {
            dayList = new List<Day>();
            dayList = dayManagerobj.GetAllYear();
            yearlistView.Items.Clear();
            if (dayList.Count > 0)
            {
                foreach (var item in dayList)
                {
                    yearlistView.Items.Add(item);
                }
            }
        }
         

        private void EditSemesterContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _dayObj = new Day();
            _dayObj = ((Day)daylistView.SelectedItem);
            dayTextBox.Text = _dayObj.DaySeveneven;
            banglaDayTextBox.Text = _dayObj.BanglaDay;
            saveButton.Content = "Update";
        }

        private void RemoveSemesterContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _dayObj = new Day();
            _dayObj = ((Day)daylistView.SelectedItem);
            //semesterManagerobj.DeleteSemester(_dayObj);
            MessageBox.Show("Data Update successfully");
            //LoadAllSemester();
        }

        private void saveButton_year_Click(object sender, RoutedEventArgs e)
        {
            
                _dayObj = new Day();
                _dayObj.Year = Convert.ToInt32(YearTextBox.Text);
                dayManagerobj.SaveYear(_dayObj);  
                MessageBox.Show("Data insurted successfully");
                LoadAllYear();


        }

        private void removeYear(object sender, RoutedEventArgs e)
        {
            _dayObj = new Day();
            _dayObj = ((Day)yearlistView.SelectedItem);
            dayManagerobj.DeleteYear(_dayObj);
            MessageBox.Show("Delete Successfully");
            LoadAllYear();
        }
    }

}
