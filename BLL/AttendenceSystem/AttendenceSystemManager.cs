using DAL.AttendenceSystem;
using ENTITY.AttendenceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AttendenceSystem
{
    public class AttendenceSystemManager
    {
        AttendenceSystemGetWay attendenceSystemGetWayOnj = new AttendenceSystemGetWay();

        public void SaveStudentAttendence(List<StudentAttendence> _studentAttendenceList)
        {
            attendenceSystemGetWayOnj.SaveStudentAttendence(_studentAttendenceList);
        }

        public List<StudentAttendence> GetSearchStudents(string dept, string semester, string year, string date)
        {
            return attendenceSystemGetWayOnj.GetSearchStudents(dept, semester, year, date);
        }

        public List<StudentAttendence> GetAllStudentAttendence()
        {
            return attendenceSystemGetWayOnj.GetAllStudentAttendence();
        }
    }
}
