using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class SectionDAL
    {
        SIPIDBEntities datacontext = new SIPIDBEntities();
        public bool SaveSection(Section anEuserGroup)
        {
            //  datacontext = new SIPLDBMLDataContext();

            var newUserGroup = new PIS_tblSection
            {
                SectionID = anEuserGroup.SectionID,
                SectionName = anEuserGroup.SectionName
            };
            datacontext.PIS_tblSection.Add(newUserGroup);
            datacontext.SaveChanges();
            return true;
        }

        public bool UpdateSection(Section anUserGroup)
        {

            var group = datacontext.PIS_tblSection.FirstOrDefault(u => u.SectionID == anUserGroup.SectionID);
            group.SectionName = anUserGroup.SectionName;
            datacontext.SaveChanges();
            return true;
        }

        public bool DeleteSection(Guid userGroupId)
        {


            PIS_tblSection userGroupObj = datacontext.PIS_tblSection.FirstOrDefault(u => u.SectionID == userGroupId);
            datacontext.PIS_tblSection.Remove(userGroupObj);
            datacontext.SaveChanges();
            return true;
        }

        public List<Section> GetAllSection()
        {

            List<Section> listUserGroup = new List<Section>();
            var query = (from j in datacontext.PIS_tblSection select j).OrderBy(m => m.SectionName);
            foreach (var userGroup in query)
            {
                Section anUserGroup = new Section();
                anUserGroup.SectionID = userGroup.SectionID;
                anUserGroup.SectionName = userGroup.SectionName;
                listUserGroup.Add(anUserGroup);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisSection(Guid SectionID)
        {


            return (datacontext.PIS_tblSection.Any(u => u.SectionID == SectionID));
        }
    }
}
