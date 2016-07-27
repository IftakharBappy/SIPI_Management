using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
    public class SIPI_DepartmentGateway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        //public List<SIPI_Program> GetAllSIPI_Program()
        //{
        //    datacontextObj = new SIPIDBEntities();
        //    List<Program> programList = new List<Program>();

        //    foreach (var p in (from j in datacontextObj.PROGRAMs select j).Distinct())
        //    {
        //        Program programObj = new Program();
        //        programObj.Id = p.Id;
        //        programObj.DepartmentId = p.DepartmentId;
        //        programObj.DeparimentName = p.DEPARTMENT.DepartmentName;

        //        programObj.ProgramName = p.ProgramName;
        //        programObj.ProgramCode = p.ProgramCode;
        //        programObj.BanglaProgram = p.BanglaProgram;

        //        programList.Add(programObj);
        //    }

        //    return programList;
        //}
 
        public bool SaveSIPI_Department(SIPI_Department _sIPI_DepartmentObj)
        { 
            try
            {
                var sipi_department = (from p in datacontextObj.SIPI_DEPARTMENT
                               where (p.SIPI_DepartmentCode == _sIPI_DepartmentObj.SIPI_DepartmentCode)
                               select p).Count();
                if (sipi_department < 1)
                {
                    var newSipi_department = new SIPI_DEPARTMENT
                    {
                        SIPI_ProgramId = _sIPI_DepartmentObj.SIPI_ProgramId,

                        SIPI_DepartmentName = _sIPI_DepartmentObj.SIPI_DepartmentName,
                        SIPI_DepartmentCode = _sIPI_DepartmentObj.SIPI_DepartmentCode,
                        SIPI_DepartmentRegulation = _sIPI_DepartmentObj.Regulation,
                        BanglaSIPI_Department = _sIPI_DepartmentObj.BanglaSIPI_DepartmentName,
                        SIPI_DepartmentEntryDate = _sIPI_DepartmentObj.SIPI_DepartmentEntryDate,
                        

                    };
                    datacontextObj.SIPI_DEPARTMENT.Add(newSipi_department);
                    datacontextObj.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (Exception ex)
            {
                throw ex;

            }

        }

        public void UpdateSIPI_Department(SIPI_Department _sIPI_DepartmentObj)
        {
            var sipi_department = datacontextObj.SIPI_DEPARTMENT.First(c => c.Id == _sIPI_DepartmentObj.Id);
            sipi_department.SIPI_ProgramId = _sIPI_DepartmentObj.SIPI_ProgramId;
            sipi_department.SIPI_DepartmentName = _sIPI_DepartmentObj.SIPI_DepartmentName;
            sipi_department.SIPI_DepartmentCode = _sIPI_DepartmentObj.SIPI_DepartmentCode;
            sipi_department.BanglaSIPI_Department = _sIPI_DepartmentObj.BanglaSIPI_DepartmentName;
            sipi_department.SIPI_DepartmentRegulation = _sIPI_DepartmentObj.Regulation;
            sipi_department.SIPI_DepartmentEntryDate = _sIPI_DepartmentObj.SIPI_DepartmentEntryDate;
              
            datacontextObj.SaveChanges();
        }

        public List<SIPI_Department> GetAll_SIPIDepartment()
        {
            datacontextObj = new SIPIDBEntities();
            List<SIPI_Department> sipi_departmentList = new List<SIPI_Department>();
             
                foreach (var p in (from j in datacontextObj.SIPI_DEPARTMENT select j).Distinct())
                {
                    SIPI_Department sIpi_DepartmentObj = new SIPI_Department();
                    sIpi_DepartmentObj.Id = p.Id;
                    sIpi_DepartmentObj.SIPI_ProgramId = p.SIPI_ProgramId;

                    //if (sIpi_DepartmentObj.SIPI_ProgramName == null)
                    //{
                    //    sIpi_DepartmentObj.SIPI_ProgramName = null;
                    //}
                    //else
                    //{
                        sIpi_DepartmentObj.SIPI_ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;
                    //}
                     

                    sIpi_DepartmentObj.SIPI_DepartmentName = p.SIPI_DepartmentName;
                    sIpi_DepartmentObj.SIPI_DepartmentCode = p.SIPI_DepartmentCode;
                    sIpi_DepartmentObj.Regulation = p.SIPI_DepartmentRegulation;
                    sIpi_DepartmentObj.BanglaSIPI_DepartmentName = p.BanglaSIPI_Department;
                    sIpi_DepartmentObj.SIPI_DepartmentEntryDate = p.SIPI_DepartmentEntryDate;



                    sipi_departmentList.Add(sIpi_DepartmentObj);
                }
         
          

            return sipi_departmentList;
        }

        public void DeleteSIPI_Deprtment(SIPI_Department _sIPI_DepartmentObj)
        {
            SIPI_DEPARTMENT sipi_department = datacontextObj.SIPI_DEPARTMENT.First(c => c.Id == _sIPI_DepartmentObj.Id);
            datacontextObj.SIPI_DEPARTMENT.Remove(sipi_department);
            datacontextObj.SaveChanges();
        }
    }
}
