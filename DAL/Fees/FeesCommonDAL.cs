using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.Admission;
using ENTITY.StudentManagement;

namespace DAL.Fees
{
   public class FeesCommonDAL
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        public List<Semester> GetAllSemester()
        {
            datacontextObj = new SIPIDBEntities();
            List<Semester> semesterList = new List<Semester>();
            foreach (var p in (from j in datacontextObj.SEMESTERs select j).Distinct())
            {
                Semester semesterObj = new Semester();

                semesterObj.Id = p.Id;
                semesterObj.SemesterNo = p.SemesterNo;
                semesterObj.BanglaSemesterNo = p.BanglaSemesterNo;

                semesterList.Add(semesterObj);
            }

            return semesterList;
        }

        public List<int> GetAllYear()
        {
            List<int> YearList = new List<int>();
            YearList.Add(2010);
            YearList.Add(2011);
            YearList.Add(2012);
            YearList.Add(2013);
            YearList.Add(2014);
            YearList.Add(2015);
            YearList.Add(2016);
            YearList.Add(2017);
            YearList.Add(2018);
            YearList.Add(2019);
            YearList.Add(2020);
            return YearList;
        }

        public List<SIPI_Department> GetAllDepartment()
        {
            datacontextObj = new SIPIDBEntities();
            List<SIPI_Department> sipiDepartmentList = new List<SIPI_Department>();
            foreach (var p in (from j in datacontextObj.SIPI_DEPARTMENT select j).Distinct())
            {
                SIPI_Department sipiDepartmentObj = new SIPI_Department();

                sipiDepartmentObj.Id = p.Id;
                sipiDepartmentObj.SIPI_DepartmentName = p.SIPI_DepartmentName;


                sipiDepartmentList.Add(sipiDepartmentObj);
            }

            return sipiDepartmentList;
        }
    }
}
