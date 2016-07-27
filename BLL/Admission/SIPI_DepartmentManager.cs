using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
    public class SIPI_DepartmentManager
    {
        SIPI_DepartmentGateway sIPI_ProgramGetwayobj = new SIPI_DepartmentGateway();
        
         

        public bool SaveSIPI_Department(SIPI_Department _sIPI_DepartmentObj)
        {
            return sIPI_ProgramGetwayobj.SaveSIPI_Department(_sIPI_DepartmentObj);
        }

        public void UpdateSIPI_Department(SIPI_Department _sIPI_DepartmentObj)
        {
            sIPI_ProgramGetwayobj.UpdateSIPI_Department(_sIPI_DepartmentObj);
        }

        public List<SIPI_Department> GetAll_SIPIDepartment()
        {
            return sIPI_ProgramGetwayobj.GetAll_SIPIDepartment();
        }

        public void DeleteSIPI_Deprtment(SIPI_Department _sIPI_DepartmentObj)
        {
            sIPI_ProgramGetwayobj.DeleteSIPI_Deprtment(_sIPI_DepartmentObj);
        }
    }
}
