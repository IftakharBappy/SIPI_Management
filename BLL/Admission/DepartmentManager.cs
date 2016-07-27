using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
  public  class DepartmentManager
    {
      DepartmentGetway departmentGatewayobj = new DepartmentGetway();

      public bool SaveDepartment(Department _departmentObj)
        {
            return departmentGatewayobj.SaveDepartment(_departmentObj);
        }
        
        public List<Department> GetAllDepartment()
        {
          return  departmentGatewayobj.GetAllDepartment();
        }

        public void UpdateDepartment(Department _departmentObj)
        {
            departmentGatewayobj.UpdateDepartment(_departmentObj);
        }

        public void DeleteDepartment(Department _departmentObj)
        {
            departmentGatewayobj.DeleteDepartment(_departmentObj);
        }

        //public void ChaqueDuplicat(Department _departmentObj)
        //{
        //    departmentGatewayobj.ChaqueDuplicat(_departmentObj);
        //}
    }
}
