using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
   public class CategoryEmpEmpBAL
    {
       private CategoryEmpEmpDAL _sUserGroupGatewayObj = new CategoryEmpEmpDAL();

        public bool SaveCategoryEmp(CategoryEmp objEuserGroup)
        {
            return _sUserGroupGatewayObj.SaveCategoryEmp(objEuserGroup);
        }

        public bool DoesExistCategoryEmpinSaveMode(string CategoryEmpName)
        {
            foreach (var anUserGroup in GetAllCategoryEmp())
            {
                if (anUserGroup.CategoryEmpName.ToLower() == CategoryEmpName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistCategoryEmpinUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllCategoryEmp())
            {
                if (anUserGroup.CategoryEmpID != userGroupId && anUserGroup.CategoryEmpName.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(CategoryEmp anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateCategoryEmp(anUserGroup);
        }

        public bool DeleteUserGroup(Guid CategoryEmpId)
        {
            return _sUserGroupGatewayObj.DeleteCategoryEmp(CategoryEmpId);
        }

        public List<CategoryEmp> GetAllCategoryEmp()
        {
            return _sUserGroupGatewayObj.GetAllCategoryEmp();
        }

        public bool DoesExistAnyUserUnderThisGroup(Guid CategoryEmpId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisCategoryEmp(CategoryEmpId);
        }
    }
}
