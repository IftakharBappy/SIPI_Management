using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
    public class SIPI_ProgramManager
    {
        DepartmentGetway departmentGatewayobj = new DepartmentGetway();
        SIPI_ProgramGateway sIPI_ProgramGatewayobj = new SIPI_ProgramGateway();
  
        public bool SaveSIPI_Program(SIPI_Program _sIPI_ProgramObj)
        {
            return sIPI_ProgramGatewayobj.SaveSIPI_Program(_sIPI_ProgramObj);
        }

        public void UpdateSIPI_Program(SIPI_Program _sIPI_ProgramObj)
        {
            sIPI_ProgramGatewayobj.UpdateSIPI_Program(_sIPI_ProgramObj);
        }

        public List<SIPI_Program> GetAllSIPI_Program()
        {
            return sIPI_ProgramGatewayobj.GetAllSIPI_Program();
        }



        public void DeleteSipiProgram(SIPI_Program _sIPI_ProgramObj)
        {
            sIPI_ProgramGatewayobj.DeleteSipiProgram(_sIPI_ProgramObj);
        }
    }
}
