using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
    public class BatchManager
    {
        BatchGetway batchGetway = new BatchGetway();

        public void SaveBatch(Batch _batchObj)
        {
            batchGetway.SaveBatch(_batchObj);
        }

        public List<Batch> GetAllBatch()
        {
            return batchGetway.GetAllBatch();
            
        }

        public void DeleteBatch(Batch _batchObj)
        {
            batchGetway.DeleteBatch(_batchObj);

        }

       
        public void UpdateBatch(Batch _batchObj)
        {
            batchGetway.UpdateBatch(_batchObj);

        }

        public List<Batch> GetAllBatchNA()
        {
            return batchGetway.GetAllBatchNA();
        }
    }
}
