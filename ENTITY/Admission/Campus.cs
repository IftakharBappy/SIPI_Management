using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
  public class Campus
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string campusName;

        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }
        private string campusAddress;

        public string CampusAddress
        {
            get { return campusAddress; }
            set { campusAddress = value; }
        }
        private string contactPerson;

        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }


        private string mobileNumber;

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        private string banglaCampus;

        public string BanglaCampus
        {
            get { return banglaCampus; }
            set { banglaCampus = value; }
        }
 
    }
}
