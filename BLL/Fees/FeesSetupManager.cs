using DAL.Fees;
using ENTITY.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Fees
{
    public class FeesSetupManager
    {
        FeesSetupGetway feesSetupgetwayObj = new FeesSetupGetway();


        public void SaveFees(List<FeesSetup> _feesSetupListObj)
        {
            feesSetupgetwayObj.SaveFees(_feesSetupListObj);
        }
    }
}
