using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.StudentManagement;

namespace DAL.StudentManagement
{
   
    public class ClassRoutineCreateGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public bool SaveClassRoutineByDay(CreateRoutine _createRoutine)
        {
            var classRoutine = (from p in datacontextObj.CREATE_ROUTINE
                           where (p.Day == _createRoutine.Day
                           && p.Year == _createRoutine.Year
                           && p.DepartmentId == _createRoutine.DepartmentId
                           && p.SemesterId == _createRoutine.SemesterId)
                           select p).Count();
            if (classRoutine < 1)
            {
                var newRoutinCreate = new CREATE_ROUTINE
                {
                    Day = _createRoutine.Day,
                    ClassRutinGroupId = _createRoutine.ClassRutinGroupId,

                    Year = _createRoutine.Year,
                    ProgramId = _createRoutine.ProgramId,
                    DepartmentId = _createRoutine.DepartmentId,
                    SemesterId = _createRoutine.SemesterId,

                    FirstClass = _createRoutine.FirstClass,
                    SecondClass = _createRoutine.SecondClass,
                    ThirdClass = _createRoutine.ThirdClass,
                    ForthClass = _createRoutine.ForthClass,
                    FifthClass = _createRoutine.FifthClass,
                    SixthClass = _createRoutine.SixthClass,
                    SeventhClass = _createRoutine.SeventhClass,
                    EighthClass = _createRoutine.EighthClass,


                    FirstCourse = _createRoutine.FirstCourse,
                    SecondCourse = _createRoutine.SecondCourse,
                    ThirdCourse = _createRoutine.ThirdCourse,
                    ForthCourse = _createRoutine.ForthCourse,
                    FifthCourse = _createRoutine.FifthCourse,
                    SixthCourse = _createRoutine.SixthCourse,
                    SeventhCourse = _createRoutine.SeventhCourse,
                    EighthCourse = _createRoutine.EighthCourse,


                    FirstTeacher = _createRoutine.FirstTeacher,
                    SecondTeacher = _createRoutine.SecondTeacher,
                    ThirdTeacher = _createRoutine.ThirdTeacher,
                    ForthTeacher = _createRoutine.ForthTeacher,
                    FifthTeacher = _createRoutine.FifthTeacher,
                    SixthTeacher = _createRoutine.SixthTeacher,
                    SeventhTeacher = _createRoutine.SeventhTeacher,
                    EighthTeacher = _createRoutine.EighthTeacher,
                };
                datacontextObj.CREATE_ROUTINE.Add(newRoutinCreate);
                datacontextObj.SaveChanges();
                return true;  
            }
            else
            {
                return false;

            }

            
        }

