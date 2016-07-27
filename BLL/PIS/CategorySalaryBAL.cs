using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
   public class CategorySalaryBAL
    {
       private CategorySalaryDAL _sUserGroupGatewayObj = new CategorySalaryDAL();

        public bool SaveCategorySalary(CategorySalary objEuserGroup)
        {
            return _sUserGroupGatewayObj.SaveCategorySalary(objEuserGroup);
        }

        public bool DoesExistCategorySalaryinSaveMode(string CategorySalaryName)
        {
            foreach (var anUserGroup in GetAllCategorySalary())
            {
                if (anUserGroup.CategorySalaryName.ToLower() == CategorySalaryName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistCategorySalaryinUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllCategorySalary())
            {
                if (anUserGroup.CategorySalaryID != userGroupId && anUserGroup.CategorySalaryName.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(CategorySalary anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateCategorySalary(anUserGroup);
        }

        public bool DeleteUserGroup(Guid CategorySalaryId)
        {
            return _sUserGroupGatewayObj.DeleteCategorySalary(CategorySalaryId);
        }

        public List<CategorySalary> GetAllCategorySalary()
        {
            return _sUserGroupGatewayObj.GetAllCategorySalary();
        }

        public bool DoesExistAnyUserUnderThisGroup(Guid CategorySalaryId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisCategorySalary(CategorySalaryId);
        }
    }
}
