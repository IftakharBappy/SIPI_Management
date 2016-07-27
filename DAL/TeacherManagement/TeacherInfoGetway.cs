using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.TeacherManagement;

namespace DAL.TeacherManagement
{
    public class TeacherInfoGetway
    {
        SIPIDBEntities dataContext = new SIPIDBEntities();

        public bool SaveTeacherInfo(TeacherInfo _teacherInfoObj)
        {
            var teacher = (from t in dataContext.TEACHERs where t.TeacherName == _teacherInfoObj.TeacherName select t).Count();

            if (teacher < 1)
            {
                var newTeacherInfo = new TEACHER
                {
                    TeacherName = _teacherInfoObj.TeacherName,
                    DepartmentId = _teacherInfoObj.DepartmentId,
                    CampusId = _teacherInfoObj.CampusId,
                };
                dataContext.TEACHERs.Add(newTeacherInfo);
                dataContext.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<TeacherInfo> LoadAllTeacherInfo()
        {

            List<TeacherInfo> teacherInfoList = new List<TeacherInfo>();

            foreach (var p in (from j in dataContext.TEACHERs select new { j.Id, j.TeacherName, j.DepartmentId, j.SIPI_DEPARTMENT.SIPI_DepartmentName, j.CampusId, j.CAMPUSINFO.CampusName }).Distinct())
            {

                TeacherInfo teacherInfoObj = new TeacherInfo();
                teacherInfoObj.Id = p.Id;
                teacherInfoObj.TeacherName = p.TeacherName;
                teacherInfoObj.DepartmentId = Convert.ToInt16(p.DepartmentId);
                teacherInfoObj.DepartmentName = p.SIPI_DepartmentName;
                teacherInfoObj.CampusId = Convert.ToInt16(p.CampusId);
                teacherInfoObj.CampusName = p.CampusName;


                teacherInfoList.Add(teacherInfoObj);
            }

            return teacherInfoList;
        }

        public void UpdateTeacherInfo(TeacherInfo _teacherInfoObj)
        {
            var teacherInfo = dataContext.TEACHERs.First(c => c.Id == _teacherInfoObj.Id);
            teacherInfo.TeacherName = _teacherInfoObj.TeacherName;
            teacherInfo.DepartmentId = _teacherInfoObj.DepartmentId;
            teacherInfo.CampusId = _teacherInfoObj.CampusId;
            dataContext.SaveChanges();
        }

        public void DeleteTeacherInfo(TeacherInfo _teacherInfoObj)
        {
            TEACHER teacherInfo = dataContext.TEACHERs.First(c => c.Id == _teacherInfoObj.Id);
            dataContext.TEACHERs.Remove(teacherInfo);
            dataContext.SaveChanges();
        }
    }
}
