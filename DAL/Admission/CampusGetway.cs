using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
   public class CampusGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

       

        public void SaveCampus(Campus _campusObj)
        {
            var newCampus = new CAMPUSINFO
            {
                CampusName = _campusObj.CampusName,
                CampusAddress = _campusObj.CampusAddress,
                ContactPerson = _campusObj.ContactPerson,
                MobileNumber = _campusObj.MobileNumber,
                BanglaCampus = _campusObj.BanglaCampus,


            };
            datacontextObj.CAMPUSINFOes.Add(newCampus);
            datacontextObj.SaveChanges();
        }
      

        public List<Campus> GetAllCampus()
        {

            datacontextObj = new SIPIDBEntities();
            List<Campus> campusList = new List<Campus>();

            foreach (var p in (from j in datacontextObj.CAMPUSINFOes select new { j.Id, j.CampusName, j.CampusAddress, j.ContactPerson, j.MobileNumber , j.BanglaCampus}).Distinct())
            {
                Campus campus = new Campus();
                campus.Id = p.Id;
                campus.CampusName = p.CampusName;
                campus.CampusAddress = p.CampusAddress;
                campus.ContactPerson = p.ContactPerson;
                campus.MobileNumber = p.MobileNumber;
                campus.BanglaCampus = p.BanglaCampus;
                campusList.Add(campus);
                
            }

            return campusList;
        }

        public void UpdateDEpartment(Department _departmentObj)
        {
            var departmrnt = datacontextObj.DEPARTMENTs.First(c => c.Id == _departmentObj.Id);
            departmrnt.DepartmentName = _departmentObj.DepartmentName;
            departmrnt.DepartmentCode = _departmentObj.DepartmentCode;
            datacontextObj.SaveChanges();
        }

        public void Updatecampus(Campus _campusObj)
        {
            var campus = datacontextObj.CAMPUSINFOes.First(c => c.Id == _campusObj.Id);
            campus.CampusName = _campusObj.CampusName;
            campus.CampusAddress = _campusObj.CampusAddress;
            campus.ContactPerson = _campusObj.ContactPerson;
            campus.MobileNumber = _campusObj.MobileNumber;
            campus.BanglaCampus = _campusObj.BanglaCampus;
            datacontextObj.SaveChanges();  
        }

        public void DeleteCampus(Campus _campusObj)
        {
            ///// here use linq
            CAMPUSINFO campusinfo = datacontextObj.CAMPUSINFOes.First(c => c.Id == _campusObj.Id);
            datacontextObj.CAMPUSINFOes.Remove(campusinfo);
            datacontextObj.SaveChanges();
        }
    }
}
