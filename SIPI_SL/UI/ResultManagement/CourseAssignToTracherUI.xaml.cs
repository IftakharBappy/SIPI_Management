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

namespace SIPI_SL.UI.ResultManagement
{
    /// <summary>
    /// Interaction logic for CourseAssignToTracherUI.xaml
    /// </summary>
    public partial class CourseAssignToTracherUI : Window
    {
        public CourseAssignToTracherUI()
        {
            InitializeComponent();
        }

        private void callChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void callUnChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");

        }
    }
}
