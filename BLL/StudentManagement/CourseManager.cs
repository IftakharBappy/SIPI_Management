using ENTITY.StudentManagement;
using DAL.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.ResultManagement;

namespace BLL.StudentManagement
{
    public class CourseManager
    {
        CourseGetway courseGetwayObj = new CourseGetway();
 
        public void SaveCourse(Course _courseObj)
        {
            courseGetwayObj.SaveCourse(_courseObj);
        }

        public List<Course> GetAllCourse()
        {
            return courseGetwayObj.GetAllCourse();
        }

        public void DeleteSemester(Course _courseObj)
        {
            courseGetwayObj.DeleteSemester(_courseObj);
        }

        public void UpdateCourse(Course _courseObj)
        {
            courseGetwayObj.UpdateSemester(_courseObj); 
        }

        public List<Course> GetAllCourseByDepartment(string dept, string semester)
        {
            return courseGetwayObj.GetAllCourseByDepartment(dept, semester);
        }



        public List<Course> GetAllCourse(int id)
        {
            return courseGetwayObj.GetAllCourse(id);
        }

      

        public List<Course> GetAllCourseBysemesterDept(int SemesID, int deptId)
        {
            return courseGetwayObj.GetAllCourseBysemesterDept(SemesID, deptId);
        }

        public List<Course> GetCourseBydeptSemester(string dept, string sem)
        {
            return courseGetwayObj.GetCourseBydeptSemester(dept, sem);
            
        }



        public List<StudentResult> GetAssignedCourse()
        {
            return courseGetwayObj.GetAssignedCourse();

        }
    }
}
