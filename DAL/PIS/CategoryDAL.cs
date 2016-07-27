using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class CategoryDAL
    {
       SIPIDBEntities datacontext = new SIPIDBEntities();
       public bool Savecategory(Category anEuserGroup)
       {
         //  datacontext = new SIPLDBMLDataContext();

           var newUserGroup = new PIS_tblCategory
           {
               CategoryID = anEuserGroup.CategoryID,
               CategoryName = anEuserGroup.CategoryName
           };
           datacontext.PIS_tblCategory.Add(newUserGroup);
           datacontext.SaveChanges();
           return true;
       }

       public bool UpdateCategory(Category anUserGroup)
       {

           var group = datacontext.PIS_tblCategory.FirstOrDefault(u => u.CategoryID == anUserGroup.CategoryID);
           group.CategoryName = anUserGroup.CategoryName;
           datacontext.SaveChanges();
           return true;
       }

       public bool DeleteCategory(Guid userGroupId)
       {


           PIS_tblCategory userGroupObj = datacontext.PIS_tblCategory.FirstOrDefault(u => u.CategoryID == userGroupId);
           datacontext.PIS_tblCategory.Remove(userGroupObj);
           datacontext.SaveChanges();
           return true;
       }

       public List<Category> GetAllCategory()
       {

           List<Category> listUserGroup = new List<Category>();
           var query = (from j in datacontext.PIS_tblCategory select j).OrderBy(m=>m.CategoryName);
           foreach (var userGroup in query)
           {
               Category anUserGroup = new Category();
               anUserGroup.CategoryID = userGroup.CategoryID;
               anUserGroup.CategoryName = userGroup.CategoryName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public bool DoesExistAnyUserUnderThisCategory(Guid CategoryID)
       {


           return (datacontext.PIS_tblCategory.Any(u => u.CategoryID == CategoryID));
       }
    }
}
