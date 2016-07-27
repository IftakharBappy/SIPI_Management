using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.StudentManagement;
using System.Data.Entity.Validation;

namespace DAL.StudentManagement
{
    public class ClassRoutineGroupGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        int id = 0;
        public void SaveClassRoutineGroup(ClassRoutineGroup _classroutinGroupObj)
        {
            //var newRoutinGroup = new ROUTINEGROUP
            //{
            //    Year = _classroutinGroupObj.Year,
            //    ProgramId = _classroutinGroupObj.ProgramId,
            //    DepartmentId = _classroutinGroupObj.DepartmentId,
            //    SemesterId = _classroutinGroupObj.SemesterId,
            //};
            //datacontextObj.ROUTINEGROUPs.Add(newRoutinGroup);
            //datacontextObj.SaveChanges();
            //id = newRoutinGroup.Id;
           
        }

       
    }
}
