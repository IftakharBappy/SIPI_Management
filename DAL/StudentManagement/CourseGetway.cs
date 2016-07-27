using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.StudentManagement;
using DATA;
using ENTITY.ResultManagement;


namespace DAL.StudentManagement
{
    public class CourseGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();


        public void SaveCourse(Course _courseObj)
        {
            var newCourse = new COURSE
            {
                CourseName = _courseObj.CourseName,
                BanglaCourseName = _courseObj.BanglaCourseName,
                DepartmentId =_courseObj.DepartmentId,
                ProgramId = _courseObj.ProgramId,
                SemesterId = _courseObj.SemesterId,
                CourseCode = _courseObj.CourseCode,

                TheoryCredit =(decimal)_courseObj.TheoryCredit,
                PracticalCredit = (decimal)_courseObj.PracticalCredit,
                TotalCredit = (decimal)_courseObj.TotalCredit,

                TheoryMarkasContinuousAssessment = (decimal)_courseObj.TheoryMarkasContinuousAssessment,
                TheoryMarkasFinalExam = (decimal)_courseObj.TheoryMarkasFinalExam,
                PracticalMarkasContinuousAssessment = (decimal)_courseObj.PracticalMarkasContinuousAssessment,
                PracticalMarkasFinalExam = (decimal)_courseObj.PracticalMarkasFinalExam,
                TotalMarks = (decimal)_courseObj.TotalMarks,
            };
            datacontextObj.COURSEs.Add(newCourse);
            datacontextObj.SaveChanges();
        }

        public List<Course> GetAllCourse()
        {
            datacontextObj = new SIPIDBEntities();
            List<Course> CourseList = new List<Course>();
            foreach (var p in (from j in datacontextObj.COURSEs select j).Distinct())
            {
                Course courseObj = new Course();
                courseObj.Id = p.Id;
                courseObj.CourseName = p.CourseName;
                courseObj.BanglaCourseName = p.BanglaCourseName;

                courseObj.DepartmentId = p.DepartmentId;
                courseObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName ;

                courseObj.ProgramId = p.ProgramId;
                courseObj.ProgramName =  p.SIPI_PROGRAM.SIPI_ProgramName;

                courseObj.SemesterId = p.SemesterId;
                courseObj.SemesterNo = p.SEMESTER.SemesterNo;
                
                courseObj.CourseCode = p.CourseCode;
                courseObj.TheoryCredit = Convert.ToDouble(p.TheoryCredit);
                courseObj.PracticalCredit = Convert.ToDouble(p.PracticalCredit);
                courseObj.TotalCredit = Convert.ToDouble(p.TotalCredit);
                courseObj.TheoryMarkasContinuousAssessment = Convert.ToDouble(p.TheoryMarkasContinuousAssessment);
                courseObj.TheoryMarkasFinalExam = Convert.ToDouble(p.TheoryMarkasFinalExam);
                courseObj.PracticalMarkasContinuousAssessment = Convert.ToDouble(p.PracticalMarkasContinuousAssessment);
                courseObj.PracticalMarkasFinalExam = Convert.ToDouble(p.PracticalMarkasFinalExam);

                courseObj.TotalMarks = Convert.ToDouble(p.TotalMarks);

                



                CourseList.Add(courseObj);
            }

            return CourseList;
        }

        public void DeleteSemester(Course _courseObj)
        {
            COURSE course = datacontextObj.COURSEs.First(c => c.Id == _courseObj.Id);
            datacontextObj.COURSEs.Remove(course);
            datacontextObj.SaveChanges();
        }

        public void UpdateSemester(Course _courseObj)
        {
            var course = datacontextObj.COURSEs.First(c => c.Id == _courseObj.Id);
            course.CourseName = _courseObj.CourseName;
            course.BanglaCourseName = _courseObj.BanglaCourseName;
            course.ProgramId = _courseObj.ProgramId;
            course.DepartmentId = _courseObj.DepartmentId;
            course.SemesterId = _courseObj.SemesterId;

            datacontextObj.SaveChanges();
        }

