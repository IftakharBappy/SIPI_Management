using BLL.LibraryManagement;
using ENTITY.Admission;
using ENTITY.LibraryManagement;
using SIPI_SL.UI.Fees;
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
    /// Interaction logic for BookReturnUI.xaml
    /// </summary>
    public partial class BookReturnUI : Window
    {    BookEntryEntity bookEntryobj ;
        StudentInfo studentInfo = new StudentInfo();
        BookListing booklistObj;
        List<BookEntryEntity>_bookentryList = new List<BookEntryEntity>();
        List<BookListing> _bookListList = new List<BookListing>();
        BookIssueEntity _bookissueObj;
        List<BookIssueEntity> _bookIssueList;
        BookIssueManager bookIssueManagerObj = new BookIssueManager();
        List<BookListing> _booklisting;

       



        public BookReturnUI()
        {
            InitializeComponent();
        }

        private void LoadAllNotreturnedBooks()
        {

            if (uniqueIdTextBox.Text != null)
            {
                
                _bookIssueList = new List<BookIssueEntity>();
                string stdID = uniqueIdTextBox.Text.Trim();
                string status = "Book Not Returned";

                _bookIssueList = bookIssueManagerObj.GetAllIssuedBookListByNotreturned(stdID, status);
                //if (_bookIssueList.Count == 0 )
                //{
                //    bookListCombobox.SelectedIndex = -1;
                //    bookListCombobox.Items.Clear();
                //}
                if (_bookIssueList.Count > 0)
                {
                    foreach (BookIssueEntity item in _bookIssueList)
                    {
                        bookListCombobox.ItemsSource = _bookIssueList;
                    }
                }
            }
        }
        
        //public BookIssue()
        //{
        //    InitializeComponent();
        //    receiveDatePicker.SelectedDate = DateTime.Today;
        //    returnDateDatePicker.SelectedDate = DateTime.Today.AddDays(+15);
        //}

        private void IssuedBookByStudent()
        {
            if (uniqueIdTextBox.Text != null)
            {
                _bookIssueList = new List<BookIssueEntity>();
                string stdID = uniqueIdTextBox.Text.Trim();
                _bookIssueList = bookIssueManagerObj.GetAllIssuedBookListByStudent(stdID);
                bookReceiveHistryDataGrid.Items.Clear();
                if (_bookIssueList.Count > 0)
                {
                    foreach (var item in _bookIssueList)
                    {
                        bookReceiveHistryDataGrid.Items.Add(item);
                    }
                }
            }
           
        }
        

        private void bookPicker_Click(object sender, RoutedEventArgs e)
        {
            if (pkIdTextBox.Text != "")
            {
                 
                //if (bookPickerobj.ShowDialog() == true)
                //{
                //    this.bookEntryobj = bookPickerobj.bookListView.SelectedItem as BookEntryEntity;
                //    programTextBox.Text = Convert.ToString(this.bookEntryobj.ProgramName);
                //    departmentTextBox.Text = Convert.ToString(this.bookEntryobj.DepartmentName);
                //    bookNametextbox.Text = this.bookEntryobj.BookName;
                //    bookAuthorTextBox.Text = this.bookEntryobj.BookAuthor;
                //    bookEditionTextBox.Text = this.bookEntryobj.BookEdition;
                //    bookPublishedYearTextBox.Text = Convert.ToString(this.bookEntryobj.PublishedYear);
                //    quantityTextbox.Text = Convert.ToString(this.bookEntryobj.Quantity);
                //    selfNoTextbox.Text = Convert.ToString(this.bookEntryobj.SelfNumber);
                //    bookPkIdTextbox.Text = Convert.ToString(this.bookEntryobj.Id);
                //    bookPickerobj.Close();
                //}
            }
            else
            {
                MessageBox.Show("Please Select the Student " + Environment.NewLine + "From List Of Student", " No Selected Student ");
            }
            
            
        }

        private void bookAddDataGrid_Click(object sender, RoutedEventArgs e)
        {
            if (bookPkIdTextbox.Text != "")
            {
               int bookid = Convert.ToInt32(bookPkIdTextbox.Text);

                _booklisting = new List<BookListing>();
                foreach (BookListing item in addBooklistView.Items)
                {
                    if (item.BookPkId == bookid)
                    {
                        _booklisting.Add(item);
                    }
                }
                if (_booklisting.Count < 1)
                {
                    booklistObj = new BookListing();
                    if (bookPkIdTextbox.Text != "")
                    {
                        booklistObj.BookPkId = Convert.ToInt32(bookPkIdTextbox.Text);
                        booklistObj.BookName = bookNametextbox.Text;
                        booklistObj.Quantity = Convert.ToInt32(quantityTextbox.Text);
                        booklistObj.EntryDate = Convert.ToDateTime(returnTodayDateDatePicker.SelectedDate);
                        booklistObj.DelayTime = Convert.ToInt32(delayTextbox.Text);
                        booklistObj.Id = Convert.ToInt32(bookIssueIdTextBox.Text);
                        _bookListList.Add(booklistObj);
                        addBooklistView.Items.Add(booklistObj);
                    }
                }
                else if (bookPkIdTextbox.Text == "")
                {
                     MessageBox.Show("Select The Book First", "Book Selection");
                }
                        
                else
                {
                    MessageBox.Show("This Book Already Added For Return", "Already Added");
                }
            }
            

        }


    
        private void listStudentButton_Click(object sender, RoutedEventArgs e)
        {
            
            StudentListUI studentListUI = new StudentListUI();
            if (studentListUI.ShowDialog() == true)
            {
                this.studentInfo = studentListUI.studentInofListView.SelectedItem as StudentInfo;

                pkIdTextBox.Text = Convert.ToString(this.studentInfo.Id);
                uniqueIdTextBox.Text = Convert.ToString(this.studentInfo.StudentID);
                nametextbox.Text = this.studentInfo.ApplicantName;
                departmentStudentTextBox.Text = Convert.ToString(this.studentInfo.DepartmentName);
                semesterTextBox.Text = this.studentInfo.SemesterNo;
                sessionTextBox.Text = this.studentInfo.Session ;
                studentListUI.Close();
            }
            /////IssuedBookByStudent();
        }

        private void bookIssueButton_Click(object sender, RoutedEventArgs e)
        {
            if (addBooklistView.Items.Count != 0)
            {
            List<BookIssueEntity> _bookIssueList = new List<BookIssueEntity>();

            foreach (BookListing j in addBooklistView.Items)
                {
                    _bookissueObj = new BookIssueEntity();
                    _bookissueObj.StudentPKId = Convert.ToInt32(pkIdTextBox.Text);
                    _bookissueObj.StudentId = uniqueIdTextBox.Text;
                    _bookissueObj.Semester = semesterTextBox.Text;

                    _bookissueObj.ReceiveDate = Convert.ToDateTime(receiveDatePicker.Text);
                    _bookissueObj.ReturnDate = Convert.ToDateTime(returnDateDatePicker.Text);

                    _bookissueObj.Id = j.Id;
                    _bookissueObj.BookId = j.BookPkId;

                    _bookissueObj.Quantity = j.Quantity;

                    _bookissueObj.BookReturnStatus = "Book Not Returned";
                    _bookIssueList.Add(_bookissueObj);
 
            }
            bookIssueManagerObj.SaveIssuedBook(_bookIssueList);
            bookIssueManagerObj.UpdateBookQuantity(_bookIssueList);
            IssuedBookByStudent();
            MessageBox.Show("Book Issue is successfull", "Book Issue");
            addBooklistView.Items.Clear();
                
            }
            

        }

        private void RemoveContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (addBooklistView.SelectedIndex != null)
            {
                addBooklistView.Items.RemoveAt(addBooklistView.Items.IndexOf(addBooklistView.SelectedItem));
            }
        }

        private void uniqueIdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            IssuedBookByStudent();
            LoadAllNotreturnedBooks();
        }


        private void bookListCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bookListCombobox.SelectedIndex != -1)
            {
                bookNametextbox.Text = ((BookIssueEntity)bookListCombobox.SelectedItem).BookName.ToString();
                quantityTextbox.Text = ((BookIssueEntity)bookListCombobox.SelectedItem).Quantity.ToString();
                bookPkIdTextbox.Text = ((BookIssueEntity)bookListCombobox.SelectedItem).BookId.ToString();
                bookIssueIdTextBox.Text = ((BookIssueEntity)bookListCombobox.SelectedItem).Id.ToString();
                receiveDatePicker.SelectedDate = ((BookIssueEntity)bookListCombobox.SelectedItem).ReceiveDate;
                returnDateDatePicker.SelectedDate = ((BookIssueEntity)bookListCombobox.SelectedItem).ReturnDate;

                ////// Delay date count
                DateTime returnDate = Convert.ToDateTime(returnDateDatePicker.SelectedDate.ToString());
                DateTime now = DateTime.Now;
                TimeSpan difference = now - returnDate;
                double days = difference.TotalDays;
                if (days >= 1)
                {
                    delayTextbox.Text = Math.Round(days, 0).ToString();
                }
                else
                {
                    delayTextbox.Text = "0";
                }
                ////// Delay date count end
                returnTodayDateDatePicker.SelectedDate = DateTime.Now;
            }
           
        }

        private void bookReturnButton_Click(object sender, RoutedEventArgs e)
        {
            if (addBooklistView.Items.Count != 0)
            {
                List<BookIssueEntity> _bookIssueList = new List<BookIssueEntity>();

                foreach (BookListing j in addBooklistView.Items)
                {
                    _bookissueObj = new BookIssueEntity();
                    _bookissueObj.StudentPKId = Convert.ToInt32(pkIdTextBox.Text);
                    _bookissueObj.StudentId = uniqueIdTextBox.Text;

                    _bookissueObj.Id = j.Id;
                    _bookissueObj.BookId = j.BookPkId;
                    _bookissueObj.Quantity = j.Quantity;
                    _bookissueObj.BookReturnDateFromStudent = j.EntryDate;
                    _bookissueObj.DelayReturn = j.DelayTime;

                    _bookissueObj.BookReturnStatus = "Book Returned";
                    _bookIssueList.Add(_bookissueObj);

                }
                bookIssueManagerObj.updateIssuedBook(_bookIssueList);
                bookIssueManagerObj.UpdateBookQuantityForReturn(_bookIssueList);
                IssuedBookByStudent();
                MessageBox.Show("Book Return successfull", "Book Return");
                addBooklistView.Items.Clear();
                ///bookListCombobox.SelectedIndex = -1;
                clearReturnReleted();
            }
        }

        private void clearReturnReleted()
        {
            LoadAllNotreturnedBooks();
            bookNametextbox.Text = "";
            quantityTextbox.Text = "";
            bookPkIdTextbox.Text = "";
            bookIssueIdTextBox.Text = "";
            delayTextbox.Text = "";
            returnDateDatePicker = null;
        }

       
    }

}
