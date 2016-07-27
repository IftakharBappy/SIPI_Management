using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class CategorySalaryDAL
    {
        SIPIDBEntities datacontext = new SIPIDBEntities();
        public bool SaveCategorySalary(CategorySalary anEuserGroup)
        {
            //  datacontext = new SIPLDBMLDataContext();

            var newUserGroup = new PIS_tblCategorySalary
            {
                CategorySalaryID = anEuserGroup.CategorySalaryID,
                CategorySalaryName = anEuserGroup.CategorySalaryName
            };
            datacontext.PIS_tblCategorySalary.Add(newUserGroup);
            datacontext.SaveChanges();
            return true;
        }

        public bool UpdateCategorySalary(CategorySalary anUserGroup)
        {

            var group = datacontext.PIS_tblCategorySalary.FirstOrDefault(u => u.CategorySalaryID == anUserGroup.CategorySalaryID);
            group.CategorySalaryName = anUserGroup.CategorySalaryName;
            datacontext.SaveChanges();
            return true;
        }

        public bool DeleteCategorySalary(Guid userGroupId)
        {


            PIS_tblCategorySalary userGroupObj = datacontext.PIS_tblCategorySalary.FirstOrDefault(u => u.CategorySalaryID == userGroupId);
            datacontext.PIS_tblCategorySalary.Remove(userGroupObj);
            datacontext.SaveChanges();
            return true;
        }

        public List<CategorySalary> GetAllCategorySalary()
        {

            List<CategorySalary> listUserGroup = new List<CategorySalary>();
            var query = (from j in datacontext.PIS_tblCategorySalary select j).OrderBy(m => m.CategorySalaryName);
            foreach (var userGroup in query)
            {
                CategorySalary anUserGroup = new CategorySalary();
                anUserGroup.CategorySalaryID = userGroup.CategorySalaryID;
                anUserGroup.CategorySalaryName = userGroup.CategorySalaryName;
                listUserGroup.Add(anUserGroup);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisCategorySalary(Guid CategorySalaryID)
        {


            return (datacontext.PIS_tblCategorySalary.Any(u => u.CategorySalaryID == CategorySalaryID));
        }
    }
}
