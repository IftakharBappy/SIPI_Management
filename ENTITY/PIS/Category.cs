using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using System.Globalization;

namespace ENTITY.PIS
{
  public  class Category
    {
       
        public Guid CategoryID
        {
            get;
            set;
        }
       
        public string CategoryName
        {
            get;
            set;
        }
    }
}
