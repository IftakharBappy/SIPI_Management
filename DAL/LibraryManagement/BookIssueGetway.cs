using DATA;
using ENTITY.LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.LibraryManagement
{
    public class BookIssueGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        
        public void SaveIssuedBook(List<BookIssueEntity> _bookIssueList)
        {
            foreach (BookIssueEntity item in _bookIssueList)
            {
                    var newBookIssue = new BOOK_ISSUE
                    {
                        StudentPKId = item.StudentPKId,
                        StudentId = item.StudentId,
                        Semester = item.Semester,
                        ReceiveDate = item.ReceiveDate,
                        ReturnDate = item.ReturnDate,
                        BookReturnStatus = item.BookReturnStatus,
                        BookId = item.BookId,
                        Quantity = item.Quantity
                    };
                    datacontextObj.BOOK_ISSUE.Add(newBookIssue);
                    datacontextObj.SaveChanges();
            }
        }

        public List<BookIssueEntity> GetAllIssuedBookListByStudent(string stdID)
        {
            datacontextObj = new SIPIDBEntities();
            List<BookIssueEntity> bookIssueInfoList = new List<BookIssueEntity>();

            foreach (var p in (from j in datacontextObj.BOOK_ISSUE
                               where j.StudentId.Equals(stdID)
                               select j).Distinct())
            {
                BookIssueEntity bookissueObj = new BookIssueEntity();
                bookissueObj.Id = p.Id;
                bookissueObj.BookId = p.BOOKS_DETAILS.Id;
                bookissueObj.StudentPKId = p.StudentPKId;
                bookissueObj.ReceiveDate = p.ReceiveDate;
                bookissueObj.ReturnDate = p.ReturnDate;
                bookissueObj.Semester = p.Semester;
                bookissueObj.Quantity = p.Quantity;
                bookissueObj.BookReturnStatus = p.BookReturnStatus;
                bookissueObj.BookName = p.BOOKS_DETAILS.BookName;
                bookIssueInfoList.Add(bookissueObj);
            }
            return bookIssueInfoList;
            
        }

        public bool GetAllIssuedBookListchequeByReturnStatus(string stdID, string returnStatusChaque, int countBookFromAddNookListView)
        {
            datacontextObj = new SIPIDBEntities();

            List<BookIssueEntity> bookIssueInfoReturnStatusList = new List<BookIssueEntity>();
            var notreturnedBook = (from j in datacontextObj.BOOK_ISSUE
                           where
                           j.StudentId.Equals(stdID)
                           && j.BookReturnStatus.Equals(returnStatusChaque)
                           select j).Count();
            int totalBookCount = notreturnedBook + countBookFromAddNookListView;
            if (totalBookCount >= 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UpdateBookQuantity(List<BookIssueEntity> _bookIssueList)
        {
            foreach (BookIssueEntity item in _bookIssueList)
            {
                var bookQuantity = datacontextObj.BOOKS_DETAILS.First(c => c.Id == item.BookId);
                int? updateBookQuentity = bookQuantity.Quantiry - item.Quantity;  
                bookQuantity.Quantiry = updateBookQuentity;
                datacontextObj.SaveChanges();
            }
        }

        public bool bookDuplicate(int bookid, int studentidPk, string returnStatusChaque)
        {
                var bookDuplicateCnt = (from d in datacontextObj.BOOK_ISSUE
                                        where
                                            d.BOOKS_DETAILS.Id.Equals(bookid) && 
                                        d.ADMISSIONINFO.Id.Equals(studentidPk) && 
                                        d.BookReturnStatus.Equals(returnStatusChaque)
                                        select d).Count();
                if (bookDuplicateCnt == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
        }

        public void updateIssuedBook(List<BookIssueEntity> _bookIssueList)
        {
            foreach (BookIssueEntity item in _bookIssueList)
            {
                var bookIssuuUpdate = datacontextObj.BOOK_ISSUE.First(c => c.Id == item.Id);
                ///int? updateBookQuentity = bookQuantity.Quantiry + item.Quantity;
                bookIssuuUpdate.BookReturnStatus = item.BookReturnStatus;
                datacontextObj.SaveChanges();
            }
        }

        public void UpdateBookQuantityForReturn(List<BookIssueEntity> _bookIssueList)
        {
            foreach (BookIssueEntity item in _bookIssueList)
            {
                var bookQuantity = datacontextObj.BOOKS_DETAILS.First(c => c.Id == item.BookId);
                int? updateBookQuentity = bookQuantity.Quantiry + item.Quantity;
                bookQuantity.Quantiry = updateBookQuentity;
                datacontextObj.SaveChanges();
            }
        }

        public List<BookIssueEntity> GetAllIssuedBookListByNotreturned(string stdID, string status)
        {
            datacontextObj = new SIPIDBEntities();
            List<BookIssueEntity> bookIssueInfoList = new List<BookIssueEntity>();

            foreach (var p in (from j in datacontextObj.BOOK_ISSUE
                               where j.StudentId.Equals(stdID) &&
                               j.BookReturnStatus.Equals(status)
                               select j).Distinct())
            {
                BookIssueEntity bookissueObj = new BookIssueEntity();
                bookissueObj.Id = p.Id;
                bookissueObj.BookId = p.BOOKS_DETAILS.Id;
                bookissueObj.StudentPKId = p.StudentPKId;
                bookissueObj.ReceiveDate = p.ReceiveDate;
                bookissueObj.ReturnDate = p.ReturnDate;
                bookissueObj.Semester = p.Semester;
                bookissueObj.Quantity = p.Quantity;
                bookissueObj.BookReturnStatus = p.BookReturnStatus;
                bookissueObj.BookName = p.BOOKS_DETAILS.BookName;
                bookIssueInfoList.Add(bookissueObj);
            }
            return bookIssueInfoList;
        }
    }
}
