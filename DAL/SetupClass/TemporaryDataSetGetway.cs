 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;

using ENTITY.SetupClass;

namespace DAL.SetupClass
{
   public class TemporaryDataSetGetway
    {
        SIPIDBEntities dataContext ;

        public List<TemporaryDataSet> GetAllSession()
        {
            dataContext = new SIPIDBEntities();
            List<TemporaryDataSet> sessionList = new List<TemporaryDataSet>();

            foreach (var p in (from j in dataContext.TEMPORARY_DATA_SET select new { j.ID, j.SESSION}).Distinct())
                {
                   
                    if (p.SESSION != "")
                    {
                        TemporaryDataSet newDataObj = new TemporaryDataSet();
                        newDataObj.Id = p.ID;
                        newDataObj.Session = p.SESSION;
                        sessionList.Add(newDataObj);
                        
                    }
                    else
                    {
                        break;
                    }

                }
                return sessionList;

        }
    }
}
