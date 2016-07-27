using System;
using System.Collections.Generic;
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
using BLL.StudentManagement;
using BLL.TeacherManagement;
using ENTITY.StudentManagement;
using ENTITY.Admission;
using BLL.Admission;
using ENTITY.TeacherManagement;

namespace SIPI_SL.UI.StudentManagement
{
    /// <summary>
    /// Interaction logic for ClassRoutineCreateUI.xaml
    /// </summary>
    public partial class ClassRoutineCreateUI : Window
    {

        /////ClassRoutineGroup _classroutinGroupObj;

        ClassRoutineGroupManager _classRoutineGroupManagerObj = new ClassRoutineGroupManager();

        CreateRoutine _createRoutine;
        ClassRoutineCreateManager _classRoutineCreateManagerObj = new ClassRoutineCreateManager();

        SIPI_Program programObj = new SIPI_Program();
        SIPI_Department departmentObj = new SIPI_Department();
        Semester semesterObj = new Semester();
        ClassPeriod _classPeriodObj;
        Course courseObj = new Course();
        TeacherInfo teacherInfoObj = new TeacherInfo();



        SIPI_ProgramManager sIPI_programManagerObj = new SIPI_ProgramManager();
        SIPI_DepartmentManager sIPI_departmentManagerObj = new SIPI_DepartmentManager();
        SemesterManager semesterManagerObj = new SemesterManager();
        ClassPeriodManager classPeriodManagerObj = new ClassPeriodManager();
        CourseManager courseManagerObj = new CourseManager();
        TeacherInfoManager teacherManagerObj = new TeacherInfoManager();
 
        List<SIPI_Program> ProgramList;
        List<SIPI_Department> DepartmentList;
        List<Semester> SemesterList;
        List<ClassPeriod> classPeriodList;
        List<Course> courseList;
        List<TeacherInfo> teacherList;

        List<CreateRoutine> createRoutineList ;
        public ClassRoutineCreateUI()
        {
            InitializeComponent();
            LoadAllUI();
        }

        private void LoadAllUI()
        {
            LoadProgramComboBox();
            LoadDepartmentComboBox();
            LoadSemesterComboBox();
            clearButton.IsEnabled = false;
            LoadClassTimeCombobox();
            LoadClassCourseCombobox(-1);
            LoadClassTeacherCombobox();
            LoadAllRoutine();
            LoadClassteacherSearch();
            //routinTabItem.IsEnabled = false;
        }

