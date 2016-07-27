using ENTITY.StudentManagement;
using DAL.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentManagement
{
    public class ClassRoutineGroupManager
    {
        ClassRoutineGroupGetway _classRoutineGroupGetway = new ClassRoutineGroupGetway();

        public void SaveClassRoutineGroup(ClassRoutineGroup _classroutinGroupObj)
        {
            _classRoutineGroupGetway.SaveClassRoutineGroup(_classroutinGroupObj);
        }
    }
}
