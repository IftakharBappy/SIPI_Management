using ENTITY.StudentManagement;
using DAL.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentManagement
{
    public class SemesterManager
    {
        SemesterGetway semesterGetwayObj =new SemesterGetway();


        public bool SaveSemester(Semester _semesterObj)
        {
           return semesterGetwayObj.SaveSemester(_semesterObj);
        }

        public List<Semester> GetAllSemester()
        {
            return semesterGetwayObj.GetAllSemester();
        }

        public void DeleteSemester(Semester _semesterObj)
        {
            semesterGetwayObj.DeleteSemester(_semesterObj);
        }

        public void SaveUpdate(Semester _semesterObj)
        {
            semesterGetwayObj.UpdateSemester(_semesterObj); 
        }

        

        
    }
}