        private void LoadAllRoutine()
        {
            createRoutineList = new List<CreateRoutine>();
            createRoutineList = _classRoutineCreateManagerObj.GetAllClassRoutine();
            allRoutineListView.Items.Clear();
            if (createRoutineList.Count > 0)
            {
                foreach (var item in createRoutineList)
                {
                    allRoutineListView.Items.Add(item);
                }
            }
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            try
            {
                _createRoutine = new CreateRoutine();
                _createRoutine.Day = dayCombobox.Text;
                _createRoutine.ClassRutinGroupId = dayCombobox.Text;

                ////////////

                _createRoutine.Year = yearTextBox.Text;


                programObj = ((SIPI_Program)programCombobox.SelectedItem);
                _createRoutine.ProgramId = programObj.Id;

                departmentObj = ((SIPI_Department)departmentCombobox.SelectedItem);
                _createRoutine.DepartmentId = departmentObj.Id;

                semesterObj = ((Semester)semesterCombobox.SelectedItem);
                _createRoutine.SemesterId = semesterObj.Id;
                /////////////////
                ////class
                if (firstClassCombobox.SelectedItem == secondClassComboBox.SelectedItem
                    | firstClassCombobox.SelectedItem == thirdClassCombobox.SelectedItem
                    | firstClassCombobox.SelectedItem == forthClassCombobox.SelectedItem
                    | firstClassCombobox.SelectedItem == fifthClassCombobox.SelectedItem
                    | firstClassCombobox.SelectedItem == sixthClassCombobox.SelectedItem
                    | firstClassCombobox.SelectedItem == seventhClassCombox.SelectedItem
                    | firstClassCombobox.SelectedItem == eighthClassCombobox.SelectedItem

                    | secondClassComboBox.SelectedItem == thirdClassCombobox.SelectedItem
                    | secondClassComboBox.SelectedItem == forthClassCombobox.SelectedItem
                    | secondClassComboBox.SelectedItem == fifthClassCombobox.SelectedItem
                    | secondClassComboBox.SelectedItem == sixthClassCombobox.SelectedItem
                    | secondClassComboBox.SelectedItem == seventhClassCombox.SelectedItem
                    | secondClassComboBox.SelectedItem == eighthClassCombobox.SelectedItem

                    | thirdClassCombobox.SelectedItem == forthClassCombobox.SelectedItem
                    | thirdClassCombobox.SelectedItem == fifthClassCombobox.SelectedItem
                    | thirdClassCombobox.SelectedItem == sixthClassCombobox.SelectedItem
                    | thirdClassCombobox.SelectedItem == seventhClassCombox.SelectedItem
                    | thirdClassCombobox.SelectedItem == eighthClassCombobox.SelectedItem

                    | forthClassCombobox.SelectedItem == fifthClassCombobox.SelectedItem
                    | forthClassCombobox.SelectedItem == sixthClassCombobox.SelectedItem
                    | forthClassCombobox.SelectedItem == seventhClassCombox.SelectedItem
                    | forthClassCombobox.SelectedItem == eighthClassCombobox.SelectedItem

                    | fifthClassCombobox.SelectedItem == sixthClassCombobox.SelectedItem
                    | fifthClassCombobox.SelectedItem == seventhClassCombox.SelectedItem
                    | fifthClassCombobox.SelectedItem == eighthClassCombobox.SelectedItem

                    | sixthClassCombobox.SelectedItem == seventhClassCombox.SelectedItem
                    | sixthClassCombobox.SelectedItem == eighthClassCombobox.SelectedItem

                    | seventhClassCombox.SelectedItem == eighthClassCombobox.SelectedItem
                    )
                {
                    MessageBox.Show("Same time selected ! Please Chick");
                }
                else
                {
                    _classPeriodObj = new ClassPeriod();
                    _classPeriodObj = ((ClassPeriod)firstClassCombobox.SelectedItem);
                    _createRoutine.FirstClass = _classPeriodObj.Id;
                    _classPeriodObj = ((ClassPeriod)secondClassComboBox.SelectedItem);
                    _createRoutine.SecondClass = _classPeriodObj.Id;

                    _classPeriodObj = ((ClassPeriod)thirdClassCombobox.SelectedItem);
                    _createRoutine.ThirdClass = _classPeriodObj.Id;

                    _classPeriodObj = ((ClassPeriod)forthClassCombobox.SelectedItem);
                    _createRoutine.ForthClass = _classPeriodObj.Id;

                    _classPeriodObj = ((ClassPeriod)fifthClassCombobox.SelectedItem);
                    _createRoutine.FifthClass = _classPeriodObj.Id;

                    _classPeriodObj = ((ClassPeriod)sixthClassCombobox.SelectedItem);
                    _createRoutine.SixthClass = _classPeriodObj.Id;

                    _classPeriodObj = ((ClassPeriod)seventhClassCombox.SelectedItem);
                    _createRoutine.SeventhClass = _classPeriodObj.Id;

                    _classPeriodObj = ((ClassPeriod)eighthClassCombobox.SelectedItem);
                    _createRoutine.EighthClass = _classPeriodObj.Id;

                    ////////
                    /////Course 
                    courseObj = ((Course)firstCourseCombobox.SelectedItem);
                    _createRoutine.FirstCourse = courseObj.Id;

                    courseObj = ((Course)secondCourseCombobox.SelectedItem);
                    _createRoutine.SecondCourse = courseObj.Id;

                    courseObj = ((Course)thirdCourseCombobox.SelectedItem);
                    _createRoutine.ThirdCourse = courseObj.Id;

                    courseObj = ((Course)forthCourseCombobox.SelectedItem);
                    _createRoutine.ForthCourse = courseObj.Id;

                    courseObj = ((Course)fifthCourseCombobox.SelectedItem);
                    _createRoutine.FifthCourse = courseObj.Id;

                    courseObj = ((Course)sixthCourseCombobox.SelectedItem);
                    _createRoutine.SixthCourse = courseObj.Id;

                    courseObj = ((Course)seventhCourseCombobox.SelectedItem);
                    _createRoutine.SeventhCourse = courseObj.Id;

                    courseObj = ((Course)eightCourseCombobox.SelectedItem);
                    _createRoutine.EighthCourse = courseObj.Id;

                    //////
                    ////Teachers's

                    teacherInfoObj = ((TeacherInfo)firstTeacherCombobox.SelectedItem);
                    _createRoutine.FirstTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)secondTeacherCombobox.SelectedItem);
                    _createRoutine.SecondTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)thirdTeacherCombobox.SelectedItem);
                    _createRoutine.ThirdTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)forthTeacherCombobox.SelectedItem);
                    _createRoutine.ForthTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)fifthTeacherCombobox.SelectedItem);
                    _createRoutine.FifthTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)sixthTeacherCombobox.SelectedItem);
                    _createRoutine.SixthTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)seventhTeacherCombobox.SelectedItem);
                    _createRoutine.SeventhTeacher = teacherInfoObj.Id;

                    teacherInfoObj = ((TeacherInfo)eighthTeacherCombobox.SelectedItem);
                    _createRoutine.EighthTeacher = teacherInfoObj.Id;

                    ///////list save////
                    //routinelist.Add(_createRoutine);
                    //allRoutineListView.Items.Clear();
                    //if (routinelist.Count > 0)
                    //{
                    //    foreach (var item in routinelist)
                    //    {
                    //        allRoutineListView.Items.Add(item);
                    //    }
                    //}
                    ///////list save////

                    LoadAllRoutine();
                    if (_classRoutineCreateManagerObj.SaveClassRoutineByDay(_createRoutine) == true)
                    {
                        MessageBox.Show("Routine Create successfully", "Routine Create");
                        LoadAllRoutine();

                    }
                    else
                    {
                        MessageBox.Show("Duplicate Data Insert ! Please check Day Entry", "Confirmation");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           

        }

        private void firstTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (firstTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)firstTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();  
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)firstClassCombobox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)firstTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    firstTeacherCombobox.SelectedIndex = -1;
                }
                //else
                //{
                //    MessageBox.Show("Teacher Is avilable", "Confirmation");
                //}
               
            }
        }
        private void LoadClassteacherSearch()
        {
            teacherList = new List<TeacherInfo>();
            teacherSearch.Items.Clear();
            teacherList = teacherManagerObj.LoadAllTeacherInfo();
            foreach (TeacherInfo teacherinfo in teacherList)
            {
                teacherSearch.ItemsSource = teacherList;
            }
            teacherSearch.DisplayMemberPath = "TeacherName";
        }
        private void LoadClassTeacherCombobox()
        {
            teacherList = new List<TeacherInfo>();
            firstTeacherCombobox.Items.Clear();
            secondTeacherCombobox.Items.Clear();
            thirdTeacherCombobox.Items.Clear();
            forthTeacherCombobox.Items.Clear();
            fifthTeacherCombobox.Items.Clear();
            sixthTeacherCombobox.Items.Clear();
            seventhTeacherCombobox.Items.Clear();
            eighthTeacherCombobox.Items.Clear();

            teacherList = teacherManagerObj.LoadAllTeacherInfo();
            foreach (TeacherInfo teacherinfo in teacherList)
            {
                firstTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < firstTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)firstTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        firstTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                secondTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < secondTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)secondTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        secondTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                thirdTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < thirdTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)thirdTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        thirdTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                forthTeacherCombobox.ItemsSource = teacherList;

                for (int i = 0; i < forthTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)forthTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        forthTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                fifthTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < fifthTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)fifthTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        fifthTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                sixthTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < sixthTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)sixthTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        sixthTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                seventhTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < seventhTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)seventhTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        seventhTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }

                eighthTeacherCombobox.ItemsSource = teacherList;
                for (int i = 0; i < eighthTeacherCombobox.Items.Count; i++)
                {
                    TeacherInfo teacher = (TeacherInfo)eighthTeacherCombobox.Items[i];
                    if (teacher.TeacherName == "N/A")
                    {
                        eighthTeacherCombobox.SelectedIndex = i;
                        break;
                    }

                }
            }
        }
        //private void LoadClassCourseCombobox()
        //{
        //    courseList = new List<Course>();
        //    firstCourseCombobox.Items.Clear();
        //    secondCourseCombobox.Items.Clear();
        //    thirdCourseCombobox.Items.Clear();
        //    forthCourseCombobox.Items.Clear();
        //    fifthCourseCombobox.Items.Clear();
        //    sixthCourseCombobox.Items.Clear();
        //    seventhCourseCombobox.Items.Clear();
        //    eightCourseCombobox.Items.Clear();

        //    courseList = courseManagerObj.GetAllCourse();
        //    foreach (Course course in courseList)
        //    {
        //        firstCourseCombobox.ItemsSource = courseList;
        //        secondCourseCombobox.ItemsSource = courseList;
        //        thirdCourseCombobox.ItemsSource = courseList;
        //        forthCourseCombobox.ItemsSource = courseList;
        //        fifthCourseCombobox.ItemsSource = courseList;
        //        sixthCourseCombobox.ItemsSource = courseList;
        //        seventhCourseCombobox.ItemsSource = courseList;
        //        eightCourseCombobox.ItemsSource = courseList;
        //    }
        //}
        

        private void LoadClassTimeCombobox()
        {
            classPeriodList = new List<ClassPeriod>();
            firstClassCombobox.Items.Clear();
            secondClassComboBox.Items.Clear();
            thirdClassCombobox.Items.Clear();
            forthClassCombobox.Items.Clear();
            fifthClassCombobox.Items.Clear();
            sixthClassCombobox.Items.Clear();
            seventhClassCombox.Items.Clear();
            eighthClassCombobox.Items.Clear();

            classPeriodList = classPeriodManagerObj.LoadAllClassPeriod();
            foreach (ClassPeriod classpriod in classPeriodList)
            {
                firstClassCombobox.ItemsSource = classPeriodList;
                firstClassCombobox.SelectedIndex = 0;
                secondClassComboBox.ItemsSource = classPeriodList;
                secondClassComboBox.SelectedIndex = 1;
                thirdClassCombobox.ItemsSource = classPeriodList;
                thirdClassCombobox.SelectedIndex = 2;
                forthClassCombobox.ItemsSource = classPeriodList;
                forthClassCombobox.SelectedIndex = 3;
                fifthClassCombobox.ItemsSource = classPeriodList;
                fifthClassCombobox.SelectedIndex = 4;
                sixthClassCombobox.ItemsSource = classPeriodList;
                sixthClassCombobox.SelectedIndex = 5;
                seventhClassCombox.ItemsSource = classPeriodList;
                seventhClassCombox.SelectedIndex = 6;
                eighthClassCombobox.ItemsSource = classPeriodList;
                eighthClassCombobox.SelectedIndex = 7;
            }
        }

        private void addignButton_Click(object sender, RoutedEventArgs e)
        {
            //_classroutinGroupObj = new ClassRoutineGroup();
            //_classroutinGroupObj.Year = yearTextBox.Text;


            //programObj = ((Program)programCombobox.SelectedItem);
            //_classroutinGroupObj.ProgramId = programObj.Id;

            //departmentObj = ((Department)departmentCombobox.SelectedItem);
            //_classroutinGroupObj.DepartmentId = departmentObj.Id;

            //semesterObj = ((Semester)semesterCombobox.SelectedItem);
            //_classroutinGroupObj.SemesterId = semesterObj.Id;

            //_classRoutineGroupManagerObj.SaveClassRoutineGroup(_classroutinGroupObj);
            //MessageBox.Show("Routine Group Create successfully" , "Routine Group");

            routinTabItem.IsEnabled = true;
            //CreateRoutineTabItem.IsEnabled = false;
            rutinTabControl.SelectedIndex++;
            

        }

        private void LoadSemesterComboBox()
        {
            SemesterList = new List<Semester>();
            semesterCombobox.Items.Clear();
            SemesterList = semesterManagerObj.GetAllSemester();
            foreach (Semester semester in SemesterList)
            {
                semesterCombobox.ItemsSource = SemesterList;
            }
        }

        private void LoadProgramComboBox()
        {
            ProgramList = new List<SIPI_Program>();
            programCombobox.Items.Clear();
            ProgramList = sIPI_programManagerObj.GetAllSIPI_Program();
            foreach (SIPI_Program program in ProgramList)
            {
                programCombobox.ItemsSource = ProgramList;
            }
        }

        private void LoadDepartmentComboBox()
        {
            DepartmentList = new List<SIPI_Department>();
            departmentCombobox.Items.Clear();
            DepartmentList = sIPI_departmentManagerObj.GetAll_SIPIDepartment();
            foreach (SIPI_Department department in DepartmentList)
            {
                departmentCombobox.ItemsSource = DepartmentList;
            }
        }

        private void clearButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ClearRoutineGroup();
        }
        private void ClearRoutineGroup()
        {
            yearTextBox.Text = "";
            programCombobox.Text = "";
            departmentCombobox.Text = "";
            semesterCombobox.Text = "";
        }
        private void ClearRoutine()
        {
            firstTeacherCombobox.Text = "";
            secondTeacherCombobox.Text = "";
            thirdTeacherCombobox.Text = "";
            forthTeacherCombobox.Text = "";
            fifthTeacherCombobox.Text = "";
            sixthTeacherCombobox.Text = "";
            seventhTeacherCombobox.Text = "";
            eighthTeacherCombobox.Text = "";

            firstCourseCombobox.Text = "";
            secondCourseCombobox.Text = "";
            thirdCourseCombobox.Text = "";
            forthCourseCombobox.Text = "";
            fifthCourseCombobox.Text = "";
            sixthCourseCombobox.Text = "";
            seventhCourseCombobox.Text = "";
            eightCourseCombobox.Text = "";

            //firstClassCombobox.Text = "";
            //secondClassComboBox.Text = "";
            //thirdClassCombobox.Text = "";
            //forthClassCombobox.Text = "";
            //fifthClassCombobox.Text = "";
            //sixthClassCombobox.Text = "";
            //seventhClassCombox.Text = "";
            //eighthClassCombobox.Text = "";
        }
        private void yearTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            clearButton.IsEnabled = true;
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            ClearRoutine();

        }

        private void RemoveContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                _createRoutine = new CreateRoutine();
                _createRoutine = ((CreateRoutine)allRoutineListView.SelectedItem);
                _classRoutineCreateManagerObj.DeleteCreateRoutine(_createRoutine);
                MessageBox.Show("Data Remove successfully");
                LoadAllRoutine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void newRoutine_Click(object sender, RoutedEventArgs e)
        {
            dayCombobox.Text = "";
            ClearRoutine();
            ClearRoutineGroup();
            rutinTabControl.SelectedIndex--;

        }

        private void secondTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (secondTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)secondTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)secondClassComboBox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)secondTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckesecondTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    secondTeacherCombobox.SelectedIndex = -1;
                }
               
            }
        }

        private void thirdTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (thirdTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)thirdTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)thirdClassCombobox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)thirdTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckeThirdTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    thirdTeacherCombobox.SelectedIndex = -1;
                }

            }
        }

        private void forthTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (forthTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)forthTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)forthClassCombobox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)forthTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckeForthTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    forthTeacherCombobox.SelectedIndex = -1;
                }

            }
        }

        private void fifthTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fifthTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)fifthTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)fifthClassCombobox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)fifthTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckeFifthTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    fifthTeacherCombobox.SelectedIndex = -1;
                }

            }
        }

        private void sixthTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (sixthTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)sixthTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)sixthClassCombobox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)sixthTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckeSixthTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    sixthTeacherCombobox.SelectedIndex = -1;
                }

            }
        }

        private void seventhTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (seventhTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)seventhTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)seventhClassCombox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)seventhTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckeSeventhTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    seventhTeacherCombobox.SelectedIndex = -1;
                }

            }
        }

        private void eighthTeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (eighthTeacherCombobox.SelectedIndex > -1 && ((TeacherInfo)eighthTeacherCombobox.SelectedItem).TeacherName != "N/A")
            {
                createRoutineList = new List<CreateRoutine>();
                string year = yearTextBox.Text.Trim();
                string classTimeSchasule = ((ClassPeriod)eighthClassCombobox.SelectedItem).StartTime.Trim();
                string day = dayCombobox.Text.Trim();
                string teacherName = ((TeacherInfo)eighthTeacherCombobox.SelectedItem).TeacherName.Trim();

                //createRoutineList = _classRoutineCreateManagerObj.GetTeacherduplicacychecke(year, classTime, day, teacherName);
                if (_classRoutineCreateManagerObj.GetTeacherduplicacycheckeEighthTeacher(year, classTimeSchasule, day, teacherName) == true)
                {
                    MessageBox.Show("This Time Teacher Have a class", "Teacher Checke ");
                    eighthTeacherCombobox.SelectedIndex = -1;
                }

            }
        }

        private void departmentCombobox_DropDownClosed(object sender, EventArgs e)
        {
            LoadClassCourseCombobox(0);
        }

        private void LoadClassCourseCombobox(int p)
        {
            if (p == -1)
            {
                courseList = new List<Course>();
                firstCourseCombobox.Items.Clear();
                secondCourseCombobox.Items.Clear();
                thirdCourseCombobox.Items.Clear();
                forthCourseCombobox.Items.Clear();
                fifthCourseCombobox.Items.Clear();
                sixthCourseCombobox.Items.Clear();
                seventhCourseCombobox.Items.Clear();
                eightCourseCombobox.Items.Clear();

                courseList = courseManagerObj.GetAllCourse();
                foreach (Course course in courseList)
                {
                    firstCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < firstCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)firstCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            firstCourseCombobox.SelectedIndex = i;
                            break;
                        }
                    }

                    secondCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < secondCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)secondCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            secondCourseCombobox.SelectedIndex = i;
                            break;
                        }
                    }

                    thirdCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < thirdCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)thirdCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            thirdCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    forthCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < forthCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)forthCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            forthCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    fifthCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < fifthCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)fifthCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            fifthCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    sixthCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < sixthCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)sixthCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            sixthCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    seventhCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < seventhCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)seventhCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            seventhCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    eightCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < eightCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)eightCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            eightCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                }
            }
            else
            {
                try
                {
                    SIPI_Department department = departmentCombobox.SelectedItem as SIPI_Department;
                    courseList = courseManagerObj.GetAllCourse(department.Id);

                    foreach (Course course in courseList)
                    {
                        firstCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < firstCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)firstCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                firstCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        secondCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < secondCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)secondCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                secondCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        thirdCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < thirdCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)thirdCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                thirdCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        forthCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < forthCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)forthCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                forthCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        fifthCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < fifthCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)fifthCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                fifthCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        sixthCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < sixthCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)sixthCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                sixthCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        seventhCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < seventhCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)seventhCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                seventhCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        eightCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < eightCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)eightCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                eightCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }


            }
        }

        private void semesterCombobox_DropDownClosed(object sender, EventArgs e)
        {
            LoadClassCourseComboboxBysemester(0);
        }

        private void LoadClassCourseComboboxBysemester(int p)
        {
            if (p == -1)
            {
                courseList = new List<Course>();
                firstCourseCombobox.Items.Clear();
                secondCourseCombobox.Items.Clear();
                thirdCourseCombobox.Items.Clear();
                forthCourseCombobox.Items.Clear();
                fifthCourseCombobox.Items.Clear();
                sixthCourseCombobox.Items.Clear();
                seventhCourseCombobox.Items.Clear();
                eightCourseCombobox.Items.Clear();

                courseList = courseManagerObj.GetAllCourse();
                foreach (Course course in courseList)
                {
                    //firstCourseCombobox.ItemsSource = courseList;
                    //secondCourseCombobox.ItemsSource = courseList;
                    //thirdCourseCombobox.ItemsSource = courseList;
                    //forthCourseCombobox.ItemsSource = courseList;
                    //fifthCourseCombobox.ItemsSource = courseList;
                    //sixthCourseCombobox.ItemsSource = courseList;
                    //seventhCourseCombobox.ItemsSource = courseList;
                    //eightCourseCombobox.ItemsSource = courseList;
                    firstCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < firstCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)firstCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            firstCourseCombobox.SelectedIndex = i;
                            break;
                        }
                    }

                    secondCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < secondCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)secondCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            secondCourseCombobox.SelectedIndex = i;
                            break;
                        }
                    }

                    thirdCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < thirdCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)thirdCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            thirdCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    forthCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < forthCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)forthCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            forthCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    fifthCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < fifthCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)fifthCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            fifthCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    sixthCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < sixthCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)sixthCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            sixthCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    seventhCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < seventhCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)seventhCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            seventhCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                    eightCourseCombobox.ItemsSource = courseList;
                    for (int i = 0; i < eightCourseCombobox.Items.Count; i++)
                    {
                        Course course_set = (Course)eightCourseCombobox.Items[i];
                        if (course_set.CourseName == "N/A")
                        {
                            eightCourseCombobox.SelectedIndex = i;
                            break;
                        }

                    }
                }
            }
            else
            {
                try
                {
                    Semester semester = semesterCombobox.SelectedItem as Semester;
                    SIPI_Department department = departmentCombobox.SelectedItem as SIPI_Department;
                    courseList = courseManagerObj.GetAllCourseBysemesterDept(semester.Id, department.Id);

                    foreach (Course course in courseList)
                    {
                        //firstCourseCombobox.ItemsSource = courseList;
                        //secondCourseCombobox.ItemsSource = courseList;
                        //thirdCourseCombobox.ItemsSource = courseList;
                        //forthCourseCombobox.ItemsSource = courseList;
                        //fifthCourseCombobox.ItemsSource = courseList;
                        //sixthCourseCombobox.ItemsSource = courseList;
                        //seventhCourseCombobox.ItemsSource = courseList;
                        //eightCourseCombobox.ItemsSource = courseList;
                        firstCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < firstCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)firstCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                firstCourseCombobox.SelectedIndex = i;
                                break;
                            }
                        }

                        secondCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < secondCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)secondCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                secondCourseCombobox.SelectedIndex = i;
                                break;
                            }
                        }

                        thirdCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < thirdCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)thirdCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                thirdCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        forthCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < forthCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)forthCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                forthCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        fifthCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < fifthCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)fifthCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                fifthCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        sixthCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < sixthCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)sixthCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                sixthCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        seventhCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < seventhCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)seventhCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                seventhCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                        eightCourseCombobox.ItemsSource = courseList;
                        for (int i = 0; i < eightCourseCombobox.Items.Count; i++)
                        {
                            Course course_set = (Course)eightCourseCombobox.Items[i];
                            if (course_set.CourseName == "N/A")
                            {
                                eightCourseCombobox.SelectedIndex = i;
                                break;
                            }

                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }


            }
        }

        private void firstCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < firstTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)firstTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    firstTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void secondCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < secondTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)secondTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    secondTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void thirdCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < thirdTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)thirdTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    thirdTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void forthCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < forthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)forthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    forthTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void fifthCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < fifthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)fifthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    fifthTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void sixthCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < sixthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)sixthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    sixthTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }

        }

        private void seventhCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < seventhTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)seventhTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    seventhTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }

        }

        private void eightCourseCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < eighthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)eighthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    eighthTeacherCombobox.SelectedIndex = i;
                    break;
                }
            }

        }

        private void dayCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            firstTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < firstTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)firstTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    firstTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            secondTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < secondTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)secondTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    secondTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            thirdTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < thirdTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)thirdTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    thirdTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            forthTeacherCombobox.ItemsSource = teacherList;

            for (int i = 0; i < forthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)forthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    forthTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            fifthTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < fifthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)fifthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    fifthTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            sixthTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < sixthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)sixthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    sixthTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            seventhTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < seventhTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)seventhTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    seventhTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }

            eighthTeacherCombobox.ItemsSource = teacherList;
            for (int i = 0; i < eighthTeacherCombobox.Items.Count; i++)
            {
                TeacherInfo teacher = (TeacherInfo)eighthTeacherCombobox.Items[i];
                if (teacher.TeacherName == "N/A")
                {
                    eighthTeacherCombobox.SelectedIndex = i;
                    break;
                }

            }
        }

        private void teacherSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (teacherSearch.SelectedIndex > -1)
                {
                    createRoutineList = new List<CreateRoutine>();
                    string teacherName = ((TeacherInfo)teacherSearch.SelectedItem).TeacherName.Trim();
                    createRoutineList = _classRoutineCreateManagerObj.GetTeacherAssignedCourse(teacherName);
                    allRoutineListView.Items.Clear();
                    if (createRoutineList.Count > 0)
                    {

                        foreach (var item in createRoutineList)
                        {
                            allRoutineListView.Items.Add(item);
                        }

                    }
                    else
                    {
                        LoadAllRoutine();
                        MessageBox.Show("Here is no Class for this Teacher");
                        teacherSearch.SelectedIndex = -1;
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

       

    }
}
