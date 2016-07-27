using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.PIS;

namespace DAL.PIS
{
   public class EmployeeGenInfoDAL
    {
        SIPIDBEntities datacontext = new SIPIDBEntities();
        Guid empId;
        public bool SaveEmployee(EmployeeInformation anEuserGroup)
        {
            //  datacontext = new SIPLDBMLDataContext();

            var newUserGroup = new PIS_tblEmployeeGenInfo
            {

                GEmployeeGenInfoID = (Guid)anEuserGroup.GEmployeeGenInfoID,
                GCompanyGenInfoID = (Guid)anEuserGroup.GCompanyGenInfoID,
                GFactoryID = anEuserGroup.GFactoryID,
                GDesignationInfoID = anEuserGroup.GDesignationInfoID,
                GLocationID = anEuserGroup.GLocationID,
                GDepartmentID = anEuserGroup.GDepartmentID,
                GEmployeeCatID = anEuserGroup.GEmployeeCatID,
                StrEmpID = anEuserGroup.StrEmpID,
                StrEmpCardNo = anEuserGroup.StrEmpCardNo,
                StrEmpOldCardNo = anEuserGroup.StrEmpOldCardNo,
                StrEmpOwnLanguageID = anEuserGroup.StrEmpOwnLanguageID,
                StrEmpName = anEuserGroup.StrEmpName,
                StrEmpNameOwnLanguage = anEuserGroup.StrEmpNameOwnLanguage,
                intGender = anEuserGroup.intGender,
                bitSystemUser = anEuserGroup.bitSystemUser,
                GReligionID = anEuserGroup.GReligionID,
                intMaritalStatus = anEuserGroup.intMaritalStatus,
                dtBirthDate = anEuserGroup.dtBirthDate,
                dtJoiningDate = anEuserGroup.dtJoiningDate,
                StrFatherName = anEuserGroup.StrFatherName,
                StrMotherName = anEuserGroup.StrMotherName,
                StrCurrentAddress = anEuserGroup.StrCurrentAddress,
                StrCurrAddrVillageMohalla = anEuserGroup.StrCurrAddrVillageMohalla,
                StrCurrAddrPostOfficeName = anEuserGroup.StrCurrAddrPostOfficeName,
                StrCurrAddrPostCode = anEuserGroup.StrCurrAddrPostCode,
                GCurrAddrAreaInfoID = anEuserGroup.GCurrAddrAreaInfoID,
                GCurrAddrThanaUpazilaInfoID = anEuserGroup.GCurrAddrThanaUpazilaInfoID,
                GCurrAddrDistrictInfoID = anEuserGroup.GCurrAddrDistrictInfoID,
                StrPermanentAddress = anEuserGroup.StrPermanentAddress,
                StrPerAddrVillageMohalla = anEuserGroup.StrPerAddrVillageMohalla,
                StrPerAddrPostofficeName = anEuserGroup.StrPerAddrPostofficeName,
                StrPerAddrPostCode = anEuserGroup.StrPerAddrPostCode,
                GPerAddrAreaInfoID = anEuserGroup.GPerAddrAreaInfoID,
                GPerAddrThanaUpazilaInfoID = anEuserGroup.GPerAddrThanaUpazilaInfoID,
                GPerAddrDistrictInfoID = anEuserGroup.GPerAddrDistrictInfoID,
                StrEmpPssportNo = anEuserGroup.StrEmpPssportNo,
                StrEmpNationalID = anEuserGroup.StrEmpNationalID,
                strEmpMobileNo = anEuserGroup.strEmpMobileNo,
                numEmpWeightKG = anEuserGroup.numEmpWeightKG,
                StrEmpIdenMark = anEuserGroup.StrEmpIdenMark,
                intLatePresentPunishmentFlag = anEuserGroup.intLatePresentPunishmentFlag,
                GCreatedBy = anEuserGroup.GCreatedBy,
                DtCreatedOn = anEuserGroup.DtCreatedOn,
                GUpdatedBy = anEuserGroup.GUpdatedBy,
                DtUpdatedOn = anEuserGroup.DtUpdatedOn,
                strEmailAdress = anEuserGroup.strEmailAdress,
                DtConfirmationDate = anEuserGroup.DtConfirmationDate,
                DtResignRetireTerminationDate = anEuserGroup.DtResignRetireTerminationDate,
                strGrade = anEuserGroup.strGrade,
                strShift = anEuserGroup.strShift,
                chkEligibleForOverTime = anEuserGroup.chkEligibleForOverTime,
                strAlternatePhone = anEuserGroup.strAlternatePhone,
                strTIN = anEuserGroup.strTIN,
                strNationalIDCard = anEuserGroup.strNationalIDCard,
                strAgeString = anEuserGroup.strAgeString,
                strFunctionalDesignation = anEuserGroup.strFunctionalDesignation,
                strBloodGroup = anEuserGroup.strBloodGroup,
                GNationalityID = anEuserGroup.GNationalityID,
                //bitCarryForwardProcessForDataUpdate = anEuserGroup.bitCarryForwardProcessForDataUpdate,
                //bitHeadOffice = anEuserGroup.bitHeadOffice,
                bitIsRoaster = anEuserGroup.bitIsRoaster,
              //  bitEligibleForVistaGLAccount = anEuserGroup.bitEligibleForVistaGLAccount,
                intActiveStatus = anEuserGroup.intActiveStatus,
                DivisionID = anEuserGroup.DivisionID,
                FingerPrintNo = anEuserGroup.FingerPrintNo,
                RelationWithAlternatePhoneOwner = anEuserGroup.RelationWithAlternatePhoneOwner,
              //  ShiftID = anEuserGroup.ShiftID,
               // RosterGroupID = anEuserGroup.RosterGroupID,
                GPaymentRuleSetupID = anEuserGroup.GPaymentRuleSetupID

            };
            datacontext.PIS_tblEmployeeGenInfo.Add(newUserGroup);
            datacontext.SaveChanges();

           // empId = newUserGroup.GEmployeeGenInfoID;
            SaveEmployeeAssignMent(anEuserGroup);
            SaveEmployeeEducation(anEuserGroup);
            return true;
        }

       
      

