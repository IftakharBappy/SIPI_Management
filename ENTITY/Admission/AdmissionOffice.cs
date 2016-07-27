using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
   public class  AdmissionOffice
    {
        private int id;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string officeName;

        public string OfficeName
        {
            get { return officeName; }
            set { officeName = value; }
        }
        private string officeAddress;

        public string OfficeAddress
        {
            get { return officeAddress; }
            set { officeAddress = value; }
        }


        private int campusId;

        public int CampusId
        {
            get { return campusId; }
            set { campusId = value; }
        }

      
        
    }
}
