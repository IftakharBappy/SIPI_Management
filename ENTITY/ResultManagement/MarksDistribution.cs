using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.ResultManagement
{
    public class MarksDistribution
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

        public int YearId { get; set; }
        public int YearNo { get; set; }

        public decimal? TheoryMarksConAssess { get; set; }
        public decimal? TheoryMarksFinalExam { get; set; }
        public decimal? PracticalMarksConAssess { get; set; }
        public decimal? PracticalMarksFinalExam { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(System.String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        //public decimal theoryMarksConAssess { get; set; }

        //public decimal TheoryMarksConAssess
        //{
        //    get
        //    {
        //        return this.theoryMarksConAssess;
        //    }

        //    set
        //    {
        //        if (value != this.theoryMarksConAssess)
        //        {
        //            this.theoryMarksConAssess = value;
        //            NotifyPropertyChanged("TheoryMarksConAssess");
        //        }
        //    }
        //}
    }
}
