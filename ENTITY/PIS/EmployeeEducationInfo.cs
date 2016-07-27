using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.PIS
{
  public  class EmployeeEducationInfo
    {
        private Guid _EmployeeEducationInfoID;
        private Guid _EmployeeGenInfoID;
        private Guid _EductionDegreeID;
      //private string
        private Guid? _EductionGroupSubject;
        private string _EductionInstituteName;
        private Guid _EductionResultID;
        private int _EductionDegreeYear;

        public int EductionDegreeYear
        {
            get { return _EductionDegreeYear; }
            set { _EductionDegreeYear = value; }
        }  

        public Guid EductionResultID
        {
            get { return _EductionResultID; }
            set { _EductionResultID = value; }
        }
       

        public string EductionInstituteName
        {
            get { return _EductionInstituteName; }
            set { _EductionInstituteName = value; }
        }
    

        public Guid? EductionGroupSubject
        {
            get { return _EductionGroupSubject; }
            set { _EductionGroupSubject = value; }
        }
        

        public Guid EductionDegreeID
        {
            get { return _EductionDegreeID; }
            set { _EductionDegreeID = value; }
        }
      

        public Guid EmployeeGenInfoID
        {
            get { return _EmployeeGenInfoID; }
            set { _EmployeeGenInfoID = value; }
        }
       

        public Guid EmployeeEducationInfoID
        {
            get { return _EmployeeEducationInfoID; }
            set { _EmployeeEducationInfoID = value; }
        }


        public string DegreeName { get; set; }

        public string GroupSubjectName { get; set; }

        public string EducationResultName { get; set; }

        public string BoardUniversityName { get; set; }
    }
}
