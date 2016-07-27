using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.PIS
{
   public class EmployeeGenInfo
    {
       // //[DataMember, DataColumn(true)]
        public Guid EmployeeCatID
        {
            get;
            set;
        }
        ////[DataMember, DataColumn(true)]
        public Guid CompanyGenInfoID
        {
            get;
            set;
        }
       // //[DataMember, DataColumn(true)]
        public Guid OrgnHierarchyDesigTypeID
        {
            get;
            set;
        }
        ////[DataMember, DataColumn(true)]
        public Guid OrgnHierarchyDesigSetupID
        {
            get;
            set;
        }
        ////[DataMember, DataColumn(true)]
        public Guid OrgnHierarchyPositionTypeID
        {
            get;
            set;
        }
       // //[DataMember, DataColumn(true)]
        public Guid OrgnHierarchyPositionSetupID
        {
            get;
            set;
        }
       // //[DataMember, DataColumn(true)]
        public Guid? LocationID
        {
            get;
            set;
        }
       // //[DataMember, DataColumn(true)]

        public Guid EmployeeGenInfoID
        {
            get;
            set;
        }
      //  //[DataMember, DataColumn(true)]
        public string EmpID
        {
            get;
            set;
        }
      //  //[DataMember, DataColumn(true)]

        public string EmpCardNo
        {
            get;
            set;
        }
     //   //[DataMember, DataColumn(true)]
        public string EmpOldCardNo
        {
            get;
            set;
        }
      //  //[DataMember, DataColumn(true)]
        public string EmpOwnLanguageID
        {
            get;
            set;
        }
        ////[DataMember, DataColumn(true)]
        public string EmpName
        {
            get;
            set;
        }
        ////[DataMember, DataColumn(true)]
        public string EmpNameOwnLanguage
        {
            get;
            set;
        }
        ////[DataMember, DataColumn(true)]

        public Guid? FactoryID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public int Gender
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public bool SystemUser
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid ReligionID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public int MaritalStatus
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public DateTime BirthDate
        {
            get
           ;
            set;
        }
        //[DataMember, DataColumn(true)]
        public DateTime JoiningDate
        {
            get
           ;
            set;
        }
        //[DataMember, DataColumn(true)]
        public DateTime BirthDateString
        {
            get
           ;
            set;
        }
        //[DataMember, DataColumn(true)]
        public DateTime JoiningDateString
        {
            get
           ;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string FatherName
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string FatherNameOwnLanguage
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string MotherName
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string MotherNameOwnLanguage
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string CurrentAddress
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string CurrentAddrOwnLanguage
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string CurrAddrVillageMohalla
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string CurrAddrPostOfficeName
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string CurrAddrPostCode
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? CurrAddrAreaInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? CurrAddrThanaUpazilaInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? CurrAddrDistrictInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string PermanentAddress
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string PermanentAddrOwnLanguage
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string PermanentAddrVillageMohalla
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string PermanentAddrPostOfficeName
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string PermanentAddrPostCode
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? PermanentAddrAreaInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? PermanentAddrThanaUpazilaInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? PermanentAddrDistrictInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? NationalityID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string EmpPssportNo
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string EmpNationalID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string EmpMobileNo
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public decimal? EmpWeightKG
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string EmpIdentifyMark
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public int LatePresentPunishmentFlag
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? CreatedBy
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? UpdatedBy
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]

        public DateTime? UpdatedOn
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]

        public string EmailAdress
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string AgeString
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string ConfirmationDate
        {
            get;
            set;

        }
        //[DataMember, DataColumn(true)]

        public DateTime? ResignRetireTerminationDate
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]

        public string FunctionalDesignation
        {

            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string Grade
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string Shift
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]

        public bool EligibleForOverTime
        {
            get;
            set;
        }

        //[DataMember, DataColumn(true)]

        public bool IsRoaster
        {
            get;
            set;
        }

        //[DataMember, DataColumn(true)]
        public Guid? DesignationInfoID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string StrDesignationName
        {
            get;
            set;
        }

        //[DataMember, DataColumn(true)]
        public Guid? DepartmentID
        {
            get;
            set;
        }

        //[DataMember, DataColumn(true)]
        public string StrDepartmentName
        {
            get;
            set;
        }



        //[DataMember, DataColumn(true)]
        public string AlternatePhone
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]

        public string TIN
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string BloodGroup
        {
            get;
            set;

        }
        //[DataMember, DataColumn(true)]
        public string NationalIDCard
        {
            get;
            set;

        }
        //[DataMember, DataColumn(true)]
        public bool HeadOffice
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public bool EligibleForVistaGLAccount
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public int ActiveStatus
        {
            get;
            set;
        }



        //[DataMember, DataColumn(true)]
        public string StrFactoryShortName
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string FingerPrintNo
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public string RelationWithAlternatePhoneOwner
        {
            get;
            set;
        }

        //[DataMember, DataColumn(true)]
        public Guid? CategoryID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? CategorySalaryID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? FloorID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? BlockID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? SectionID
        {
            get;
            set;
        }
        //[DataMember, DataColumn(true)]
        public Guid? TableID
        {
            get;
            set;
        }
        //[DataColumn(true)]
        //[DataMember]
        public Guid? MachineID { get; set; }
        //[DataColumn(true)]
        //[DataMember]
        public string MachineName { get; set; }
        //[DataColumn(true)]
        //[DataMember]
        public string MachineNo { get; set; }


        //[DataMember, DataColumn(true)]
        public System.Guid? DivisionID
        {
            get;
            set;
        }

        //[DataMember, DataColumn(true)]
        public byte[] imageEmployeePicture { get; set; }

        private List<EmployeeGenInfo> _LstEmployeeGenInfo;
        public List<EmployeeGenInfo> LstEmployeeGenInfo
        {
            get
            {
                if (_LstEmployeeGenInfo == null)
                {
                    _LstEmployeeGenInfo = new List<EmployeeGenInfo>();
                }
                return _LstEmployeeGenInfo;
            }
            set { _LstEmployeeGenInfo = value; }
        }

        private EmployeeGenInfo _ObjEmployeeGenInfo;
        public EmployeeGenInfo ObjEmployeeGenInfo
        {
            get
            {
                if (_ObjEmployeeGenInfo == null)
                {
                    _ObjEmployeeGenInfo = new EmployeeGenInfo();
                }
                return _ObjEmployeeGenInfo;
            }
            set { _ObjEmployeeGenInfo = value; }
        }


        public EmployeeGenInfo() { }
    }
}
