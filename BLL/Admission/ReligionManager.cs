using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
   public class ReligionManager
    {
       ReligionGateway gatewayObj = new ReligionGateway();

       public void DeleteReligion( Religion _ReligionObj)
       {
           gatewayObj.DeleteReligion(_ReligionObj);
       }

       public void UpdateReligion( Religion _ReligionObj)
       {
           gatewayObj.UpdateReligion(_ReligionObj);
       }

       public bool SaveReligion( Religion _ReligionObj)
       {
           return gatewayObj.SaveReligion(_ReligionObj);
       }

       public List<Religion> GetAllReligion()
       {
          return gatewayObj.GetAllReligion( );
       }
    }
}
