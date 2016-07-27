using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
  public  class EmployeeGenInfoBAL
    {
      private EmployeeGenInfoDAL _sUserGroupGatewayObj = new EmployeeGenInfoDAL();

        public bool SaveEmployeeInformation(EmployeeInformation objEuserGroup)
        {
            return _sUserGroupGatewayObj.SaveEmployee(objEuserGroup);
        }

        public bool DoesExistEmployeeInformationinSaveMode(string name)
        {
            foreach (var anUserGroup in GetAllEmployeeInformation())
            {
                if (anUserGroup.StrEmpName.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistEmployeeInformationinUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllEmployeeInformation())
            {
                if (anUserGroup.GEmployeeGenInfoID != userGroupId && anUserGroup.StrEmpID.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(EmployeeInformation anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateEmployee(anUserGroup);
        }

        public bool DeleteUserGroup(Guid EmployeeInformationId)
        {
            return _sUserGroupGatewayObj.DeleteEmployee(EmployeeInformationId);
        }

        public List<EmployeeInformation> GetAllEmployeeInformation()
        {
            return _sUserGroupGatewayObj.GetAllEmployee();
        }

        public bool DoesExistAnyUserUnderThisGroup(Guid EmployeeInformationId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisEmployee(EmployeeInformationId);
        }
    }
}
