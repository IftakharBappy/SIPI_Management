using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.LibraryManagement
{
    public class BookEntryEntity
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string ProgramName { get; set; }

        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookEdition { get; set; }
        public int? PublishedYear { get; set; }
        public string SelfNumber { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? Quantity { get; set; }



    }
}
