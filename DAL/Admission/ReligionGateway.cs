using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
    public class ReligionGateway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void DeleteReligion(Religion _ReligionObj)
        {

            RELIGION religion = datacontextObj.RELIGIONs.First(c => c.Id == _ReligionObj.Id);
            datacontextObj.RELIGIONs.Remove(religion);
            datacontextObj.SaveChanges();
        }

        public void UpdateReligion(Religion _ReligionObj)
        {

            var religion = datacontextObj.RELIGIONs.First(c => c.Id == _ReligionObj.Id);
            religion.ReligionName = _ReligionObj.ReligionName;
            religion.BanglaReligion = _ReligionObj.BanglaReligionName;

            datacontextObj.SaveChanges();
        }

        public bool SaveReligion(Religion _ReligionObj)
        {
            var relagion = (from s in datacontextObj.RELIGIONs where s.ReligionName == _ReligionObj.ReligionName 
                                ||
                                s.BanglaReligion == _ReligionObj.BanglaReligionName select s).Count();
            if (relagion < 1)
            {
                var newReligion = new RELIGION
                {
                    ReligionName = _ReligionObj.ReligionName,
                    BanglaReligion = _ReligionObj.BanglaReligionName,

                };
                datacontextObj.RELIGIONs.Add(newReligion);
                datacontextObj.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<Religion> GetAllReligion()
        {
            datacontextObj = new SIPIDBEntities();
            List<Religion> religionList = new List<Religion>();

            foreach (var p in (from j in datacontextObj.RELIGIONs select new { j.Id, j.ReligionName, j.BanglaReligion }).Distinct())
            {
                Religion religion = new Religion();
                religion.Id = p.Id;
                religion.ReligionName = p.ReligionName;
                religion.BanglaReligionName = p.BanglaReligion;

                religionList.Add(religion);
            }

            return religionList;
        }
    }
}
