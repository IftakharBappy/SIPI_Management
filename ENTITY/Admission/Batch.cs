using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
    public class Batch
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        private string banglaBatch;

        public string BanglaBatch
        {
            get { return banglaBatch; }
            set { banglaBatch = value; }
        }

             
    }
}