        private void SaveEmployeeEducation(EmployeeInformation anEuserGroup)
        {
            foreach (EmployeeEducationInfo item in anEuserGroup.EducationList)
            {
                var newUserGroup = new PIS_tblEmpEducationInfo
                {
                    GEmployeeGenInfoID = (Guid)anEuserGroup.GEmployeeGenInfoID,
                    GEmpEducationInfoID = Guid.NewGuid(),
                    GEmpEduDegreeID = item.EductionDegreeID,
                    StrEmpEduInstituteName = item.EductionInstituteName,
                    GEmpEduGroupSubject = item.EductionGroupSubject,
                    GEmpEduResultID = item.EductionResultID,
                    intEmpEduDegreeYear = item.EductionDegreeYear
                };
                datacontext.PIS_tblEmpEducationInfo.Add(newUserGroup);
                datacontext.SaveChanges();
                
            }
        }

        private void SaveEmployeeAssignMent(EmployeeInformation anEuserGroup)
        {
            var newUserGroup = new PIS_tblEmpAssignment
            {
                GEmpAssignID = Guid.NewGuid(),
                GEmployeeGenInfoID = (Guid)anEuserGroup.GEmployeeGenInfoID,
                SectionID =  anEuserGroup.GSectionID,
                CategoryID =  anEuserGroup.CategoryID,
                CategoryEmpID = anEuserGroup.GCategoryEmpID,
                CategorySalaryID =  anEuserGroup.CategorySalaryID
            };
            datacontext.PIS_tblEmpAssignment.Add(newUserGroup);
            datacontext.SaveChanges();
        }

      

