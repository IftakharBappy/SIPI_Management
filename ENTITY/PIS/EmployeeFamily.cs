using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.PIS
{
  public  class EmployeeFamily
    {
      public Guid GEmpFamilyID { get; set; }
      public Guid GEmployeeGenInfoID { get; set; }
      public Guid GEmpFamilyType { get; set; }
      public string StrEmpFamilyMemberName { get; set; }
      public DateTime dtEmpFamilyBirthDate { get; set; }
      public int intEmpFamilyGender { get; set; }
      public Guid GEmpFamilyEduDegreeID { get; set; }
      public Guid GEmpFamilyProfession { get; set; }
      public int intEmpFamilyBloodGroup { get; set; }
      public int intNominee { get; set; }
      public int numShare { get; set; }
    }
}
