using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Admission
{
    public class BatchGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void SaveBatch(Batch _batchObj)
        {
            var newBatch = new BATCH
            {
                BatchNo = _batchObj.BatchNo,
                Year = Convert.ToInt16(_batchObj.Year),
                BanglaBatch = _batchObj.BanglaBatch,

              
            };
            datacontextObj.BATCHes.Add(newBatch);
            datacontextObj.SaveChanges();
        }

        public List<Batch> GetAllBatch()
        {
            datacontextObj = new SIPIDBEntities();
            List<Batch> batchList = new List<Batch>();

             foreach (var p in (from j in datacontextObj.BATCHes select new { j.ID, j.BatchNo, j.Year, j.BanglaBatch }).Distinct())
            {
                Batch batchObj = new Batch();
                batchObj.Id = p.ID;
                batchObj.BatchNo = p.BatchNo;
                batchObj.Year = Convert.ToInt16(p.Year);
                batchObj.BanglaBatch = p.BanglaBatch;
                batchList.Add(batchObj);
            }

            return batchList;
        }

        public void DeleteBatch(Batch _batchObj)
        {
            BATCH batch = datacontextObj.BATCHes.First(c => c.ID == _batchObj.Id);
            datacontextObj.BATCHes.Remove(batch);
            datacontextObj.SaveChanges();
        }

        public void UpdateBatch(Batch _batchObj)
        {
            var batch = datacontextObj.BATCHes.First(c => c.ID == _batchObj.Id);
            batch.BatchNo = _batchObj.BatchNo;
            batch.Year = Convert.ToInt32(_batchObj.Year);
            batch.BanglaBatch = _batchObj.BanglaBatch;
            datacontextObj.SaveChanges();
            

        }
    }
}
