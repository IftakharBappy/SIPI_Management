using BLL.Admission;
using BLL.LibraryManagement;
using ENTITY.Admission;
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
    /// Interaction logic for BookEntry.xaml
    /// </summary>
    public partial class BookEntry : Window
    {
        List<SIPI_Program> _SIPIprogramList;
        SIPI_ProgramManager sIPI_ProgramManagerObj = new SIPI_ProgramManager();

        List<SIPI_Department> _SIPIDepartmentList;
        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();

        BookEntryEntity _bookentry;
        BookEntryManager bookEntryManager = new BookEntryManager();
        List<BookEntryEntity> _bookentryList;

        public BookEntry()
        {
            InitializeComponent();
            LoadProgramComboBox();
            LoadDepartmentComboBox();
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

        private void LoadProgramComboBox()
        {
            _SIPIprogramList = new List<SIPI_Program>();
            programCombobox.Items.Clear();
            _SIPIprogramList = sIPI_ProgramManagerObj.GetAllSIPI_Program();
            foreach (SIPI_Program program in _SIPIprogramList)
            {
                programCombobox.ItemsSource = _SIPIprogramList;
            }
            programCombobox.DisplayMemberPath = "SIPI_ProgramName";
        }
        private void LoadDepartmentComboBox()
        {
            _SIPIDepartmentList = new List<SIPI_Department>();
            departmentCombobox.Items.Clear();
            _SIPIDepartmentList = sIPI_DepartmentManagerObj.GetAll_SIPIDepartment();
            foreach (SIPI_Department department in _SIPIDepartmentList)
            {
                departmentCombobox.ItemsSource = _SIPIDepartmentList;
            }

        }

        private void newBookSaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (programCombobox.SelectedIndex != -1 && departmentCombobox.SelectedIndex != -1)
                {
                    _bookentry = new BookEntryEntity();

                    _bookentry.ProgramId = ((SIPI_Program)programCombobox.SelectedItem).Id;
                    _bookentry.DepartmentId = ((SIPI_Department)departmentCombobox.SelectedItem).Id;
                    _bookentry.BookName = bookNametextbox.Text;
                    _bookentry.BookAuthor = bookAuthorTextBox.Text;
                    _bookentry.BookEdition = bookEditionTextBox.Text;
                    _bookentry.PublishedYear = Convert.ToInt32(bookPublishedYearTextBox.Text);
                    _bookentry.Quantity = Convert.ToInt32(quantityTextbox.Text);
                    _bookentry.SelfNumber = selfNoTextbox.Text;
                    _bookentry.EntryDate = Convert.ToDateTime(entrydateDatePicker.SelectedDate);

                    bookEntryManager.SaveBook(_bookentry);
                    MessageBox.Show("Book Entry SuccessFull", "Book Entry");
                    LoadAllBooks();

                }
                else
                {
                    MessageBox.Show("Please Select The Required field", "Required field");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            


        }

        private void RemoveCourseContextMenu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _bookentry = new BookEntryEntity();
                _bookentry = ((BookEntryEntity)bookListView.SelectedItem);
                bookEntryManager.DeleteSemester(_bookentry);
                MessageBox.Show("Data Remove successfully");
                LoadAllBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "This Might be a Relation ");
            }
            
        }
    }
}
