using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPI_SL.Report.Entity.ResultManagement
{
    public class StudentResultReport
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public int StudentPKId { get; set; }
        public string StudentName { get; set; }
        public string StudentId { get; set; }

        public int SemesterId { get; set; }
        public string SemesterNo { get; set; }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int YearId { get; set; }
        public int YearNo { get; set; }

        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int BoardRollNo { get; set; }
        public int BoardRegistrationNo { get; set; }
        public string Section { get; set; }
        public decimal CourseFullMarks { get; set; }
        public decimal CourseFullCredit { get; set; }
        public int HeldIn { get; set; }
        public string Shift { get; set; }
        public decimal TheoryMarksConAssess { get; set; }
        public decimal TheoryMarksFinalExam { get; set; }
        public decimal PracticalMarksConAssess { get; set; }
        public decimal PracticalMarksFinalExam { get; set; }
        public decimal MarksObtain { get; set; }

        public decimal TotalMarks { get; set; }
    }
}
