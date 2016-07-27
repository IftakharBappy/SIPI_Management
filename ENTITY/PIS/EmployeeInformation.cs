using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.PIS
{
   public class EmployeeInformation
    {
      //[DataMember, DataColumn(true)]
        public System.String StrEmpID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strGrade { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strEmpOldCardNo { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrEmpName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strDesignationName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strDepartmentName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strFactoryName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrCompanyName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String CategoryOrSection { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String CategoryName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String SectionName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GSectionID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GEmployeeGenInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GCompanyGenInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GFactoryID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GDesignationInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GLocationID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GDepartmentID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GEmployeeCatID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrEmpCardNo { get; set; }
        public System.String StrEmpOldCardNo { get; set; }

          public bool? bitSystemUser { get; set; }
       
       
      //[DataMember, DataColumn(true)]
        public System.String StrEmpOwnLanguageID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrEmpNameOwnLanguage { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Int32? intGender { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strGender { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GReligionID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strReligion { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Int32? intMaritalStatus { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strMaritialStatus { get; set; }
      //[DataMember, DataColumn(true)]
        public System.DateTime dtBirthDate { get; set; }
      //[DataMember, DataColumn(true)]
        public System.DateTime dtJoiningDate { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrFatherName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrMotherName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrCurrentAddress { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrCurrAddrVillageMohalla { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrCurrAddrPostOfficeName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrCurrAddrPostCode { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GCurrAddrAreaInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GCurrAddrThanaUpazilaInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GCurrAddrDistrictInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrPermanentAddress { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrPerAddrVillageMohalla { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrPerAddrPostofficeName { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrPerAddrPostCode { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GPerAddrAreaInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GPerAddrThanaUpazilaInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GPerAddrDistrictInfoID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrEmpPssportNo { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrEmpNationalID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strEmpMobileNo { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Decimal? numEmpWeightKG { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String StrEmpIdenMark { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Int32? intLatePresentPunishmentFlag { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GCreatedBy { get; set; }
      //[DataMember, DataColumn(true)]
        public System.DateTime? DtCreatedOn { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GUpdatedBy { get; set; }
      //[DataMember, DataColumn(true)]
        public System.DateTime? DtUpdatedOn { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strEmailAdress { get; set; }
      //[DataMember, DataColumn(true)]
        public System.DateTime? DtConfirmationDate { get; set; }
      //[DataMember, DataColumn(true)]
        public System.DateTime? DtResignRetireTerminationDate { get; set; }
      //[DataMember, DataColumn(true)]

        public System.String strShift { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Boolean? chkEligibleForOverTime { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strAlternatePhone { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strTIN { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strNationalIDCard { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strAgeString { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strFunctionalDesignation { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String strBloodGroup { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Guid ? GNationalityID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Boolean? bitIsRoaster { get; set; }
      //[DataMember, DataColumn(true)]
        public System.Int32? intActiveStatus { get; set; }


      //[DataMember, DataColumn(true)]
        public System.Guid ? DivisionID { get; set; }
      //[DataMember, DataColumn(true)]
        public System.String DivisionName { get; set; }

      //[DataMember, DataColumn(true)]
        public System.String LoginId { get; set; }
        public System.String FingerPrintNo { get; set; }
        public System.String RelationWithAlternatePhoneOwner { get; set; }
       
       

      //[DataMember, DataColumn(true)]
        public byte[] imageEmployeePicture { get; set; }

        public System.Guid ? CategorySalaryID { get; set; }


        public System.Guid ? GPaymentRuleSetupID { get; set; }

       
        // public System.Guid ? GCreatedBy { get; set; }
         //public System.Guid ? GUpdatedBy { get; set; }

        public System.Guid? GEmpAssignID { get; set; }
        public System.Guid? CategoryID { get; set; }
        public System.Guid? GCategoryEmpID { get; set; }

        private List<EmployeeEducationInfo> _educationList = new List<EmployeeEducationInfo>();

        public List<EmployeeEducationInfo> EducationList
        {
            get { return _educationList; }
            set { _educationList = value; }
        }
       
    }
}
