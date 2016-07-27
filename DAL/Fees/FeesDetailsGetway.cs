using DATA;
using ENTITY.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fees
{
    public class FeesDetailsGetway
    {
        SIPIDBEntities dataContext = new SIPIDBEntities();
        public void SaveFeesDetails(FeesDetails feesDetails)
        {
            var newFees = new FEESDETAIL
            {

                Name = feesDetails.FeesName,
            };
            dataContext.FEESDETAILS.Add(newFees);
            dataContext.SaveChanges();
        }

        public List<FeesDetails> GetAllFeesDetail()
        {
            dataContext = new SIPIDBEntities();
            List<FeesDetails> feesList = new List<FeesDetails>();
            foreach (var p in (from j in dataContext.FEESDETAILS select new { j.Id, j.Name}).Distinct())
            {
                FeesDetails feesDetails = new FeesDetails();
                feesDetails.Id = p.Id;
                feesDetails.FeesName = p.Name;


                feesList.Add(feesDetails);
            }

            return feesList;
        }
         

        public void DeleteFeesDetail(FeesDetails feesDetails)
        {
            FEESDETAIL feesDetail = dataContext.FEESDETAILS.First(c => c.Id == feesDetails.Id);
            dataContext.FEESDETAILS.Remove(feesDetail);
            dataContext.SaveChanges();
        }
    }
}
