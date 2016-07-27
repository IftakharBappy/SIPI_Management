using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.TeacherManagement;
using ENTITY.TeacherManagement;

namespace BLL.TeacherManagement
{
    public class TeacherInfoManager
    {
        TeacherInfoGetway teacherInfoGetway = new TeacherInfoGetway();
        public bool SaveTeacherInfo(TeacherInfo _teacherInfoObj)
        {
           return teacherInfoGetway.SaveTeacherInfo(_teacherInfoObj);
        }

        public List<TeacherInfo> LoadAllTeacherInfo()
        {
            return teacherInfoGetway.LoadAllTeacherInfo();
        }

        public void UpdateTeacherInfo(TeacherInfo _productTypeInfoObj)
        {
            teacherInfoGetway.UpdateTeacherInfo(_productTypeInfoObj);
        }

        public void DeleteTeacherInfo(TeacherInfo _productTypeInfoObj)
        {
            teacherInfoGetway.DeleteTeacherInfo(_productTypeInfoObj);
        }
    }
}
