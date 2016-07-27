using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.LibraryManagement
{
    public class BookIssueEntity
    {
        public int Id {get; set;}
        public int? StudentPKId {get; set;}
        public string StudentId {get; set;}
        public string Semester {get; set;}
        public int BookId {get; set;}
        public string BookName { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ReceiveDate {get; set;}
        public DateTime? ReturnDate {get; set;}
        public string BookReturnStatus {get; set;}
        public int? DelayReturn { get; set; }
        public DateTime? BookReturnDateFromStudent { get; set; }
        


    }
}
