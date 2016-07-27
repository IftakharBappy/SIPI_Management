using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
    public class Program
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int? departmentId;

        public int? DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        private string deparimentName;

        public string DeparimentName
        {
            get { return deparimentName; }
            set { deparimentName = value; }
        }
        private string programName;

        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }
        private string programCode;

        public string ProgramCode
        {
            get { return programCode; }
            set { programCode = value; }
        }

        private string banglaProgram;

        public string BanglaProgram
        {
            get { return banglaProgram; }
            set { banglaProgram = value; }
        }

    }
}
