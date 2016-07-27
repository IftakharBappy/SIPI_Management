using BLL.Admission;
using BLL.StudentManagement;
using ENTITY.Admission;
using ENTITY.StudentManagement;
using SIPI_SL.Report.Crystal.Admission;
using SIPI_SL.Report.Crystal.CourseManagement;
using SIPI_SL.Report.Entity;
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

namespace SIPI_SL.Report.UI.Routine
{
    /// <summary>
    /// Interaction logic for RoutineReposrt.xaml
    /// </summary>
    public partial class RoutineReposrt : Window
    {
        List<CreateRoutine> createRoutineList;
        ClassRoutineCreateManager _classRoutineCreateManagerObj = new ClassRoutineCreateManager();
        List<SIPI_Department> _SIPIDepartmentList;
        SIPI_DepartmentManager sIPI_DepartmentManagerObj = new SIPI_DepartmentManager();
        List<Semester> SemesterList;
        SemesterManager semesterManagerObj = new SemesterManager();
        List<CreateRoutineR> createRoutineR = new List<CreateRoutineR>();
     
        public RoutineReposrt()
        {
            InitializeComponent();
            LoadAllRoutine();
            LoadDepartmentComboBox();
            LoadSemesterComboBox();
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

        private void LoadDepartmentComboBox()
        {
             _SIPIDepartmentList = new List<SIPI_Department>();
            departmentCombobox.Items.Clear();
            _SIPIDepartmentList = sIPI_DepartmentManagerObj.GetAll_SIPIDepartment();
            foreach (SIPI_Department department in _SIPIDepartmentList)
            {
                departmentCombobox.ItemsSource = _SIPIDepartmentList;
            }
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


        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (departmentCombobox.Text != "")
            {
                createRoutineList = new List<CreateRoutine>();
                string dept = departmentCombobox.Text.Trim();
                string semester = semesterCombobox.Text.Trim();
                string year = yearTextBox.Text.Trim();
                createRoutineList = _classRoutineCreateManagerObj.GetAllRoutineDepartment(dept, semester, year);
                allRoutineListView.Items.Clear();
                if (createRoutineList.Count > 0)
                {

                    foreach (var item in createRoutineList)
                    {
                        allRoutineListView.Items.Add(item);
                        
                    }

                }
            }
            else
            {
                LoadAllRoutine();
            }

        }

        private void previewReportButton_Click(object sender, RoutedEventArgs e)
        {
            createRoutineR.Clear();
            foreach (CreateRoutine p in createRoutineList)
            {
                CreateRoutineR routineInfo = new CreateRoutineR();
                routineInfo.Id = p.Id;
                routineInfo.Day = p.Day;
                routineInfo.FirstClassName = p.FirstClassName;
                routineInfo.SecondClassName = p.SecondClassName;
                routineInfo.ThirdClassName = p.ThirdClassName;
                routineInfo.ForthClassName = p.ForthClassName;
                routineInfo.FifthClassName = p.FifthClassName;
                routineInfo.SixthClassName = p.SixthClassName;
                routineInfo.SeventhClassName = p.SeventhClassName;
                routineInfo.EighthClassName = p.EighthClassName;

                routineInfo.FirstClassStart = p.FirstClassStart;
                routineInfo.FirstClassEnd = p.FirstClassEnd;
                routineInfo.SecondClassStart = p.SecondClassStart;
                routineInfo.SecondClassEnd = p.SecondClassEnd;
                routineInfo.ThirdClassStart = p.ThirdClassStart;
                routineInfo.ThirdClassEnd = p.ThirdClassEnd;
                routineInfo.ForthClassStart = p.ForthClassStart;
                routineInfo.ForthClassEnd = p.ForthClassEnd;
                routineInfo.FifthClassStart = p.FifthClassStart;
                routineInfo.FifthClassEnd = p.FifthClassEnd;
                routineInfo.SixthClassStart = p.SixthClassStart;
                routineInfo.SixthClassEnd = p.SixthClassEnd;
                routineInfo.SeventhClassStart = p.SeventhClassStart;
                routineInfo.SeventhClassEnd = p.SeventhClassEnd;
                routineInfo.EighthClassStart = p.EighthClassStart;
                routineInfo.EighthClassEnd = p.EighthClassEnd;



                routineInfo.FirstCourseName = p.FirstCourseName;
                routineInfo.SecondCourseName = p.SecondCourseName;
                routineInfo.ThirdCourseName = p.ThirdCourseName;
                routineInfo.ForthCourseName = p.ForthCourseName;
                routineInfo.FifthCourseName = p.FifthCourseName;
                routineInfo.SixthCourseName = p.SixthCourseName;
                routineInfo.SeventhCourseName = p.SeventhCourseName;
                routineInfo.EighthCourseName = p.EighthCourseName;


                routineInfo.FirstTeacherName = p.FirstTeacherName;
                routineInfo.SecondTeacherName = p.SecondTeacherName;
                routineInfo.ThirdTeacherrName = p.ThirdTeacherrName;
                routineInfo.ForthTeacherrName = p.ForthTeacherrName;
                routineInfo.FifthTeacherrName = p.FifthTeacherrName;
                routineInfo.SixthTeacherrName = p.SixthTeacherrName;
                routineInfo.SeventhTeacherrName = p.SeventhTeacherrName;
                routineInfo.EighthTeacherrName = p.EighthTeacherrName;

                routineInfo.Year = p.Year;
                routineInfo.ProgramName = p.ProgramName;
                routineInfo.DepartmentName = p.DepartmentName;
                routineInfo.SemesterNo = p.SemesterNo;



                createRoutineR.Add(routineInfo);
                
            }


            if (createRoutineR.Count > 0)
            {
                RoutineRepost riport = new RoutineRepost();
                ReportUtility.Display_report(riport, createRoutineR, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
        }

        private void Report_department_Button_Click(object sender, RoutedEventArgs e)
        {
            if (previewReportButton_department.Content.ToString() == "Department wise Routine")
            {
                createRoutineR.Clear();
                foreach (CreateRoutine p in createRoutineList)
                {
                    CreateRoutineR routineInfo = new CreateRoutineR();
                    routineInfo.Id = p.Id;
                    routineInfo.Day = p.Day;
                    routineInfo.FirstClassName = p.FirstClassName;
                    routineInfo.SecondClassName = p.SecondClassName;
                    routineInfo.ThirdClassName = p.ThirdClassName;
                    routineInfo.ForthClassName = p.ForthClassName;
                    routineInfo.FifthClassName = p.FifthClassName;
                    routineInfo.SixthClassName = p.SixthClassName;
                    routineInfo.SeventhClassName = p.SeventhClassName;
                    routineInfo.EighthClassName = p.EighthClassName;

                    routineInfo.FirstClassStart = p.FirstClassStart;
                    routineInfo.FirstClassEnd = p.FirstClassEnd;
                    routineInfo.SecondClassStart = p.SecondClassStart;
                    routineInfo.SecondClassEnd = p.SecondClassEnd;
                    routineInfo.ThirdClassStart = p.ThirdClassStart;
                    routineInfo.ThirdClassEnd = p.ThirdClassEnd;
                    routineInfo.ForthClassStart = p.ForthClassStart;
                    routineInfo.ForthClassEnd = p.ForthClassEnd;
                    routineInfo.FifthClassStart = p.FifthClassStart;
                    routineInfo.FifthClassEnd = p.FifthClassEnd;
                    routineInfo.SixthClassStart = p.SixthClassStart;
                    routineInfo.SixthClassEnd = p.SixthClassEnd;
                    routineInfo.SeventhClassStart = p.SeventhClassStart;
                    routineInfo.SeventhClassEnd = p.SeventhClassEnd;
                    routineInfo.EighthClassStart = p.EighthClassStart;
                    routineInfo.EighthClassEnd = p.EighthClassEnd;



                    routineInfo.FirstCourseName = p.FirstCourseName;
                    routineInfo.SecondCourseName = p.SecondCourseName;
                    routineInfo.ThirdCourseName = p.ThirdCourseName;
                    routineInfo.ForthCourseName = p.ForthCourseName;
                    routineInfo.FifthCourseName = p.FifthCourseName;
                    routineInfo.SixthCourseName = p.SixthCourseName;
                    routineInfo.SeventhCourseName = p.SeventhCourseName;
                    routineInfo.EighthCourseName = p.EighthCourseName;


                    routineInfo.FirstTeacherName = p.FirstTeacherName;
                    routineInfo.SecondTeacherName = p.SecondTeacherName;
                    routineInfo.ThirdTeacherrName = p.ThirdTeacherrName;
                    routineInfo.ForthTeacherrName = p.ForthTeacherrName;
                    routineInfo.FifthTeacherrName = p.FifthTeacherrName;
                    routineInfo.SixthTeacherrName = p.SixthTeacherrName;
                    routineInfo.SeventhTeacherrName = p.SeventhTeacherrName;
                    routineInfo.EighthTeacherrName = p.EighthTeacherrName;

                    routineInfo.Year = p.Year;
                    routineInfo.ProgramName = p.ProgramName;
                    routineInfo.DepartmentName = p.DepartmentName;
                    routineInfo.SemesterNo = p.SemesterNo;

                    createRoutineR.Add(routineInfo);

                }


                if (createRoutineR.Count > 0)
                {
                    DepartmentWiseRoutine riport = new DepartmentWiseRoutine();
                    ReportUtility.Display_report(riport, createRoutineR, this);
                }
                else
                {
                    MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
 
                }
            if (previewReportButton_department.Content.ToString() == "Semester wise Routine")
            {
                createRoutineR.Clear();
            foreach (CreateRoutine p in createRoutineList)
            {
                CreateRoutineR routineInfo = new CreateRoutineR();
                routineInfo.Id = p.Id;
                routineInfo.Day = p.Day;
                routineInfo.FirstClassName = p.FirstClassName;
                routineInfo.SecondClassName = p.SecondClassName;
                routineInfo.ThirdClassName = p.ThirdClassName;
                routineInfo.ForthClassName = p.ForthClassName;
                routineInfo.FifthClassName = p.FifthClassName;
                routineInfo.SixthClassName = p.SixthClassName;
                routineInfo.SeventhClassName = p.SeventhClassName;
                routineInfo.EighthClassName = p.EighthClassName;

                routineInfo.FirstClassStart = p.FirstClassStart;
                routineInfo.FirstClassEnd = p.FirstClassEnd;
                routineInfo.SecondClassStart = p.SecondClassStart;
                routineInfo.SecondClassEnd = p.SecondClassEnd;
                routineInfo.ThirdClassStart = p.ThirdClassStart;
                routineInfo.ThirdClassEnd = p.ThirdClassEnd;
                routineInfo.ForthClassStart = p.ForthClassStart;
                routineInfo.ForthClassEnd = p.ForthClassEnd;
                routineInfo.FifthClassStart = p.FifthClassStart;
                routineInfo.FifthClassEnd = p.FifthClassEnd;
                routineInfo.SixthClassStart = p.SixthClassStart;
                routineInfo.SixthClassEnd = p.SixthClassEnd;
                routineInfo.SeventhClassStart = p.SeventhClassStart;
                routineInfo.SeventhClassEnd = p.SeventhClassEnd;
                routineInfo.EighthClassStart = p.EighthClassStart;
                routineInfo.EighthClassEnd = p.EighthClassEnd;



                routineInfo.FirstCourseName = p.FirstCourseName;
                routineInfo.SecondCourseName = p.SecondCourseName;
                routineInfo.ThirdCourseName = p.ThirdCourseName;
                routineInfo.ForthCourseName = p.ForthCourseName;
                routineInfo.FifthCourseName = p.FifthCourseName;
                routineInfo.SixthCourseName = p.SixthCourseName;
                routineInfo.SeventhCourseName = p.SeventhCourseName;
                routineInfo.EighthCourseName = p.EighthCourseName;


                routineInfo.FirstTeacherName = p.FirstTeacherName;
                routineInfo.SecondTeacherName = p.SecondTeacherName;
                routineInfo.ThirdTeacherrName = p.ThirdTeacherrName;
                routineInfo.ForthTeacherrName = p.ForthTeacherrName;
                routineInfo.FifthTeacherrName = p.FifthTeacherrName;
                routineInfo.SixthTeacherrName = p.SixthTeacherrName;
                routineInfo.SeventhTeacherrName = p.SeventhTeacherrName;
                routineInfo.EighthTeacherrName = p.EighthTeacherrName;

                routineInfo.Year = p.Year;
                routineInfo.ProgramName = p.ProgramName;
                routineInfo.DepartmentName = p.DepartmentName;
                routineInfo.SemesterNo = p.SemesterNo;



                createRoutineR.Add(routineInfo);
                
            }


            if (createRoutineR.Count > 0)
            {
                RoutineRepost riport = new RoutineRepost();
                ReportUtility.Display_report(riport, createRoutineR, this);
            }
            else
            {
                MessageBox.Show("Don't have any records.", "Employee Info", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            }
            
        }
    }
}
