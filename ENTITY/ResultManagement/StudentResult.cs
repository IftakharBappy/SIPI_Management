using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.ResultManagement
{
    public class StudentResult : INotifyPropertyChanged
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
        public decimal MarksObtain { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(System.String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        /////////TheoryMarksConAssess
        public decimal theoryMarksConAssess { get; set; }
        public decimal TheoryMarksConAssess
        {
            get
            {
                return this.theoryMarksConAssess;
            }

            set
            {
                if (value != this.theoryMarksConAssess)
                {
                    this.theoryMarksConAssess = value;
                    NotifyPropertyChanged("TheoryMarksConAssess");
                }
            }
        }
        /////////End TheoryMarksConAssess
        /////

        /////////TheoryMarksFinalExam
        public decimal theoryMarksFinalExam { get; set; }
        public decimal TheoryMarksFinalExam
        {
            get
            {
                return this.theoryMarksFinalExam;
            }

            set
            {
                if (value != this.theoryMarksFinalExam)
                {
                    this.theoryMarksFinalExam = value;
                    NotifyPropertyChanged("TheoryMarksFinalExam");
                }
            }
        }
        /////////End TheoryMarksFinalExam
        ///////

        /////////TheoryMarksFinalExam
        public decimal practicalMarksFinalExam { get; set; }
        public decimal PracticalMarksFinalExam
        {
            get
            {
                return this.practicalMarksFinalExam;
            }

            set
            {
                if (value != this.practicalMarksFinalExam)
                {
                    this.practicalMarksFinalExam = value;
                    NotifyPropertyChanged("PracticalMarksFinalExam");
                }
            }
        }
        /////////End TheoryMarksFinalExam
        //////

        /////////TheoryMarksFinalExam
        public decimal practicalMarksConAssess { get; set; }
        public decimal PracticalMarksConAssess
        {
            get
            {
                return this.practicalMarksConAssess;
            }

            set
            {
                if (value != this.practicalMarksConAssess)
                {
                    this.practicalMarksConAssess = value;
                    NotifyPropertyChanged("PracticalMarksConAssess");
                }
            }
        }
        /////////End TheoryMarksFinalExam
          public decimal totalMarks { get; set; }
          public decimal TotalMarks
            {
                get
                {
                    return this.totalMarks;
                }

                set
                {
                    if (value != this.totalMarks)
                    {
                        this.totalMarks = value;
                        NotifyPropertyChanged("TotalMarks");
                    }
                }
            }

        

    }
}


