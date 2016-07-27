using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
     public class SIPI_ProgramGateway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

     
        public bool SaveSIPI_Program(SIPI_Program _sIPI_ProgramObj)
        {
            var sIPI_program = (from d in datacontextObj.SIPI_PROGRAM
                                where d.SIPI_ProgramName == _sIPI_ProgramObj.SIPI_ProgramName
                                   || d.SIPI_ProgramTime == _sIPI_ProgramObj.SIPI_ProgramTime
                                   || d.BanglaSIPI_Program == _sIPI_ProgramObj.BanglaSIPI_ProgramName
                              select d).Count();
            if (sIPI_program < 1)
            {
                var newDepartment = new SIPI_PROGRAM
                {
                    SIPI_ProgramName = _sIPI_ProgramObj.SIPI_ProgramName,
                    SIPI_ProgramTime = _sIPI_ProgramObj.SIPI_ProgramTime,
                    BanglaSIPI_Program = _sIPI_ProgramObj.BanglaSIPI_ProgramName,

                };
                datacontextObj.SIPI_PROGRAM.Add(newDepartment);
                datacontextObj.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }



        public void UpdateSIPI_Program(SIPI_Program _sIPI_ProgramObj)
        {
            var sipi_program = datacontextObj.SIPI_PROGRAM.First(c => c.Id == _sIPI_ProgramObj.Id);
            sipi_program.SIPI_ProgramName = _sIPI_ProgramObj.SIPI_ProgramName;
            sipi_program.SIPI_ProgramTime = _sIPI_ProgramObj.SIPI_ProgramTime;
            sipi_program.BanglaSIPI_Program = _sIPI_ProgramObj.BanglaSIPI_ProgramName;
            datacontextObj.SaveChanges();
        }

        public List<SIPI_Program> GetAllSIPI_Program()
        {
            datacontextObj = new SIPIDBEntities();
            List<SIPI_Program> sipi_programList = new List<SIPI_Program>();

            foreach (var p in (from j in datacontextObj.SIPI_PROGRAM select new { j.Id, j.SIPI_ProgramName, j.SIPI_ProgramTime, j.BanglaSIPI_Program }).Distinct())
            {
                SIPI_Program sipi_program = new SIPI_Program();
                sipi_program.Id = p.Id;
                sipi_program.SIPI_ProgramName = p.SIPI_ProgramName;
                sipi_program.SIPI_ProgramTime = p.SIPI_ProgramTime;
                sipi_program.BanglaSIPI_ProgramName = p.BanglaSIPI_Program;
                sipi_programList.Add(sipi_program);
            }

            return sipi_programList;
        }

        public void DeleteSipiProgram(SIPI_Program _sIPI_ProgramObj)
        {
            SIPI_PROGRAM sipi_program = datacontextObj.SIPI_PROGRAM.First(c => c.Id == _sIPI_ProgramObj.Id);
            datacontextObj.SIPI_PROGRAM.Remove(sipi_program);
            datacontextObj.SaveChanges();
        }
    }
}
