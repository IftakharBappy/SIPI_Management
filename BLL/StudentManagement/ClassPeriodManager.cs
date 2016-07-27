using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.StudentManagement;
using ENTITY.StudentManagement;

namespace BLL.StudentManagement
{
    public class ClassPeriodManager
    {
        ClassPeriodGetway classPeriodGetway = new ClassPeriodGetway();
        public void SaveClassPeriod(ClassPeriod _classPeriodObj)
        {
            classPeriodGetway.SaveClassPeriod(_classPeriodObj);
        }

        public List<ClassPeriod> LoadAllClassPeriod()
        {
            return classPeriodGetway.LoadAllClassPeriod();
        }

        public void UpdateClassPeriod(ClassPeriod _classPeriodObj)
        {
            classPeriodGetway.UpdateClassPeriod(_classPeriodObj);
        }

        public void DeleteClassPeriod(ClassPeriod _classPeriodObj)
        {
            classPeriodGetway.DeleteClassPeriod(_classPeriodObj);
        }
    }
}
