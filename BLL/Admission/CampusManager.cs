using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
    public class CampusManager
    {
        CampusGetway campusGetway = new CampusGetway();
        
        public void SaveCampus(Campus _campusObj)
        {
            campusGetway.SaveCampus(_campusObj);
        }

        public List<Campus> GetAllCampus()
        {
            return campusGetway.GetAllCampus();
        }

        public void UpdateCampus(Campus _campusObj)
        {
            campusGetway.Updatecampus(_campusObj);
        }


        public void DeleteCampus(Campus _campusObj)
        {
            campusGetway.DeleteCampus(_campusObj);
        }
    }
}