        public List<CreateRoutine> GetAllClassRoutine()
        {
            datacontextObj = new SIPIDBEntities();
            List<CreateRoutine> routineList = new List<CreateRoutine>();

             
           foreach (var p in (from j in datacontextObj.CREATE_ROUTINE select j).Distinct())
            {
                CreateRoutine createRoutine = new CreateRoutine();
 
                createRoutine.Id = p.Id;
                createRoutine.Day = p.Day;
                createRoutine.ClassRutinGroupId =  p.ClassRutinGroupId;

                createRoutine.FirstClass = p.FirstClass;
                createRoutine.FirstCourse = p.FirstCourse ;
                createRoutine.FirstTeacher= p.FirstTeacher ;
                createRoutine.FirstClassName = p.CLASSPERIOD.Period;
                createRoutine.FirstCourseName = p.COURSE.CourseName;
                createRoutine.FirstTeacherName = p.TEACHER.TeacherName;

                createRoutine.FirstClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.FirstClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SecondClass = p.SecondClass;
                createRoutine.SecondCourse= p.SecondCourse ;
                createRoutine.SecondTeacher= p.SecondTeacher ;
                createRoutine.SecondClassName = p.CLASSPERIOD1.Period;
                createRoutine.SecondCourseName = p.COURSE1.CourseName;
                createRoutine.SecondTeacherName = p.TEACHER1.TeacherName;

                createRoutine.SecondClassStart = p.CLASSPERIOD1.StartTime;
                createRoutine.SecondClassEnd = p.CLASSPERIOD.EndTime;
                
                createRoutine.ThirdClass= p.ThirdClass ;
                createRoutine.ThirdCourse= p.ThirdCourse ;
                createRoutine.ThirdTeacher= p.ThirdTeacher ;
                createRoutine.ThirdClassName = p.CLASSPERIOD2.Period;
                createRoutine.ThirdCourseName = p.COURSE2.CourseName;
                createRoutine.ThirdTeacherrName = p.TEACHER2.TeacherName;

                createRoutine.ThirdClassStart = p.CLASSPERIOD2.StartTime;
                createRoutine.ThirdClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ForthClass= p.ForthClass ;
                createRoutine.ForthCourse= p.ForthCourse ;
                createRoutine.ForthTeacher= p.ForthTeacher ;
                createRoutine.ForthClassName = p.CLASSPERIOD3.Period;
                createRoutine.ForthCourseName = p.COURSE3.CourseName;
                createRoutine.ForthTeacherrName = p.TEACHER3.TeacherName;

                createRoutine.ForthClassStart = p.CLASSPERIOD3.StartTime;
                createRoutine.ForthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.FifthClass= p.FifthClass ;
                createRoutine.FifthCourse= p.FifthCourse ;
                createRoutine.FifthTeacher= p.FifthTeacher ;
                createRoutine.FifthClassName = p.CLASSPERIOD4.Period;
                createRoutine.FifthCourseName = p.COURSE4.CourseName;
                createRoutine.FifthTeacherrName = p.TEACHER4.TeacherName;

                createRoutine.FifthClassStart = p.CLASSPERIOD4.StartTime;
                createRoutine.FifthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SixthClass= p.SixthClass ;
                createRoutine.SixthCourse= p.SixthCourse ;
                createRoutine.SixthTeacher= p.SixthTeacher ;
                createRoutine.SixthClassName = p.CLASSPERIOD5.Period;
                createRoutine.SixthCourseName = p.COURSE5.CourseName;
                createRoutine.SixthTeacherrName = p.TEACHER5.TeacherName;

                createRoutine.SixthClassStart = p.CLASSPERIOD5.StartTime;
                createRoutine.SixthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SeventhClass= p.SeventhClass ;
                createRoutine.SeventhCourse= p.SeventhCourse ;
                createRoutine.SeventhTeacher= p. SeventhTeacher;
                createRoutine.SeventhClassName = p.CLASSPERIOD6.Period;
                createRoutine.SeventhCourseName = p.COURSE6.CourseName;
                createRoutine.SeventhTeacherrName = p.TEACHER6.TeacherName;

                createRoutine.SeventhClassStart = p.CLASSPERIOD6.StartTime;
                createRoutine.SeventhClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.EighthClass= p.EighthClass ;
                createRoutine.EighthCourse= p. EighthCourse;
                createRoutine.EighthTeacher= p.EighthTeacher ;
                createRoutine.EighthClassName = p.CLASSPERIOD7.Period;
                createRoutine.EighthCourseName = p.COURSE7.CourseName;
                createRoutine.EighthTeacherrName = p.TEACHER7.TeacherName;

                createRoutine.EighthClassStart = p.CLASSPERIOD7.StartTime;
                createRoutine.EighthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.Year= p.Year ;
                createRoutine.ProgramId= p.ProgramId ;
                createRoutine.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;

                createRoutine.DepartmentId= p.DepartmentId ;
                createRoutine.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createRoutine.SemesterId = p.SemesterId;
                createRoutine.SemesterNo = p.SEMESTER.SemesterNo;

                
                routineList.Add(createRoutine);
            }

           return routineList;
        }

        public void DeleteCreateRoutine(CreateRoutine _createRoutine)
        {
            CREATE_ROUTINE createRoutine = datacontextObj.CREATE_ROUTINE.First(c => c.Id == _createRoutine.Id);
            datacontextObj.CREATE_ROUTINE.Remove(createRoutine);
            datacontextObj.SaveChanges();
        }

