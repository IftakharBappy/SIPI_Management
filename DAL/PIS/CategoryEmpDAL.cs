using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class CategoryEmpEmpDAL
    {
        SIPIDBEntities datacontext = new SIPIDBEntities();
        public bool SaveCategoryEmp(CategoryEmp anEuserGroup)
        {
            //  datacontext = new SIPLDBMLDataContext();

            var newUserGroup = new PIS_tblCategoryEmp
            {
                CategoryEmpID = anEuserGroup.CategoryEmpID,
                CategoryEmpName = anEuserGroup.CategoryEmpName
            };
            datacontext.PIS_tblCategoryEmp.Add(newUserGroup);
            datacontext.SaveChanges();
            return true;
        }

        public bool UpdateCategoryEmp(CategoryEmp anUserGroup)
        {

            var group = datacontext.PIS_tblCategoryEmp.FirstOrDefault(u => u.CategoryEmpID == anUserGroup.CategoryEmpID);
            group.CategoryEmpName = anUserGroup.CategoryEmpName;
            datacontext.SaveChanges();
            return true;
        }

        public bool DeleteCategoryEmp(Guid userGroupId)
        {


            PIS_tblCategoryEmp userGroupObj = datacontext.PIS_tblCategoryEmp.FirstOrDefault(u => u.CategoryEmpID == userGroupId);
            datacontext.PIS_tblCategoryEmp.Remove(userGroupObj);
            datacontext.SaveChanges();
            return true;
        }

        public List<CategoryEmp> GetAllCategoryEmp()
        {

            List<CategoryEmp> listUserGroup = new List<CategoryEmp>();
            var query = (from j in datacontext.PIS_tblCategoryEmp select j).OrderBy(m => m.CategoryEmpName);
            foreach (var userGroup in query)
            {
                CategoryEmp anUserGroup = new CategoryEmp();
                anUserGroup.CategoryEmpID = userGroup.CategoryEmpID;
                anUserGroup.CategoryEmpName = userGroup.CategoryEmpName;
                listUserGroup.Add(anUserGroup);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisCategoryEmp(Guid CategoryEmpID)
        {


            return (datacontext.PIS_tblCategoryEmp.Any(u => u.CategoryEmpID == CategoryEmpID));
        }
    }
}
