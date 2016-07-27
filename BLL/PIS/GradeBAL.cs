using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
   public class GradeBAL
    {
       private GradeDAL _sUserGroupGatewayObj = new GradeDAL();

        public bool SaveGrade(Grade objEuserGroup)
        {
            return _sUserGroupGatewayObj.SaveGrade(objEuserGroup);
        }

        public bool DoesExistGradeinSaveMode(string GradeName)
        {
            foreach (var anUserGroup in GetAllGrade())
            {
                if (anUserGroup.StrGradeName== GradeName)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistGradeinUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllGrade())
            {
                if (anUserGroup.GGradeInfoID != userGroupId && anUserGroup.StrGradeName.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(Grade anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateGrade(anUserGroup);
        }

        public bool DeleteUserGroup(Guid GradeId)
        {
            return _sUserGroupGatewayObj.DeleteGrade(GradeId);
        }

        public List<Grade> GetAllGrade()
        {
            return _sUserGroupGatewayObj.GetAllGrade();
        }

        public bool DoesExistAnyUserUnderThisGroup(Guid GradeId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisGrade(GradeId);
        }
    }
}
