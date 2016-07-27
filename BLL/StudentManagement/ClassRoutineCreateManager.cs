using ENTITY.StudentManagement;
using DAL.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentManagement
{
    public class ClassRoutineCreateManager
    {
        ClassRoutineCreateGetway _classRoutineCreateGetway = new ClassRoutineCreateGetway();



        public bool SaveClassRoutineByDay(CreateRoutine _createRoutine)
        {
            return   _classRoutineCreateGetway.SaveClassRoutineByDay(_createRoutine);
        }

        public List<CreateRoutine> GetAllClassRoutine()
        {
            return _classRoutineCreateGetway.GetAllClassRoutine();
        }

        public void DeleteCreateRoutine(CreateRoutine _createRoutine)
        {
            _classRoutineCreateGetway.DeleteCreateRoutine(_createRoutine);
        }

        public List<CreateRoutine> GetAllRoutineDepartment(string dept, string semester, string year)
        {
            return _classRoutineCreateGetway.GetAllRoutineDepartment(dept, semester, year);
        }

        public List<CreateRoutine> GetAllRoutineSemester(string semester)
        {
            return _classRoutineCreateGetway.GetAllRoutineSemester(semester);
        }

        //public bool GetTeacherduplicacychecke(string year, int classTime, string day, int teacherName)
        //{
        //    return _classRoutineCreateGetway.GetTeacherduplicacychecke(year, classTime, day, teacherName);
        //}

        public bool GetTeacherduplicacychecke(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacychecke(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckesecondTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckesecondTeacher(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckeThirdTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckeThirdTeacher(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckeForthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckeForthTeacher(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckeFifthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckeFifthTeacher(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckeSixthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckeSixthTeacher(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckeSeventhTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckeSeventhTeacher(year, classTimeSchasule, day, teacherName);
        }

        public bool GetTeacherduplicacycheckeEighthTeacher(string year, string classTimeSchasule, string day, string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherduplicacycheckeEighthTeacher(year, classTimeSchasule, day, teacherName);
        }



        public List<CreateRoutine> GetTeacherAssignedCourse(string teacherName)
        {
            return _classRoutineCreateGetway.GetTeacherAssignedCourse(teacherName);
        }
    }
}
