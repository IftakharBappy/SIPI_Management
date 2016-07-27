using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
    public class BloodGroupsManager
    {
         BloodGroupGetway bloodGroupGetway = new BloodGroupGetway();

        public bool SaveBloodGroup(BloodGroup _bloodGroupObj)
        {
          return  bloodGroupGetway.SaveBloodGroup(_bloodGroupObj);
        }

        public void UpdateBloodGroup(BloodGroup _bloodGroupObj)
        {
            bloodGroupGetway.UpdateBloodGroup(_bloodGroupObj);
        }

        public List<BloodGroup> GetAllBloodGroup()
        {
            return bloodGroupGetway.GetAllBloodGroup();
        }

        public void DeleteBloodGroup(BloodGroup _bloodGroupObj)
        {
            bloodGroupGetway.DeleteBloodGroup(_bloodGroupObj);
        }




        
    }
}
