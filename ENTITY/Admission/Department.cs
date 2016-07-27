using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
  public class Department
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        private string departmentCode;

        public string DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }

        private string banglaDepartment;

        public string BanglaDepartment
        {
            get { return banglaDepartment; }
            set { banglaDepartment = value; }
        }

        
       
    }
}
