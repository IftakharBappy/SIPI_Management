using BLL.Admission;
using BLL.SetupClass;
using ENTITY.Admission;
using ENTITY.SetupClass;
using ENTITY.Validations;
using Microsoft.Win32;
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


namespace SIPI_SL.UI.Admission
{
    /// <summary>
    /// Interaction logic for StudentAdmissionInformation.xaml
    /// </summary>
    public partial class StudentAdmissionInformation : Window
    {
        StudentInfo _studentInfo;
        StudentInfoManager studentInfoManager = new StudentInfoManager();
        DepartmentManager departmentManagerObj = new DepartmentManager();
        ProgarmManager progarmManagerObj = new ProgarmManager();
        CampusManager campusManagerObj = new CampusManager();
        BatchManager batchManagerObj = new BatchManager();
        ReligionManager religionManager = new ReligionManager();
        DistrictManager districtManagerobj = new DistrictManager();
        PostManager postManagerObj = new PostManager();
        ThanaManager thanaManagerObj = new ThanaManager();
        BloodGroupsManager bloodGroupObj = new BloodGroupsManager();
        List<BloodGroup> _bloodgroupList;
        List<Religion> _rligionList;
        List<StudentInfo> studentInfoList;
        //List<Department> _departmentList;
        //List<Program> _programList;
        List<Campus> _campusList;
        List<Batch> _batchList;
        List<District> _districtList;
        List<Post> _postList;
        List<Thana> _thanaList;

        SIPI_ProgramManager sIPI_ProgramManagerObj = new SIPI_ProgramManager();
        List<SIPI_Program> _SIPIprogramList;

        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();
        List<SIPI_Department> _SIPIDepartmentList;


        byte[] MemberPhoto = new byte[0];
        byte[] SignaturePhoto = new byte[0];

        public StudentAdmissionInformation()
        {
            InitializeComponent();
            LoadAllUIData();
            
            nextButton();
        }

