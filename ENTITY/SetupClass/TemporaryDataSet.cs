using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENTITY.SetupClass
{
   public class TemporaryDataSet
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string session;

        public string Session
        {
            get { return session; }
            set { session = value; }
        }
         

    }
}
