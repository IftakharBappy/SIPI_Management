using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.Common;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class PISCommonDAL
    {
       SIPIDBEntities datacontext = new SIPIDBEntities();

       public List<Gender> GetAllGender()
       {

           List<Gender> listUserGroup = new List<Gender>();
           var query = (from j in datacontext.PIS_tblGender select j).OrderBy(m => m.Id);
           foreach (var userGroup in query)
           {
               Gender anUserGroup = new Gender();
               anUserGroup.Id = userGroup.Id;
               anUserGroup.GenderName = userGroup.GenderName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Religion> GetAllReligion()
       {

           List<Religion> listUserGroup = new List<Religion>();
           var query = (from j in datacontext.PIS_tblReligion select j).OrderBy(m => m.ReligionName);
           foreach (var userGroup in query)
           {
               Religion anUserGroup = new Religion();
               anUserGroup.GReligionID = userGroup.GReligionID;
               anUserGroup.ReligionName = userGroup.ReligionName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<District> GetAllDistrict()
       {

           List<District> listUserGroup = new List<District>();
           var query = (from j in datacontext.PIS_tblDistrictInfo select j).OrderBy(m => m.StrDistrictName);
           foreach (var userGroup in query)
           {
               District anUserGroup = new District();
               anUserGroup.GDistrictInfoID = userGroup.GDistrictInfoID;
               anUserGroup.StrDistrictName = userGroup.StrDistrictName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<MaritalStatus> GetAllMaritalStatus()
       {

           List<MaritalStatus> listUserGroup = new List<MaritalStatus>();
           var query = (from j in datacontext.PIS_tblMaritalStatus select j).OrderBy(m => m.Status);
           foreach (var userGroup in query)
           {
               MaritalStatus anUserGroup = new MaritalStatus();
               anUserGroup.Id = userGroup.Id;
               anUserGroup.Status = userGroup.Status;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Company> GetAllCompany()
       {

           List<Company> listUserGroup = new List<Company>();
           var query = (from j in datacontext.LMS_tblCompany select j).OrderBy(m => m.strCompany);
           foreach (var userGroup in query)
           {
               Company anUserGroup = new Company();
               anUserGroup.strCompanyID = userGroup.strCompanyID;
               anUserGroup.strCompany = userGroup.strCompany;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Designation> GetAllDesignation()
       {

           List<Designation> listUserGroup = new List<Designation>();
           var query = (from j in datacontext.PIS_tblDesignationInfo select j).OrderBy(m => m.StrDesignationName);
           foreach (var userGroup in query)
           {
               Designation anUserGroup = new Designation();
               anUserGroup.GDesignationInfoID = userGroup.GDesignationInfoID;
               anUserGroup.StrDesignationName = userGroup.StrDesignationName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Work> GetAllWork()
       {

           List<Work> listUserGroup = new List<Work>();
           var query = (from j in datacontext.PIS_tblWorkTimeScheduleSetup select j).OrderBy(m => m.strWorkTimeSchedule);
           foreach (var userGroup in query)
           {
               Work anUserGroup = new Work();
               anUserGroup.GWorkTimeScheduleSetupID = userGroup.GWorkTimeScheduleSetupID;
               anUserGroup.strWorkTimeSchedule = userGroup.strWorkTimeSchedule;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Department> GetAllDepartment()
       {

           List<Department> listUserGroup = new List<Department>();
           var query = (from j in datacontext.PIS_tblDepartment select j).OrderBy(m => m.StrDepartmentName);
           foreach (var userGroup in query)
           {
               Department anUserGroup = new Department();
               anUserGroup.GDepartmentID = userGroup.GDepartmentID;
               anUserGroup.StrDepartmentName = userGroup.StrDepartmentName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Grade> GetAllGrade()
       {

           List<Grade> listUserGroup = new List<Grade>();
           var query = (from j in datacontext.PIS_tblGradeInfo select j).OrderBy(m => m.StrGradeName);
           foreach (var userGroup in query)
           {
               Grade anUserGroup = new Grade();
               anUserGroup.GGradeInfoID = userGroup.GGradeInfoID;
               anUserGroup.StrGradeName = userGroup.StrGradeName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Factory> GetAllFactory()
       {

           List<Factory> listUserGroup = new List<Factory>();
           var query = (from j in datacontext.tblFactories select j).OrderBy(m => m.StrFactoryName);
           foreach (var userGroup in query)
           {
               Factory anUserGroup = new Factory();
               anUserGroup.GFactoryID = userGroup.GFactoryID;
               anUserGroup.StrFactoryName = userGroup.StrFactoryName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<JobStatus> GetAllJobStatus()
       {

           List<JobStatus> listUserGroup = new List<JobStatus>();
           var query = (from j in datacontext.PIS_tblJobStatus select j).OrderBy(m => m.JobStatus);
           foreach (var userGroup in query)
           {
               JobStatus anUserGroup = new JobStatus();
               anUserGroup.Id = userGroup.Id;
               anUserGroup.EmpJobStatus = userGroup.JobStatus;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Country> GetAllCountry()
       {

           List<Country> listUserGroup = new List<Country>();
           var query = (from j in datacontext.PIS_tblCountry select j).OrderBy(m => m.CountryName);
           foreach (var userGroup in query)
           {
               Country anUserGroup = new Country();
               anUserGroup.Id = userGroup.Id;
               anUserGroup.CountryName = userGroup.CountryName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<BloodGroup> GetAllBloodGroup()
       {

           List<BloodGroup> listUserGroup = new List<BloodGroup>();
           var query = (from j in datacontext.PIS_tblBloodGroup select j).OrderBy(m => m.BloodGroupName);
           foreach (var userGroup in query)
           {
               BloodGroup anUserGroup = new BloodGroup();
               anUserGroup.BloodGroupID = Convert.ToInt32(userGroup.BloodGroupID);
               anUserGroup.BloodGroupName = userGroup.BloodGroupName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }
    
       public List<Category> GetAllCategory()
       {

           List<Category> listUserGroup = new List<Category>();
           var query = (from j in datacontext.GS_tblCategory select j).OrderBy(m => m.CategoryName);
           foreach (var userGroup in query)
           {
               Category anUserGroup = new Category();
               anUserGroup.CategoryName = userGroup.CategoryName;
               anUserGroup.CategoryID = userGroup.ItemCategoryID;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Section> GetAllSection()
       {

           List<Section> listUserGroup = new List<Section>();
           var query = (from j in datacontext.PIS_tblSection select j).OrderBy(m => m.SectionName);
           foreach (var userGroup in query)
           {
               Section anUserGroup = new Section();
               anUserGroup.SectionName = userGroup.SectionName;
               anUserGroup.SectionID = userGroup.SectionID;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<Division> GetAllDivision()
       {

           List<Division> listUserGroup = new List<Division>();
           var query = (from j in datacontext.PIS_tblDivision select j).OrderBy(m => m.DivisionName);
           foreach (var userGroup in query)
           {
               Division anUserGroup = new Division();
               anUserGroup.DivisionID = userGroup.DivisionID;
               anUserGroup.DivisionName = userGroup.DivisionName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<CategoryEmp> GetAllCatEmployee()
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

       public List<CategorySalary> GetAllCatEmployeeSalary()
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

       public List<EmployeeEducationInfo> GetAllDegree()
       {

           List<EmployeeEducationInfo> listUserGroup = new List<EmployeeEducationInfo>();
           var query = (from j in datacontext.tblCfgCommonTypes
                        join f in datacontext.tblCfgCommons on j.GCfgCommonTypeID equals f.GCfgCommonTypeID
                        where j.strType == "Education Degree"
                        select new { j.GCfgCommonTypeID,j.strType,f.GCfgCommonID,f.StrName}).OrderBy(m => m.StrName);
           foreach (var userGroup in query)
           {
               EmployeeEducationInfo anUserGroup = new EmployeeEducationInfo();
               anUserGroup.EductionDegreeID = userGroup.GCfgCommonID;
               anUserGroup.DegreeName = userGroup.StrName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<EmployeeEducationInfo> GetAllGroupSubject()
       {

           List<EmployeeEducationInfo> listUserGroup = new List<EmployeeEducationInfo>();
           var query = (from j in datacontext.tblCfgCommonTypes
                        join f in datacontext.tblCfgCommons on j.GCfgCommonTypeID equals f.GCfgCommonTypeID
                        where j.strType == "Group/Subject"
                        select new { j.GCfgCommonTypeID, j.strType, f.GCfgCommonID, f.StrName }).OrderBy(m => m.StrName);
           foreach (var userGroup in query)
           {
               EmployeeEducationInfo anUserGroup = new EmployeeEducationInfo();
               anUserGroup.EductionGroupSubject = userGroup.GCfgCommonID;
               anUserGroup.GroupSubjectName = userGroup.StrName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<EmployeeEducationInfo> GetAllEducationResult()
       {

           List<EmployeeEducationInfo> listUserGroup = new List<EmployeeEducationInfo>();
           var query = (from j in datacontext.tblCfgCommonTypes
                        join f in datacontext.tblCfgCommons on j.GCfgCommonTypeID equals f.GCfgCommonTypeID
                        where j.strType == "Education Result"
                        select new { j.GCfgCommonTypeID, j.strType, f.GCfgCommonID, f.StrName }).OrderBy(m => m.StrName);
           foreach (var userGroup in query)
           {
               EmployeeEducationInfo anUserGroup = new EmployeeEducationInfo();
               anUserGroup.EductionResultID = userGroup.GCfgCommonID;
               anUserGroup.EducationResultName = userGroup.StrName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }

       public List<EmployeeEducationInfo> GetAllBoardUniversity()
       {

           List<EmployeeEducationInfo> listUserGroup = new List<EmployeeEducationInfo>();
           var query = (from j in datacontext.tblCfgCommonTypes
                        join f in datacontext.tblCfgCommons on j.GCfgCommonTypeID equals f.GCfgCommonTypeID
                        where j.strType == "Education Board"
                        select new { j.GCfgCommonTypeID, j.strType, f.GCfgCommonID, f.StrName }).OrderBy(m => m.StrName);
           foreach (var userGroup in query)
           {
               EmployeeEducationInfo anUserGroup = new EmployeeEducationInfo();
               anUserGroup.EductionDegreeID = userGroup.GCfgCommonID;
               anUserGroup.EductionInstituteName = userGroup.StrName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }
       public List<EmpFamily> GetAllFamily()
       {

           List<EmpFamily> listUserGroup = new List<EmpFamily>();
           var query = (from j in datacontext.tblCfgCommonTypes
                        join f in datacontext.tblCfgCommons on j.GCfgCommonTypeID equals f.GCfgCommonTypeID
                        where j.strType == "Employee Family"
                        select new { j.GCfgCommonTypeID, j.strType, f.GCfgCommonID, f.StrName }).OrderBy(m => m.StrName);
           foreach (var userGroup in query)
           {
               EmpFamily anUserGroup = new EmpFamily();
               anUserGroup.GEmpFamilyID = userGroup.GCfgCommonID;
               anUserGroup.FamilyTypeName = userGroup.StrName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }


       public List<NomineeProfession> GetAllProfession()
       {
           List<NomineeProfession> listUserGroup = new List<NomineeProfession>();
           var query = (from j in datacontext.tblCfgCommonTypes
                        join f in datacontext.tblCfgCommons on j.GCfgCommonTypeID equals f.GCfgCommonTypeID
                        where j.strType == "Profession"
                        select new { j.GCfgCommonTypeID, j.strType, f.GCfgCommonID, f.StrName }).OrderBy(m => m.StrName);
           foreach (var userGroup in query)
           {
               NomineeProfession anUserGroup = new NomineeProfession();
               anUserGroup.GEmpFamilyProfession = userGroup.GCfgCommonID;
               anUserGroup.FamilyProfessionName = userGroup.StrName;
               listUserGroup.Add(anUserGroup);
           }
           return listUserGroup;
       }
    }
}