        public List<CreateRoutine> GetAllRoutineDepartment(string dept, string semester, string year)
        {  
            datacontextObj = new SIPIDBEntities();
            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();

            foreach (var p in (from j in datacontextObj.CREATE_ROUTINE
                               where j.SIPI_DEPARTMENT.SIPI_DepartmentName.StartsWith(dept) && j.SEMESTER.SemesterNo.StartsWith(semester) && j.Year.StartsWith(year)
                               select j).Distinct())
            {

                CreateRoutine createRoutine = new CreateRoutine();

                createRoutine.Id = p.Id;
                createRoutine.Day = p.Day;
                createRoutine.ClassRutinGroupId = p.ClassRutinGroupId;

                createRoutine.FirstClass = p.FirstClass;
                createRoutine.FirstCourse = p.FirstCourse;
                createRoutine.FirstTeacher = p.FirstTeacher;
                createRoutine.FirstClassName = p.CLASSPERIOD.Period;
                createRoutine.FirstCourseName = p.COURSE.CourseName;
                createRoutine.FirstTeacherName = p.TEACHER.TeacherName;

                createRoutine.FirstClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.FirstClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SecondClass = p.SecondClass;
                createRoutine.SecondCourse = p.SecondCourse;
                createRoutine.SecondTeacher = p.SecondTeacher;
                createRoutine.SecondClassName = p.CLASSPERIOD1.Period;
                createRoutine.SecondCourseName = p.COURSE1.CourseName;
                createRoutine.SecondTeacherName = p.TEACHER1.TeacherName;

                createRoutine.SecondClassStart = p.CLASSPERIOD1.StartTime;
                createRoutine.SecondClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ThirdClass = p.ThirdClass;
                createRoutine.ThirdCourse = p.ThirdCourse;
                createRoutine.ThirdTeacher = p.ThirdTeacher;
                createRoutine.ThirdClassName = p.CLASSPERIOD2.Period;
                createRoutine.ThirdCourseName = p.COURSE2.CourseName;
                createRoutine.ThirdTeacherrName = p.TEACHER2.TeacherName;

                createRoutine.ThirdClassStart = p.CLASSPERIOD2.StartTime;
                createRoutine.ThirdClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ForthClass = p.ForthClass;
                createRoutine.ForthCourse = p.ForthCourse;
                createRoutine.ForthTeacher = p.ForthTeacher;
                createRoutine.ForthClassName = p.CLASSPERIOD3.Period;
                createRoutine.ForthCourseName = p.COURSE3.CourseName;
                createRoutine.ForthTeacherrName = p.TEACHER3.TeacherName;

                createRoutine.ForthClassStart = p.CLASSPERIOD3.StartTime;
                createRoutine.ForthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.FifthClass = p.FifthClass;
                createRoutine.FifthCourse = p.FifthCourse;
                createRoutine.FifthTeacher = p.FifthTeacher;
                createRoutine.FifthClassName = p.CLASSPERIOD4.Period;
                createRoutine.FifthCourseName = p.COURSE4.CourseName;
                createRoutine.FifthTeacherrName = p.TEACHER4.TeacherName;

                createRoutine.FifthClassStart = p.CLASSPERIOD4.StartTime;
                createRoutine.FifthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SixthClass = p.SixthClass;
                createRoutine.SixthCourse = p.SixthCourse;
                createRoutine.SixthTeacher = p.SixthTeacher;
                createRoutine.SixthClassName = p.CLASSPERIOD5.Period;
                createRoutine.SixthCourseName = p.COURSE5.CourseName;
                createRoutine.SixthTeacherrName = p.TEACHER5.TeacherName;

                createRoutine.SixthClassStart = p.CLASSPERIOD5.StartTime;
                createRoutine.SixthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SeventhClass = p.SeventhClass;
                createRoutine.SeventhCourse = p.SeventhCourse;
                createRoutine.SeventhTeacher = p.SeventhTeacher;
                createRoutine.SeventhClassName = p.CLASSPERIOD6.Period;
                createRoutine.SeventhCourseName = p.COURSE6.CourseName;
                createRoutine.SeventhTeacherrName = p.TEACHER6.TeacherName;

                createRoutine.SeventhClassStart = p.CLASSPERIOD6.StartTime;
                createRoutine.SeventhClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.EighthClass = p.EighthClass;
                createRoutine.EighthCourse = p.EighthCourse;
                createRoutine.EighthTeacher = p.EighthTeacher;
                createRoutine.EighthClassName = p.CLASSPERIOD7.Period;
                createRoutine.EighthCourseName = p.COURSE7.CourseName;
                createRoutine.EighthTeacherrName = p.TEACHER7.TeacherName;

                createRoutine.EighthClassStart = p.CLASSPERIOD7.StartTime;
                createRoutine.EighthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.Year = p.Year;
                createRoutine.ProgramId = p.ProgramId;
                createRoutine.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;

                createRoutine.DepartmentId = p.DepartmentId;
                createRoutine.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createRoutine.SemesterId = p.SemesterId;
                createRoutine.SemesterNo = p.SEMESTER.SemesterNo;
                studentInfoList.Add(createRoutine);
            }

            return studentInfoList;
        }

