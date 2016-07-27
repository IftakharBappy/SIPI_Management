using BLL.LibraryManagement;
using ENTITY.LibraryManagement;
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

namespace SIPI_SL.UI.LibraryManagement
{
    /// <summary>
    /// Interaction logic for BookPickerUI.xaml
    /// </summary>
    public partial class BookPickerUI : Window
    {
        List<BookEntryEntity> _bookentryList;
        BookEntryManager bookEntryManager = new BookEntryManager();
        public BookPickerUI()
        {
            InitializeComponent();
            LoadAllBooks();
        }
        private void LoadAllBooks()
        {
            _bookentryList = new List<BookEntryEntity>();
            _bookentryList = bookEntryManager.GetAllBooks();
            bookListView.Items.Clear();
            if (_bookentryList.Count > 0)
            {
                foreach (var item in _bookentryList)
                {
                    bookListView.Items.Add(item);
                }

            }
        }

        private void bookListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (bookListView.SelectedIndex > -1)
            {
                this.DialogResult = true;
            }
        }
    }
}
