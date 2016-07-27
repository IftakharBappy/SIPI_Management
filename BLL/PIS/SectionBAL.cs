using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
  public  class SectionBAL
    {
      private SectionDAL _sUserGroupGatewayObj = new SectionDAL();

        public bool SaveSection(Section objEuserGroup)
        {
            return _sUserGroupGatewayObj.SaveSection(objEuserGroup);
        }

        public bool DoesExistSectioninSaveMode(string SectionName)
        {
            foreach (var anUserGroup in GetAllSection())
            {
                if (anUserGroup.SectionName.ToLower() == SectionName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistSectioninUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllSection())
            {
                if (anUserGroup.SectionID != userGroupId && anUserGroup.SectionName.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(Section anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateSection(anUserGroup);
        }

        public bool DeleteUserGroup(Guid SectionId)
        {
            return _sUserGroupGatewayObj.DeleteSection(SectionId);
        }

        public List<Section> GetAllSection()
        {
            return _sUserGroupGatewayObj.GetAllSection();
        }

        public bool DoesExistAnyUserUnderThisGroup(Guid SectionId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisSection(SectionId);
        }
    }
}
