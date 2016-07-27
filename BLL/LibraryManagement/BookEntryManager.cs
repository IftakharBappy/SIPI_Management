using DAL.LibraryManagement;
using ENTITY.LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LibraryManagement
{
    public class BookEntryManager
    {
        BookEntryGetway bookEnteyGetwayObj = new BookEntryGetway();

        public void SaveBook(BookEntryEntity _bookentry)
        {
            bookEnteyGetwayObj.SaveBook(_bookentry);
        }

        public List<BookEntryEntity> GetAllBooks()
        {
            return bookEnteyGetwayObj.GetAllBooks();
        }

        public void DeleteSemester(BookEntryEntity _bookentry)
        {
            bookEnteyGetwayObj.DeleteBooks(_bookentry);
        }
    }
}
