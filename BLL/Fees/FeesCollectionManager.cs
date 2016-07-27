using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fees;
using ENTITY.Fees;
using ENTITY.Report.Fees;

namespace BLL.Fees
{
   public class FeesCollectionManager
    {
       FeesCollectionGateway _feesCollectionGateWayObj = new FeesCollectionGateway();

        public List<ENTITY.Fees.FeesDetails> GetSemesterFeesDetails(ENTITY.Fees.FeesDetails obj)
        {
            return _feesCollectionGateWayObj.GetSemesterFeesDetails(obj);
        }

        public void SaveFeesCollectionDetails(ENTITY.Fees.FeesCollection obj)
        {
            _feesCollectionGateWayObj.SaveFeesCollectionDetails(obj);
        }

        public List<RStudentFees> GetCollectionReportDetails(FeesCollection obj)
        {
            return _feesCollectionGateWayObj.GetCollectionReportDetails(obj);
        }

        public List<FeesCollection> GetAllCollection()
        {
            return _feesCollectionGateWayObj.GetAllCollection();
        }

        public List<FeesCollection> GetCollection(DateTime startDate, DateTime endDate, int campus)
        {
            return _feesCollectionGateWayObj.GetCollection(startDate, endDate, campus);
        }
    }
}
