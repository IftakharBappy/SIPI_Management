using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
    public class BloodGroupGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();


        public bool SaveBloodGroup(BloodGroup _bloodGroupObj)
        {
            var bloodgroup = (from s in datacontextObj.BLOODGROUPs where s.BloodGroupName == _bloodGroupObj.BloodGroupName select s).Count();
            if (bloodgroup < 1)
            {
                var newbloodgroup = new BLOODGROUP
                {
                    BloodGroupName = _bloodGroupObj.BloodGroupName,
                    
                };
                datacontextObj.BLOODGROUPs.Add(newbloodgroup);
                datacontextObj.SaveChanges();

                return true;
            }
            else
                return false;
             
        }

        public List<BloodGroup> GetAllBloodGroup()
        { 
            datacontextObj = new SIPIDBEntities();
            List<BloodGroup> bloodGroupList = new List<BloodGroup>();

            foreach (var p in (from j in datacontextObj.BLOODGROUPs select new { j.ID, j.BloodGroupName }).Distinct())
            {
                BloodGroup bloodGroup = new BloodGroup();
                bloodGroup.Id = p.ID;
                bloodGroup.BloodGroupName = p.BloodGroupName;

                bloodGroupList.Add(bloodGroup);

            }

            return bloodGroupList;
        }

        public void DeleteBloodGroup(BloodGroup _bloodGroupObj)
        {
            BLOODGROUP bloodGroupinfo = datacontextObj.BLOODGROUPs.First(c => c.ID == _bloodGroupObj.Id);
            datacontextObj.BLOODGROUPs.Remove(bloodGroupinfo);
            datacontextObj.SaveChanges();
        }

        public void UpdateBloodGroup(BloodGroup _bloodGroupObj)
        {
            var bloodGroup = datacontextObj.BLOODGROUPs.First(c => c.ID == _bloodGroupObj.Id);
            bloodGroup.BloodGroupName = _bloodGroupObj.BloodGroupName;
             datacontextObj.SaveChanges();

        }
    }
}