        public List<CreateRoutine> GetAllRoutineSemester(string semester)
        {
            datacontextObj = new SIPIDBEntities();
            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();

            foreach (var p in (from j in datacontextObj.CREATE_ROUTINE
                               where j.SEMESTER.SemesterNo.StartsWith(semester)
                               select j).Distinct())
            {

                CreateRoutine createRoutine = new CreateRoutine();
                createRoutine.Id = p.Id;
                createRoutine.Day = p.Day;
                createRoutine.ClassRutinGroupId = p.ClassRutinGroupId;

                createRoutine.FirstClass = p.FirstClass;
                createRoutine.FirstCourse = p.FirstCourse;
                createRoutine.FirstTeacher = p.FirstTeacher;
                createRoutine.FirstClassName = p.CLASSPERIOD.Period;
                createRoutine.FirstCourseName = p.COURSE.CourseName;
                createRoutine.FirstTeacherName = p.TEACHER.TeacherName;

                createRoutine.FirstClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.FirstClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SecondClass = p.SecondClass;
                createRoutine.SecondCourse = p.SecondCourse;
                createRoutine.SecondTeacher = p.SecondTeacher;
                createRoutine.SecondClassName = p.CLASSPERIOD1.Period;
                createRoutine.SecondCourseName = p.COURSE1.CourseName;
                createRoutine.SecondTeacherName = p.TEACHER1.TeacherName;

                createRoutine.SecondClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.SecondClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ThirdClass = p.ThirdClass;
                createRoutine.ThirdCourse = p.ThirdCourse;
                createRoutine.ThirdTeacher = p.ThirdTeacher;
                createRoutine.ThirdClassName = p.CLASSPERIOD2.Period;
                createRoutine.ThirdCourseName = p.COURSE2.CourseName;
                createRoutine.ThirdTeacherrName = p.TEACHER2.TeacherName;

                createRoutine.ThirdClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.ThirdClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ForthClass = p.ForthClass;
                createRoutine.ForthCourse = p.ForthCourse;
                createRoutine.ForthTeacher = p.ForthTeacher;
                createRoutine.ForthClassName = p.CLASSPERIOD3.Period;
                createRoutine.ForthCourseName = p.COURSE3.CourseName;
                createRoutine.ForthTeacherrName = p.TEACHER3.TeacherName;

                createRoutine.ForthClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.ForthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.FifthClass = p.FifthClass;
                createRoutine.FifthCourse = p.FifthCourse;
                createRoutine.FifthTeacher = p.FifthTeacher;
                createRoutine.FifthClassName = p.CLASSPERIOD4.Period;
                createRoutine.FifthCourseName = p.COURSE4.CourseName;
                createRoutine.FifthTeacherrName = p.TEACHER4.TeacherName;

                createRoutine.FifthClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.FifthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SixthClass = p.SixthClass;
                createRoutine.SixthCourse = p.SixthCourse;
                createRoutine.SixthTeacher = p.SixthTeacher;
                createRoutine.SixthClassName = p.CLASSPERIOD5.Period;
                createRoutine.SixthCourseName = p.COURSE5.CourseName;
                createRoutine.SixthTeacherrName = p.TEACHER5.TeacherName;

                createRoutine.SixthClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.SixthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SeventhClass = p.SeventhClass;
                createRoutine.SeventhCourse = p.SeventhCourse;
                createRoutine.SeventhTeacher = p.SeventhTeacher;
                createRoutine.SeventhClassName = p.CLASSPERIOD6.Period;
                createRoutine.SeventhCourseName = p.COURSE6.CourseName;
                createRoutine.SeventhTeacherrName = p.TEACHER6.TeacherName;

                createRoutine.SeventhClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.SeventhClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.EighthClass = p.EighthClass;
                createRoutine.EighthCourse = p.EighthCourse;
                createRoutine.EighthTeacher = p.EighthTeacher;
                createRoutine.EighthClassName = p.CLASSPERIOD7.Period;
                createRoutine.EighthCourseName = p.COURSE7.CourseName;
                createRoutine.EighthTeacherrName = p.TEACHER7.TeacherName;

                createRoutine.EighthClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.EighthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.Year = p.Year;
                createRoutine.ProgramId = p.ProgramId;
                createRoutine.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;

                createRoutine.DepartmentId = p.DepartmentId;
                createRoutine.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createRoutine.SemesterId = p.SemesterId;
                createRoutine.SemesterNo = p.SEMESTER.SemesterNo;
                studentInfoList.Add(createRoutine);
            }

            return studentInfoList;
        }


