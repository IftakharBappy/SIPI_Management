using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class DepartmentDAL
    {
        SIPIDBEntities datacontext = new SIPIDBEntities();
        public bool SaveDepartment(Department anEuserGroup)
        {
            //  datacontext = new SIPLDBMLDataContext();

            var newUserGroup = new PIS_tblDepartment
            {
                GDepartmentID = anEuserGroup.GDepartmentID,
                StrDepartmentName = anEuserGroup.StrDepartmentName,
                StrDepartmentCode = anEuserGroup.StrDepartmentCode
            };
            datacontext.PIS_tblDepartment.Add(newUserGroup);
            datacontext.SaveChanges();
            return true;
        }

        public bool UpdateDepartment(Department anUserGroup)
        {

            var group = datacontext.PIS_tblDepartment.FirstOrDefault(u => u.GDepartmentID == anUserGroup.GDepartmentID);
            group.StrDepartmentName = anUserGroup.StrDepartmentName;
            group.StrDepartmentCode = anUserGroup.StrDepartmentCode;
            datacontext.SaveChanges();
            return true;
        }

        public bool DeleteDepartment(Guid userGroupId)
        {


            PIS_tblDepartment userGroupObj = datacontext.PIS_tblDepartment.FirstOrDefault(u => u.GDepartmentID == userGroupId);
            datacontext.PIS_tblDepartment.Remove(userGroupObj);
            datacontext.SaveChanges();
            return true;
        }

        public List<Department> GetAllDepartment()
        {

            List<Department> listUserGroup = new List<Department>();
            var query = (from j in datacontext.PIS_tblDepartment select j).OrderBy(m => m.GDepartmentID);
            foreach (var userGroup in query)
            {
                Department anUserGroup = new Department();
                anUserGroup.GDepartmentID = userGroup.GDepartmentID;
                anUserGroup.StrDepartmentName = userGroup.StrDepartmentName;
                anUserGroup.StrDepartmentCode = userGroup.StrDepartmentCode;
                listUserGroup.Add(anUserGroup);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisDepartment(Guid DepartmentID)
        {


            return (datacontext.PIS_tblDepartment.Any(u => u.GDepartmentID == DepartmentID));
        }
    }
}
