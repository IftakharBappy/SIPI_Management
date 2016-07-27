using DAL.Admission;
using ENTITY.Admission;
using ENTITY.ResultManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
    public class StudentInfoManager
    {
        StudentInfoGetway studentInfoGetway = new StudentInfoGetway();

        public void SaveStudentInfo(StudentInfo _studentInfo)
        {
            studentInfoGetway.SaveStudentInfo(_studentInfo);
        }

        public List<StudentInfo> GetAllStudentInfo()
        {
            return studentInfoGetway.GetAllStudentInfo();
        }

        public void DeletesStudentInfo(StudentInfo _studentInfo)
        {
            studentInfoGetway.DeletesStudentInfo(_studentInfo);
        }

        public void UpdateInfo(StudentInfo _studentInfo)
        {
            studentInfoGetway.UpdateInfo(_studentInfo);
        }

        public List<StudentInfo> GetAllStudentInfoByName(string name)
        {
            return studentInfoGetway.GetAllStudentInfoByName(name);
        }

        public List<StudentInfo> GetAllStudentInfoByMobile(string Mobile)
        {
            return studentInfoGetway.GetAllStudentInfoByMobile(Mobile);
        }

        public List<StudentInfo> GetAllStudentInfoByCampus(string campus)
        {
            return studentInfoGetway.GetAllStudentInfoByCampus(campus);
        }

        public List<StudentInfo> GetAllStudentInfoByDepartment(string dep)
        {
            return studentInfoGetway.GetAllStudentInfoByDepartment(dep);
        }

        public List<StudentInfo> GetAllStudentInfoByStudentId(string id)
        {
            return studentInfoGetway.GetAllStudentInfoByStudentId(id);
        }

        public List<StudentInfo> GetAllStudentInfoById(string id)
        {
            return studentInfoGetway.GetAllStudentInfoByStudentId(id);
        }

        public List<StudentInfo> GetAllStudentDepartment(string dept)
        {
            return studentInfoGetway.GetAllStudentDepartment(dept);
        }

        public int GetLastStudentForID(string dept, string year)
        {
            return studentInfoGetway.GetLastStudentForID(dept, year);
        }

        public List<StudentInfo> GetAllStudentInfoByStudentID(string StudentId)
        {
            return studentInfoGetway.GetAllStudentInfoByStudentID(StudentId);
        }



        public List<StudentInfo> GetAllStudentDepartmentSemester(string dept, string sem, string camp)
        {
            return studentInfoGetway.GetAllStudentDepartmentSemester(dept, sem, camp);
        }

        public List<StudentInfo> GetAllStudentForAssignSemester(string dept, string sem, string year)
        {
            return studentInfoGetway.GetAllStudentForAssignSemester(dept, sem, year);

        }

        public void UpdateSemesterStatus(StudentResult _studentResultObj)
        {
            studentInfoGetway.UpdateSemesterStatus(_studentResultObj);
            
        }
    }
}
