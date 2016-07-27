using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.StudentManagement
{
    public class Course
    {

        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int? SemesterId { get; set; }
        public string SemesterNo { get; set; }
        public string CourseName { get; set; }
        public string BanglaCourseName { get; set; }
       
        public string CourseCode { get; set; }
        public double TheoryCredit { get; set; }
        public double PracticalCredit { get; set; }
        public double TotalCredit { get; set; }
        /// <summary>
        /// ///
        /// </summary>

        public double TheoryMarkasContinuousAssessment { get; set; }
        public double TheoryMarkasFinalExam { get; set; }

        public double PracticalMarkasContinuousAssessment { get; set; }
        public double PracticalMarkasFinalExam { get; set; }
        public double TotalMarks { get; set; }


        
    }
}
