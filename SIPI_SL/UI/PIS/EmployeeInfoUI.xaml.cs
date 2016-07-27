using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLL.PIS;
using ENTITY.Common;
using ENTITY.PIS;
using Microsoft.Win32;

namespace SIPI_SL.UI.PIS
{
    /// <summary>
    /// Interaction logic for EmployeeInfoUI.xaml
    /// </summary>
    public partial class EmployeeInfoUI : Window
    {
        EmployeeGenInfoBAL _ObjBAL = new EmployeeGenInfoBAL();
        List<EmployeeEducationInfo> _educationListObj = new List<EmployeeEducationInfo>();
        List<EmpFamily> _familyListObj = new List<EmpFamily>();
        string caption = "Employee Setup";
        byte[] MemberPhoto = new byte[0];
        public EmployeeInfoUI()
        {
            InitializeComponent();
            LoadPersonalInfoData();
            
        }

        

        private void LoadPersonalInfoData()
        {
            LoadGender();
            LoadRegion();
            LoadDistrictInfo();
            LoadMaritalStatusInfo();
            LoadCompanyInfo();
            LoadDesignation();
            LoadWork();
            LoadDEpartment();
            LoadGrade();
            LoadFactory();
            LoadJobStatus();
            LoadNationality();
            LoadAllDate();
            LoadBloodGroup();

            LoadDivision();
            LoadCategory();
            LoadSection();
            LoadEmpCategory();
            LoadCategorySalary();

            LoadDegree();
            LoadGroupSubject();
            LoadEducationResult();
            LoadBoardUniversity();

            LoadFamilyType();

            LoadNominee();
            NomineeGender();

            LoadNomineeProfession();
            NomineeBirthDateDatePicker.SelectedDate = DateTime.Now;
        }

        private void LoadNomineeProfession()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                FamilyProfessionComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllProfession())
                {

                    FamilyProfessionComboBox.Items.Add(userGroup);

                }
                FamilyProfessionComboBox.DisplayMemberPath = "FamilyProfessionName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Gender.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NomineeGender()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                FamilyGenderComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllGender())
                {

                    FamilyGenderComboBox.Items.Add(userGroup);

                }
                FamilyGenderComboBox.DisplayMemberPath = "GenderName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Gender.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadNominee()
        {
            FamilyNomineeComboBox.Items.Add("Yes");
            FamilyNomineeComboBox.Items.Add("No");
        }