        public bool GetTeacherduplicacychecke(string year, int classTime, string day, int teacherName)
        {
            List<CreateRoutine> routineInfoList = new List<CreateRoutine>();

            foreach (var p in (from j in datacontextObj.CREATE_ROUTINE
                               where
                               j.Year.Equals(year)
                               && j.FirstClass.Equals(classTime)
                               && j.Day.Equals(day)
                               && j.FirstTeacher.Equals(teacherName)
                               select j).Distinct())
            {

                CreateRoutine createRoutine = new CreateRoutine();
               
                createRoutine.Id = p.Id;
                createRoutine.Day = p.Day;
                createRoutine.ClassRutinGroupId = p.ClassRutinGroupId;

                createRoutine.FirstClass = p.FirstClass;
                createRoutine.FirstCourse = p.FirstCourse;
                createRoutine.FirstTeacher = p.FirstTeacher;
                createRoutine.FirstClassName = p.CLASSPERIOD.Period;
                createRoutine.FirstCourseName = p.COURSE.CourseName;
                createRoutine.FirstTeacherName = p.TEACHER.TeacherName;

                createRoutine.FirstClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.FirstClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SecondClass = p.SecondClass;
                createRoutine.SecondCourse = p.SecondCourse;
                createRoutine.SecondTeacher = p.SecondTeacher;
                createRoutine.SecondClassName = p.CLASSPERIOD1.Period;
                createRoutine.SecondCourseName = p.COURSE1.CourseName;
                createRoutine.SecondTeacherName = p.TEACHER1.TeacherName;

                createRoutine.SecondClassStart = p.CLASSPERIOD1.StartTime;
                createRoutine.SecondClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ThirdClass = p.ThirdClass;
                createRoutine.ThirdCourse = p.ThirdCourse;
                createRoutine.ThirdTeacher = p.ThirdTeacher;
                createRoutine.ThirdClassName = p.CLASSPERIOD2.Period;
                createRoutine.ThirdCourseName = p.COURSE2.CourseName;
                createRoutine.ThirdTeacherrName = p.TEACHER2.TeacherName;

                createRoutine.ThirdClassStart = p.CLASSPERIOD2.StartTime;
                createRoutine.ThirdClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ForthClass = p.ForthClass;
                createRoutine.ForthCourse = p.ForthCourse;
                createRoutine.ForthTeacher = p.ForthTeacher;
                createRoutine.ForthClassName = p.CLASSPERIOD3.Period;
                createRoutine.ForthCourseName = p.COURSE3.CourseName;
                createRoutine.ForthTeacherrName = p.TEACHER3.TeacherName;

                createRoutine.ForthClassStart = p.CLASSPERIOD3.StartTime;
                createRoutine.ForthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.FifthClass = p.FifthClass;
                createRoutine.FifthCourse = p.FifthCourse;
                createRoutine.FifthTeacher = p.FifthTeacher;
                createRoutine.FifthClassName = p.CLASSPERIOD4.Period;
                createRoutine.FifthCourseName = p.COURSE4.CourseName;
                createRoutine.FifthTeacherrName = p.TEACHER4.TeacherName;

                createRoutine.FifthClassStart = p.CLASSPERIOD4.StartTime;
                createRoutine.FifthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SixthClass = p.SixthClass;
                createRoutine.SixthCourse = p.SixthCourse;
                createRoutine.SixthTeacher = p.SixthTeacher;
                createRoutine.SixthClassName = p.CLASSPERIOD5.Period;
                createRoutine.SixthCourseName = p.COURSE5.CourseName;
                createRoutine.SixthTeacherrName = p.TEACHER5.TeacherName;

                createRoutine.SixthClassStart = p.CLASSPERIOD5.StartTime;
                createRoutine.SixthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SeventhClass = p.SeventhClass;
                createRoutine.SeventhCourse = p.SeventhCourse;
                createRoutine.SeventhTeacher = p.SeventhTeacher;
                createRoutine.SeventhClassName = p.CLASSPERIOD6.Period;
                createRoutine.SeventhCourseName = p.COURSE6.CourseName;
                createRoutine.SeventhTeacherrName = p.TEACHER6.TeacherName;

                createRoutine.SeventhClassStart = p.CLASSPERIOD6.StartTime;
                createRoutine.SeventhClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.EighthClass = p.EighthClass;
                createRoutine.EighthCourse = p.EighthCourse;
                createRoutine.EighthTeacher = p.EighthTeacher;
                createRoutine.EighthClassName = p.CLASSPERIOD7.Period;
                createRoutine.EighthCourseName = p.COURSE7.CourseName;
                createRoutine.EighthTeacherrName = p.TEACHER7.TeacherName;

                createRoutine.EighthClassStart = p.CLASSPERIOD7.StartTime;
                createRoutine.EighthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.Year = p.Year;
                createRoutine.ProgramId = p.ProgramId;
                createRoutine.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;

                createRoutine.DepartmentId = p.DepartmentId;
                createRoutine.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createRoutine.SemesterId = p.SemesterId;
                createRoutine.SemesterNo = p.SEMESTER.SemesterNo; ;
                routineInfoList.Add(createRoutine);
            }

            return true;
        }

