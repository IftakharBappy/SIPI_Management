using DATA;
using ENTITY.LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.LibraryManagement
{
    public class BookEntryGetway
    {

        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        public void SaveBook(BookEntryEntity _bookentry)
        {
            var newBook = new BOOKS_DETAILS
            {
                ProgramId = _bookentry.ProgramId,
                DepartmentId  = _bookentry.DepartmentId,
                BookName = _bookentry.BookName,
                BookAuthor = _bookentry.BookAuthor,
                BookEdition = _bookentry.BookEdition,
                PublishedYear = _bookentry.PublishedYear,
                Quantiry = _bookentry.Quantity,
                SelfNumber = _bookentry.SelfNumber,
                EntryDate = _bookentry.EntryDate,
            };
            datacontextObj.BOOKS_DETAILS.Add(newBook);
            datacontextObj.SaveChanges();
        }

        public List<BookEntryEntity> GetAllBooks()
        {
            List<BookEntryEntity> bookList = new List<BookEntryEntity>();
            datacontextObj = new SIPIDBEntities();
            foreach (var p in (from j in datacontextObj.BOOKS_DETAILS select j).Distinct())
            {
                BookEntryEntity bookObj = new BookEntryEntity();
                bookObj.Id = p.Id;
                bookObj.ProgramId = p.ProgramId;
                bookObj.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                bookObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                bookObj.DepartmentId = p.DepartmentId;
                bookObj.BookName = p.BookName;
                bookObj.BookAuthor = p.BookAuthor;
                bookObj.BookEdition = p.BookEdition;
                bookObj.EntryDate = p.EntryDate;
                bookObj.PublishedYear = p.PublishedYear;
                bookObj.Quantity = p.Quantiry;
                bookObj.SelfNumber = p.SelfNumber;
                bookList.Add(bookObj);
            }
            return bookList;
        }

        public void DeleteBooks(BookEntryEntity _bookentry)
        {
            
            BOOKS_DETAILS course = datacontextObj.BOOKS_DETAILS.First(c => c.Id == _bookentry.Id);
            datacontextObj.BOOKS_DETAILS.Remove(course);
            datacontextObj.SaveChanges();
        }
    }
}
