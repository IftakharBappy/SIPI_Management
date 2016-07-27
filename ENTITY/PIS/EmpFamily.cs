using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.PIS
{
  public  class EmpFamily
    {
       // [DataMember, DataColumn(true)]
        public Guid GEmpFamilyID { get; set; }
       // [DataMember, DataColumn(true)]
        public Guid GEmployeeGenInfoID { get; set; }
       // [DataMember, DataColumn(true)]
        public Guid? GEmpFamilyType { get; set; }
        //[DataMember, DataColumn(true)]
        public string StrEmpFamilyMemberName { get; set; }
       // [DataMember, DataColumn(true)]
        public DateTime? dtEmpFamilyBirthDate { get; set; }
      //[DataMember, DataColumn(true)]
        public int intEmpFamilyGender { get; set; }
      //  [DataMember, DataColumn(true)]
        public Guid? GEmpFamilyEduDegreeID { get; set; }
      //  [DataMember, DataColumn(true)]
        public Guid? GEmpFamilyProfession { get; set; }
        //[DataMember, DataColumn(true)]
        public int? intEmpFamilyBloodGroup { get; set; }
       // [DataMember, DataColumn(true)]
        public int? intNominee { get; set; }
       // [DataMember, DataColumn(true)]
        public decimal? numShare { get; set; }

        public string FamilyName { get; set; }

        public string FamilyTypeName { get; set; }

        public string NomineeGenderName { get; set; }

        public string EmpFamilyEduDegreeName { get; set; }

        public string FamilyProfessionName { get; set; }

        public string EmpFamilyBloodGroupName { get; set; }

        public string IsNominee { get; set; }
    }
}
