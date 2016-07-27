using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
   public class ThanaGateway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void DeleteThana(Thana _ThanaObj)
        {

            THANA thanaObj = datacontextObj.THANAs.First(c => c.Id == _ThanaObj.Id);
            datacontextObj.THANAs.Remove(thanaObj);
            datacontextObj.SaveChanges();
        }

        public void UpdateThana(Thana _ThanaObj)
        {

            var thana = datacontextObj.THANAs.First(c => c.Id == _ThanaObj.Id);
            thana.ThanaName = _ThanaObj.ThanaName;
            thana.BanglaThanaName = _ThanaObj.BanglaThanaName;
            thana.DistrictId = _ThanaObj.DistrictId;
                
            datacontextObj.SaveChanges();
        }

        public void SaveThana(Thana _ThanaObj)
        {
            var newthanaObj = new THANA
            {
                ThanaName = _ThanaObj.ThanaName,
                DistrictId = _ThanaObj.DistrictId,
                BanglaThanaName  =_ThanaObj.BanglaThanaName
            };
            datacontextObj.THANAs.Add(newthanaObj);
            datacontextObj.SaveChanges();
        }

        public List<Thana> GetAllThana()
        {
            datacontextObj = new SIPIDBEntities();
            List<Thana> ThanaList = new List<Thana>();
            foreach (var p in (from j in datacontextObj.THANAs select j).Distinct())
            {
                Thana thanaObj = new Thana();
                thanaObj.Id = p.Id;
                thanaObj.ThanaName = p.ThanaName;
                thanaObj.BanglaThanaName = p.BanglaThanaName;
 
                thanaObj.DistrictId = p.DistrictId;
                thanaObj.DistrictName = p.DISTRICT.DistrictName;

                ThanaList.Add(thanaObj);
            }

            return ThanaList;
        }

        public List<Thana> LoadAllThana(int id)
        {
            List<Thana> thanaList = new List<Thana>();

            // -1 for all categories
            if (id == -1)
            {
                foreach (var p in (from j in datacontextObj.THANAs
                                   select new
                                   {
                                       j.Id,
                                       j.ThanaName,
                                       j.BanglaThanaName,
                                       j.DistrictId,
                                       j.DISTRICT.DistrictName,
                                   }).Distinct())
                {

                    Thana thanaObj = new Thana();
                    thanaObj.Id = p.Id;
                    thanaObj.ThanaName = p.ThanaName;
                    thanaObj.BanglaThanaName = p.BanglaThanaName;
                    thanaObj.DistrictId = p.DistrictId;
                    thanaObj.DistrictName = p.DistrictName;

                    thanaList.Add(thanaObj);
                }
            }

            else
            {

                foreach (var p in (from j in datacontextObj.THANAs
                                   where j.DistrictId == id
                                   select new
                                   {
                                       j.Id,
                                       j.ThanaName,
                                       j.BanglaThanaName,
                                       j.DistrictId,
                                       j.DISTRICT.DistrictName,
                                   }).Distinct())
                {
                    Thana thanaObj = new Thana();
                    thanaObj.Id = p.Id;
                    thanaObj.ThanaName = p.ThanaName;
                    thanaObj.BanglaThanaName = p.BanglaThanaName;
                    thanaObj.DistrictId = p.DistrictId;
                    thanaObj.DistrictName = p.DistrictName;

                    thanaList.Add(thanaObj);

                }
            }

            return thanaList;
            
          
        }
    }
}