        public List<Course> GetAllCourseByDepartment(string dept, string semester)
        {
            datacontextObj = new SIPIDBEntities();
            List<Course> CourseList = new List<Course>();

            foreach (var p in (from j in datacontextObj.COURSEs
                               where j.SIPI_DEPARTMENT.SIPI_DepartmentName.StartsWith(dept) 
                               //&& j.SEMESTER.SemesterNo.StartsWith(semester)
                               select j).Distinct())
            
            {
                Course courseObj = new Course();
                courseObj.Id = p.Id;
                courseObj.CourseName = p.CourseName;
                courseObj.BanglaCourseName = p.BanglaCourseName;

                courseObj.DepartmentId = p.DepartmentId;
                courseObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName ;

                courseObj.ProgramId = p.ProgramId;
                courseObj.ProgramName =  p.SIPI_PROGRAM.SIPI_ProgramName;

                courseObj.SemesterId = p.SemesterId;
                courseObj.SemesterNo = p.SEMESTER.SemesterNo;
                
                courseObj.CourseCode = p.CourseCode;
                courseObj.TheoryCredit = Convert.ToDouble(p.TheoryCredit);
                courseObj.PracticalCredit = Convert.ToDouble(p.PracticalCredit);
                courseObj.TotalCredit = Convert.ToDouble(p.TotalCredit);
                courseObj.TheoryMarkasContinuousAssessment = Convert.ToDouble(p.TheoryMarkasContinuousAssessment);
                courseObj.TheoryMarkasFinalExam = Convert.ToDouble(p.TheoryMarkasFinalExam);
                courseObj.PracticalMarkasContinuousAssessment = Convert.ToDouble(p.PracticalMarkasContinuousAssessment);
                courseObj.PracticalMarkasFinalExam = Convert.ToDouble(p.PracticalMarkasFinalExam);

                courseObj.TotalMarks = Convert.ToDouble(p.TotalMarks);

                



                CourseList.Add(courseObj);
            }

            return CourseList;
        
        }

        public List<Course> GetAllCourse(int id)
        {
            List<Course> courseList = new List<Course>();

            // -1 for all categories
            if (id == -1)
            {
                foreach (var p in (from j in datacontextObj.COURSEs
                                   select new
                                   {
                                       j.Id,
                                       j.CourseName,
                                       j.CourseCode,
                                       j.BanglaCourseName,
                                       j.DepartmentId,
                                   }).Distinct())
                {

                    Course courseObj = new Course();
                    courseObj.Id = p.Id;
                    courseObj.CourseName = p.CourseName;
                    courseObj.CourseCode = p.CourseCode;
                    courseObj.BanglaCourseName = p.BanglaCourseName;
                    courseObj.DepartmentId = p.DepartmentId;

                    courseList.Add(courseObj);
                }
            }

            else
            {

                foreach (var p in (from j in datacontextObj.COURSEs
                                   where j.DepartmentId == id
                                   select new
                                   {
                                       j.Id,
                                       j.CourseName,
                                       j.CourseCode,
                                       j.BanglaCourseName,
                                       j.DepartmentId,
                                   }).Distinct())
                {
                    Course courseObj = new Course();
                    courseObj.Id = p.Id;
                    courseObj.CourseName = p.CourseName;
                    courseObj.CourseCode = p.CourseCode;
                    courseObj.BanglaCourseName = p.BanglaCourseName;
                    courseObj.DepartmentId = p.DepartmentId;

                    courseList.Add(courseObj);

                }
            }

            return courseList;
            
          
        }


