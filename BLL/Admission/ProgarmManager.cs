using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
  public  class ProgarmManager
    {
      ProgramGetway programGetwayobj = new ProgramGetway();
           
      public bool SaveProgram(Program _programObj)
        {
            return programGetwayobj.SaveProgram(_programObj);
        }



      public List<Program> GetAllProgram()
      {
          return programGetwayobj.GetAllProgram();
      }

      public void UpdateDEpartment(Program _programObj)
      {
          programGetwayobj.UpdateDEpartment(_programObj);
      }

      public void DeleteProgram(Program _programObj)
      {
          programGetwayobj.DeleteProgram(_programObj);
      }
    }
}


