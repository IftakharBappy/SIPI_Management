
using DAL.Admission;
using DAL.SetupClass;
using ENTITY.Admission;
using ENTITY.SetupClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SetupClass
{
    public class TemporaryDataSetManager
    {
        TemporaryDataSetGetway temporaryDataSetGetway = new TemporaryDataSetGetway();


        public List<TemporaryDataSet> GetAllSession()
        {
            return temporaryDataSetGetway.GetAllSession();
        }
     
    }
}
