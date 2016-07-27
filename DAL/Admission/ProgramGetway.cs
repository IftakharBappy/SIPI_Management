using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
    public class ProgramGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public bool SaveProgram(Program _programObj)
        {

            try
            {
                var program = (from p in datacontextObj.PROGRAMs
                               where (
                               p.DepartmentId == _programObj.DepartmentId
                               && 
                               p.ProgramCode == _programObj.ProgramCode)
                               select p).Count();
                if (program < 1)
                {
                    var newProgram = new PROGRAM
                    {
                        DepartmentId = _programObj.DepartmentId,

                        ProgramName = _programObj.ProgramName,
                        ProgramCode = _programObj.ProgramCode,
                        BanglaProgram = _programObj.BanglaProgram,

                    };
                    datacontextObj.PROGRAMs.Add(newProgram);
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

        public List<Department> GetAllBranchID()
        {
            List<Department> listOfDepartmentID = new List<Department>();
            try
            {

                foreach (var p in datacontextObj.DEPARTMENTs)
                {
                    Department departmentObj = new Department();
                    departmentObj.Id = p.Id;
                    departmentObj.DepartmentCode = p.DepartmentCode;
                    departmentObj.DepartmentName = p.DepartmentName;
                    listOfDepartmentID.Add(departmentObj);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return listOfDepartmentID;
        }

        public List<Program> GetAllProgram()
        {
            datacontextObj = new SIPIDBEntities();
            List<Program> programList = new List<Program>();

            foreach (var p in (from j in datacontextObj.PROGRAMs select j).Distinct())
            {
                Program programObj = new Program();
                programObj.Id = p.Id;
                programObj.DepartmentId = p.DepartmentId;
                programObj.DeparimentName = p.DEPARTMENT.DepartmentName;
                   
                programObj.ProgramName = p.ProgramName;
                programObj.ProgramCode = p.ProgramCode;
                programObj.BanglaProgram = p.BanglaProgram;

                programList.Add(programObj);
            }

            return programList;
        }

        public void UpdateDEpartment(Program _programObj)
        {
            var program = datacontextObj.PROGRAMs.First(c => c.Id == _programObj.Id);
            program.DepartmentId = _programObj.DepartmentId;
            program.ProgramName = _programObj.ProgramName;
            program.ProgramCode = _programObj.ProgramCode;
            datacontextObj.SaveChanges();
        }

        public void DeleteProgram(Program _programObj)
        {
            PROGRAM program = datacontextObj.PROGRAMs.First(c => c.Id == _programObj.Id);
            datacontextObj.PROGRAMs.Remove(program);
            datacontextObj.SaveChanges();
        }
    }
}
