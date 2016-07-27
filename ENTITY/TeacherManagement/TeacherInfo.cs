using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.TeacherManagement
{
    public class TeacherInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string teacherName;

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }

        private int departmentId;

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        private int campusId;

        public int CampusId
        {
            get { return campusId; }
            set { campusId = value; }
        }
        private string campusName;

        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }
    }
}
