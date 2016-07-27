using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.PIS;

namespace BLL.PIS
{
    public class CategoryBAL
    {
        private CategoryDAL _sUserGroupGatewayObj = new CategoryDAL();

        public bool SaveCategory(Category objEuserGroup)
        {
            return _sUserGroupGatewayObj.Savecategory(objEuserGroup);
        }

        public bool DoesExistCategoryinSaveMode(string CategoryName)
        {
            foreach (var anUserGroup in GetAllCategory())
            {
                if (anUserGroup.CategoryName.ToLower() == CategoryName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesExistCategoryinUpdateMode(string groupName, Guid userGroupId)
        {
            foreach (var anUserGroup in GetAllCategory())
            {
                if (anUserGroup.CategoryID != userGroupId && anUserGroup.CategoryName.ToLower() == groupName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserGroup(Category anUserGroup)
        {
            return _sUserGroupGatewayObj.UpdateCategory(anUserGroup);
        }

        public bool DeleteUserGroup(Guid categoryId)
        {
            return _sUserGroupGatewayObj.DeleteCategory(categoryId);
        }

        public List<Category> GetAllCategory()
        {
            return _sUserGroupGatewayObj.GetAllCategory();
        }

        public bool DoesExistAnyUserUnderThisGroup(Guid categoryId)
        {
            return _sUserGroupGatewayObj.DoesExistAnyUserUnderThisCategory(categoryId);
        }
    }
}