        public bool UpdateEmployee(EmployeeInformation anEuserGroup)
        {

            var group = datacontext.PIS_tblEmployeeGenInfo.FirstOrDefault(u => u.GEmployeeGenInfoID == anEuserGroup.GEmployeeGenInfoID);
            //group.EmployeeName = anUserGroup.EmployeeName;

            group.GCompanyGenInfoID = (Guid)anEuserGroup.GCompanyGenInfoID;
                 group.GFactoryID = anEuserGroup.GFactoryID;
                 group.GDesignationInfoID = anEuserGroup.GDesignationInfoID;
                 group.GLocationID = anEuserGroup.GLocationID;
                 group.GDepartmentID = anEuserGroup.GDepartmentID;
                 group.GEmployeeCatID = anEuserGroup.GEmployeeCatID;
                 group.StrEmpID = anEuserGroup.StrEmpID;
                 group.StrEmpCardNo = anEuserGroup.StrEmpCardNo;
                 group.StrEmpOldCardNo = anEuserGroup.StrEmpOldCardNo;
                 group.StrEmpOwnLanguageID = anEuserGroup.StrEmpOwnLanguageID;
                 group.StrEmpName = anEuserGroup.StrEmpName;
                 group.StrEmpNameOwnLanguage = anEuserGroup.StrEmpNameOwnLanguage;
                 group.intGender = anEuserGroup.intGender;
                 group.bitSystemUser = anEuserGroup.bitSystemUser;
                 group.GReligionID = anEuserGroup.GReligionID;
                 group.intMaritalStatus = anEuserGroup.intMaritalStatus;
                 group.dtBirthDate = anEuserGroup.dtBirthDate;
                 group.dtJoiningDate = anEuserGroup.dtJoiningDate;
                 group.StrFatherName = anEuserGroup.StrFatherName;
                 group.StrMotherName = anEuserGroup.StrMotherName;
                 group.StrCurrentAddress = anEuserGroup.StrCurrentAddress;
                 group.StrCurrAddrVillageMohalla = anEuserGroup.StrCurrAddrVillageMohalla;
                 group.StrCurrAddrPostOfficeName = anEuserGroup.StrCurrAddrPostOfficeName;
                 group.StrCurrAddrPostCode = anEuserGroup.StrCurrAddrPostCode;
                 group.GCurrAddrAreaInfoID = anEuserGroup.GCurrAddrAreaInfoID;
                 group.GCurrAddrThanaUpazilaInfoID = anEuserGroup.GCurrAddrThanaUpazilaInfoID;
                 group.GCurrAddrDistrictInfoID = anEuserGroup.GCurrAddrDistrictInfoID;
                 group.StrPermanentAddress = anEuserGroup.StrPermanentAddress;
                 group.StrPerAddrVillageMohalla = anEuserGroup.StrPerAddrVillageMohalla;
                 group.StrPerAddrPostofficeName = anEuserGroup.StrPerAddrPostofficeName;
                 group.StrPerAddrPostCode = anEuserGroup.StrPerAddrPostCode;
                 group.GPerAddrAreaInfoID = anEuserGroup.GPerAddrAreaInfoID;
                 group.GPerAddrThanaUpazilaInfoID = anEuserGroup.GPerAddrThanaUpazilaInfoID;
                 group.GPerAddrDistrictInfoID = anEuserGroup.GPerAddrDistrictInfoID;
                 group.StrEmpPssportNo = anEuserGroup.StrEmpPssportNo;
                 group.StrEmpNationalID = anEuserGroup.StrEmpNationalID;
                 group.strEmpMobileNo = anEuserGroup.strEmpMobileNo;
                 group.numEmpWeightKG = anEuserGroup.numEmpWeightKG;
                 group.StrEmpIdenMark = anEuserGroup.StrEmpIdenMark;
                 group.intLatePresentPunishmentFlag = anEuserGroup.intLatePresentPunishmentFlag;
                 group.GCreatedBy = anEuserGroup.GCreatedBy;
                 group.DtCreatedOn = anEuserGroup.DtCreatedOn;
                 group.GUpdatedBy = anEuserGroup.GUpdatedBy;
                 group.DtUpdatedOn = anEuserGroup.DtUpdatedOn;
                 group.strEmailAdress = anEuserGroup.strEmailAdress;
                 group.DtConfirmationDate = anEuserGroup.DtConfirmationDate;
                 group.DtResignRetireTerminationDate = anEuserGroup.DtResignRetireTerminationDate;
                 group.strGrade = anEuserGroup.strGrade;
                 group.strShift = anEuserGroup.strShift;
                 group.chkEligibleForOverTime = anEuserGroup.chkEligibleForOverTime;
                 group.strAlternatePhone = anEuserGroup.strAlternatePhone;
                 group.strTIN = anEuserGroup.strTIN;
                 group.strNationalIDCard = anEuserGroup.strNationalIDCard;
                 group.strAgeString = anEuserGroup.strAgeString;
                 group.strFunctionalDesignation = anEuserGroup.strFunctionalDesignation;
                 group.strBloodGroup = anEuserGroup.strBloodGroup;
                 group.GNationalityID = anEuserGroup.GNationalityID;
                //bitCarryForwardProcessForDataUpdate = anEuserGroup.bitCarryForwardProcessForDataUpdate,
                //bitHeadOffice = anEuserGroup.bitHeadOffice,
                 group.bitIsRoaster = anEuserGroup.bitIsRoaster;
              //  bitEligibleForVistaGLAccount = anEuserGroup.bitEligibleForVistaGLAccount,
                 group.intActiveStatus = anEuserGroup.intActiveStatus;
                 group.DivisionID = anEuserGroup.DivisionID;
                 group.FingerPrintNo = anEuserGroup.FingerPrintNo;
                 group.RelationWithAlternatePhoneOwner = anEuserGroup.RelationWithAlternatePhoneOwner;
              //  ShiftID = anEuserGroup.ShiftID,
               // RosterGroupID = anEuserGroup.RosterGroupID,
                 group.GPaymentRuleSetupID = anEuserGroup.GPaymentRuleSetupID;

            datacontext.SaveChanges();
            return true;
        }

