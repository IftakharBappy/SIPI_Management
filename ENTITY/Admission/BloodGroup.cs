using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Admission
{
    public class BloodGroup
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string bloodGroupName;

        public string BloodGroupName
        {
            get { return bloodGroupName; }
            set { bloodGroupName = value; }
        }
    }
}
