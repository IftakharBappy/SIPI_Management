using DAL.LibraryManagement;
using ENTITY.LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LibraryManagement
{
    public class BookIssueManager
    {
        BookIssueGetway bookIssueGetWayObj = new BookIssueGetway();

        public void SaveIssuedBook(List<BookIssueEntity> _bookIssueList)
        {
            bookIssueGetWayObj.SaveIssuedBook(_bookIssueList);

        }
        public List<BookIssueEntity> GetAllIssuedBookListByStudent(string stdID)
        {
            return bookIssueGetWayObj.GetAllIssuedBookListByStudent(stdID);
        }


        public bool GetAllIssuedBookListchequeByReturnStatus(string stdID, string returnStatusChaque, int countBookFromAddNookListView)
        {
            return bookIssueGetWayObj.GetAllIssuedBookListchequeByReturnStatus(stdID, returnStatusChaque, countBookFromAddNookListView);
        }

        public void UpdateBookQuantity(List<BookIssueEntity> _bookIssueList)
        {
            bookIssueGetWayObj.UpdateBookQuantity(_bookIssueList);
        }

        public bool bookDuplicate(int bookid, int studentidPk, string returnStatusChaque)
        {
            return bookIssueGetWayObj.bookDuplicate(bookid, studentidPk, returnStatusChaque);
        }

        public void updateIssuedBook(List<BookIssueEntity> _bookIssueList)
        {
            bookIssueGetWayObj.updateIssuedBook(_bookIssueList);
        }

        public void UpdateBookQuantityForReturn(List<BookIssueEntity> _bookIssueList)
        {
            bookIssueGetWayObj.UpdateBookQuantityForReturn(_bookIssueList);
        }

        public List<BookIssueEntity> GetAllIssuedBookListByNotreturned(string stdID, string status)
        {
            return bookIssueGetWayObj.GetAllIssuedBookListByNotreturned(stdID, status);
        }
    }
}