        private void nextButton()
        {
            mainTab.SelectedIndex++;
            saveButton.Content = "Next";
            if (mainTab.SelectedIndex == 0)
            {
                saveButton.Content = "Next";
                backButton.Visibility = Visibility.Hidden;
            }
            if (mainTab.SelectedIndex == 1)
            {
                saveButton.Content = "Next";
                backButton.Visibility = Visibility.Visible;
                backButton.Content = "Previous";

            }
            if (mainTab.SelectedIndex == 2)
            {
                saveButton.Content = "Save";
                backButton.Visibility = Visibility.Visible;
                backButton.Content = "Previous";

            }  
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            _studentInfo = new StudentInfo();

            try
            {
                #region Finish Click event
                if (saveButton.Content.ToString() == "Save")
                {

                    //FIRST TAB
                    #region programCombobox
                    if (programCombobox.SelectedIndex == -1)
                    {
                        _SIPIprogramList = new List<SIPI_Program>();
                        _SIPIprogramList = sIPI_ProgramManagerObj.GetAllSIPI_ProgramNA();
                        foreach (var item in _SIPIprogramList)
                        {
                            if (item.SIPI_ProgramName == "N/A")
                            {
                                _studentInfo.ProgramId = item.Id;
                                _studentInfo.BanglaProgram = item.Id.ToString();
                            }
                        }
                    }
                    else
                    {
                        _studentInfo.ProgramId = ((SIPI_Program)programCombobox.SelectedItem).Id;
                        _studentInfo.BanglaProgram = ((SIPI_Program)programCombobox.SelectedItem).Id.ToString();

                    }
                    #endregion

                    #region departmentCombobox
                    if (departmentCombobox.SelectedIndex == -1)
                    {
                        _SIPIDepartmentList = new List<SIPI_Department>();
                        _SIPIDepartmentList = sIPI_DepartmentManagerObj.GetAll_SIPIDepartmentNA();

                        foreach (var item in _SIPIDepartmentList)
                        {
                            if (item.SIPI_DepartmentName == "N/A")
                            {
                                _studentInfo.DepartmentId = item.Id;
                                _studentInfo.BanglaDepartment = item.Id.ToString();
                            }
                        }
                    }
                    else
                    {
                        _studentInfo.DepartmentId = ((SIPI_Department)departmentCombobox.SelectedItem).Id;
                        _studentInfo.BanglaDepartment = ((SIPI_Department)departmentCombobox.SelectedItem).Id.ToString();

                    }
                    #endregion

                    #region Session
                    _studentInfo.Session = sessionTextBox.Text;

                    string s = _studentInfo.Session;
                    // Split string on '-'
                    string[] words = s.Split('-');
                    string yearStr = "";
                    string yearEnd = "";
                    int i = 0;
                    foreach (string word in words)
                    {
                        i++;
                        if (i == 1)
                        {
                            yearStr = word;
                        }
                        else
                        {
                            yearEnd = word;
                        }
                    }
                    yearStr = string.Concat(yearStr.Select(c => (char)('\u09E6' + c - '0'))); // "১২৩৪৫৬৭৮৯০"
                    yearEnd = string.Concat(yearEnd.Select(c => (char)('\u09E6' + c - '0'))); // "১২৩৪৫৬৭৮৯০"
                    _studentInfo.BanglaSession = yearStr + "-" + yearEnd;
                    #endregion

                    #region campusCombobox
                    if (campusCombobox.SelectedIndex == -1)
                    {
                        campusCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.CampusId = ((Campus)campusCombobox.SelectedItem).Id;
                    }
                    #endregion

                    #region accademicYear
                    _studentInfo.AccadamicYear = accademicYearTextBox.Text;
                    _studentInfo.BanglaAccadamicYear = string.Concat(_studentInfo.AccadamicYear.Select(c => (char)('\u09E6' + c - '0'))); // "১২৩৪৫৬৭৮৯০"

                    #endregion

                    #region batchCombobox
                    if (batchCombobox.SelectedIndex == -1)
                    {
                        _batchList = new List<Batch>();
                        _batchList = batchManagerObj.GetAllBatchNA();
                        _SIPIprogramList = sIPI_ProgramManagerObj.GetAllSIPI_ProgramNA();
                        foreach (var item in _batchList)
                        {

                            _studentInfo.BatchId = item.Id;
                            _studentInfo.BanglaBatch = item.BanglaBatch;
                            _studentInfo.BatchNo = item.BatchNo;

                        }
                    }
                    else
                    {
                        _studentInfo.BatchId = ((Batch)batchCombobox.SelectedItem).Id;
                        _studentInfo.BanglaBatch = ((Batch)batchCombobox.SelectedItem).BanglaBatch;
                        _studentInfo.BatchNo = ((Batch)batchCombobox.SelectedItem).BatchNo;
                    }

                    #endregion

                    #region ApplicantName
                    _studentInfo.ApplicantName = applicantNameTextBox.Text;
                    _studentInfo.BanglaApplicantName = banglaApplicantNameTextBox.Text;
                    _studentInfo.MobileNo = applicantmobileNumberTextBox.Text;
                    _studentInfo.Email = emailTextBox.Text;
                    _studentInfo.DateOfBirth = DateTime.Parse(dateOfBirth.Text);
                    _studentInfo.BanglaDateOfBirth = DateTime.Parse(dateOfBirth.Text);

                    _studentInfo.Interest = interestTextBox.Text;
                    _studentInfo.BanglaInterest = banglaInterestTextBox.Text;
                    _studentInfo.OthersInfo = othersInformationTextBox.Text;
                    _studentInfo.BanglaOthersInfo = banglaOthersInformationTextBox.Text;

                    #endregion
                    #region Nationality
                    _studentInfo.Nationality = nationalityTextBox.Text;
                    if (_studentInfo.Nationality.Equals("bangladeshi", StringComparison.InvariantCultureIgnoreCase))
                    {
                        _studentInfo.BanglaNationality = "বাংলাদেশী";
                    }
                    if (_studentInfo.Nationality.Equals("indian", StringComparison.InvariantCultureIgnoreCase))
                    {
                        _studentInfo.BanglaNationality = "ইন্ডিয়ান";
                    }
                    if (_studentInfo.Nationality.Equals("bhutanese", StringComparison.InvariantCultureIgnoreCase))
                    {
                        _studentInfo.BanglaNationality = "ভুটানি";
                    }
                    if (_studentInfo.Nationality.Equals("nepalese", StringComparison.InvariantCultureIgnoreCase))
                    {
                        _studentInfo.BanglaNationality = "নেপালী";
                    }
                    else
                    {
                        _studentInfo.BanglaNationality = nationalityTextBox.Text;
                    }
                    #endregion
                    #region Gender
                    if (maleRadioButton.IsChecked == true)
                    {
                        _studentInfo.Gender = "Male"; // male gender
                        _studentInfo.BanglaGender = "ছাত্র";
                    }
                    if (femaleRadioButton.IsChecked == true)
                    {
                        _studentInfo.Gender = "Female"; // Female 
                        _studentInfo.BanglaGender = "ছাত্রী"; // Female 
                    }
                    #endregion

                    #region Student_Photo
                    _studentInfo.Student_Photo = MemberPhoto;
                    _studentInfo.Student_Signature = SignaturePhoto;
                    #endregion

                    #region bloodGroup
                    if (bloodGroupComboBox.SelectedIndex == -1)
                    {
                        bloodGroupComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.BloodGroupId = ((BloodGroup)bloodGroupComboBox.SelectedItem).Id;
                    }
                    #endregion

                    #region religion
                    if (religionCombobox.SelectedIndex == -1)
                    {
                        religionCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.ReligionId = ((Religion)religionCombobox.SelectedItem).Id;
                    }
                    #endregion

                    //// 2nd tab

                    #region Family father mother

                    _studentInfo.FatherName = fathersNameTextBox.Text;
                    _studentInfo.BanglaFatherName = banglaFathersNameTextBox.Text;

                    _studentInfo.MotherName = mothersNameTextBox.Text;
                    _studentInfo.BanglaMotherName = banglaMothersNameTextBox.Text;
                    #endregion

                    #region contact
                    _studentInfo.FathersMobileNo = fathersMobileNotextBox.Text;
                    _studentInfo.MothersMobileNo = mothersMobileNoTextBox.Text;
                    _studentInfo.TelephoneNo = telephoneNoTestBox.Text;
                    #endregion

                    #region Permanent
                    _studentInfo.PermanentHouserNo = permanentHouserNoTextBox.Text;
                    _studentInfo.BanglaPermanentHouserNo = banglaPermanentHouserNoTextBox.Text;

                    _studentInfo.PermanentRoadNo = permanentRoadNoTextBox.Text;
                    _studentInfo.BanglaPermanentRoadNo = banglaPermanentRoadNoTextBox.Text;

                    _studentInfo.PermanentBlock = permanentBlockTextBox.Text;
                    _studentInfo.BanglaPermanentBlock = banglaPermanentBlockTextBox.Text;

                    _studentInfo.PermanentSector = permanentSectorTextBox.Text;
                    _studentInfo.BanglaPermanentSector = banglaPermanentSectorTextBox.Text;

                    #region permanentPostComboBox
                    if (permanentPostComboBox.SelectedIndex == -1)
                    {
                        permanentPostComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.BanglaPermanentPost = ((Post)permanentPostComboBox.SelectedItem).BanglaPostName;
                        _studentInfo.PermanentPost = ((Post)permanentPostComboBox.SelectedItem).Id;
                        _studentInfo.PermanentPostName = ((Post)permanentPostComboBox.SelectedItem).PostName;
                    }
                    #endregion
                    #region permanentThanaComboBox
                    if (permanentThanaComboBox.SelectedIndex == -1)
                    {
                        permanentThanaComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PermanentThana = ((Thana)permanentThanaComboBox.SelectedItem).Id;
                        _studentInfo.BanglaPermanentThana = ((Thana)permanentThanaComboBox.SelectedItem).BanglaThanaName;
                        _studentInfo.PermanentThanaName = ((Thana)permanentThanaComboBox.SelectedItem).ThanaName;
                    }
                    #endregion
                    #region permanentDistrictComboBox
                    if (permanentDistrictComboBox.SelectedIndex == -1)
                    {
                        permanentDistrictComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PermanentDistrict = ((District)permanentDistrictComboBox.SelectedItem).Id;
                        _studentInfo.PermanentDistrictName = ((District)permanentDistrictComboBox.SelectedItem).DistrictName;
                        _studentInfo.BanglaPermanentDistrict = ((District)permanentDistrictComboBox.SelectedItem).BanglaDistrict;
                    }
                    #endregion

                    #endregion
                    #region present
                    _studentInfo.PresentHouserNo = presentHouserNoTextBox.Text;
                    _studentInfo.BanglaPresentHouserNo = banglapresentHouserNoTextBox.Text;

                    _studentInfo.PresentRoadNo = presentRoadNoTextBox.Text;
                    _studentInfo.BanglaPresentRoadNo = banglaPresentRoadNoTextBox.Text;

                    _studentInfo.PresentBlock = presentBlockTextBox.Text;
                    _studentInfo.BanglaPresentBlock = banglaPresentBlockTextBox.Text;

                    _studentInfo.PresentSector = presentSectorTextBox.Text;
                    _studentInfo.BanglaPresentSector = banglaPresentSectorTextBox.Text;

                    #region presentPostComboBox
                    if (presentPostComboBox.SelectedIndex == -1)
                    {
                        presentPostComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PresentPost = ((Post)presentPostComboBox.SelectedItem).Id;
                        _studentInfo.BanglaPresentPost = ((Post)presentPostComboBox.SelectedItem).BanglaPostName;
                        _studentInfo.PresentPostName = ((Post)presentPostComboBox.SelectedItem).PostName;
                    }
                    #endregion
                    #region presentThanaComboBox
                    if (presentThanaComboBox.SelectedIndex == -1)
                    {
                        presentThanaComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PresentThana = ((Thana)presentThanaComboBox.SelectedItem).Id;
                        _studentInfo.BanglaPresentThana = ((Thana)presentThanaComboBox.SelectedItem).BanglaThanaName;
                        _studentInfo.PresentThanaName = ((Thana)presentThanaComboBox.SelectedItem).ThanaName;
                    }
                    #endregion
                    #region presentDistrictComboBox
                    if (presentDistrictComboBox.SelectedIndex == -1)
                    {
                        presentDistrictComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PresentDistrict = ((District)presentDistrictComboBox.SelectedItem).Id;
                        _studentInfo.PresentDistrictName = ((District)presentDistrictComboBox.SelectedItem).DistrictName;
                        _studentInfo.BanglaPresentDistrict = ((District)presentDistrictComboBox.SelectedItem).BanglaDistrict;
                    }
                    #endregion

                    #endregion

                    #region freedomFighter
                    if (freedomFighterYesRadioButton.IsChecked == true)
                    {
                        _studentInfo.FreedomFighter = true;
                        _studentInfo.BanglaFreedomFighter = true;
                    }
                    if (freedomFighterNoRadioButton.IsChecked == true)
                    {
                        _studentInfo.FreedomFighter = false;
                        _studentInfo.BanglaFreedomFighter = false;
                    }
                    #endregion

                    #region tribal
                    if (tribalYesRadioButton.IsChecked == true)
                    {
                        _studentInfo.Tribal = true;
                        _studentInfo.BanglaTribal = true;

                    }
                    if (tribalNoRadioButton.IsChecked == true)
                    {
                        _studentInfo.Tribal = false;
                        _studentInfo.BanglaTribal = false;
                    }

                    #endregion
                    #region Guardian local
                    _studentInfo.GuardianName = guardianNameTextbox.Text;
                    _studentInfo.BanglaGuardianName = banglaGuardianNameTextbox.Text;
                    _studentInfo.GuardianMobileNo = guardianMobileNoTextbox.Text;
                    _studentInfo.GuardianEmail = guardianEmailTextBox.Text;
                    #endregion
                    #region Guardian local address
                    _studentInfo.GuardianHouserNo = guardianHouserNoTextBox.Text;
                    _studentInfo.GuardianRoadNo = guardianRoadNoTextBox.Text;
                    _studentInfo.GuardianBlock = guardianBlockTextBox.Text;
                    _studentInfo.GuardianSector = guardianSectorTextBox.Text;

                    _studentInfo.BanglaGuardianHouserNo = banglaGuardianHouserNoTextBox.Text;
                    _studentInfo.BanglaGuardianRoadNo = banglaGuardianRoadNoTextBox.Text;
                    _studentInfo.BanglaGuardianBlock = banglaGuardianBlockTextBox.Text;
                    _studentInfo.BanglaGuardianSector = banglaGuardianSectorTextBox.Text;

                    #region guardianPostComboBox
                    if (guardianPostComboBox.SelectedIndex == -1)
                    {
                        guardianPostComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.GuardianPost = ((Post)guardianPostComboBox.SelectedItem).Id;
                        _studentInfo.BanglaGuardianPost = ((Post)guardianPostComboBox.SelectedItem).BanglaPostName;
                    }
                    #endregion
                    #region guardianThanaComboBox
                    if (guardianThanaComboBox.SelectedIndex == -1)
                    {
                        guardianThanaComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.GuardianThana = ((Thana)guardianThanaComboBox.SelectedItem).Id;
                        _studentInfo.BanglaGuardianThana = ((Thana)guardianThanaComboBox.SelectedItem).BanglaThanaName;
                    }
                    #endregion
                    #region guardianDistrictComboBox
                    if (guardianDistrictComboBox.SelectedIndex == -1)
                    {
                        guardianDistrictComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.GuardianDistrict = ((District)guardianDistrictComboBox.SelectedItem).Id;
                        _studentInfo.BanglaGuardianDistrict = ((District)guardianDistrictComboBox.SelectedItem).BanglaDistrict;
                    }
                    #endregion

                    ////
                    #endregion

                    #region AccadamicInfo
                    _studentInfo.AccadamicInfo_ExamNme = examNameCombobox.Text;
                    _studentInfo.AccadamicInfo_Group = groupNameCombobox.Text;
                    _studentInfo.AccadamicInfo_Board = boardCombobox.Text;
                    _studentInfo.AccadamicInfo_SchoolName = schoolNameTextbox.Text;
                    #region rollNo
                    if (rollNoTextbox.Text == "")
                    {
                        rollNoTextbox.Text = null;
                    }
                    else
                    {
                        _studentInfo.AccadamicInfo_RollNo = Convert.ToInt32(rollNoTextbox.Text);
                    }
                    #endregion

                    #region RegistrationNo
                    if (registrationNoTextbox.Text == "")
                    {
                        registrationNoTextbox.Text = null;
                    }
                    else
                    {
                        _studentInfo.AccadamicInfo_RegistrationNo = Convert.ToInt32(registrationNoTextbox.Text);
                    }
                    #endregion AccadamicInfo_RegistrationNo

                    #region passingYear
                    if (passingYearTextbox.Text == "")
                    {
                        passingYearTextbox.Text = null;
                    }
                    else
                    {
                        _studentInfo.AccadamicInfo_PassingYear = Convert.ToInt32(passingYearTextbox.Text);
                    }

                    #endregion

                    _studentInfo.AccadamicInfo_GPA = gpaTextbox.Text;
                    #endregion

                    #region Id Generate

                    string yearforStId = accademicYearTextBox.Text;
                    string sub = yearforStId.Substring(2, yearforStId.Length - 2); /////Sub string
                    int cnt = 0;
                    string dept = ((SIPI_Department)departmentCombobox.SelectedItem).SIPI_DepartmentName;
                    string year = accademicYearTextBox.Text.Trim();

                    cnt = studentInfoManager.GetLastStudentForID(dept, year) + 1; /////count


                    string threeDigit = cnt.ToString("000");

                    _studentInfo.StudentID = sub + ((SIPI_Department)departmentCombobox.SelectedItem).SIPI_DepartmentCode + threeDigit;
                    #endregion

                    studentInfoManager.SaveStudentInfo(_studentInfo);
                    #region Message box
                    string message = "Student Admission Successfull" +
                       Environment.NewLine + "This Student ID IS :  " + _studentInfo.StudentID +
                       Environment.NewLine + "Keep Remember this ID";
                    string caption = "Confirmation";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Information;
                    MessageBox.Show(message, caption, buttons, icon);
                    #endregion

                    LoadAllStudentInfo();
                    ClearAllStudentInfo();

                }
                #endregion

                #region Update Click Event
                if (finishButton.Content.ToString() == "Update")
                {
                    //// Program Information


                    if (programCombobox.Text == "")
                    {
                        programCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.ProgramId = ((SIPI_Program)programCombobox.SelectedItem).Id;
                    }

                    _studentInfo.Session = sessionTextBox.Text;

                    ///// campusCombobox
                    if (campusCombobox.Text == "")
                    {
                        campusCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.CampusId = ((Campus)campusCombobox.SelectedItem).Id;
                    }

                    ///// departmentCombobox
                    if (departmentCombobox.Text == "")
                    {
                        departmentCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.DepartmentId = ((SIPI_Department)departmentCombobox.SelectedItem).Id;
                    }
                    ////

                    _studentInfo.AccadamicYear = accademicYearTextBox.Text; //problem is here

                    //_studentInfo.BanglaAccadamicYear = banglaAccademicYearTextBox.Text;

                    ///// batchCombobox
                    if (batchCombobox.Text == "")
                    {
                        batchCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.BatchId = ((Batch)batchCombobox.SelectedItem).Id;
                    }
                    ////

                    //_studentInfo.BanglaSession = banglaSessionTextBox.Text;

                    _studentInfo.GuardianName = guardianNameTextbox.Text;

                    //// 2nd tab (Presonal Information)

                    _studentInfo.Student_Photo = MemberPhoto;
                    _studentInfo.Student_Signature = SignaturePhoto;

                    _studentInfo.ApplicantName = applicantNameTextBox.Text;

                    _studentInfo.MobileNo = applicantmobileNumberTextBox.Text;
                    _studentInfo.Email = emailTextBox.Text;

                    /// Boolin type here
                    if (maleRadioButton.IsChecked == true)
                    {
                        _studentInfo.Gender = "Male"; // male gender
                    }
                    if (femaleRadioButton.IsChecked == true)
                    {
                        _studentInfo.Gender = "Female"; // Female 
                    }

                    _studentInfo.DateOfBirth = DateTime.Parse(dateOfBirth.Text);
                    _studentInfo.Nationality = nationalityTextBox.Text;
                    /////bloodGroupComboBox
                    if (bloodGroupComboBox.Text == "")
                    {
                        bloodGroupComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.BloodGroupId = ((BloodGroup)bloodGroupComboBox.SelectedItem).Id;
                    }
                    ////
                    /////religionCombobox
                    if (religionCombobox.Text == "")
                    {
                        religionCombobox.Text = null;
                    }
                    else
                    {
                        _studentInfo.ReligionId = ((Religion)religionCombobox.SelectedItem).Id;
                    }
                    ////



                    _studentInfo.Interest = interestTextBox.Text;
                    _studentInfo.OthersInfo = othersInformationTextBox.Text;
                    _studentInfo.BanglaApplicantName = banglaApplicantNameTextBox.Text;
                    ////Boolin type here  bangla Gender
                    //if (banglaMaleRadioButton.IsChecked == true)
                    //{
                    //    _studentInfo.BanglaGender = "ছাত্র"; // male gender
                    //}
                    //if (banglaFemaleRadioButton.IsChecked == true)
                    //{
                    //    _studentInfo.BanglaGender = "ছাত্রী"; // Female 
                    //}

                    //_studentInfo.BanglaNationality = banglaNationalityTextBox.Text;
                    //_studentInfo.BanglaDateOfBirth = DateTime.Parse(banglaDateOfbirth.Text);
                    _studentInfo.BanglaInterest = banglaInterestTextBox.Text;
                    _studentInfo.BanglaOthersInfo = banglaOthersInformationTextBox.Text;

                    //// 3rd tab (Contact Information)
                    /////Family And Contact Information

                    _studentInfo.FatherName = fathersNameTextBox.Text;
                    _studentInfo.MotherName = mothersNameTextBox.Text;

                    ////Freedom Fighter Radio Button
                    //end
                    if (freedomFighterYesRadioButton.IsChecked == true)
                    {
                        _studentInfo.FreedomFighter = true;
                    }
                    if (freedomFighterNoRadioButton.IsChecked == true)
                    {
                        _studentInfo.FreedomFighter = false;
                    }
                    ///// Tribal Radio Button
                    if (tribalYesRadioButton.IsChecked == true)
                    {
                        _studentInfo.Tribal = true;
                    }
                    if (tribalNoRadioButton.IsChecked == true)
                    {
                        _studentInfo.Tribal = false;
                    }

                    ///////
                    _studentInfo.FathersMobileNo = fathersMobileNotextBox.Text;
                    _studentInfo.MothersMobileNo = mothersMobileNoTextBox.Text;
                    _studentInfo.TelephoneNo = telephoneNoTestBox.Text;
                    //////

                    _studentInfo.BanglaFatherName = banglaFathersNameTextBox.Text;
                    _studentInfo.BanglaMotherName = banglaMothersNameTextBox.Text;

                    //Bangla Freedom Fighter Radio Button
                    //if (banglaFreedomFighterYesRadioButton.IsChecked == true)
                    //{
                    //    _studentInfo.BanglaFreedomFighter = true;
                    //}
                    //if (banglaFreedomFighterNoRadioButton.IsChecked == true)
                    //{
                    //    _studentInfo.BanglaFreedomFighter = false;
                    //}
                    ///// Bangla Tribal Radio Button
                    //if (banglaTribalYesRadioButton.IsChecked == true)
                    //{
                    //    _studentInfo.BanglaTribal = true;
                    //}
                    //if (banglaTribalNoRadioButton.IsChecked == true)
                    //{
                    //    _studentInfo.BanglaTribal = false;
                    //}


                    _studentInfo.PermanentHouserNo = permanentHouserNoTextBox.Text;
                    _studentInfo.PermanentRoadNo = permanentRoadNoTextBox.Text;
                    _studentInfo.PermanentBlock = permanentBlockTextBox.Text;
                    _studentInfo.PermanentSector = permanentSectorTextBox.Text;

                    ///// permanentPostComboBox
                    if (permanentPostComboBox.Text == "")
                    {
                        permanentPostComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PostId = ((Post)permanentPostComboBox.SelectedItem).Id;
                    }
                    ////

                    ///// permanentThanaComboBox
                    if (permanentThanaComboBox.Text == "")
                    {
                        permanentThanaComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.ThanaId = ((Thana)permanentThanaComboBox.SelectedItem).Id;
                    }
                    ////

                    ///// permanentDistrictComboBox
                    if (permanentDistrictComboBox.Text == "")
                    {
                        permanentDistrictComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.DistrictId = ((District)permanentDistrictComboBox.SelectedItem).Id;
                    }
                    ////

                    //////Bangla Permanent
                    _studentInfo.BanglaPermanentHouserNo = banglaPermanentHouserNoTextBox.Text;
                    _studentInfo.BanglaPermanentRoadNo = banglaPermanentRoadNoTextBox.Text;
                    _studentInfo.BanglaPermanentBlock = banglaPermanentBlockTextBox.Text;
                    _studentInfo.BanglaPermanentSector = banglaPermanentSectorTextBox.Text;


                    ////// present address
                    _studentInfo.PresentHouserNo = presentHouserNoTextBox.Text;
                    _studentInfo.PresentRoadNo = presentRoadNoTextBox.Text;
                    _studentInfo.PresentBlock = presentBlockTextBox.Text;
                    _studentInfo.PresentSector = presentSectorTextBox.Text;

                    ///// presentPostComboBox
                    if (presentPostComboBox.Text == "")
                    {
                        presentPostComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PostId = ((Post)presentPostComboBox.SelectedItem).Id;
                    }
                    ////

                    ///// presentThanaComboBox
                    if (presentThanaComboBox.Text == "")
                    {
                        presentThanaComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.ThanaId = ((Thana)presentThanaComboBox.SelectedItem).Id;
                    }
                    ////

                    ///// presentDistrictComboBox
                    if (presentDistrictComboBox.Text == "")
                    {
                        presentDistrictComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.DistrictId = ((District)presentDistrictComboBox.SelectedItem).Id;
                    }
                    ////

                    //// bangla present
                    _studentInfo.BanglaPresentHouserNo = banglapresentHouserNoTextBox.Text;
                    _studentInfo.BanglaPresentRoadNo = banglaPresentRoadNoTextBox.Text;
                    _studentInfo.BanglaPresentBlock = banglaPresentBlockTextBox.Text;
                    _studentInfo.BanglaPresentSector = banglaPresentSectorTextBox.Text;


                    //Guardian Info

                    _studentInfo.GuardianName = guardianNameTextbox.Text;
                    _studentInfo.BanglaGuardianName = banglaGuardianNameTextbox.Text;
                    _studentInfo.GuardianMobileNo = guardianMobileNoTextbox.Text;
                    _studentInfo.GuardianEmail = guardianEmailTextBox.Text;

                    ///Guardian Address
                    _studentInfo.GuardianHouserNo = guardianHouserNoTextBox.Text;
                    _studentInfo.GuardianRoadNo = guardianRoadNoTextBox.Text;
                    _studentInfo.GuardianBlock = guardianBlockTextBox.Text;
                    _studentInfo.GuardianSector = guardianSectorTextBox.Text;

                    ///// guardianPostComboBox
                    if (guardianPostComboBox.Text == "")
                    {
                        guardianPostComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.PostId = ((Post)guardianPostComboBox.SelectedItem).Id;
                    }
                    ////

                    ///// guardianThanaComboBox
                    if (guardianThanaComboBox.Text == "")
                    {
                        guardianThanaComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.ThanaId = ((Thana)guardianThanaComboBox.SelectedItem).Id;
                        //_studentInfo.GuardianThana = guardianThanaComboBox.Text;
                    }
                    ////
                    ///// guardianDistrictComboBox
                    if (guardianDistrictComboBox.Text == "")
                    {
                        guardianDistrictComboBox.Text = null;
                    }
                    else
                    {
                        _studentInfo.DistrictId = ((District)guardianDistrictComboBox.SelectedItem).Id;
                        //_studentInfo.GuardianDistrict = guardianDistrictComboBox.Text;
                    }
                    ////


                    //Bangla Guardian Info

                    _studentInfo.BanglaGuardianHouserNo = banglaGuardianHouserNoTextBox.Text;
                    _studentInfo.BanglaGuardianRoadNo = banglaGuardianRoadNoTextBox.Text;
                    _studentInfo.BanglaGuardianBlock = banglaGuardianBlockTextBox.Text;
                    _studentInfo.BanglaGuardianSector = banglaGuardianSectorTextBox.Text;


                    ////Accadamic info
                    /////
                    _studentInfo.AccadamicInfo_ExamNme = examNameCombobox.Text;
                    _studentInfo.AccadamicInfo_Group = groupNameCombobox.Text;
                    _studentInfo.AccadamicInfo_Board = boardCombobox.Text;
                    _studentInfo.AccadamicInfo_SchoolName = schoolNameTextbox.Text;
                    if (rollNoTextbox.Text == "")
                    {
                        rollNoTextbox.Text = null;
                    }
                    else
                    {
                        _studentInfo.AccadamicInfo_RollNo = Convert.ToInt32(rollNoTextbox.Text);
                    }
                    /////
                    //
                    if (registrationNoTextbox.Text == "")
                    {
                        registrationNoTextbox.Text = null;
                    }
                    else
                    {
                        _studentInfo.AccadamicInfo_RegistrationNo = Convert.ToInt32(registrationNoTextbox.Text);
                    }
                    ////
                    //
                    if (passingYearTextbox.Text == "")
                    {
                        passingYearTextbox.Text = null;
                    }
                    else
                    {
                        _studentInfo.AccadamicInfo_PassingYear = Convert.ToInt32(passingYearTextbox.Text);
                    }

                    _studentInfo.AccadamicInfo_GPA = gpaTextbox.Text;

                    studentInfoManager.UpdateInfo(_studentInfo);
                    LoadAllStudentInfo();
                    MessageBox.Show("Data Update Successfully");
                    finishButton.Content = "Finish";
                    ClearAllStudentInfo();


                }
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            nextButton();

        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            mainTab.SelectedIndex--;
        }
        private void mainTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //nextButton();
            if (mainTab.SelectedIndex == 0)
            {
                saveButton.Content = "Next";
                backButton.Visibility = Visibility.Hidden;
            }
            if (mainTab.SelectedIndex == 1)
            {
                saveButton.Content = "Next";
                backButton.Visibility = Visibility.Visible;
                backButton.Content = "Previous";

            }
            if (mainTab.SelectedIndex == 2)
            {
                saveButton.Content = "Save";
                backButton.Visibility = Visibility.Visible;
                backButton.Content = "Previous";

            }  
        }
        public void LoadAllUIData()
        {
            LoadDepartmentComboBox();
            LoadProgramComboBox();
            LoadsessionTextBox();
            LoadCampusComboBox();
            LoadBatchComboBox();
            LoadBloodGroupComboBox();
            LoadReligionComboBox();
            dateOfBirth.SelectedDate = DateTime.Now;
            LoadAllPostComboBox(-1);
            LoadallThanaComboBox(-1);
            LoadAllDistrictComboBox();


            //LoadAllStudentInfo();
            //LoadBanglaDepartmentComboBox();
            //LoadBanglaProgramComboBox();
            //LoadBanglaCampusComboBox();
            //LoadBanglaBatchComboBox();
            //LoadPermanentPostComboBox(-1);
            //LoadPermanentThanaComboBox(-1);
            ////LoadPermanentThanaComboBox();
            //LoadPresentPostComboBox(-1);
            //LoadPresentThanaComboBox(-1);
            //LoadGuardianThanaComboBox(-1);
            //LoadBanglaGuardianThanaComboBox(-1);,
            //LoadBanglaGuardianDistrictComboBox();
            //LoadGuardianPostComboBox(-1); 
            //LoadBanglaGuardianPostComboBox(-1);
            //banglaDateOfbirth.SelectedDate = DateTime.Now;
        }
         TemporaryDataSetManager _temporaryDataSetManagerObj = new TemporaryDataSetManager();
        List<TemporaryDataSet> _temporaryDataSetList;
        private void LoadAllDistrictComboBox()
        {
            _districtList = new List<District>();
            _districtList = districtManagerobj.GetAllDistrict();

            //permanentDistrictComboBox.Items.Clear();
            foreach (District district in _districtList)
            {
                permanentDistrictComboBox.ItemsSource = _districtList;
                presentDistrictComboBox.ItemsSource = _districtList;
                guardianDistrictComboBox.ItemsSource = _districtList;
                for (int i = 0; i < permanentDistrictComboBox.Items.Count; i++)
                {
                    District permanentDistrictObj = (District)permanentDistrictComboBox.Items[i];
                    if (permanentDistrictObj.DistrictName == "N/A")
                    {
                        permanentDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                    permanentDistrictComboBox.DisplayMemberPath = "DistrictName";
                } 
                //presentDistrictComboBox
                for (int i = 0; i < presentDistrictComboBox.Items.Count; i++)
                {
                    District presentDistrictObj = (District)presentDistrictComboBox.Items[i];
                    if (presentDistrictObj.DistrictName == "N/A")
                    {
                        presentDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                    presentDistrictComboBox.DisplayMemberPath = "DistrictName";
                }
               //guardianDistrictComboBox
                for (int i = 0; i < guardianDistrictComboBox.Items.Count; i++)
                {
                    District guardianDistrictObj = (District)guardianDistrictComboBox.Items[i];
                    if (guardianDistrictObj.DistrictName == "N/A")
                    {
                        guardianDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                    guardianDistrictComboBox.DisplayMemberPath = "DistrictName";
                }
            }
             
        }
        private void LoadAllPostComboBox(int p)
        {
            _postList = new List<Post>();
            _postList = postManagerObj.LoadAllPost(p);
            #region presentPostComboBox
            if (p == -1)
            {
                foreach (Post post in _postList)
                {
                    presentPostComboBox.ItemsSource = _postList;
                    for (int i = 0; i < presentPostComboBox.Items.Count; i++)
                    {
                        Post postObj = (Post)presentPostComboBox.Items[i];
                        if (postObj.PostName == "N/A")
                        {
                            presentPostComboBox.SelectedIndex = i;
                            break;
                        }
                        presentPostComboBox.DisplayMemberPath = "PostName";
                    }
                }

            }

            else
            {
                try
                {
                    Thana thana = presentThanaComboBox.SelectedItem as Thana;
                    //_postList = postManagerObj.LoadAllPost(thana.Id);

                    foreach (Post post in _postList)
                    {
                        if (post.ThanaId == thana.Id)
                        {
                            presentPostComboBox.ItemsSource = _postList;
                        }
                    }
                    presentPostComboBox.DisplayMemberPath = "PostName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
            #endregion
            #region permanentPostComboBox
            if (p == -1)
            {
                foreach (Post post in _postList)
                {
                    permanentPostComboBox.ItemsSource = _postList;
                    for (int i = 0; i < permanentPostComboBox.Items.Count; i++)
                    {
                        Post postObj = (Post)permanentPostComboBox.Items[i];
                        if (postObj.PostName == "N/A")
                        {
                            permanentPostComboBox.SelectedIndex = i;
                            break;
                        }
                        permanentPostComboBox.DisplayMemberPath = "PostName";
                    }
                }

            }

            else
            {
                try
                {
                    Thana thana = permanentThanaComboBox.SelectedItem as Thana;
                    foreach (Post post in _postList)
                    {
                        if (post.ThanaId == post.ThanaId)
                        {
                            permanentPostComboBox.ItemsSource = _postList;
                        }
                    }
                    permanentPostComboBox.DisplayMemberPath = "PostName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
            
            #endregion
            #region guardianPostComboBox
            if (p == -1)
            {
                foreach (Post post in _postList)
                {
                    guardianPostComboBox.ItemsSource = _postList;
                    for (int i = 0; i < guardianPostComboBox.Items.Count; i++)
                    {
                        Post postObj = (Post)guardianPostComboBox.Items[i];
                        if (postObj.PostName == "N/A")
                        {
                            guardianPostComboBox.SelectedIndex = i;
                            break;
                        }
                        guardianPostComboBox.DisplayMemberPath = "PostName";
                    }
                }

            }
            else
            {
                try
                {
                    Thana thana = guardianPostComboBox.SelectedItem as Thana;
                    foreach (Post post in _postList)
                    {
                        if (post.ThanaId == post.ThanaId)
                        {
                            guardianPostComboBox.ItemsSource = _postList;
                        }
                    }
                    guardianPostComboBox.DisplayMemberPath = "PostName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }

            #endregion
        }
        private void LoadallThanaComboBox(int p)
        {
            _thanaList = new List<Thana>();
            _thanaList = thanaManagerObj.LoadAllThana(p);

            #region presentThanaComboBox
            if (p == -1)
            {
                foreach (Thana thana in _thanaList)
                {
                    presentThanaComboBox.ItemsSource = _thanaList;
                    for (int i = 0; i < presentThanaComboBox.Items.Count; i++)
                    {
                        Thana thanaObj = (Thana)presentThanaComboBox.Items[i];
                        if (thanaObj.ThanaName == "N/A")
                        {
                            presentThanaComboBox.SelectedIndex = i;
                            break;
                        }
                        presentThanaComboBox.DisplayMemberPath = "ThanaName";
                    }
                }

            }

            else
            {
                try
                {
                    District district = presentDistrictComboBox.SelectedItem as District;

                    foreach (Thana thana in _thanaList)
                    {
                        if (thana.DistrictId == district.Id)
                        {
                            presentThanaComboBox.ItemsSource = _thanaList;
                        }
                    }
                    presentThanaComboBox.DisplayMemberPath = "ThanaName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
            #endregion
            #region permanentThanaComboBox
            if (p == -1)
            {
                foreach (Thana thana in _thanaList)
                {
                    permanentThanaComboBox.ItemsSource = _thanaList;
                    for (int i = 0; i < permanentThanaComboBox.Items.Count; i++)
                    {
                        Thana thanaObj = (Thana)permanentThanaComboBox.Items[i];
                        if (thanaObj.ThanaName == "N/A")
                        {
                            permanentThanaComboBox.SelectedIndex = i;
                            break;
                        }
                        permanentThanaComboBox.DisplayMemberPath = "ThanaName";
                    }
                }

            }

            else
            {
                try
                {
                    District district = permanentDistrictComboBox.SelectedItem as District;

                    foreach (Thana thana in _thanaList)
                    {
                        if (thana.DistrictId == district.Id)
                        {
                            permanentThanaComboBox.ItemsSource = _thanaList;
                        }
                    }
                    permanentThanaComboBox.DisplayMemberPath = "ThanaName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
            #endregion
            #region guardianThanaComboBox
            if (p == -1)
            {
                foreach (Thana thana in _thanaList)
                {
                    guardianThanaComboBox.ItemsSource = _thanaList;
                    for (int i = 0; i < guardianThanaComboBox.Items.Count; i++)
                    {
                        Thana thanaObj = (Thana)guardianThanaComboBox.Items[i];
                        if (thanaObj.ThanaName == "N/A")
                        {
                            guardianThanaComboBox.SelectedIndex = i;
                            break;
                        }
                        guardianThanaComboBox.DisplayMemberPath = "ThanaName";
                    }
                }

            }

            else
            {
                try
                {
                    District district = guardianDistrictComboBox.SelectedItem as District;

                    foreach (Thana thana in _thanaList)
                    {
                        if (thana.DistrictId == district.Id)
                        {
                            guardianThanaComboBox.ItemsSource = _thanaList;
                        }
                    }
                    guardianThanaComboBox.DisplayMemberPath = "ThanaName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
            #endregion
          
        }
      
        private void LoadsessionTextBox()
        {
            sessionTextBox.SelectedIndex = -1;
            _temporaryDataSetList = new List<TemporaryDataSet>();
            _temporaryDataSetList = _temporaryDataSetManagerObj.GetAllSession();
            sessionTextBox.Items.Clear();

            foreach (TemporaryDataSet temporaryDataSession in _temporaryDataSetList)
            {
                sessionTextBox.Items.Add(temporaryDataSession);
                for (int i = 0; i < sessionTextBox.Items.Count; i++)
                {
                    TemporaryDataSet departmentobj = (TemporaryDataSet)sessionTextBox.Items[i];
                    if (departmentobj.Session == "N/A")
                    {
                        sessionTextBox.SelectedIndex = i;
                        break;
                    }
                }
            }
            sessionTextBox.DisplayMemberPath = "Session";
        }


        //private void LoadBanglaGuardianPostComboBox(int p)
        //{


        //    if (p == -1)
        //    {
        //        _postList = postManagerObj.LoadAllPost(p);
        //        foreach (Post post in _postList)
        //        {
        //            banglaGuardianPostComboBox.ItemsSource = _postList;
        //            for (int i = 0; i < banglaGuardianPostComboBox.Items.Count; i++)
        //            {
        //                Post banglaPostObj = (Post)banglaGuardianPostComboBox.Items[i];
        //                if (banglaPostObj.PostName == "N/A")
        //                {
        //                    banglaGuardianPostComboBox.SelectedIndex = i;
        //                    break;
        //                }
        //                banglaGuardianPostComboBox.DisplayMemberPath = "BanglaPostName";
        //            }
        //        }
                
        //    }

        //    else
        //    {
        //        try
        //        {
        //            Thana thana = banglaGuardianThanaComboBox.SelectedItem as Thana;
        //            _postList = postManagerObj.LoadAllPost(thana.Id);

        //            foreach (Post post in _postList)
        //            {
        //                banglaGuardianPostComboBox.ItemsSource = _postList;
        //            }
        //            banglaGuardianPostComboBox.DisplayMemberPath = "BanglaPostName";

        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Please Select Product Category", "Confirmation");
        //        }

        //    }
        //}

        //private void LoadBanglaGuardianThanaComboBox(int p)
        //{
        //    if (p == -1)
        //    {
        //        _thanaList = thanaManagerObj.LoadAllThana(p);
        //        foreach (Thana thana in _thanaList)
        //        {
        //            banglaGuardianThanaComboBox.ItemsSource = _thanaList;
        //            for (int i = 0; i < banglaGuardianThanaComboBox.Items.Count; i++)
        //            {
        //                Thana banglaThanaObj = (Thana)banglaGuardianThanaComboBox.Items[i];
        //                if (banglaThanaObj.ThanaName == "N/A")
        //                {
        //                    banglaGuardianThanaComboBox.SelectedIndex = i;
        //                    break;
        //                }
        //                banglaGuardianThanaComboBox.DisplayMemberPath = "BanglaThanaName";
        //            }
        //        }
        //        banglaGuardianThanaComboBox.DisplayMemberPath = "BanglaThanaName";
        //    }

        //    else
        //    {
        //        try
        //        {
        //            District district = banglaGuardianDistrictComboBox.SelectedItem as District;
        //            _thanaList = thanaManagerObj.LoadAllThana(district.Id);

        //            foreach (Thana thana in _thanaList)
        //            {
        //                banglaGuardianThanaComboBox.ItemsSource = _thanaList;
        //            }
        //            banglaGuardianThanaComboBox.DisplayMemberPath = "BanglaThanaName";

        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Please Select Product Category", "Confirmation");
        //        }

        //    }
        //}

        private void LoadGuardianPostComboBox(int p)
        {


            if (p == -1)
            {
                _postList = postManagerObj.LoadAllPost(p);
                foreach (Post post in _postList)
                {
                    guardianPostComboBox.ItemsSource = _postList;
                    for (int i = 0; i < guardianPostComboBox.Items.Count; i++)
                    {
                        Post postObj = (Post)guardianPostComboBox.Items[i];
                        if (postObj.PostName == "N/A")
                        {
                            guardianPostComboBox.SelectedIndex = i;
                            break;
                        }
                        guardianPostComboBox.DisplayMemberPath = "PostName";
                    }
                }
                guardianPostComboBox.DisplayMemberPath = "PostName";
            }

            else
            {
                try
                {
                    Thana thana = guardianThanaComboBox.SelectedItem as Thana;
                    _postList = postManagerObj.LoadAllPost(thana.Id);

                    foreach (Post post in _postList)
                    {
                        guardianPostComboBox.ItemsSource = _postList;
                    }
                    guardianPostComboBox.DisplayMemberPath = "PostName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
        }

        private void LoadGuardianThanaComboBox(int p)
        {
            if (p == -1)
            {
                _thanaList = thanaManagerObj.LoadAllThana(p);
                foreach (Thana thana in _thanaList)
                {
                    guardianThanaComboBox.ItemsSource = _thanaList;
                    for (int i = 0; i < guardianThanaComboBox.Items.Count; i++)
                    {
                        Thana thanaObj = (Thana)guardianThanaComboBox.Items[i];
                        if (thanaObj.ThanaName == "N/A")
                        {
                            guardianThanaComboBox.SelectedIndex = i;
                            break;
                        }
                        guardianThanaComboBox.DisplayMemberPath = "ThanaName";
                    }
                }
                
            }

            else
            {
                try
                {
                    District district = guardianDistrictComboBox.SelectedItem as District;
                    _thanaList = thanaManagerObj.LoadAllThana(district.Id);

                    foreach (Thana thana in _thanaList)
                    {
                        guardianThanaComboBox.ItemsSource = _thanaList;
                    }
                    guardianThanaComboBox.DisplayMemberPath = "ThanaName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
        }
      
        private void LoadPresentPostComboBox(int p)
        {


            if (p == -1)
            {
                _postList = postManagerObj.LoadAllPost(p);
                foreach (Post post in _postList)
                {
                    presentPostComboBox.ItemsSource = _postList;
                    for (int i = 0; i < presentPostComboBox.Items.Count; i++)
                    {
                        Post postObj = (Post)presentPostComboBox.Items[i];
                        if (postObj.PostName == "N/A")
                        {
                            presentPostComboBox.SelectedIndex = i;
                            break;
                        }
                        presentPostComboBox.DisplayMemberPath = "PostName";
                    }
                }
                
            }

            else
            {
                try
                {
                    Thana thana = presentThanaComboBox.SelectedItem as Thana;
                    _postList = postManagerObj.LoadAllPost(thana.Id);

                    foreach (Post post in _postList)
                    {
                        presentPostComboBox.ItemsSource = _postList;
                    }
                    presentPostComboBox.DisplayMemberPath = "PostName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
        }

        private void LoadPresentThanaComboBox(int p)
        {

            if (p == -1)
            {
                _thanaList = thanaManagerObj.LoadAllThana(p);
                foreach (Thana thana in _thanaList)
                {
                    presentThanaComboBox.ItemsSource = _thanaList;
                    for (int i = 0; i < presentThanaComboBox.Items.Count; i++)
                    {
                        Thana thanaObj = (Thana)presentThanaComboBox.Items[i];
                        if (thanaObj.ThanaName == "N/A")
                        {
                            presentThanaComboBox.SelectedIndex = i;
                            break;
                        }
                        presentThanaComboBox.DisplayMemberPath = "ThanaName";
                    }
                }
               
            }

            else
            {
                try
                {
                    District district = presentDistrictComboBox.SelectedItem as District;
                    _thanaList = thanaManagerObj.LoadAllThana(district.Id);

                    foreach (Thana thana in _thanaList)
                    {
                        presentThanaComboBox.ItemsSource = _thanaList;
                    }
                    presentThanaComboBox.DisplayMemberPath = "ThanaName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
        }

        private void LoadPermanentPostComboBox(int p)
        {

            if (p == -1)
            {
                _postList = postManagerObj.LoadAllPost(p);
                foreach (Post post in _postList)
                {
                    permanentPostComboBox.ItemsSource = _postList;
                    for (int i = 0; i < permanentPostComboBox.Items.Count; i++)
                    {
                        Post permanentPostObj = (Post)permanentPostComboBox.Items[i];
                        if (permanentPostObj.PostName == "N/A")
                        {
                            permanentPostComboBox.SelectedIndex = i;
                            break;
                        }
                        permanentPostComboBox.DisplayMemberPath = "PostName";
                    }
                }
                
            }

            else
            {
                try
                {
                    Thana thana = permanentThanaComboBox.SelectedItem as Thana;
                    _postList = postManagerObj.LoadAllPost(thana.Id);

                    foreach (Post post in _postList)
                    {
                        permanentPostComboBox.ItemsSource = _postList;
                    }
                    permanentPostComboBox.DisplayMemberPath = "PostName";

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }
        }

        private void LoadPermanentThanaComboBox(int p)
        {

            if (p == -1)
            {
                _thanaList = thanaManagerObj.LoadAllThana(p);
                foreach (Thana thana in _thanaList)
                {
                    permanentThanaComboBox.ItemsSource = _thanaList;

                    for (int i = 0; i < permanentThanaComboBox.Items.Count; i++)
                    {
                        Thana permanentThanaObj = (Thana)permanentThanaComboBox.Items[i];
                        if (permanentThanaObj.ThanaName == "N/A")
                        {
                            permanentThanaComboBox.SelectedIndex = i;
                            break;
                        }
                        permanentThanaComboBox.DisplayMemberPath = "ThanaName";
                    }

                }
                
            }

            else
            {
                try
                {
                    District district = permanentDistrictComboBox.SelectedItem as District;
                    _thanaList = thanaManagerObj.LoadAllThana(district.Id);

                    foreach (Thana thana in _thanaList)
                    {
                        permanentThanaComboBox.ItemsSource = _thanaList;

                       
                    }

                    permanentThanaComboBox.DisplayMemberPath = "ThanaName";
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }

            }

        }

        /// <summary>
        /// ////////////Present Address
        /// </summary>




        private void LoadPresentDistrictComboBox()
        {
            _districtList = new List<District>();
            presentDistrictComboBox.Items.Clear();
            _districtList = districtManagerobj.GetAllDistrict();
            foreach (District district in _districtList)
            {
                presentDistrictComboBox.ItemsSource = _districtList;
                for (int i = 0; i <presentDistrictComboBox.Items.Count; i++)
                {
                    District presentDistrictObj = (District)presentDistrictComboBox.Items[i];
                    if (presentDistrictObj.DistrictName == "N/A")
                    {
                        presentDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                    presentDistrictComboBox.DisplayMemberPath = "DistrictName";
                }
            }
            
        }


        private void LoadPermanentDistrictComboBox()
        {
            _districtList = new List<District>();
            permanentDistrictComboBox.Items.Clear();
            _districtList = districtManagerobj.GetAllDistrict();
            foreach (District district in _districtList)
            {
                permanentDistrictComboBox.ItemsSource = _districtList;
                for (int i = 0; i < permanentDistrictComboBox.Items.Count; i++)
                {
                    District permanentDistrictObj = (District)permanentDistrictComboBox.Items[i];
                    if (permanentDistrictObj.DistrictName == "N/A")
                    {
                        permanentDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                    permanentDistrictComboBox.DisplayMemberPath = "DistrictName";
                }
            }
            
        }



        /// <summary>
        /// ////////////Gurdian Address
        /// </summary>

        //private void LoadBanglaGuardianThanaComboBox()
        //{
        //    _thanaList = new List<Thana>();
        //    banglaGuardianThanaComboBox.Items.Clear();
        //    _thanaList = thanaManagerObj.GetAllThana();
        //    foreach (Thana thana in _thanaList)
        //    {
        //        banglaGuardianThanaComboBox.ItemsSource = _thanaList;
        //    }
        //}

        private void LoadGuardianPostComboBox()
        {
            _postList = new List<Post>();
            guardianPostComboBox.Items.Clear();
            _postList = postManagerObj.GetAllPost();
            foreach (Post post in _postList)
            {
                guardianPostComboBox.ItemsSource = _postList;
            }
        }


        //private void LoadBanglaGuardianPostComboBox()
        //{
        //    _postList = new List<Post>();
        //    banglaGuardianPostComboBox.Items.Clear();
        //    _postList = postManagerObj.GetAllPost();
        //    foreach (Post post in _postList)
        //    {
        //        banglaGuardianPostComboBox.ItemsSource = _postList;
        //    }
        //}

        private void LoadGuardianDistrictComboBox()
        {
            _districtList = new List<District>();
            guardianDistrictComboBox.Items.Clear();
            _districtList = districtManagerobj.GetAllDistrict();
            foreach (District district in _districtList)
            {
                guardianDistrictComboBox.ItemsSource = _districtList;
                for (int i = 0; i < guardianDistrictComboBox.Items.Count; i++)
                {
                    District presentDistrictObj = (District)guardianDistrictComboBox.Items[i];
                    if (presentDistrictObj.DistrictName == "N/A")
                    {
                        guardianDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                    guardianDistrictComboBox.DisplayMemberPath = "DistrictName";
                }
            }
            
        }

        //private void LoadBanglaGuardianDistrictComboBox()
        //{
        //    _districtList = new List<District>();
        //    banglaGuardianDistrictComboBox.Items.Clear();
        //    _districtList = districtManagerobj.GetAllDistrict();
        //    foreach (District district in _districtList)
        //    {
        //        banglaGuardianDistrictComboBox.ItemsSource = _districtList;
        //        for (int i = 0; i < banglaGuardianDistrictComboBox.Items.Count; i++)
        //        {
        //            District guardianDistrictObj = (District)banglaGuardianDistrictComboBox.Items[i];
        //            if (guardianDistrictObj.DistrictName == "N/A")
        //            {
        //                banglaGuardianDistrictComboBox.SelectedIndex = i;
        //                break;
        //            }
        //            banglaGuardianDistrictComboBox.DisplayMemberPath = "DistrictName";
        //        }
        //    }
        //    banglaGuardianDistrictComboBox.DisplayMemberPath = "BanglaDistrict";
        //}
        /// <summary>
        /// //////////////END address
        /// </summary>

        private void LoadCampusComboBox()
        {
            _campusList = new List<Campus>();
            _campusList = campusManagerObj.GetAllCampus();

            campusCombobox.Items.Clear();
            //banglaCampusCombobox.Items.Clear();

            
            foreach (Campus campus in _campusList)
            {
                campusCombobox.ItemsSource = _campusList;
                for (int i = 0; i < campusCombobox.Items.Count; i++)
                {
                    Campus campusobj = (Campus)campusCombobox.Items[i];
                    if (campusobj.CampusName == "N/A")
                    {
                        campusCombobox.SelectedIndex = i;
                        break;
                    }
                    campusCombobox.DisplayMemberPath = "CampusName";
                }
                //banglaCampusCombobox.ItemsSource = _campusList;
                //for (int i = 0; i < banglaCampusCombobox.Items.Count; i++)
                //{
                //    Campus banglaCampusobj = (Campus)banglaCampusCombobox.Items[i];
                //    if (banglaCampusobj.BanglaCampus == "N/A")
                //    {
                //        banglaCampusCombobox.SelectedIndex = i;
                //        break;
                //    }
                //    banglaCampusCombobox.DisplayMemberPath = "BanglaCampus";
                //}

            }
            
        }

        /// <summary>
        /// ///////Bangla campus
        /// </summary>

        //private void LoadBanglaCampusComboBox()
        //{
        //    _campusList = new List<Campus>();
        //    banglaCampusCombobox.Items.Clear();
        //    _campusList = campusManagerObj.GetAllCampus();
        //    foreach (Campus banglacampus in _campusList)
        //    {
        //        banglaCampusCombobox.ItemsSource = _campusList;
        //        for (int i = 0; i < banglaCampusCombobox.Items.Count; i++)
        //        {
        //            Campus banglaCampusobj = (Campus)banglaCampusCombobox.Items[i];
        //            if (banglaCampusobj.BanglaCampus == "N/A")
        //            {
        //                banglaCampusCombobox.SelectedIndex = i;
        //                break;
        //            }
        //            banglaCampusCombobox.DisplayMemberPath = "BanglaCampus";
        //        }
        //    }
        //}
        
        private void LoadBatchComboBox()
        {
            _batchList = new List<Batch>();
            _batchList = batchManagerObj.GetAllBatch();

            batchCombobox.Items.Clear();
            //banglaBatchCombobox.Items.Clear(); 

            foreach (Batch batch in _batchList)
            {
                batchCombobox.ItemsSource = _batchList;
                for (int i = 0; i < batchCombobox.Items.Count; i++)
                {
                    Batch batchObj= (Batch)batchCombobox.Items[i];
                    if(batchObj.BatchNo=="N/A")
                    {
                        batchCombobox.SelectedIndex = i;
                        break;
                    }
                    batchCombobox.DisplayMemberPath = "BatchNo";
                }
                //banglaBatchCombobox.ItemsSource = _batchList;
                //for (int i = 0; i < banglaBatchCombobox.Items.Count; i++)
                //{
                //    Batch banglaBatchObj = (Batch)banglaBatchCombobox.Items[i];
                //    if (banglaBatchObj.BatchNo == "N/A")
                //    {
                //        banglaBatchCombobox.SelectedIndex = i;
                //        break;
                //    }
                //    banglaBatchCombobox.DisplayMemberPath = "BanglaBatch";
                //}
            }
            
        }
        /// <summary>
        /// /////Bangla Batch
        /// </summary>
        //private void LoadBanglaBatchComboBox()
        //{
        //    _batchList = new List<Batch>();
        //    banglaBatchCombobox.Items.Clear();
        //    _batchList = batchManagerObj.GetAllBatch();
        //    foreach (Batch batch in _batchList)
        //    {
        //        banglaBatchCombobox.ItemsSource = _batchList;

        //        for (int i = 0; i < banglaBatchCombobox.Items.Count; i++)
        //        {
        //            Batch banglaBatchObj = (Batch)banglaBatchCombobox.Items[i];
        //            if (banglaBatchObj.BatchNo == "N/A")
        //            {
        //                banglaBatchCombobox.SelectedIndex = i;
        //                break;
        //            }
        //            banglaBatchCombobox.DisplayMemberPath = "BanglaBatch";
        //        }

        //    }
           
        //}
        private void LoadProgramComboBox()
        {
            _SIPIprogramList = new List<SIPI_Program>();
            programCombobox.Items.Clear();
            //banglaProgramCombobox.Items.Clear();
            _SIPIprogramList = sIPI_ProgramManagerObj.GetAllSIPI_Program();
            foreach (SIPI_Program program in _SIPIprogramList)
            {
                programCombobox.ItemsSource = _SIPIprogramList;
                //banglaProgramCombobox.ItemsSource = _SIPIprogramList;

            }
            programCombobox.DisplayMemberPath = "SIPI_ProgramName";
            programCombobox.SelectedIndex = 0;
            //banglaProgramCombobox.DisplayMemberPath = "BanglaSIPI_ProgramName";
            //banglaProgramCombobox.SelectedIndex = 0;
            
        }

        /// <summary>
        /// /////BanglaProgramComboBox
        /// </summary>
        //private void LoadBanglaProgramComboBox()
        //{
        //    _SIPIprogramList = new List<SIPI_Program>();
        //    //banglaProgramCombobox.Items.Clear();
        //    _SIPIprogramList = sIPI_ProgramManagerObj.GetAllSIPI_Program();
        //    foreach (SIPI_Program program in _SIPIprogramList)
        //    {
        //        banglaProgramCombobox.ItemsSource = _SIPIprogramList;
        //    }
        //    banglaProgramCombobox.DisplayMemberPath = "BanglaSIPI_ProgramName";
        //    banglaProgramCombobox.SelectedIndex = 0;
        //}
        /// <summary>
        /// ////SIPI_Department Technology
        /// </summary>

        private void LoadDepartmentComboBox()
        {
            _SIPIDepartmentList = new List<SIPI_Department>();
            _SIPIDepartmentList = sIPI_DepartmentManagerObj.GetAll_SIPIDepartment();
            departmentCombobox.Items.Clear();
            //banglaDepartmentCombobox.Items.Clear();
            foreach (SIPI_Department department in _SIPIDepartmentList)
            {
                departmentCombobox.ItemsSource = _SIPIDepartmentList;
                for (int i = 0; i < departmentCombobox.Items.Count; i++)
                {
                    SIPI_Department departmentobj = (SIPI_Department)departmentCombobox.Items[i];
                    if (departmentobj.SIPI_DepartmentName == "N/A")
                    {
                        departmentCombobox.SelectedIndex = i;
                        break;
                    }

                }

                //banglaDepartmentCombobox.ItemsSource = _SIPIDepartmentList;
                //for (int i = 0; i < banglaDepartmentCombobox.Items.Count; i++)
                //{
                //    SIPI_Department departmentobj = (SIPI_Department)banglaDepartmentCombobox.Items[i];
                //    if (departmentobj.SIPI_DepartmentName == "N/A")
                //    {
                //        banglaDepartmentCombobox.SelectedIndex = i;
                //        break;
                //    }
                //    //banglaDepartmentCombobox.DisplayMemberPath = department.BanglaSIPI_DepartmentName;
                //}
            }

        }
        /// <summary>
        /// ////////Bangla Department
        /// </summary>
        //private void LoadBanglaDepartmentComboBox()
        //{
        //    _SIPIDepartmentList = new List<SIPI_Department>();
        //    banglaDepartmentCombobox.Items.Clear();
        //    _SIPIDepartmentList = sIPI_DepartmentManagerObj.GetAll_SIPIDepartment();
        //    foreach (SIPI_Department department in _SIPIDepartmentList)
        //    {
        //        banglaDepartmentCombobox.ItemsSource = _SIPIDepartmentList;
        //        for (int i = 0; i < banglaDepartmentCombobox.Items.Count; i++)
        //        {
        //            SIPI_Department departmentobj = (SIPI_Department)banglaDepartmentCombobox.Items[i];
        //            if (departmentobj.SIPI_DepartmentName == "N/A")
        //            {
        //                banglaDepartmentCombobox.SelectedIndex = i;
        //                break;
        //            }
        //            banglaDepartmentCombobox.DisplayMemberPath = "BanglaSIPI_DepartmentName";
        //        }

        //    }
            

        //}

        /// <summary>
        /// Blood Group Combobox
        /// </summary>
        private void LoadBloodGroupComboBox()
        {
            _bloodgroupList = new List<BloodGroup>();
            bloodGroupComboBox.Items.Clear();
            _bloodgroupList = bloodGroupObj.GetAllBloodGroup();
            foreach (BloodGroup bloodgroup in _bloodgroupList)
            {
                bloodGroupComboBox.ItemsSource = _bloodgroupList;
                for (int i = 0; i < bloodGroupComboBox.Items.Count; i++)
                {
                    BloodGroup bloodGroupobj = (BloodGroup)bloodGroupComboBox.Items[i];
                    if (bloodGroupobj.BloodGroupName == "N/A")
                    {
                        bloodGroupComboBox.SelectedIndex = i;
                        break;
                    }
                    bloodGroupComboBox.DisplayMemberPath = "BloodGroupName";
                }

            }
        }

        /// <summary>
        /// Religion Combobox
        /// </summary>
        private void LoadReligionComboBox()
        {
            _rligionList = new List<Religion>();
            religionCombobox.Items.Clear();
            _rligionList = religionManager.GetAllReligion();
            foreach (Religion religion in _rligionList)
            {
                religionCombobox.ItemsSource = _rligionList;
                religionCombobox.SelectedIndex = 0;
            }
            religionCombobox.DisplayMemberPath = "ReligionName";
        }
        /// <summary>
        /// Bangla Religion Combobox
        /// </summary>
        //private void LoadBanglaReligionComboBox()
        //{
        //    _rligionList = new List<Religion>();
        //    banglaReligionCombobox.Items.Clear();
        //    _rligionList = religionManager.GetAllReligion();
        //    foreach (Religion religion in _rligionList)
        //    {
        //        banglaReligionCombobox.ItemsSource = _rligionList;
        //        banglaReligionCombobox.SelectedIndex = 0;

        //    }
        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            



        }

        /// <summary>
        /// //clear event
        /// </summary>
        /// 

        private void ClearAllStudentInfo()
        {

            ClearProgramInfo();
            ClearPersonalInfo();
            ClearFamilyNameInfo();
            ClearFamilyAddressInfo();
            ClearImiditeGuardianInfo();
            ClearImiditeGuardianInfo();
            ClearAccadamicInfo();

        }
        private void ClearProgramInfo()
        {
            programCombobox.Text = "";
            sessionTextBox.Text = "";
            campusCombobox.Text = "";
            departmentCombobox.Text = "";
            accademicYearTextBox.Text = "";
            batchCombobox.Text = "";
        
        }
        private void ClearPersonalInfo()
        {
            applicantNameTextBox.Text = "";
            applicantmobileNumberTextBox.Text = "";
            emailTextBox.Text = "";
            maleRadioButton.IsChecked = false;
            femaleRadioButton.IsChecked = false;
            dateOfBirth.SelectedDate = DateTime.Now;
            nationalityTextBox.Text = "";
            bloodGroupComboBox.Text = "";
            religionCombobox.Text = "";
            interestTextBox.Text = "";
            othersInformationTextBox.Text = "";
            //imgMemberPhoto.;
            banglaApplicantNameTextBox.Text = "";
          
            banglaInterestTextBox.Text = "";
            banglaOthersInformationTextBox.Text = "";
        }
        private void ClearFamilyNameInfo()
        {
            fathersNameTextBox.Text = "";
            mothersNameTextBox.Text = "";
            freedomFighterYesRadioButton.IsChecked = false;
            freedomFighterNoRadioButton.IsChecked = false;
            tribalYesRadioButton.IsChecked = false;
            tribalNoRadioButton.IsChecked = false;
            fathersMobileNotextBox.Text = "";
            mothersMobileNoTextBox.Text = "";
            telephoneNoTestBox.Text = "";

            banglaFathersNameTextBox.Text = "";
            banglaMothersNameTextBox.Text = "";
            //banglaFreedomFighterYesRadioButton.IsChecked = false;
            //banglaFreedomFighterNoRadioButton.IsChecked = false;
            //banglaTribalYesRadioButton.IsChecked = false;
            //banglaTribalNoRadioButton.IsChecked = false;


        }
        private void ClearFamilyAddressInfo()
        {
            permanentHouserNoTextBox.Text = "";
            permanentRoadNoTextBox.Text = "";
            permanentBlockTextBox.Text = "";
            permanentSectorTextBox.Text = "";
            permanentPostComboBox.Text = "";
            permanentThanaComboBox.Text = "";
            permanentDistrictComboBox.Text = "";

            banglaPermanentHouserNoTextBox.Text = "";
            banglaPermanentRoadNoTextBox.Text = "";
            banglaPermanentBlockTextBox.Text = "";
            banglaPermanentSectorTextBox.Text = "";

            presentHouserNoTextBox.Text = "";
            presentRoadNoTextBox.Text = "";
            presentBlockTextBox.Text = "";
            presentSectorTextBox.Text = "";
            presentPostComboBox.Text = "";
            presentThanaComboBox.Text = "";
            presentDistrictComboBox.Text = "";

            banglapresentHouserNoTextBox.Text = "";
            banglaPresentRoadNoTextBox.Text = "";
            banglaPresentBlockTextBox.Text = "";
            banglaPresentSectorTextBox.Text = "";
        }

        private void ClearImiditeGuardianInfo()
        {
            guardianNameTextbox.Text = "";
            guardianMobileNoTextbox.Text = "";
            guardianEmailTextBox.Text = "";

            guardianHouserNoTextBox.Text = "";
            guardianRoadNoTextBox.Text = "";
            guardianBlockTextBox.Text = "";
            guardianSectorTextBox.Text = "";
            guardianPostComboBox.Text = "";
            guardianThanaComboBox.Text = "";
            guardianDistrictComboBox.Text = "";

            banglaGuardianNameTextbox.Text = "";
            banglaGuardianHouserNoTextBox.Text = "";
            banglaGuardianRoadNoTextBox.Text = "";
            banglaGuardianBlockTextBox.Text = "";
            banglaGuardianSectorTextBox.Text = "";
            ////banglaGuardianPostComboBox.Text = "";
            //banglaGuardianThanaComboBox.Text = "";
            //banglaGuardianDistrictComboBox.Text = "";
        }
        private void ClearAccadamicInfo()
        {
            examNameCombobox.Text = "";
            groupNameCombobox.Text = "";
            boardCombobox.Text = "";
            schoolNameTextbox.Text = "";
            rollNoTextbox.Text = "";
            registrationNoTextbox.Text = "";
            passingYearTextbox.Text = "";
            gpaTextbox.Text = "";

        }



        private void LoadAllStudentInfo()
        {
            studentInfoList = new List<StudentInfo>();
            studentInfoList = studentInfoManager.GetAllStudentInfo();
            studentInofListView.Items.Clear();
            if (studentInfoList.Count > 0)
            {
                foreach (var item in studentInfoList)
                {
                    studentInofListView.Items.Add(item);
                }

            }
        }

        private void EditCampusContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            if (studentInofListView.SelectedIndex > 0)
            {
                _studentInfo = new StudentInfo();
                _studentInfo = ((StudentInfo)studentInofListView.SelectedItem);

                try
                {
                    MemberPhoto = (byte[])_studentInfo.Student_Photo;
                    if (MemberPhoto.Length > 0)
                    {
                        string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                        FileStream fs1 = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                        fs1.Write(MemberPhoto, 0, MemberPhoto.Length);
                        fs1.Flush();
                        fs1.Close();
                        ImageSourceConverter imgs = new ImageSourceConverter();
                        imgMemberPhoto.SetValue(Image.SourceProperty, imgs.ConvertFromString(strfn));
                    }

                    SignaturePhoto = (byte[])_studentInfo.Student_Signature;
                    if (SignaturePhoto.Length > 0)
                    {
                        string strfn2 = Convert.ToString(DateTime.Now.ToFileTime());
                        FileStream fs2 = new FileStream(strfn2, FileMode.CreateNew, FileAccess.Write);
                        fs2.Write(SignaturePhoto, 0, SignaturePhoto.Length);
                        fs2.Flush();
                        fs2.Close();
                        ImageSourceConverter img2 = new ImageSourceConverter();
                        imgMemberSignature.SetValue(Image.SourceProperty, img2.ConvertFromString(strfn2));
                    }

                }
                catch
                {
                    MessageBox.Show("Image cant't Load");
                }

                ////FOR PROGRAM COMBOBOX
                for (int i = 0; i < programCombobox.Items.Count; i++)
                {
                    SIPI_Program prog = (SIPI_Program)programCombobox.Items[i];
                    if (_studentInfo.ProgramId == prog.Id)
                    {
                        programCombobox.SelectedIndex = i;
                        break;
                    }

                }
              
                sessionTextBox.Text = _studentInfo.Session;
                /////FOR CAMPUS COMBOBOX

                for (int i = 0; i < campusCombobox.Items.Count; i++)
                {
                    Campus camp = (Campus)campusCombobox.Items[i];
                    if (_studentInfo.CampusId == camp.Id)
                    {
                        campusCombobox.SelectedIndex = i;
                        break;

                    }

                }

            

                /////FOR DEARTMENT COMBOBOX

                for (int i = 0; i < departmentCombobox.Items.Count; i++)
                {
                    SIPI_Department department = (SIPI_Department)departmentCombobox.Items[i];
                    if (_studentInfo.DepartmentId == department.Id)
                    {
                        departmentCombobox.SelectedIndex = i;
                        break;

                    }
                }


                accademicYearTextBox.Text = _studentInfo.AccadamicYear;
                //banglaAccademicYearTextBox = _studentInfo.BanglaAccadamicYear;

                ///// FOR Batch COMBOBOX

                for (int i = 0; i < batchCombobox.Items.Count; i++)
                {
                    Batch batch = (Batch)batchCombobox.Items[i];
                    if (_studentInfo.BatchId == batch.Id)
                    {
                        batchCombobox.SelectedIndex = i;
                        break;

                    }

                }
              


                applicantNameTextBox.Text = _studentInfo.ApplicantName;
                applicantmobileNumberTextBox.Text = _studentInfo.MobileNo;
                emailTextBox.Text = _studentInfo.Email;

                //Gender

                if (_studentInfo.Gender == "Male")
                {
                    maleRadioButton.IsChecked = true;

                }
                if (_studentInfo.Gender == "Female")
                {
                    femaleRadioButton.IsChecked = true;

                }

               
                //dateOfBirth.Text = DateTime.Parse(_studentInfo.DateOfBirth);
                nationalityTextBox.Text = _studentInfo.Nationality;
                /////FOR BLOODGROUP CMB
                for (int i = 0; i < bloodGroupComboBox.Items.Count; i++)
                {
                    BloodGroup bloodGroup = (BloodGroup)bloodGroupComboBox.Items[i];
                    if (_studentInfo.BloodGroupId == bloodGroup.Id)
                    {
                        bloodGroupComboBox.SelectedIndex = i;
                        break;

                    }

                }
                /////FOR RELIGION CMB
                for (int i = 0; i < religionCombobox.Items.Count; i++)
                {
                    Religion religion = (Religion)religionCombobox.Items[i];
                    if (_studentInfo.ReligionId == religion.Id)
                    {
                        religionCombobox.SelectedIndex = i;
                        break;

                    }

                }
             

                interestTextBox.Text = _studentInfo.Interest;
                othersInformationTextBox.Text = _studentInfo.OthersInfo;
                banglaApplicantNameTextBox.Text = _studentInfo.BanglaApplicantName;
                ///bangla gender
                ///bangla date of birth

                banglaInterestTextBox.Text = _studentInfo.BanglaInterest;
                banglaOthersInformationTextBox.Text = _studentInfo.BanglaOthersInfo;

                ///////////////Family and info Tab
                fathersNameTextBox.Text = _studentInfo.FatherName;
                mothersNameTextBox.Text = _studentInfo.MotherName;
                //freedomFighterNoRadioButton
                if (_studentInfo.FreedomFighter == true)
                {

                    freedomFighterYesRadioButton.IsChecked = true;

                }
                if (_studentInfo.FreedomFighter == false)
                {
                    freedomFighterNoRadioButton.IsChecked = true;
                }
                //tribalNoRadioButton
                if (_studentInfo.Tribal == true)
                {

                    tribalYesRadioButton.IsChecked = true;

                }
                if (_studentInfo.Tribal == false)
                {
                    tribalNoRadioButton.IsChecked = true;
                }
                fathersMobileNotextBox.Text = _studentInfo.FathersMobileNo;
                mothersMobileNoTextBox.Text = _studentInfo.MothersMobileNo;
                telephoneNoTestBox.Text = _studentInfo.TelephoneNo;

                banglaFathersNameTextBox.Text = _studentInfo.BanglaFatherName;
                banglaMothersNameTextBox.Text = _studentInfo.BanglaMotherName;
                ////bangla freedomFighterNoRadioButton
                //if (_studentInfo.BanglaFreedomFighter == true)
                //{

                //    banglaFreedomFighterYesRadioButton.IsChecked = true;

                //}
                //if (_studentInfo.BanglaFreedomFighter == false)
                //{
                //    banglaFreedomFighterNoRadioButton.IsChecked = true;

                //}
                //bangla tribalNoRadioButton
                //if (_studentInfo.BanglaTribal == true)
                //{

                //    banglaTribalYesRadioButton.IsChecked = true;

                //}
                //if (_studentInfo.BanglaTribal == false)
                //{
                //    banglaTribalNoRadioButton.IsChecked = true;
                //}

                ///////////////////////address
                //(int)_studentInfo.PostId;
                //(int)_studentInfo.ThanaId;
                //(int)_studentInfo.DistrictId;
                permanentHouserNoTextBox.Text = _studentInfo.PermanentHouserNo;
                permanentRoadNoTextBox.Text = _studentInfo.PermanentRoadNo;
                permanentBlockTextBox.Text = _studentInfo.PermanentBlock;
                permanentSectorTextBox.Text = _studentInfo.PermanentSector;
                //// FOR ADDRESS POST
                for (int i = 0; i < permanentPostComboBox.Items.Count; i++)
                {
                    Post post = (Post)permanentPostComboBox.Items[i];
                    if (_studentInfo.PermanentPost == post.Id)
                    {
                        permanentPostComboBox.SelectedIndex = i;
                        break;
                    }
                }
                //// FOR ADDRESS THANA
                for (int i = 0; i < permanentThanaComboBox.Items.Count; i++)
                {
                    Thana thana = (Thana)permanentThanaComboBox.Items[i];
                    if (_studentInfo.PermanentThana == thana.Id)
                    {
                        permanentThanaComboBox.SelectedIndex = i;
                        break;
                    }
                }
                //// FOR ADDRESS DISTRICT
                for (int i = 0; i < permanentDistrictComboBox.Items.Count; i++)
                {
                    District didtrict = (District)permanentDistrictComboBox.Items[i];
                    if (_studentInfo.PermanentDistrict == didtrict.Id)
                    {
                        permanentDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                }





                //////Bangla Permanent
                banglaPermanentHouserNoTextBox.Text = _studentInfo.BanglaPermanentHouserNo;
                banglaPermanentRoadNoTextBox.Text = _studentInfo.BanglaPermanentRoadNo;
                banglaPermanentBlockTextBox.Text = _studentInfo.BanglaPermanentBlock;
                banglaPermanentSectorTextBox.Text = _studentInfo.BanglaPermanentSector;
                //banglaPermanentPostComboBox.SelectedIndex = (int)_studentInfo.PostId;
                //banglaPermanentThanaComboBox.SelectedIndex = (int)_studentInfo.ThanaId;
                //banglaPermanentDistrictComboBox.SelectedIndex = (int)_studentInfo.DistrictId;

                ///present
                presentHouserNoTextBox.Text = _studentInfo.PresentHouserNo;
                presentRoadNoTextBox.Text = _studentInfo.PresentRoadNo;
                presentBlockTextBox.Text = _studentInfo.PresentBlock;
                presentSectorTextBox.Text = _studentInfo.PresentSector;
                //// FOR ADDRESS POST
                for (int i = 0; i < presentPostComboBox.Items.Count; i++)
                {
                    Post post = (Post)presentPostComboBox.Items[i];
                    if (_studentInfo.PresentPost == post.Id)
                    {
                        presentPostComboBox.SelectedIndex = i;
                        break;
                    }
                }
                //// FOR ADDRESS THANA
                for (int i = 0; i < presentThanaComboBox.Items.Count; i++)
                {
                    Thana thana = (Thana)presentThanaComboBox.Items[i];
                    if (_studentInfo.PresentThana == thana.Id)
                    {
                        presentThanaComboBox.SelectedIndex = i;
                        break;
                    }
                }
                //// FOR ADDRESS DISTRICT
                for (int i = 0; i < presentDistrictComboBox.Items.Count; i++)
                {
                    District district = (District)presentDistrictComboBox.Items[i];
                    if (_studentInfo.PresentDistrict == district.Id)
                    {
                        presentDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                }


                //////Bangla Permanent
                banglapresentHouserNoTextBox.Text = _studentInfo.BanglaPresentHouserNo;
                banglaPresentRoadNoTextBox.Text = _studentInfo.BanglaPresentRoadNo;
                banglaPresentBlockTextBox.Text = _studentInfo.BanglaPresentBlock;
                banglaPresentSectorTextBox.Text = _studentInfo.BanglaPresentSector;
                //banglaPresentPostComboBox.SelectedIndex = (int)_studentInfo.PostId;
                //banglaPresentThanaComboBox.SelectedIndex = (int)_studentInfo.ThanaId;
                //banglaPresentDistrictComboBox.SelectedIndex = (int)_studentInfo.DistrictId;

                guardianNameTextbox.Text = _studentInfo.GuardianName;
                guardianMobileNoTextbox.Text = _studentInfo.GuardianMobileNo;
                guardianEmailTextBox.Text = _studentInfo.GuardianEmail;
                banglaGuardianNameTextbox.Text = _studentInfo.BanglaGuardianName;
                ///////////////////
                /////address
                ///////////////////
                guardianHouserNoTextBox.Text = _studentInfo.GuardianHouserNo;
                guardianRoadNoTextBox.Text = _studentInfo.GuardianRoadNo;
                guardianBlockTextBox.Text = _studentInfo.GuardianBlock;
                guardianSectorTextBox.Text = _studentInfo.GuardianSector;
                //guardianPostComboBox.SelectedIndex = (int)_studentInfo.PostId;
                //guardianThanaComboBox.SelectedIndex = (int)_studentInfo.ThanaId;
                //guardianDistrictComboBox.SelectedIndex = (int)_studentInfo.DistrictId;
                //// FOR ADDRESS POST
                for (int i = 0; i < guardianPostComboBox.Items.Count; i++)
                {
                    Post post = (Post)guardianPostComboBox.Items[i];
                    if (_studentInfo.GuardianPost == post.Id)
                    {
                        guardianPostComboBox.SelectedIndex = i;
                        break;
                    }
                }
                //// FOR ADDRESS THANA
                for (int i = 0; i < guardianThanaComboBox.Items.Count; i++)
                {
                    Thana thana = (Thana)guardianThanaComboBox.Items[i];
                    if (_studentInfo.GuardianThana == thana.Id)
                    {
                        guardianThanaComboBox.SelectedIndex = i;
                        break;
                    }
                }
                //// FOR ADDRESS DISTRICT
                for (int i = 0; i < guardianDistrictComboBox.Items.Count; i++)
                {
                    District district = (District)guardianDistrictComboBox.Items[i];
                    if (_studentInfo.GuardianDistrict == district.Id)
                    {
                        guardianDistrictComboBox.SelectedIndex = i;
                        break;
                    }
                }

                //////Bangla Permanent
                banglaGuardianHouserNoTextBox.Text = _studentInfo.BanglaGuardianHouserNo;
                banglaGuardianRoadNoTextBox.Text = _studentInfo.BanglaGuardianRoadNo;
                banglaGuardianBlockTextBox.Text = _studentInfo.BanglaGuardianBlock;
                banglaGuardianSectorTextBox.Text = _studentInfo.BanglaGuardianSector;
                //// FOR ADDRESS POST
                //for (int i = 0; i < banglaGuardianPostComboBox.Items.Count; i++)
                //{
                //    Post post = (Post)banglaGuardianPostComboBox.Items[i];
                //    if (_studentInfo.GuardianPost == post.Id)
                //    {
                //        banglaGuardianPostComboBox.SelectedIndex = i;
                //        break;
                //    }
                //}
                //// FOR ADDRESS THANA
                //for (int i = 0; i < banglaGuardianThanaComboBox.Items.Count; i++)
                //{
                //    Thana thana = (Thana)banglaGuardianThanaComboBox.Items[i];
                //    if (_studentInfo.GuardianThana == thana.Id)
                //    {
                //        banglaGuardianThanaComboBox.SelectedIndex = i;
                //        break;
                //    }
                //}
                ////// FOR ADDRESS DISTRICT
                //for (int i = 0; i < banglaGuardianDistrictComboBox.Items.Count; i++)
                //{
                //    District district = (District)banglaGuardianDistrictComboBox.Items[i];
                //    if (_studentInfo.GuardianDistrict == district.Id)
                //    {
                //        banglaGuardianDistrictComboBox.SelectedIndex = i;
                //        break;
                //    }
                //}


                //////Accadamic Info

                examNameCombobox.Text = _studentInfo.AccadamicInfo_ExamNme;
                groupNameCombobox.Text = _studentInfo.AccadamicInfo_Group;
                boardCombobox.Text = _studentInfo.AccadamicInfo_Board;
                schoolNameTextbox.Text = _studentInfo.AccadamicInfo_SchoolName;
                rollNoTextbox.Text = _studentInfo.AccadamicInfo_RollNo.ToString();
                registrationNoTextbox.Text = _studentInfo.AccadamicInfo_RegistrationNo.ToString();
                passingYearTextbox.Text = _studentInfo.AccadamicInfo_PassingYear.ToString();
                gpaTextbox.Text = _studentInfo.AccadamicInfo_GPA;


                finishButton.Content = "Update";
                clearAccadamicButton.IsEnabled = false;

                mainTab.SelectedIndex = 0;
            }
           
        }

        private void RemoveCampusContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                _studentInfo = new StudentInfo();
                _studentInfo = ((StudentInfo)studentInofListView.SelectedItem);
                studentInfoManager.DeletesStudentInfo(_studentInfo);
                LoadAllStudentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void studentPhoto_Click_1(object sender, RoutedEventArgs e)
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
                    //if (MemberPhoto.Length < 800 * 1024)
                    //{
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

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Filesize of image is too large. Maximum file size permitted is 800KB", "Member/Customer Setup",           MessageBoxButton.OK, MessageBoxImage.Error);
                    //    MemberPhoto = new byte[0];
                    //}
                }
            }
            catch (Exception ex)
            {
                MemberPhoto = new byte[0];
                MessageBox.Show("Error while uploading Image File.\n" + ex.Message, "Member/Customer Setup", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void chooseStudentSignature_Click_1(object sender, RoutedEventArgs e)
        {
            // imgMemberSignature

            try
            {
                OpenFileDialog dlg;
                FileStream fs;
                dlg = new OpenFileDialog();
                dlg.ShowDialog();

                if (dlg.FileName != "")
                {
                    fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                    SignaturePhoto = new byte[fs.Length].ToArray();
                    //if (MemberPhoto.Length < 800 * 1024)
                    //{
                    fs.Read(SignaturePhoto, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    byte[] barrImg = (byte[])SignaturePhoto;
                    string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                    FileStream fs1 = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                    fs1.Write(barrImg, 0, barrImg.Length);
                    fs1.Flush();
                    fs1.Close();
                    ImageSourceConverter imgs = new ImageSourceConverter();
                    imgMemberSignature.SetValue(Image.SourceProperty, imgs.ConvertFromString(strfn));

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Filesize of image is too large. Maximum file size permitted is 800KB", "Member/Customer Setup",           MessageBoxButton.OK, MessageBoxImage.Error);
                    //    MemberPhoto = new byte[0];
                    //}
                }
            }
            catch (Exception ex)
            {
                SignaturePhoto = new byte[0];
                MessageBox.Show("Error while uploading Image File.\n" + ex.Message, "Member/Customer Setup", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void nextButton(object sender, RoutedEventArgs e)
        {
            mainTab.SelectedIndex++;
        }

        private void previousButton(object sender, RoutedEventArgs e)
        {
            mainTab.SelectedIndex--;

        }

        //private void NextFamiltInfoButton(object sender, RoutedEventArgs e)
        //{
        //    familyContactInfoTab.SelectedIndex++;
        //}

        //private void previousFamilyInfoTab(object sender, RoutedEventArgs e)
        //{
        //    familyContactInfoTab.SelectedIndex--;
        //}

        private void ClearButtonAccadamic(object sender, RoutedEventArgs e)
        {
            ClearAccadamicInfo();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

            if (nameTextBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string name = nameTextBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByName(name);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {

                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }
            else
            {
                LoadAllStudentInfo();
            }

            if (mobileNoTestBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string Mobile = mobileNoTestBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByMobile(Mobile);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }

            if (campusTextBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string Campus = campusTextBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByCampus(Campus);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }

            if (studentIdTextBox.Text != "")
            {
                studentInfoList = new List<StudentInfo>();
                string StudentId = studentIdTextBox.Text.Trim();
                studentInfoList = studentInfoManager.GetAllStudentInfoByStudentID(StudentId);
                studentInofListView.Items.Clear();
                if (studentInfoList.Count > 0)
                {
                    studentInofListView.Items.Clear();
                    foreach (var item in studentInfoList)
                    {
                        studentInofListView.Items.Add(item);
                    }

                }
            }


        }

        private void permanentDistrictComboBox_DropDownClosed(object sender, EventArgs e)
        {
            LoadPermanentThanaComboBox(0);
        }


        private void permanentThanaComboBox_DropDownClosed(object sender, EventArgs e)
        {
            LoadPermanentPostComboBox(0);
        }

        private void presentDistrictComboBox_DropDownClosed(object sender, EventArgs e)
        {
            LoadPresentThanaComboBox(0);
        }

        private void presentThanaComboBox_DropDownClosed(object sender, EventArgs e)
        {
            LoadPresentPostComboBox(0);
        }

        private void guardianDistrictComboBox_DropDownClosed(object sender, EventArgs e)
        {
            LoadGuardianThanaComboBox(0);
        }

        private void guardianThanaComboBox_DropDownClosed(object sender, EventArgs e)
        {
            LoadGuardianPostComboBox(0);
        }

        //private void banglaGuardianDistrictComboBox_DropDownClosed(object sender, EventArgs e)
        //{
        //    LoadBanglaGuardianThanaComboBox(0);
        //}

        //private void banglaGuardianThanaComboBox_DropDownClosed(object sender, EventArgs e)
        //{
        //    LoadBanglaGuardianPostComboBox(0);
        //}


        private void ViewStudent(string className)
        {
            bool isOpen = false;
            Window objWindowName = new Window();
            foreach (Window objWindow in Application.Current.Windows)
            {
                string[] splitedNamespace = (objWindow.ToString()).Split('.');
                string aClassNameFromCollection = splitedNamespace[splitedNamespace.Length - 1];

                if (aClassNameFromCollection == className)
                {
                    isOpen = true;
                    objWindowName = objWindow;
                    break;
                }

            }

            if (isOpen == false)
            {
                #region SHOW DESIRED WINDOW
                switch (className)
                {
                    case "StudentInfoViewUI":
                        StudentInfoViewUI studentInfo = new StudentInfoViewUI();

                        _studentInfo = new StudentInfo();
                        _studentInfo = ((StudentInfo)studentInofListView.SelectedItem);
                        studentInfo.apiilicantNameLable.Content = _studentInfo.ApplicantName;
                        studentInfo.fatherNameLable.Content = _studentInfo.FatherName;
                        studentInfo.motherNameLable.Content = _studentInfo.MotherName;
                        studentInfo.dateofBirthLable.Content = _studentInfo.DateOfBirth;
                        studentInfo.mobileLable.Content = _studentInfo.MobileNo;
                        studentInfo.fatherMobileNoLable.Content = _studentInfo.MothersMobileNo;
                        studentInfo.presentAddressLable.Content = _studentInfo.PresentDistrict;

                        studentInfo.programeNameLable.Content = _studentInfo.ProgramName;
                        studentInfo.departmentNameLable.Content = _studentInfo.DepartmentName;
                        studentInfo.EmailLable.Content = _studentInfo.Email;
                        studentInfo.guardianNameLable.Content = _studentInfo.GuardianName;
                        studentInfo.guardianNumberLable.Content = _studentInfo.GuardianMobileNo;
                        studentInfo.bloodGroupLable.Content = _studentInfo.BloodGroupId;
                        studentInfo.campusNameLable.Content = _studentInfo.CampusName;

                        //////////////////Image///////////
                        try
                        {
                            MemberPhoto = (byte[])_studentInfo.Student_Photo;
                            if (MemberPhoto.Length > 0)
                            {
                                string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                                FileStream fs1 = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                                fs1.Write(MemberPhoto, 0, MemberPhoto.Length);
                                fs1.Flush();
                                fs1.Close();
                                ImageSourceConverter imgs = new ImageSourceConverter();
                                studentInfo.Photo.SetValue(Image.SourceProperty, imgs.ConvertFromString(strfn));
                            }


                        }
                        catch
                        {
                            MessageBox.Show("No Image Hare");
                        }
                        //////////////////
                        studentInfo.Owner = this;
                        studentInfo.ShowDialog();
                        break;
                }
                #endregion SHOW DESIRED WINDOW
            }
            if (isOpen)
            {
                foreach (Window objWindow in Application.Current.Windows)
                {
                    string[] splitedNamespace = (objWindow.ToString()).Split('.');
                    string aClassNameFromCollection = splitedNamespace[splitedNamespace.Length - 1];

                    if (aClassNameFromCollection == className)
                    {
                        objWindowName.WindowState = WindowState.Normal;
                        objWindowName.Activate();
                        break;
                    }
                }
            }


        }

        private void viewStudentContextMenu_Click(object sender, RoutedEventArgs e)
        {
            ViewStudent("StudentInfoViewUI");
        }

        private void MenuChange_Click(object sender, RoutedEventArgs e)
        {
            finishButton.Content = "Finish";
        }

        private void coppyButton_Click(object sender, RoutedEventArgs e)
        {
            presentHouserNoTextBox.Text = permanentHouserNoTextBox.Text ;
            presentRoadNoTextBox.Text  = permanentRoadNoTextBox.Text;
            presentBlockTextBox.Text  = permanentBlockTextBox.Text;
            presentSectorTextBox.Text = permanentSectorTextBox.Text;
            presentPostComboBox.SelectedIndex = permanentPostComboBox.SelectedIndex;
            presentThanaComboBox.SelectedIndex=permanentThanaComboBox.SelectedIndex;
            presentDistrictComboBox.SelectedIndex=permanentDistrictComboBox.SelectedIndex;

            banglapresentHouserNoTextBox.Text = banglaPermanentHouserNoTextBox.Text;
            banglaPresentRoadNoTextBox.Text = banglaPermanentRoadNoTextBox.Text;
            banglaPresentBlockTextBox.Text = banglaPermanentBlockTextBox.Text;
            banglaPresentSectorTextBox.Text = banglaPermanentSectorTextBox.Text;


            
        }

        private void fatherChickBox_Checked(object sender, RoutedEventArgs e)
        {
            guardianNameTextbox .Text= fathersNameTextBox.Text;
            banglaGuardianNameTextbox.Text = banglaFathersNameTextBox.Text;

            guardianMobileNoTextbox.Text = fathersMobileNotextBox.Text;

            banglaGuardianHouserNoTextBox.Text = banglaPermanentHouserNoTextBox.Text;
            banglaGuardianRoadNoTextBox.Text = banglaPermanentRoadNoTextBox.Text;
            banglaGuardianBlockTextBox.Text = banglaPermanentBlockTextBox.Text;
            banglaGuardianSectorTextBox.Text = banglaPermanentSectorTextBox.Text;

            guardianHouserNoTextBox.Text = permanentHouserNoTextBox.Text;
            guardianRoadNoTextBox.Text = permanentRoadNoTextBox.Text;
            guardianBlockTextBox.Text = permanentBlockTextBox.Text;
            guardianSectorTextBox.Text = permanentSectorTextBox.Text;
            guardianPostComboBox.SelectedIndex = permanentPostComboBox.SelectedIndex;
            guardianThanaComboBox.SelectedIndex = permanentThanaComboBox.SelectedIndex;
            guardianDistrictComboBox.SelectedIndex = permanentDistrictComboBox.SelectedIndex;

            //banglaGuardianPostComboBox.SelectedIndex = permanentPostComboBox.SelectedIndex;
            //banglaGuardianThanaComboBox.SelectedIndex = permanentThanaComboBox.SelectedIndex;
            //banglaGuardianDistrictComboBox.SelectedIndex = permanentDistrictComboBox.SelectedIndex;

            motherChickBox.IsChecked = false;
        }

        private void motherChickBox_Checked(object sender, RoutedEventArgs e)
        {
            guardianNameTextbox.Text = mothersNameTextBox.Text;
            banglaGuardianNameTextbox.Text = banglaMothersNameTextBox.Text;

            guardianMobileNoTextbox.Text = mothersMobileNoTextBox.Text;

            banglaGuardianHouserNoTextBox.Text = banglaPermanentHouserNoTextBox.Text;
            banglaGuardianRoadNoTextBox.Text = banglaPermanentRoadNoTextBox.Text;
            banglaGuardianBlockTextBox.Text = banglaPermanentBlockTextBox.Text;
            banglaGuardianSectorTextBox.Text = banglaPermanentSectorTextBox.Text;

            guardianHouserNoTextBox.Text = permanentHouserNoTextBox.Text;
            guardianRoadNoTextBox.Text = permanentRoadNoTextBox.Text;
            guardianBlockTextBox.Text = permanentBlockTextBox.Text;
            guardianSectorTextBox.Text = permanentSectorTextBox.Text;
            guardianPostComboBox.SelectedIndex = permanentPostComboBox.SelectedIndex;
            guardianThanaComboBox.SelectedIndex = permanentThanaComboBox.SelectedIndex;
            guardianDistrictComboBox.SelectedIndex = permanentDistrictComboBox.SelectedIndex;

            //banglaGuardianPostComboBox.SelectedIndex = permanentPostComboBox.SelectedIndex;
            //banglaGuardianThanaComboBox.SelectedIndex = permanentThanaComboBox.SelectedIndex;
            //banglaGuardianDistrictComboBox.SelectedIndex = permanentDistrictComboBox.SelectedIndex;

            guardianHouserNoTextBox.Text = permanentHouserNoTextBox.Text;
            guardianRoadNoTextBox.Text = permanentRoadNoTextBox.Text;
            guardianBlockTextBox.Text = permanentBlockTextBox.Text;
            guardianSectorTextBox.Text = permanentSectorTextBox.Text;
            guardianPostComboBox.SelectedIndex = permanentPostComboBox.SelectedIndex;
            guardianThanaComboBox.SelectedIndex = permanentThanaComboBox.SelectedIndex;
            guardianDistrictComboBox.SelectedIndex = permanentDistrictComboBox.SelectedIndex;

            fatherChickBox.IsChecked = false;
        }
       
        #region validation
            private void validationCheck(TextBox textbox, Label lable, bool validstatus, string labledefaultContent)
            {


                if (textbox.Text == "" && validstatus == false)
                {
                    textbox.BorderThickness = new Thickness(2.0);
                    textbox.BorderBrush = Brushes.Red;
                    lable.Content += " can not Empty";
                    lable.Foreground = Brushes.Red;
                    validstatus = true;

                }
                else
                {
                    textbox.BorderThickness = new Thickness(1.0);
                    textbox.BorderBrush = Brushes.DarkGray;
                    lable.Foreground = Brushes.Black;
                    lable.Content = labledefaultContent;
                    validstatus = false;
                }
            }
            private void validationCheckCombobox(ComboBox combobox, Label lable, string lableContent)
            {
                if (combobox.SelectedIndex == 0)
                {
                    lable.Content += " not selected";
                    lable.Foreground = Brushes.Red;

                    combobox.BorderThickness = new Thickness(2.0);
                    combobox.BorderBrush = Brushes.Red;
                }
                else
                {
                    combobox.BorderThickness = new Thickness(1.0);
                    combobox.BorderBrush = Brushes.DarkGray;
                    lable.Content = lableContent;
                    lable.Foreground = Brushes.Black;


                }
            }
        #endregion
        #region applicantNameTextBox validation
            bool applicantNameTextBox_validate_empty = false;
             private void applicantNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
                {
                    string labledefaultContent = "Applicant Name";
                    validationCheck(applicantNameTextBox, applicantNameCon, applicantNameTextBox_validate_empty ,labledefaultContent);
                }
        #endregion
        #region mobileNumberTextBox validate
             bool mobileNumberTextBox_validate_empty = false;
             private void applicantmobileNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
             {
                 string labledefaultContent = "Mobile Number";
                 validationCheck(applicantmobileNumberTextBox, mobileNumber, mobileNumberTextBox_validate_empty, labledefaultContent);
             }
         #endregion

            private void programCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                programComboboxValid();
            }
            private void departmentCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                departmentComboboxValid();
            }

            private void programComboboxValid()
            {
                var combobox = programCombobox;
                var lable = programeName;
                string lableContent = "Program";
                validationCheckCombobox(combobox, lable, lableContent);
            }
            private void departmentComboboxValid()
            {
                var combobox = departmentCombobox;
                var lable = departmentLab;
                string lableContent = "Department";
                validationCheckCombobox(combobox, lable, lableContent);
            }

          
           
            

    }
}
