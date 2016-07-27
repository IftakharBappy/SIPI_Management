using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fees;
using ENTITY.Admission;
using ENTITY.StudentManagement;

namespace BLL.Fees
{
    public class FeesCommonBAL
    {
        FeesCommonDAL obj = new FeesCommonDAL();

        public List<Semester> GetAllSemester()
        {

            return obj.GetAllSemester();
        }

        public List<int> GetAllYear()
        {
            return obj.GetAllYear();
        }

        public List<SIPI_Department> GetAllDepartment()
        {
            return obj.GetAllDepartment();
        }
    }
}
