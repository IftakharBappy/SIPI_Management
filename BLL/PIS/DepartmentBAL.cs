using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
  public  class DepartmentBAL
    {
      private DepartmentDAL _sUserGroupGatewayObj = new DepartmentDAL();

        public bool SaveDepartment(Department objEuserGroup)
        {
            return _sUserGroupGatewayObj.SaveDepartment(objEuserGroup);
        }

        public bool DoesExistDepartmentinSaveMode(string DepartmentName)
        {
            foreach (var anUserGroup in GetAllDepartment())
            {
                if (anUserGroup.StrDepartmentName.ToLower() == DepartmentName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistDepartmentinUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllDepartment())
            {
                if (anUserGroup.GDepartmentID != userGroupId && anUserGroup.StrDepartmentName.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(Department anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateDepartment(anUserGroup);
        }

        public bool DeleteUserGroup(Guid DepartmentId)
        {
            return _sUserGroupGatewayObj.DeleteDepartment(DepartmentId);
        }

        public List<Department> GetAllDepartment()
        {
            return _sUserGroupGatewayObj.GetAllDepartment();
        }

        public bool DoesExistAnyDepartmentUnderThisGroup(Guid DepartmentId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisDepartment(DepartmentId);
        }
    }
}
