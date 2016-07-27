using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
   public class DistrictGateway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

       
        public void DeleteDistrict(District _DistrictObj)
        {

            DISTRICT department = datacontextObj.DISTRICTs.First(c => c.Id == _DistrictObj.Id);
            datacontextObj.DISTRICTs.Remove(department);
            datacontextObj.SaveChanges();
        }

        public void UpdateDistrict(District _DistrictObj)
        {

            var district = datacontextObj.DISTRICTs.First(c => c.Id == _DistrictObj.Id);
            district.DistrictName = _DistrictObj.DistrictName;
            district.BanglaDistrict = _DistrictObj.BanglaDistrict;
            
            datacontextObj.SaveChanges();
        }

        public void SaveDistrict(District _DistrictObj)
        {
            var newDepartment = new DISTRICT
            {
                DistrictName = _DistrictObj.DistrictName,
                BanglaDistrict = _DistrictObj.BanglaDistrict,
                

            };
            datacontextObj.DISTRICTs.Add(newDepartment);
            datacontextObj.SaveChanges();
        }

        public List<District> GetAllDistrict()
        {
            datacontextObj = new SIPIDBEntities();
            List<District> DistrictList = new List<District>();
            foreach (var p in (from j in datacontextObj.DISTRICTs select new { j.Id, j.DistrictName, j.BanglaDistrict }).Distinct())
            {
                District district = new District();
                district.Id = p.Id;
                district.DistrictName = p.DistrictName;
                district.BanglaDistrict = p.BanglaDistrict;


                DistrictList.Add(district);
            }

            return DistrictList;
        }
    }
}