        public List<Course> GetAllCourseBysemesterDept(int SemesID, int deptId)
        {
            List<Course> courseList = new List<Course>();

            // -1 for all categories
            if (SemesID == -1)
            {
                foreach (var p in (from j in datacontextObj.COURSEs
                                   select new
                                   {
                                       j.Id,
                                       j.CourseName,
                                       j.CourseCode,
                                       j.BanglaCourseName,
                                       j.DepartmentId,
                                   }).Distinct())
                {

                    Course courseObj = new Course();
                    courseObj.Id = p.Id;
                    courseObj.CourseName = p.CourseName;
                    courseObj.CourseCode = p.CourseCode;
                    courseObj.BanglaCourseName = p.BanglaCourseName;
                    courseObj.DepartmentId = p.DepartmentId;

                    courseList.Add(courseObj);
                }
            }

            else
            {

                foreach (var p in (from j in datacontextObj.COURSEs
                                   where j.SemesterId == SemesID && j.DepartmentId == deptId
                                   select new
                                   {
                                       j.Id,
                                       j.CourseName,
                                       j.CourseCode,
                                       j.BanglaCourseName,
                                       j.DepartmentId,
                                   }).Distinct())
                {
                    Course courseObj = new Course();
                    courseObj.Id = p.Id;
                    courseObj.CourseName = p.CourseName;
                    courseObj.CourseCode = p.CourseCode;
                    courseObj.BanglaCourseName = p.BanglaCourseName;
                    courseObj.DepartmentId = p.DepartmentId;

                    courseList.Add(courseObj);

                }
            }

            return courseList;
        }

        public List<Course> GetCourseBydeptSemester(string dept, string sem)
        {
             datacontextObj = new SIPIDBEntities();
             List<Course> courseList = new List<Course>();

            foreach (var p in (from j in datacontextObj.COURSEs
                               where j.SEMESTER.SemesterNo.Equals(sem) && j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept)
                               select j).Distinct())
	            {
                        Course courseObj = new Course();
                        courseObj.Id = p.Id;
                        courseObj.CourseName = p.CourseName;
                        courseObj.CourseCode = p.CourseCode;
                        courseObj.TotalCredit = (int) p.TotalCredit;
                        courseObj.TotalMarks =(int) p.TotalMarks;
                        courseObj.BanglaCourseName = p.BanglaCourseName;
                        courseObj.DepartmentId = p.DepartmentId;
                        courseObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                        courseObj.SemesterNo = p.SEMESTER.SemesterNo;
                        courseList.Add(courseObj);
                  
	            }
            return courseList;
             }


        //public List<Course> GetAssignedCourse()
        //{
        //    datacontextObj = new SIPIDBEntities();
        //    List<Course> courseList = new List<Course>();

        //    foreach (var p in (from j in datacontextObj.STUDENT_RESULT
        //                       select new { j.SEMESTER.SemesterNo , j.SIPI_DEPARTMENT.SIPI_DepartmentName, j.YEAR.Year1}).Distinct())
        //    {
        //        ResultManagement courseObj = new ResultManagement();
        //        //courseObj.Id = p.Id;
        //        //courseObj.CourseName = p.CourseName;
        //        //courseObj.CourseCode = p.CourseCode;
        //        //courseObj.TotalCredit = (int)p.TotalCredit;
        //        //courseObj.TotalMarks = (int)p.TotalMarks;
        //        //courseObj.BanglaCourseName = p.BanglaCourseName;
        //        //courseObj.DepartmentId = p.DepartmentId;
        //        //courseObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
        //        //courseObj.SemesterNo = p.SEMESTER.SemesterNo;
        //        courseList.Add(courseObj);
        //    }
        //    return courseList;
        //}

        public List<StudentResult> GetAssignedCourse()
        {
            datacontextObj = new SIPIDBEntities();
            List<StudentResult> assigncourseList = new List<StudentResult>();

            foreach (var p in (from j in datacontextObj.STUDENT_RESULT
                               select new { j.SEMESTER.SemesterNo, j.SIPI_DEPARTMENT.SIPI_DepartmentName, j.YearId }).Distinct())
            {
                StudentResult studentResultObj = new StudentResult();
                studentResultObj.DepartmentName = p.SIPI_DepartmentName;
                studentResultObj.SemesterNo = p.SemesterNo;
                studentResultObj.YearNo =(int) p.YearId;
                assigncourseList.Add(studentResultObj);
            }
            return assigncourseList;
        }
    }
}