        private void LoadFamilyType()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                FamilyTypeComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllFamily())
                {
                    FamilyTypeComboBox.Items.Add(userGroup);
                }
                FamilyTypeComboBox.DisplayMemberPath = "FamilyTypeName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Family Type.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadBoardUniversity()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                BoardComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllBoardUniversity())
                {
                    BoardComboBox.Items.Add(userGroup);
                }
                BoardComboBox.DisplayMemberPath = "EductionInstituteName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Group Board University Name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadEducationResult()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                ResultComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllEducationResult())
                {
                    ResultComboBox.Items.Add(userGroup);
                }
                ResultComboBox.DisplayMemberPath = "EducationResultName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Group Education Result Name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadGroupSubject()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                GroupComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllGroupSubject())
                {
                    GroupComboBox.Items.Add(userGroup);
                }
                GroupComboBox.DisplayMemberPath = "GroupSubjectName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Group Subject Name.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadDegree()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                ExamComboBox.Items.Clear();
                FamilyEducationComboBox.Items.Clear();
                
                foreach (var userGroup in aBUserGroup.GetAllDegree())
                {
                    ExamComboBox.Items.Add(userGroup);
                    FamilyEducationComboBox.Items.Add(userGroup);
                }
                ExamComboBox.DisplayMemberPath = "DegreeName";
                FamilyEducationComboBox.DisplayMemberPath = "DegreeName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Degree.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadCategorySalary()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                SalaryCategoryCombobox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllCatEmployeeSalary())
                {
                    SalaryCategoryCombobox.Items.Add(userGroup);
                }
                SalaryCategoryCombobox.DisplayMemberPath = "CategorySalaryName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Section.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region CAT EMPLOYEE
        private void LoadEmpCategory()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                EmployeeCategoryComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllEmpCategory())
                {
                    EmployeeCategoryComboBox.Items.Add(userGroup);
                }
                EmployeeCategoryComboBox.DisplayMemberPath = "CategoryEmpName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Employee Category.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region SECTION
        private void LoadSection()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                SectionComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllSection())
                {
                    SectionComboBox.Items.Add(userGroup);
                }
                SectionComboBox.DisplayMemberPath = "SectionName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Section.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region CATEGORY
        private void LoadCategory()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                CategoryComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllCategory())
                {
                    CategoryComboBox.Items.Add(userGroup);
                }
                CategoryComboBox.DisplayMemberPath = "CategoryName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Category.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region DIVISION
        private void LoadDivision()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                DivisionNameComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllDivision())
                {
                    DivisionNameComboBox.Items.Add(userGroup);
                }
                DivisionNameComboBox.DisplayMemberPath = "DivisionName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Division.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion



        #region BLOOD GROUP
        private void LoadBloodGroup()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                BloodGroupComboBox.Items.Clear();
                FamilyBloodGroupComboBox.Items.Clear();
                
                foreach (var userGroup in aBUserGroup.GetAllBoodGroup())
                {
                    BloodGroupComboBox.Items.Add(userGroup);
                    FamilyBloodGroupComboBox.Items.Add(userGroup);
                }
                BloodGroupComboBox.DisplayMemberPath = "BloodGroupName";
                FamilyBloodGroupComboBox.DisplayMemberPath = "BloodGroupName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Blood Group.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        private void LoadAllDate()
        {
            BirthDateStringDatePicker.SelectedDate = DateTime.UtcNow;
            JoiningDateStringDatePicker.SelectedDate = DateTime.UtcNow;
            ResignRetireTerminationDateDatePicker.SelectedDate = DateTime.UtcNow;
            ConfirmationDateDateDatePicker.SelectedDate = DateTime.UtcNow;

        }

        #region NATIONALITY
        private void LoadNationality()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                NationalityIDComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllCountry())
                {
                    NationalityIDComboBox.Items.Add(userGroup);
                }
                NationalityIDComboBox.DisplayMemberPath = "CountryName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Nationality.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Job Status
        private void LoadJobStatus()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                JobStatusComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllJobStatus())
                {
                    JobStatusComboBox.Items.Add(userGroup);
                }
                JobStatusComboBox.DisplayMemberPath = "EmpJobStatus";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Job Status.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region FACTORY
        private void LoadFactory()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                FactoryComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllFactory())
                {
                    FactoryComboBox.Items.Add(userGroup);
                }
                FactoryComboBox.DisplayMemberPath = "StrFactoryName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Factory.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region GRADE
        private void LoadGrade()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                GradeComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllGrade())
                {
                    GradeComboBox.Items.Add(userGroup);
                }
                GradeComboBox.DisplayMemberPath = "StrDepartmentName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Grade.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region DEPARTMENT
        private void LoadDEpartment()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                DepartmentComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllDepartment())
                {
                    DepartmentComboBox.Items.Add(userGroup);
                }
                DepartmentComboBox.DisplayMemberPath = "StrDepartmentName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Department.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region WORK
        private void LoadWork()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                WorkComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllWork())
                {
                    WorkComboBox.Items.Add(userGroup);
                }
                WorkComboBox.DisplayMemberPath = "strWorkTimeSchedule";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Workpalace.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region DEsignation
        private void LoadDesignation()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                DesignationComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllDesignation())
                {
                    DesignationComboBox.Items.Add(userGroup);
                }
                DesignationComboBox.DisplayMemberPath = "StrDesignationName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Designation.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Company

        private void LoadCompanyInfo()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                CompanyComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllCompany())
                {
                    CompanyComboBox.Items.Add(userGroup);
                }
                CompanyComboBox.DisplayMemberPath = "strCompany";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Company.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Marital Status
        private void LoadMaritalStatusInfo()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                MaritalStatusComboBox.Items.Clear();

                foreach (var userGroup in aBUserGroup.GetAllMaritalStatus())
                {

                    MaritalStatusComboBox.Items.Add(userGroup);


                }
                MaritalStatusComboBox.DisplayMemberPath = "Status";

            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading District.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region District
        private void LoadDistrictInfo()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                PresentDistrictComboBox.Items.Clear();
                PermanentDistrictComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllDistrict())
                {

                    PresentDistrictComboBox.Items.Add(userGroup);
                    PermanentDistrictComboBox.Items.Add(userGroup);

                }
                PresentDistrictComboBox.DisplayMemberPath = "StrDistrictName";
                PermanentDistrictComboBox.DisplayMemberPath = "StrDistrictName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading District.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Religious

        private void LoadRegion()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                regionTextBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllRegion())
                {

                    regionTextBox.Items.Add(userGroup);

                }
                regionTextBox.DisplayMemberPath = "ReligionName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Region.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Gender

        private void LoadGender()
        {
            try
            {
                PISCommonBAL aBUserGroup = new PISCommonBAL();
                GenderComboBox.Items.Clear();
                foreach (var userGroup in aBUserGroup.GetAllGender())
                {

                    GenderComboBox.Items.Add(userGroup);

                }
                GenderComboBox.DisplayMemberPath = "GenderName";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Loading Gender.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        private void BrowsPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg;
                FileStream fs;
                dlg = new OpenFileDialog();
                dlg.ShowDialog();

                if (dlg.FileName != "")
                {
                    fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                    MemberPhoto = new byte[fs.Length].ToArray();
                    if (MemberPhoto.Length < 800 * 1024)
                    {
                        fs.Read(MemberPhoto, 0, Convert.ToInt32(fs.Length));
                        fs.Close();
                        byte[] barrImg = (byte[])MemberPhoto;
                        string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                        FileStream fs1 = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                        fs1.Write(barrImg, 0, barrImg.Length);
                        fs1.Flush();
                        fs1.Close();
                        ImageSourceConverter imgs = new ImageSourceConverter();
                        imgMemberPhoto.SetValue(Image.SourceProperty, imgs.ConvertFromString(strfn));

                    }
                    else
                    {
                        MessageBox.Show("Filesize of image is too large. Maximum file size permitted is 800KB", "Member/Customer Setup", MessageBoxButton.OK, MessageBoxImage.Error);
                        MemberPhoto = new byte[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MemberPhoto = new byte[0];
                MessageBox.Show("Error while uploading Image File.\n" + ex.Message, "Member/Customer Setup", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (CheckFieldofUserGroup())
                //{
                if (SaveButton.Content.ToString() == "Save")
                {
                    SaveOperationofUserGroup();
                    //  PopulateUserGroupList();
                }
                if (SaveButton.Content.ToString() == "Modify")
                {
                    //  UpdateOperationofUserGroup();
                    // PopulateUserGroupList();
                }
                // }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Occur While Storing Information.", caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void SaveOperationofUserGroup()
        {
            bool stat = false;
            if (_ObjBAL.DoesExistEmployeeInformationinSaveMode(EmpIDTextBox.Text.Trim()) == false)
            {
                EmployeeInformation group = new EmployeeInformation();
                group.GEmployeeGenInfoID = Guid.NewGuid();
                if (CompanyComboBox.SelectedIndex > -1)
                {
                    group.GCompanyGenInfoID = new Guid(((Company)(CompanyComboBox.SelectedItem)).strCompanyID);
                }
                if (FactoryComboBox.SelectedIndex > -1)
                {
                    group.GFactoryID = (((Factory)(FactoryComboBox.SelectedItem)).GFactoryID);
                }
                if (DesignationComboBox.SelectedIndex > -1)
                {
                    group.GDesignationInfoID = (((Designation)(DesignationComboBox.SelectedItem)).GDesignationInfoID);
                }
                //group.GLocationID = anEuserGroup.GLocationID;
                if (DepartmentComboBox.SelectedIndex > -1)
                {
                    group.GDepartmentID = (((Department)(DepartmentComboBox.SelectedItem)).GDepartmentID);
                }
                if (JobStatusComboBox.SelectedIndex > -1)
                {
                    group.GEmployeeCatID = (((JobStatus)(JobStatusComboBox.SelectedItem)).Id);
                }
                group.StrEmpID = EmpIDTextBox.Text;
                group.StrEmpCardNo = EmpCardNo.Text;
                group.StrEmpOldCardNo = Employee_EmpOldCardNo.Text;
                group.StrEmpName = EmpName.Text;
                group.StrEmpNameOwnLanguage = Employee_EmpOldCardNo_Copy.Text;
                if (GenderComboBox.SelectedIndex > -1)
                {
                    group.intGender = (((Gender)(GenderComboBox.SelectedItem)).Id);
                }
                //group.bitSystemUser = anEuserGroup.bitSystemUser;
                if (regionTextBox.SelectedIndex > -1)
                {
                    group.GReligionID = (((Religion)(regionTextBox.SelectedItem)).GReligionID);
                }
                if (MaritalStatusComboBox.SelectedIndex > -1)
                {
                    group.intMaritalStatus = (((MaritalStatus)(MaritalStatusComboBox.SelectedItem)).Id);
                }
                group.dtBirthDate = Convert.ToDateTime(BirthDateStringDatePicker.Text);
                group.dtJoiningDate = Convert.ToDateTime(JoiningDateStringDatePicker.Text);
                group.StrFatherName = FatherNameTextBox.Text;
                group.StrMotherName = MotherNameTextBox.Text;
                group.StrCurrentAddress = CurrentAddressTextBox.Text;
                group.StrCurrAddrVillageMohalla = CurrentAddressTextBox.Text;
                group.StrCurrAddrPostOfficeName = CurrAddrPostOfficeNameTextBox_Copy.Text;
                //group.StrCurrAddrPostCode = anEuserGroup.StrCurrAddrPostCode;
                //group.GCurrAddrAreaInfoID = anEuserGroup.GCurrAddrAreaInfoID;
                //group.GCurrAddrThanaUpazilaInfoID = anEuserGroup.GCurrAddrThanaUpazilaInfoID;
                if (PresentDistrictComboBox.SelectedIndex > -1)
                {
                    group.GCurrAddrDistrictInfoID = (((District)(PresentDistrictComboBox.SelectedItem)).GDistrictInfoID);
                }
                group.StrPermanentAddress = PermanentAddressTextBox.Text;
                group.StrPerAddrVillageMohalla = PermanentAddrPostOfficeNameTextBox.Text;
                group.StrPerAddrPostofficeName = PermanentPostOfficeNameTextBox_Copy1.Text;
                //group.StrPerAddrPostCode = anEuserGroup.StrPerAddrPostCode;
                //group.GPerAddrAreaInfoID = anEuserGroup.GPerAddrAreaInfoID;
                //group.GPerAddrThanaUpazilaInfoID = anEuserGroup.GPerAddrThanaUpazilaInfoID;
                if (PermanentDistrictComboBox.SelectedIndex > -1)
                {
                    group.GPerAddrDistrictInfoID = (((District)(PermanentDistrictComboBox.SelectedItem)).GDistrictInfoID);
                }
                group.StrEmpPssportNo = EmpPssportNoTextBox.Text;
                group.StrEmpNationalID = NationalityIDComboBox.Text;
                group.strEmpMobileNo = EmpMobileNoTextBox.Text;
                // group.numEmpWeightKG = Convert.ToDecimal(WeightTextBox.Text);
                group.StrEmpIdenMark = EmpIdentifyMarkTextBox.Text;
                //group.intLatePresentPunishmentFlag = anEuserGroup.intLatePresentPunishmentFlag;
                //group.GCreatedBy = anEuserGroup.GCreatedBy;
                //group.DtCreatedOn = anEuserGroup.DtCreatedOn;
                //group.GUpdatedBy = anEuserGroup.GUpdatedBy;
                //group.DtUpdatedOn = anEuserGroup.DtUpdatedOn;
                group.strEmailAdress = EmailAdressTestBox.Text;
                group.DtConfirmationDate = Convert.ToDateTime(ConfirmationDateDateDatePicker.SelectedDate);
                group.DtResignRetireTerminationDate = Convert.ToDateTime(ResignRetireTerminationDateDatePicker.SelectedDate);
                group.strGrade = GradeComboBox.Text;
                //group.strShift = anEuserGroup.strShift;
                //group.chkEligibleForOverTime = anEuserGroup.chkEligibleForOverTime;
                group.strAlternatePhone = AlternatePhoneTextBox.Text;
                group.strTIN = TINTextBox.Text;
                group.strNationalIDCard = NationalIDCardTextBox.Text;
                group.strAgeString = AgeTextBox.Text;
                group.strFunctionalDesignation = FunctionalDesignationTextBox.Text;
                group.strBloodGroup = BloodGroupComboBox.Text;
                //group.GNationalityID = anEuserGroup.GNationalityID;
                ////bitCarryForwardProcessForDataUpdate = anEuserGroup.bitCarryForwardProcessForDataUpdate,
                ////bitHeadOffice = anEuserGroup.bitHeadOffice,
                //group.bitIsRoaster = anEuserGroup.bitIsRoaster;
                ////  bitEligibleForVistaGLAccount = anEuserGroup.bitEligibleForVistaGLAccount,
                group.intActiveStatus = 1;
                //group.DivisionID = anEuserGroup.DivisionID;
                //group.FingerPrintNo = anEuserGroup.FingerPrintNo;
                group.RelationWithAlternatePhoneOwner = RelationWithAlternatePhoneOwnerTextBox.Text;
                ////  ShiftID = anEuserGroup.ShiftID,
                //// RosterGroupID = anEuserGroup.RosterGroupID,
                //group.GPaymentRuleSetupID = anEuserGroup.GPaymentRuleSetupID;
                /// Employee Assignment
                /// 
                if (SectionComboBox.SelectedIndex > -1)
                {
                    group.GSectionID = ((ENTITY.PIS.Section)(SectionComboBox.SelectedItem)).SectionID;
                }

                if (CategoryComboBox.SelectedIndex > -1)
                {
                    group.CategoryID = ((ENTITY.PIS.Category)(CategoryComboBox.SelectedItem)).CategoryID;
                }
                if (EmployeeCategoryComboBox.SelectedIndex > -1)
                {
                    group.GCategoryEmpID = ((ENTITY.PIS.CategoryEmp)(EmployeeCategoryComboBox.SelectedItem)).CategoryEmpID;
                }
                if (SalaryCategoryCombobox.SelectedIndex > -1)
                {
                    group.CategorySalaryID = ((ENTITY.PIS.CategorySalary)(SalaryCategoryCombobox.SelectedItem)).CategorySalaryID;
                }

                // Education
                group.EducationList = new List<EmployeeEducationInfo>();
                group.EducationList = _educationListObj;
                stat = _ObjBAL.SaveEmployeeInformation(group);


                if (stat)
                {
                    MessageBox.Show("Employee Name has been Saved", caption, MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Employee ID Already Exist.", caption, MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void EducationInfoAddButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeEducationInfo educationObj = new EmployeeEducationInfo();

            if (ExamComboBox.SelectedIndex > -1)
            {
                educationObj.EductionDegreeID = ((ENTITY.PIS.EmployeeEducationInfo)(ExamComboBox.SelectedItem)).EductionDegreeID;
                educationObj.DegreeName = ((ENTITY.PIS.EmployeeEducationInfo)(ExamComboBox.SelectedItem)).DegreeName;
            }
            if (GroupComboBox.SelectedIndex > -1)
            {
                educationObj.EductionGroupSubject = ((ENTITY.PIS.EmployeeEducationInfo)(GroupComboBox.SelectedItem)).EductionGroupSubject;
                educationObj.GroupSubjectName = ((ENTITY.PIS.EmployeeEducationInfo)(GroupComboBox.SelectedItem)).GroupSubjectName;
            }
            if (ResultComboBox.SelectedIndex > -1)
            {
                educationObj.EductionResultID = ((ENTITY.PIS.EmployeeEducationInfo)(ResultComboBox.SelectedItem)).EductionResultID;
                educationObj.EducationResultName = ((ENTITY.PIS.EmployeeEducationInfo)(ResultComboBox.SelectedItem)).EducationResultName;
            }
            if (BoardComboBox.SelectedIndex > -1)
            {
                educationObj.EductionInstituteName = ((ENTITY.PIS.EmployeeEducationInfo)(BoardComboBox.SelectedItem)).EductionInstituteName;
            }
            educationObj.EductionInstituteName = InstituteTextBox.Text;
            educationObj.EductionDegreeYear = Convert.ToInt32(YearTextBox.Text);
            _educationListObj.Add(educationObj);
            lvEmployeeEducation.Items.Clear();
            foreach (EmployeeEducationInfo item in _educationListObj)
            {
                lvEmployeeEducation.Items.Add(item);
                
            }
        }

        private void familyAddButton_Click(object sender, RoutedEventArgs e)
        {
            EmpFamily familyObj = new EmpFamily();
            if (FamilyTypeComboBox.SelectedIndex > -1)
            {
                familyObj.GEmpFamilyType = ((ENTITY.PIS.EmpFamily)(FamilyTypeComboBox.SelectedItem)).GEmpFamilyType;
                familyObj.FamilyTypeName = ((ENTITY.PIS.EmpFamily)(FamilyTypeComboBox.SelectedItem)).FamilyTypeName;
            }

            if (FamilyNomineeComboBox.SelectedIndex > -1)
            {
                if (FamilyNomineeComboBox.SelectedItem.ToString()=="Yes")
                {
                    familyObj.intNominee = 1;
                    familyObj.IsNominee = "Yes";
                }
                if (FamilyNomineeComboBox.SelectedItem.ToString() == "No")
                {
                    familyObj.intNominee = 0;
                    familyObj.IsNominee = "No";
                }
            }
            if (FamilyGenderComboBox.SelectedIndex > -1)
            {
                familyObj.intEmpFamilyGender = ((ENTITY.Common.Gender)(FamilyGenderComboBox.SelectedItem)).Id;
                familyObj.NomineeGenderName = ((ENTITY.Common.Gender)(FamilyGenderComboBox.SelectedItem)).GenderName;
            }
            if (FamilyEducationComboBox.SelectedIndex > -1)
            {
                familyObj.GEmpFamilyEduDegreeID = ((ENTITY.PIS.EmployeeEducationInfo)(FamilyEducationComboBox.SelectedItem)).EductionResultID;
                familyObj.EmpFamilyEduDegreeName = ((ENTITY.PIS.EmployeeEducationInfo)(FamilyEducationComboBox.SelectedItem)).DegreeName;
            }
            if (FamilyProfessionComboBox.SelectedIndex > -1)
            {
                familyObj.GEmpFamilyProfession = ((ENTITY.PIS.NomineeProfession)(FamilyProfessionComboBox.SelectedItem)).GEmpFamilyProfession;
                familyObj.FamilyProfessionName = ((ENTITY.PIS.NomineeProfession)(FamilyProfessionComboBox.SelectedItem)).FamilyProfessionName;
            }
            if (FamilyBloodGroupComboBox.SelectedIndex > -1)
            {
                familyObj.intEmpFamilyBloodGroup = ((ENTITY.Common.BloodGroup)(FamilyBloodGroupComboBox.SelectedItem)).BloodGroupID;
                familyObj.EmpFamilyBloodGroupName = ((ENTITY.Common.BloodGroup)(FamilyBloodGroupComboBox.SelectedItem)).BloodGroupName;
            }
            familyObj.FamilyName = FamilyName.Text;
            if (ShareComboBox.Text=="")
            {
                familyObj.numShare = 0;
            }
            else
            {
                familyObj.numShare = Convert.ToDecimal(ShareComboBox.Text);
            }
            familyObj.dtEmpFamilyBirthDate = NomineeBirthDateDatePicker.SelectedDate;

            _familyListObj.Add(familyObj);
            lvEmployeefamily.Items.Clear();
            foreach (EmpFamily item in _familyListObj)
            {
                lvEmployeefamily.Items.Add(item);

            }
        }
    }
}
