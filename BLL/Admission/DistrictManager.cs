using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
  public  class DistrictManager
    {
      
        DistrictGateway gatewayObj = new DistrictGateway();

        public void DeleteDistrict(District _DistrictObj)
        {
            gatewayObj.DeleteDistrict(_DistrictObj);
        }

        public void UpdateDistrict(District _DistrictObj)
        {
            gatewayObj.UpdateDistrict(_DistrictObj);
        }

        public void SaveDistrict(District _DistrictObj)
        {
            gatewayObj.SaveDistrict(_DistrictObj);
        }

        public List<District> GetAllDistrict()
        {
            return gatewayObj.GetAllDistrict();
        }
    }
}
