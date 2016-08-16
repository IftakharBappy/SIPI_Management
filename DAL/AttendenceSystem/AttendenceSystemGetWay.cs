using DATA;
using ENTITY.AttendenceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AttendenceSystem
{
    public class AttendenceSystemGetWay
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void SaveStudentAttendence(List<StudentAttendence> _studentAttendenceList)
        {



            foreach (StudentAttendence item in _studentAttendenceList)
            {
                var newStudentAttendence = new STUDENT_ATTENDENCE
                {
                    DepartmentId = item.DepartmentId,
                    SemesterId = item.SemesterId,
                    CampusId = item.CampusId,
                    StudentPKId = item.StudentPKId,
                    Date = item.Date,
                    Year = item.Year.ToString(),
                    Status = item.Status,
                };
                datacontextObj.STUDENT_ATTENDENCE.Add(newStudentAttendence);
                datacontextObj.SaveChanges();
            }

        }

        public List<StudentAttendence> GetSearchStudents(string dept, string semester, string year, string date)
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentAttendence> studentInfoList = new List<StudentAttendence>();

            foreach (var p in (from j in datacontextObj.STUDENT_ATTENDENCE
                               where j.SIPI_DEPARTMENT.SIPI_DepartmentName.StartsWith(dept) 
                               && j.SEMESTER.SemesterNo.StartsWith(semester)
                               //&& j.Date.Equals(date)
                               //|| j.Year.Equals(year)
                               select j).Distinct())
            {
                StudentAttendence createStudentAttendence = new StudentAttendence();
                createStudentAttendence.ID = p.ID;
                createStudentAttendence.StudentPKId = p.StudentPKId;
                createStudentAttendence.StudentName = p.ADMISSIONINFO.ApplicantName;
                createStudentAttendence.DepartmentId = p.DepartmentId;
                createStudentAttendence.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createStudentAttendence.SemesterNo = p.SEMESTER.SemesterNo;
                createStudentAttendence.Date = p.Date;
                createStudentAttendence.Year = Convert.ToInt32(p.Year);
                createStudentAttendence.Status = p.Status;
                createStudentAttendence.CampusName = p.CAMPUSINFO.CampusName;
                studentInfoList.Add(createStudentAttendence);
            }
            return studentInfoList;
        }

        public List<StudentAttendence> GetAllStudentAttendence()
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentAttendence> attendenceList = new List<StudentAttendence>();
            foreach (var p in (from j in datacontextObj.STUDENT_ATTENDENCE select j).Distinct())
            {
                StudentAttendence createStudentAttendence = new StudentAttendence();
                createStudentAttendence.ID = p.ID;
                createStudentAttendence.StudentPKId = p.StudentPKId;
                createStudentAttendence.StudentName = p.ADMISSIONINFO.ApplicantName;
                createStudentAttendence.DepartmentId = p.DepartmentId;
                createStudentAttendence.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createStudentAttendence.SemesterNo = p.SEMESTER.SemesterNo;
                createStudentAttendence.Date = p.Date;
                createStudentAttendence.Year = Convert.ToInt32(p.Year);
                createStudentAttendence.Status = p.Status;
                createStudentAttendence.CampusName = p.CAMPUSINFO.CampusName;
                attendenceList.Add(createStudentAttendence);
            }

            return attendenceList;
        }
    }
}
