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
    /// Interaction logic for BookIssue.xaml
    /// </summary>
    public partial class BookIssue : Window
    {
        BookEntryEntity bookEntryobj ;
        StudentInfo studentInfo = new StudentInfo();
        BookListing booklistObj;
        List<BookEntryEntity>_bookentryList = new List<BookEntryEntity>();
        List<BookListing> _bookListList = new List<BookListing>();
        BookIssueEntity _bookissueObj;
        List<BookIssueEntity> _bookIssueList;
        BookIssueManager bookIssueManagerObj = new BookIssueManager();
        List<BookListing> _booklisting;


        public BookIssue()
        {
            InitializeComponent();
            receiveDatePicker.SelectedDate = DateTime.Today;
            returnDateDatePicker.SelectedDate = DateTime.Today.AddDays(+15);
        }

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
                BookPickerUI bookPickerobj = new BookPickerUI();
                if (bookPickerobj.ShowDialog() == true)
                {
                    this.bookEntryobj = bookPickerobj.bookListView.SelectedItem as BookEntryEntity;
                    programTextBox.Text = Convert.ToString(this.bookEntryobj.ProgramName);
                    departmentTextBox.Text = Convert.ToString(this.bookEntryobj.DepartmentName);
                    bookNametextbox.Text = this.bookEntryobj.BookName;
                    bookAuthorTextBox.Text = this.bookEntryobj.BookAuthor;
                    bookEditionTextBox.Text = this.bookEntryobj.BookEdition;
                    bookPublishedYearTextBox.Text = Convert.ToString(this.bookEntryobj.PublishedYear);
                    quantityTextbox.Text = Convert.ToString(this.bookEntryobj.Quantity);
                    selfNoTextbox.Text = Convert.ToString(this.bookEntryobj.SelfNumber);
                    bookPkIdTextbox.Text = Convert.ToString(this.bookEntryobj.Id);
                    bookPickerobj.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select the Student " + Environment.NewLine + "From List Of Student", " No Selected Student ");
            }
            
            
        }


        private void bookAddDataGrid_Click(object sender, RoutedEventArgs e)
        {
            if (pkIdTextBox.Text != "" && bookPkIdTextbox.Text !="")
            {
                int countBookFromAddNookListView = addBooklistView.Items.Count;
                chequeBookReturnStatus(countBookFromAddNookListView);
            }

        }

        private void chequeBookReturnStatus(int countBookFromAddNookListView)
        {
            int bookid = Convert.ToInt32(bookPkIdTextbox.Text);
            int studentidPk = Convert.ToInt32(pkIdTextBox.Text);
            string returnStatusChaque = "Book Not Returned";
            string stdID = uniqueIdTextBox.Text.Trim();
            
            _booklisting = new List<BookListing>();
            foreach (BookListing item in addBooklistView.Items)
            {
                if (item.Id == bookid)
                {
                    _booklisting.Add(item);
                }
                
            }


            if (uniqueIdTextBox.Text != null && pkIdTextBox.Text != "" && bookIssueManagerObj.bookDuplicate(bookid, studentidPk, returnStatusChaque) != false && _booklisting.Count == 0)
            {
                _bookIssueList = new List<BookIssueEntity>();
                
                if (bookIssueManagerObj.GetAllIssuedBookListchequeByReturnStatus(stdID, returnStatusChaque, countBookFromAddNookListView) == true && quantityTextbox.Text != "0")
                {
                    booklistObj = new BookListing();
                    if (bookPkIdTextbox.Text != "" )
                    {
                        booklistObj.Id = Convert.ToInt32(bookPkIdTextbox.Text);
                        booklistObj.BookName = bookNametextbox.Text;
                        booklistObj.Quantity = 1;
                        _bookListList.Add(booklistObj);
                        addBooklistView.Items.Add(booklistObj);
                    }
                }
                
                else if (quantityTextbox.Text == "0")
	            {
                    MessageBox.Show("This Book is Not Available Now", " Not Available ");
	            }
                else
                {
                    MessageBox.Show("Your Book Limit is Over", " Book Limit ");
                }
            }
            else if (bookIssueManagerObj.bookDuplicate(bookid, studentidPk, returnStatusChaque) != true || _booklisting.Count != 0)
            {
                MessageBox.Show("You Alrady have take this Book", "  Issue not possible");
            }

            else if (pkIdTextBox.Text == "")
            {
                MessageBox.Show("Please Pick a book" + Environment.NewLine + "From Book Picker", " No Book Selected ");
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

                    _bookissueObj.BookId = j.Id;
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
        }

        private void quantityTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (quantityTextbox.Text == "0")
            {
                quentatyMessageLable.Content = "This Book is Not Available Now";
            }
            else
            {
                quentatyMessageLable.Content = "This Book is Available ";
            }
        }

       
    }
}
