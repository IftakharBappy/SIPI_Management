using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
    public class DepartmentGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public bool SaveDepartment(Department _departmentObj)
        {
            var department = (from d in datacontextObj.DEPARTMENTs
                              where d.DepartmentName == _departmentObj.DepartmentName
                                  || d.DepartmentCode == _departmentObj.DepartmentCode
                                  || d.BanglaDepartment == _departmentObj.BanglaDepartment

                              select d).Count();
            if (department < 1)
            {
                var newDepartment = new DEPARTMENT
                {
                    DepartmentName = _departmentObj.DepartmentName,
                    DepartmentCode = _departmentObj.DepartmentCode,
                    BanglaDepartment = _departmentObj.BanglaDepartment,

                };
                datacontextObj.DEPARTMENTs.Add(newDepartment);
                datacontextObj.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Department> GetAllDepartment()
        {
            datacontextObj = new SIPIDBEntities();
            List<Department> departmentList = new List<Department>();

            foreach (var p in (from j in datacontextObj.DEPARTMENTs select new { j.Id, j.DepartmentName, j.DepartmentCode, j.BanglaDepartment }).Distinct())
            {
                Department department = new Department();
                department.Id = p.Id;
                department.DepartmentName = p.DepartmentName;
                department.DepartmentCode = p.DepartmentCode;
                department.BanglaDepartment = p.BanglaDepartment;
                departmentList.Add(department);
            }

            return departmentList;
        }

        public void UpdateDepartment(Department _departmentObj)
        {
            var departmrnt = datacontextObj.DEPARTMENTs.First(c => c.Id == _departmentObj.Id);
            departmrnt.DepartmentName = _departmentObj.DepartmentName;
            departmrnt.DepartmentCode = _departmentObj.DepartmentCode;
            departmrnt.BanglaDepartment = _departmentObj.BanglaDepartment;
            datacontextObj.SaveChanges();

        }


        public void DeleteDepartment(Department _departmentObj)
        {
            DEPARTMENT department = datacontextObj.DEPARTMENTs.First(c => c.Id == _departmentObj.Id);
            datacontextObj.DEPARTMENTs.Remove(department);
            datacontextObj.SaveChanges();
        }


    }
}