        public bool GetTeacherduplicacychecke(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool GetTeacherduplicacycheckesecondTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var  teacher =   (from j in datacontextObj.CREATE_ROUTINE
                               where
                               j.Year.Equals(year)
                               && j.CLASSPERIOD1.StartTime.Equals(classTimeSchasule)
                               && j.Day.Equals(day)
                               && j.TEACHER1.TeacherName.Equals(teacherName)
                               select j).Count();
            if (teacher > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTeacherduplicacycheckeThirdTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD2.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER2.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTeacherduplicacycheckeForthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD3.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER3.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTeacherduplicacycheckeFifthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD4.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER4.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTeacherduplicacycheckeSixthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD5.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER5.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTeacherduplicacycheckeSeventhTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD6.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER6.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTeacherduplicacycheckeEighthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            datacontextObj = new SIPIDBEntities();

            List<CreateRoutine> studentInfoList = new List<CreateRoutine>();
            var teacher = (from j in datacontextObj.CREATE_ROUTINE
                           where
                           j.Year.Equals(year)
                           && j.CLASSPERIOD7.StartTime.Equals(classTimeSchasule)
                           && j.Day.Equals(day)
                           && j.TEACHER7.TeacherName.Equals(teacherName)
                           select j).Count();
            if (teacher > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CreateRoutine> GetTeacherAssignedCourse(string teacherName)
        {
            datacontextObj = new SIPIDBEntities();
            List<CreateRoutine> routineList = new List<CreateRoutine>();

            foreach (var p in (from j in datacontextObj.CREATE_ROUTINE
                               where j.TEACHER.TeacherName.Equals(teacherName) 
                               || j.TEACHER1.TeacherName.Equals(teacherName)
                               || j.TEACHER2.TeacherName.Equals(teacherName)
                               || j.TEACHER3.TeacherName.Equals(teacherName)
                               || j.TEACHER4.TeacherName.Equals(teacherName)
                               || j.TEACHER5.TeacherName.Equals(teacherName)
                               || j.TEACHER6.TeacherName.Equals(teacherName) 
                               || j.TEACHER7.TeacherName.Equals(teacherName)
                               select j).Distinct())
            {
                CreateRoutine createRoutine = new CreateRoutine();

                createRoutine.Id = p.Id;
                createRoutine.Day = p.Day;
                createRoutine.ClassRutinGroupId = p.ClassRutinGroupId;

                createRoutine.FirstClass = p.FirstClass;
                createRoutine.FirstCourse = p.FirstCourse;
                createRoutine.FirstTeacher = p.FirstTeacher;
                createRoutine.FirstClassName = p.CLASSPERIOD.Period;
                createRoutine.FirstCourseName = p.COURSE.CourseName;
                createRoutine.FirstTeacherName = p.TEACHER.TeacherName;

                createRoutine.FirstClassStart = p.CLASSPERIOD.StartTime;
                createRoutine.FirstClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SecondClass = p.SecondClass;
                createRoutine.SecondCourse = p.SecondCourse;
                createRoutine.SecondTeacher = p.SecondTeacher;
                createRoutine.SecondClassName = p.CLASSPERIOD1.Period;
                createRoutine.SecondCourseName = p.COURSE1.CourseName;
                createRoutine.SecondTeacherName = p.TEACHER1.TeacherName;

                createRoutine.SecondClassStart = p.CLASSPERIOD1.StartTime;
                createRoutine.SecondClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ThirdClass = p.ThirdClass;
                createRoutine.ThirdCourse = p.ThirdCourse;
                createRoutine.ThirdTeacher = p.ThirdTeacher;
                createRoutine.ThirdClassName = p.CLASSPERIOD2.Period;
                createRoutine.ThirdCourseName = p.COURSE2.CourseName;
                createRoutine.ThirdTeacherrName = p.TEACHER2.TeacherName;

                createRoutine.ThirdClassStart = p.CLASSPERIOD2.StartTime;
                createRoutine.ThirdClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.ForthClass = p.ForthClass;
                createRoutine.ForthCourse = p.ForthCourse;
                createRoutine.ForthTeacher = p.ForthTeacher;
                createRoutine.ForthClassName = p.CLASSPERIOD3.Period;
                createRoutine.ForthCourseName = p.COURSE3.CourseName;
                createRoutine.ForthTeacherrName = p.TEACHER3.TeacherName;

                createRoutine.ForthClassStart = p.CLASSPERIOD3.StartTime;
                createRoutine.ForthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.FifthClass = p.FifthClass;
                createRoutine.FifthCourse = p.FifthCourse;
                createRoutine.FifthTeacher = p.FifthTeacher;
                createRoutine.FifthClassName = p.CLASSPERIOD4.Period;
                createRoutine.FifthCourseName = p.COURSE4.CourseName;
                createRoutine.FifthTeacherrName = p.TEACHER4.TeacherName;

                createRoutine.FifthClassStart = p.CLASSPERIOD4.StartTime;
                createRoutine.FifthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SixthClass = p.SixthClass;
                createRoutine.SixthCourse = p.SixthCourse;
                createRoutine.SixthTeacher = p.SixthTeacher;
                createRoutine.SixthClassName = p.CLASSPERIOD5.Period;
                createRoutine.SixthCourseName = p.COURSE5.CourseName;
                createRoutine.SixthTeacherrName = p.TEACHER5.TeacherName;

                createRoutine.SixthClassStart = p.CLASSPERIOD5.StartTime;
                createRoutine.SixthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.SeventhClass = p.SeventhClass;
                createRoutine.SeventhCourse = p.SeventhCourse;
                createRoutine.SeventhTeacher = p.SeventhTeacher;
                createRoutine.SeventhClassName = p.CLASSPERIOD6.Period;
                createRoutine.SeventhCourseName = p.COURSE6.CourseName;
                createRoutine.SeventhTeacherrName = p.TEACHER6.TeacherName;

                createRoutine.SeventhClassStart = p.CLASSPERIOD6.StartTime;
                createRoutine.SeventhClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.EighthClass = p.EighthClass;
                createRoutine.EighthCourse = p.EighthCourse;
                createRoutine.EighthTeacher = p.EighthTeacher;
                createRoutine.EighthClassName = p.CLASSPERIOD7.Period;
                createRoutine.EighthCourseName = p.COURSE7.CourseName;
                createRoutine.EighthTeacherrName = p.TEACHER7.TeacherName;

                createRoutine.EighthClassStart = p.CLASSPERIOD7.StartTime;
                createRoutine.EighthClassEnd = p.CLASSPERIOD.EndTime;

                createRoutine.Year = p.Year;
                createRoutine.ProgramId = p.ProgramId;
                createRoutine.ProgramName = p.SIPI_PROGRAM.SIPI_ProgramName;

                createRoutine.DepartmentId = p.DepartmentId;
                createRoutine.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                createRoutine.SemesterId = p.SemesterId;
                createRoutine.SemesterNo = p.SEMESTER.SemesterNo;
                routineList.Add(createRoutine);
            }
            return routineList;
        }
    }
}
