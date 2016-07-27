using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class GradeDAL
    {
        SIPIDBEntities datacontext = new SIPIDBEntities();
        public bool SaveGrade(Grade anEuserGroup)
        {
            //  datacontext = new SIPLDBMLDataContext();

            var newUserGroup = new PIS_tblGradeInfo
            {
                GGradeInfoID = anEuserGroup.GGradeInfoID,
                GGradeTypeID = anEuserGroup.GGradeTypeID,
                StrGradeName = anEuserGroup.StrGradeName,
                StrGradeDesc = anEuserGroup.StrGradeDesc,
                numMinimumSalary = anEuserGroup.numMinimumSalary,
                numMaximumSalary = anEuserGroup.numMaximumSalary
            };
            datacontext.PIS_tblGradeInfo.Add(newUserGroup);
            datacontext.SaveChanges();
            return true;
        }

        public bool UpdateGrade(Grade anUserGroup)
        {
            var group = datacontext.PIS_tblGradeInfo.FirstOrDefault(u => u.GGradeInfoID == anUserGroup.GGradeInfoID);
            group.GGradeTypeID = anUserGroup.GGradeTypeID;
            group.StrGradeName = anUserGroup.StrGradeName;
            group.StrGradeDesc = anUserGroup.StrGradeDesc;
            group.numMinimumSalary = anUserGroup.numMinimumSalary;
            group.numMaximumSalary = anUserGroup.numMaximumSalary;
            datacontext.SaveChanges();
            return true;
        }

        public bool DeleteGrade(Guid userGroupId)
        {
            PIS_tblGradeInfo userGroupObj = datacontext.PIS_tblGradeInfo.FirstOrDefault(u => u.GGradeInfoID == userGroupId);
            datacontext.PIS_tblGradeInfo.Remove(userGroupObj);
            datacontext.SaveChanges();
            return true;
        }

        public List<Grade> GetAllGrade()
        {

            List<Grade> listUserGroup = new List<Grade>();
            var query = (from j in datacontext.PIS_tblGradeInfo select j).OrderBy(m => m.StrGradeName);
            foreach (var userGroup in query)
            {
                Grade anUserGroup = new Grade();
                anUserGroup.GGradeInfoID = userGroup.GGradeInfoID;
                anUserGroup.StrGradeName = anUserGroup.StrGradeName;
                anUserGroup.StrGradeDesc = anUserGroup.StrGradeDesc;
                anUserGroup.numMinimumSalary = anUserGroup.numMinimumSalary;
                anUserGroup.numMaximumSalary = anUserGroup.numMaximumSalary;
              //  anUserGroup.GGradeTypeID = userGroup.GGradeTypeID;
                listUserGroup.Add(anUserGroup);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisGrade(Guid GradeID)
        {
            return (datacontext.PIS_tblGradeInfo.Any(u => u.GGradeInfoID == GradeID));
        }
    }
}
