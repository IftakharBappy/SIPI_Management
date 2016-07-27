using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
  public  class ThanaManager
    {
        ThanaGateway gatewayObj = new ThanaGateway();

        public void DeleteThana(Thana _ThanaObj)
        {
            gatewayObj.DeleteThana(_ThanaObj);
        }

        public void UpdateThana(Thana _ThanaObj)
        {
            gatewayObj.UpdateThana(_ThanaObj);
        }

        public void SaveThana(Thana _ThanaObj)
        {
            gatewayObj.SaveThana(_ThanaObj);
        }

        public List<Thana> GetAllThana()
        {
            return gatewayObj.GetAllThana();
        }

        public List<Thana> LoadAllThana(int id)
        {
            return gatewayObj.LoadAllThana(id);
        }
    }
}
