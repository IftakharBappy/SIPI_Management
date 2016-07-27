using DAL.Fees;
using ENTITY.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Fees
{
    public class FeesDetailsManager
    {
        FeesDetailsGetway feesDetailsGetway = new FeesDetailsGetway();
        public void SaveFeesDetails(FeesDetails feesDetails)
        {
            feesDetailsGetway.SaveFeesDetails(feesDetails);
        }

        public List<FeesDetails> GetAllFeesDetail()
        {
            return feesDetailsGetway.GetAllFeesDetail();
        }

        public void DeleteFeesDetail(FeesDetails feesDetails)
        {
            feesDetailsGetway.DeleteFeesDetail(feesDetails);
        }
    }
}
