using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.StudentManagement;

namespace DAL.StudentManagement
{
    public class ClassPeriodGetway
    {
        SIPIDBEntities dataContext = new SIPIDBEntities();

        public void SaveClassPeriod(ClassPeriod _classPeriodObj)
        {
            var newclassPeriod = new CLASSPERIOD
            {
                Period = _classPeriodObj.PeriodName,
                StartTime = _classPeriodObj.StartTime,
                EndTime = _classPeriodObj.EndTime,
            };
            dataContext.CLASSPERIODs.Add(newclassPeriod);
            dataContext.SaveChanges();
        }

        public List<ClassPeriod> LoadAllClassPeriod()
        {

            List<ClassPeriod> classPeriodList = new List<ClassPeriod>();

            foreach (var p in (from j in dataContext.CLASSPERIODs select j).Distinct())
            {

                ClassPeriod classPeriodObj = new ClassPeriod();
                classPeriodObj.Id = p.Id;
                classPeriodObj.PeriodName = p.Period;
                classPeriodObj.StartTime = p.StartTime;
                classPeriodObj.EndTime = p.EndTime;

                classPeriodList.Add(classPeriodObj);
            }

            return classPeriodList;
        }

        public void UpdateClassPeriod(ClassPeriod _classPeriodObj)
        {
            var classPeriod = dataContext.CLASSPERIODs.First(c => c.Id == _classPeriodObj.Id);
            classPeriod.Period = _classPeriodObj.PeriodName;
            classPeriod.StartTime = _classPeriodObj.StartTime;
            classPeriod.EndTime = _classPeriodObj.EndTime;
            dataContext.SaveChanges();
        }

        public void DeleteClassPeriod(ClassPeriod _classPeriodObj)
        {
            CLASSPERIOD classPeriod = dataContext.CLASSPERIODs.First(c => c.Id == _classPeriodObj.Id);
            dataContext.CLASSPERIODs.Remove(classPeriod);
            dataContext.SaveChanges();
        }
    }
}
