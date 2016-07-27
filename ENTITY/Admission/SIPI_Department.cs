using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
    public class SIPI_Department
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int? sIPI_ProgramId;

        public int? SIPI_ProgramId
            {
              get { return sIPI_ProgramId; }
              set { sIPI_ProgramId = value; }
            }

        private string sIPI_ProgramName;

        public string SIPI_ProgramName
            {
              get { return sIPI_ProgramName; }
              set { sIPI_ProgramName = value; }
            }
        
        private string sIPI_DepartmentName;

        public string SIPI_DepartmentName
            {
              get { return sIPI_DepartmentName; }
              set { sIPI_DepartmentName = value; }
            }
        
        private string sIPI_DepartmentCode;

        public string SIPI_DepartmentCode
            {
              get { return sIPI_DepartmentCode; }
              set { sIPI_DepartmentCode = value; }
            }
        
        private string banglaSIPI_DepartmentName;

        public string BanglaSIPI_DepartmentName
            {
                get { return banglaSIPI_DepartmentName; }
                set { banglaSIPI_DepartmentName = value; }
            }
       
        private string regulation;

        public string Regulation
            {
              get { return regulation; }
              set { regulation = value; }
            }

        private DateTime? sIPI_DepartmentEntryDate;

        public DateTime? SIPI_DepartmentEntryDate
        {
            get { return sIPI_DepartmentEntryDate; }
            set { sIPI_DepartmentEntryDate = value; }
        }
 

    }
}
