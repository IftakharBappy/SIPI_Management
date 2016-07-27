using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.PIS;
using ENTITY.Common;
using ENTITY.PIS;

namespace BLL.PIS
{
   public class PISCommonBAL
    {
       PISCommonDAL obj = new PISCommonDAL();

       public List<Gender> GetAllGender()
       {
           return obj.GetAllGender();

       }

       public List<Religion> GetAllRegion()
       {
           return obj.GetAllReligion();
       }

       public List<District> GetAllDistrict()
       {
           return obj.GetAllDistrict();
       }

       public List<MaritalStatus> GetAllMaritalStatus()
       {
           return obj.GetAllMaritalStatus();
       }

       public List<Company> GetAllCompany()
       {
           return obj.GetAllCompany();
       }

       public List<Designation> GetAllDesignation()
       {
           return obj.GetAllDesignation();
       }

       public List<Work> GetAllWork()
       {
           return obj.GetAllWork();
       }

       public List<Department> GetAllDepartment()
       {
           return obj.GetAllDepartment();
       }
       public List<Grade> GetAllGrade()
       {
           return obj.GetAllGrade();
       }

       public List<Factory> GetAllFactory()
       {
           return obj.GetAllFactory();
       }

       public List<JobStatus> GetAllJobStatus()
       {
           return obj.GetAllJobStatus();
       }
       public List<Country> GetAllCountry()
       {
           return obj.GetAllCountry();
       }

       public List<BloodGroup> GetAllBoodGroup()
       {
           return obj.GetAllBloodGroup();
       }

       public List<Section> GetAllSection()
       {
           return obj.GetAllSection();
       }

       public List<Category> GetAllCategory()
       {
           return obj.GetAllCategory();
       }

       public List<Division> GetAllDivision()
       {
           return obj.GetAllDivision();
       }

       public List<CategoryEmp> GetAllEmpCategory()
       {
           return obj.GetAllCatEmployee();
       }

       public List<CategorySalary> GetAllCatEmployeeSalary()
       {
           return obj.GetAllCatEmployeeSalary();
       }


       public List<EmployeeEducationInfo> GetAllDegree()
       {
           return obj.GetAllDegree();
       }

       public List<EmployeeEducationInfo> GetAllGroupSubject()
       {
           return obj.GetAllGroupSubject();
       }
       public List<EmployeeEducationInfo> GetAllEducationResult()
       {
           return obj.GetAllEducationResult();
       }
       public List<EmployeeEducationInfo> GetAllBoardUniversity()
       {
           return obj.GetAllBoardUniversity();
       }


       public List<EmpFamily> GetAllFamily()
       {
           return obj.GetAllFamily();
       }


       public List<NomineeProfession> GetAllProfession()
       {
           return obj.GetAllProfession();
       }
    }
}