        public bool DeleteEmployee(Guid userGroupId)
        {


            PIS_tblEmployeeGenInfo userGroupObj = datacontext.PIS_tblEmployeeGenInfo.FirstOrDefault(u => u.GEmployeeGenInfoID == userGroupId);
            datacontext.PIS_tblEmployeeGenInfo.Remove(userGroupObj);
            datacontext.SaveChanges();
            return true;
        }

        public List<EmployeeInformation> GetAllEmployee()
        {

            List<EmployeeInformation> listUserGroup = new List<EmployeeInformation>();
            var query = (from j in datacontext.PIS_tblEmployeeGenInfo select j).OrderBy(m => m.StrEmpName);
            foreach (var anEuserGroup in query)
            {
                EmployeeInformation group = new EmployeeInformation();
                group.GCompanyGenInfoID = anEuserGroup.GCompanyGenInfoID;
                group.GFactoryID = anEuserGroup.GFactoryID;
                group.GDesignationInfoID = anEuserGroup.GDesignationInfoID;
                group.GLocationID = anEuserGroup.GLocationID;
                group.GDepartmentID = anEuserGroup.GDepartmentID;
                group.GEmployeeCatID = anEuserGroup.GEmployeeCatID;
                group.StrEmpID = anEuserGroup.StrEmpID;
                group.StrEmpCardNo = anEuserGroup.StrEmpCardNo;
                group.StrEmpOldCardNo = anEuserGroup.StrEmpOldCardNo;
                group.StrEmpOwnLanguageID = anEuserGroup.StrEmpOwnLanguageID;
                group.StrEmpName = anEuserGroup.StrEmpName;
                group.StrEmpNameOwnLanguage = anEuserGroup.StrEmpNameOwnLanguage;
                group.intGender = anEuserGroup.intGender;
                group.bitSystemUser = anEuserGroup.bitSystemUser;
                group.GReligionID = anEuserGroup.GReligionID;
                group.intMaritalStatus = anEuserGroup.intMaritalStatus;
                group.dtBirthDate = anEuserGroup.dtBirthDate;
                group.dtJoiningDate = anEuserGroup.dtJoiningDate;
                group.StrFatherName = anEuserGroup.StrFatherName;
                group.StrMotherName = anEuserGroup.StrMotherName;
                group.StrCurrentAddress = anEuserGroup.StrCurrentAddress;
                group.StrCurrAddrVillageMohalla = anEuserGroup.StrCurrAddrVillageMohalla;
                group.StrCurrAddrPostOfficeName = anEuserGroup.StrCurrAddrPostOfficeName;
                group.StrCurrAddrPostCode = anEuserGroup.StrCurrAddrPostCode;
                group.GCurrAddrAreaInfoID = anEuserGroup.GCurrAddrAreaInfoID;
                group.GCurrAddrThanaUpazilaInfoID = anEuserGroup.GCurrAddrThanaUpazilaInfoID;
                group.GCurrAddrDistrictInfoID = anEuserGroup.GCurrAddrDistrictInfoID;
                group.StrPermanentAddress = anEuserGroup.StrPermanentAddress;
                group.StrPerAddrVillageMohalla = anEuserGroup.StrPerAddrVillageMohalla;
                group.StrPerAddrPostofficeName = anEuserGroup.StrPerAddrPostofficeName;
                group.StrPerAddrPostCode = anEuserGroup.StrPerAddrPostCode;
                group.GPerAddrAreaInfoID = anEuserGroup.GPerAddrAreaInfoID;
                group.GPerAddrThanaUpazilaInfoID = anEuserGroup.GPerAddrThanaUpazilaInfoID;
                group.GPerAddrDistrictInfoID = anEuserGroup.GPerAddrDistrictInfoID;
                group.StrEmpPssportNo = anEuserGroup.StrEmpPssportNo;
                group.StrEmpNationalID = anEuserGroup.StrEmpNationalID;
                group.strEmpMobileNo = anEuserGroup.strEmpMobileNo;
                group.numEmpWeightKG = anEuserGroup.numEmpWeightKG;
                group.StrEmpIdenMark = anEuserGroup.StrEmpIdenMark;
                group.intLatePresentPunishmentFlag = anEuserGroup.intLatePresentPunishmentFlag;
                group.GCreatedBy = anEuserGroup.GCreatedBy;
                group.DtCreatedOn = anEuserGroup.DtCreatedOn;
                group.GUpdatedBy = anEuserGroup.GUpdatedBy;
                group.DtUpdatedOn = anEuserGroup.DtUpdatedOn;
                group.strEmailAdress = anEuserGroup.strEmailAdress;
                group.DtConfirmationDate = anEuserGroup.DtConfirmationDate;
                group.DtResignRetireTerminationDate = anEuserGroup.DtResignRetireTerminationDate;
                group.strGrade = anEuserGroup.strGrade;
                group.strShift = anEuserGroup.strShift;
                group.chkEligibleForOverTime = anEuserGroup.chkEligibleForOverTime;
                group.strAlternatePhone = anEuserGroup.strAlternatePhone;
                group.strTIN = anEuserGroup.strTIN;
                group.strNationalIDCard = anEuserGroup.strNationalIDCard;
                group.strAgeString = anEuserGroup.strAgeString;
                group.strFunctionalDesignation = anEuserGroup.strFunctionalDesignation;
                group.strBloodGroup = anEuserGroup.strBloodGroup;
                group.GNationalityID = anEuserGroup.GNationalityID;
                //bitCarryForwardProcessForDataUpdate = anEuserGroup.bitCarryForwardProcessForDataUpdate,
                //bitHeadOffice = anEuserGroup.bitHeadOffice,
                group.bitIsRoaster = anEuserGroup.bitIsRoaster;
                //  bitEligibleForVistaGLAccount = anEuserGroup.bitEligibleForVistaGLAccount,
                group.intActiveStatus = anEuserGroup.intActiveStatus;
                group.DivisionID = anEuserGroup.DivisionID;
                group.FingerPrintNo = anEuserGroup.FingerPrintNo;
                group.RelationWithAlternatePhoneOwner = anEuserGroup.RelationWithAlternatePhoneOwner;
                //  ShiftID = anEuserGroup.ShiftID,
                // RosterGroupID = anEuserGroup.RosterGroupID,
                group.GPaymentRuleSetupID = anEuserGroup.GPaymentRuleSetupID;
                listUserGroup.Add(group);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisEmployee(Guid GEmployeeGenInfoID)
        {


            return (datacontext.PIS_tblEmployeeGenInfo.Any(u => u.GEmployeeGenInfoID == GEmployeeGenInfoID));
        }
    }
}
