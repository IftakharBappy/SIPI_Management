using DATA;
using ENTITY.ResultManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ResultManagement
{
    public class StudentResultGetwey
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        public void SaveAssignedStudent(List<StudentResult> _studentResultList)
        {
            foreach (StudentResult item in _studentResultList)
            {
                var newstudentResultCourse = new STUDENT_RESULT
                    {
                        StudentPKId = item.StudentPKId,
                        DepartmentId = item.DepartmentId,
                        SemesterId = item.SemesterId,
                        YearId = item.YearNo,
                        CourseId = item.CourseId
                    };
                    datacontextObj.STUDENT_RESULT.Add(newstudentResultCourse);
                    datacontextObj.SaveChanges();
            }

            
        }

        public List<StudentResult> GetStudentForMarks(string dept, string sem, int year, string course)
        {
            try
            {
                //int yearInt = Convert.ToInt16(year);
                datacontextObj = new SIPIDBEntities();
                List<StudentResult> studentResultList = new List<StudentResult>();
                foreach (var p in (from j in datacontextObj.STUDENT_RESULT
                                   where j.SEMESTER.SemesterNo.Equals(sem) &&
                                   j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept) &&
                                   j.COURSE.CourseName.Equals(course) &&
                                  j.YearId.Equals(year)
                                   select j).Distinct())
                {
                    StudentResult studentResultObj = new StudentResult();
                    studentResultObj.Id = p.Id;
                    studentResultObj.StudentId = p.ADMISSIONINFO.StudentID;
                    studentResultObj.StudentPKId = p.StudentPKId;
                    studentResultObj.StudentName = p.ADMISSIONINFO.ApplicantName;
                    studentResultObj.CourseName = p.COURSE.CourseName;
                    studentResultObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                    studentResultObj.SemesterNo = p.SEMESTER.SemesterNo;
                    if (p.PracticalMarksConAssess != null)
                    {
                    studentResultObj.PracticalMarksConAssess =(int) p.PracticalMarksConAssess;
                        
                    }
                    if (p.TheoryMarksConAssess != null)
                    {
                        studentResultObj.TheoryMarksConAssess = (int)p.TheoryMarksConAssess;
                        
                    }
                    if (p.PracticalMarksFinalExam != null)
                    {
                        studentResultObj.PracticalMarksFinalExam = (int)p.PracticalMarksFinalExam;
                        
                    }
                    if (p.TheoryMarksFinalExam != null)
                    {
                        studentResultObj.TheoryMarksFinalExam = (int)p.TheoryMarksFinalExam;
                    }
                    studentResultList.Add(studentResultObj);

                }
                return studentResultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }

        public void UpdateMarks(List<StudentResult> _StudentResultList)
        {

                foreach (StudentResult item in _StudentResultList)
                {
                    var studentInfo = datacontextObj.STUDENT_RESULT.First(c => c.Id == item.Id);
                        studentInfo.TheoryMarksConAssess = item.theoryMarksConAssess;
                        studentInfo.PracticalMarksConAssess = item.PracticalMarksConAssess;
                        studentInfo.TheoryMarksFinalExam = item.TheoryMarksFinalExam;
                        studentInfo.PracticalMarksFinalExam = item.PracticalMarksFinalExam;
                        studentInfo.TotalMarks = item.TotalMarks;
                        datacontextObj.SaveChanges();
                }
            
        }

        public List<StudentResult> GetStudentMarksSeetSemesterWise(string dept, string sem, int year, string _studentId)
        {
            try
            {
                //int yearInt = Convert.ToInt16(year);
                decimal marksOntain = 0;
                    datacontextObj = new SIPIDBEntities();
                    List<StudentResult> studentResultList = new List<StudentResult>();
                    foreach (var p in (from j in datacontextObj.STUDENT_RESULT
                                   where j.SEMESTER.SemesterNo.Equals(sem) &&
                                   j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept) &&
                                  j.YearId.Equals(year) && j.ADMISSIONINFO.StudentID.Equals(_studentId)
                                   select j))
                    {
                        StudentResult studentResultObj = new StudentResult();
                        studentResultObj.Id = p.Id;
                        studentResultObj.StudentId = p.ADMISSIONINFO.StudentID;
                        studentResultObj.StudentPKId = p.StudentPKId;
                        studentResultObj.StudentName = p.ADMISSIONINFO.ApplicantName;
                        studentResultObj.CourseName = p.COURSE.CourseName;
                        studentResultObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                        studentResultObj.SemesterNo = p.SEMESTER.SemesterNo;
                        studentResultObj.PracticalMarksConAssess = (int)p.PracticalMarksConAssess;
                        studentResultObj.TheoryMarksConAssess = (int)p.TheoryMarksConAssess;
                        studentResultObj.PracticalMarksFinalExam = (int)p.PracticalMarksFinalExam;
                        studentResultObj.TheoryMarksFinalExam = (int)p.TheoryMarksFinalExam;
                        studentResultObj.TotalMarks = (int)p.TotalMarks;
                        studentResultObj.FatherName = p.ADMISSIONINFO.FatherName;
                        studentResultObj.MotherName = p.ADMISSIONINFO.MotherName;
                        //studentResultObj.BoardRollNo = (int)p.ADMISSIONINFO.BoardRollNo;
                        //studentResultObj.BoardRegistrationNo = (int)p.ADMISSIONINFO.BoardRegistrationNo;
                        studentResultObj.Section = p.ADMISSIONINFO.Session;
                        studentResultObj.CourseFullMarks = (int)p.COURSE.TotalMarks;
                        studentResultObj.CourseFullCredit = (int)p.COURSE.TotalCredit;
                        studentResultObj.CourseCode = p.COURSE.CourseCode;
                        studentResultObj.MarksObtain = (int)p.PracticalMarksConAssess + (int)p.TheoryMarksConAssess + (int)p.PracticalMarksFinalExam + (int)p.TheoryMarksFinalExam;


                        studentResultList.Add(studentResultObj);

                    }
                    return studentResultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public List<StudentResult> GetStudentMarksSeetSemesterWisePerStudent(string dept, string sem, int year)
        {
            try
            {
                //int yearInt = Convert.ToInt16(year);

                datacontextObj = new SIPIDBEntities();
                List<StudentResult> studentResultList = new List<StudentResult>();
                foreach (var p in (from j in datacontextObj.STUDENT_RESULT
                                   where j.SEMESTER.SemesterNo.Equals(sem) &&
                                   j.SIPI_DEPARTMENT.SIPI_DepartmentName.Equals(dept) &&
                                  j.YearId.Equals(year) select j))
                {
                    StudentResult studentResultObj = new StudentResult();
                    studentResultObj.Id = p.Id;
                    studentResultObj.StudentId = p.ADMISSIONINFO.StudentID;
                    studentResultObj.StudentPKId = p.StudentPKId;
                    studentResultObj.StudentName = p.ADMISSIONINFO.ApplicantName;
                    studentResultObj.CourseName = p.COURSE.CourseName;
                    studentResultObj.DepartmentName = p.SIPI_DEPARTMENT.SIPI_DepartmentName;
                    studentResultObj.SemesterNo = p.SEMESTER.SemesterNo;
                    studentResultObj.PracticalMarksConAssess = (int)p.PracticalMarksConAssess;
                    studentResultObj.TheoryMarksConAssess = (int)p.TheoryMarksConAssess;
                    studentResultObj.PracticalMarksFinalExam = (int)p.PracticalMarksFinalExam;
                    studentResultObj.TheoryMarksFinalExam = (int)p.TheoryMarksFinalExam;
                    studentResultObj.TotalMarks = (int)p.TotalMarks;
                    studentResultObj.FatherName = p.ADMISSIONINFO.FatherName;
                    studentResultObj.MotherName = p.ADMISSIONINFO.MotherName;
                    //studentResultObj.BoardRollNo = (int)p.ADMISSIONINFO.BoardRollNo;
                    //studentResultObj.BoardRegistrationNo = (int)p.ADMISSIONINFO.BoardRegistrationNo;
                    studentResultObj.Section = p.ADMISSIONINFO.Session;
                    studentResultObj.CourseFullMarks = (int)p.COURSE.TotalMarks;
                    studentResultObj.CourseFullCredit = (int)p.COURSE.TotalCredit;
                    studentResultObj.CourseCode = p.COURSE.CourseCode;
                    studentResultObj.MarksObtain = (int)p.PracticalMarksConAssess + (int)p.TheoryMarksConAssess + (int)p.PracticalMarksFinalExam + (int)p.TheoryMarksFinalExam;

                    studentResultList.Add(studentResultObj);

                }
                return studentResultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

