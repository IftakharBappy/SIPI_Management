using DAL.ResultManagement;
using ENTITY.ResultManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ResultManagement
{
    
    public class StudentResultManager
    {
        StudentResultGetwey studentResultGetweyObj = new StudentResultGetwey();

        public void SaveAssignedStudent(List<StudentResult> _studentResultList)
        {
            studentResultGetweyObj.SaveAssignedStudent(_studentResultList);
        }

        public List<StudentResult> GetStudentForMarks(string dept, string sem, int year, string course)
        {
            return studentResultGetweyObj.GetStudentForMarks(dept, sem, year, course);
        }


        public void UpdateMarks(List<StudentResult> _StudentResultList)
        {
            studentResultGetweyObj.UpdateMarks(_StudentResultList);

        }



        public List<StudentResult> GetStudentMarksSeetSemesterWise(string dept, string sem, int year, string _studentId)
        {
            return studentResultGetweyObj.GetStudentMarksSeetSemesterWise(dept, sem, year, _studentId);


        }

        public List<StudentResult> GetStudentMarksSeetSemesterWisePerStudent(string dept, string sem, int year)
        {
            return studentResultGetweyObj.GetStudentMarksSeetSemesterWisePerStudent(dept, sem, year);

        }
    }
}

