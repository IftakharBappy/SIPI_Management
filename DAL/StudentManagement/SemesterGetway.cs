using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.StudentManagement;
using DATA;

namespace DAL.StudentManagement
{
    public class SemesterGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();


        //public void SaveSemester(Semester _semesterObj)
        //{
        //    var newSemester = new SEMESTER
        //    {
        //        SemesterNo = _semesterObj.SemesterNo,
        //        BanglaSemesterNo = _semesterObj.BanglaSemesterNo,
        //    };
        //    datacontextObj.SEMESTERs.Add(newSemester);
        //    datacontextObj.SaveChanges();
        //}

        public List<Semester> GetAllSemester()
        {
            datacontextObj = new SIPIDBEntities();
            List<Semester> SemesterList = new List<Semester>();
            foreach (var p in (from j in datacontextObj.SEMESTERs select new { j.Id, j.SemesterNo, j.BanglaSemesterNo }).Distinct())
            {
                Semester semester = new Semester();
                semester.Id = p.Id;
                semester.SemesterNo = p.SemesterNo;
                semester.BanglaSemesterNo = p.BanglaSemesterNo;

                SemesterList.Add(semester);
            }

            return SemesterList;
        }

        public void DeleteSemester(Semester _semesterObj)
        {
            SEMESTER semester = datacontextObj.SEMESTERs.First(c => c.Id == _semesterObj.Id);
            datacontextObj.SEMESTERs.Remove(semester);
            datacontextObj.SaveChanges();
        }

        public void UpdateSemester(Semester _semesterObj)
        {
            var semester = datacontextObj.SEMESTERs.First(c => c.Id == _semesterObj.Id);
            semester.SemesterNo = _semesterObj.SemesterNo;
            semester.BanglaSemesterNo = _semesterObj.BanglaSemesterNo;
            datacontextObj.SaveChanges();
        }


        /// //// work in here

        //public void DuplicatesSemester(Semester _semesterObj)
        //{
        //    //     var q = from r in Context.Table
        //    //        group r by new { FieldA = r.FieldA, FieldB = r.FieldB }// ...
        //    //            into g 
        //    //        where g.Count() > 1
        //    //        select g;
        //    //foreach (var g in q)
        //    //{
        //    //    var dupes = g.Skip(1).ToList();
        //    //    foreach (var record in dupes)
        //    //    {
        //    //        Context.DeleteObject(record);

        //    //    }
        //    //}
        //    //Context.SaveChanges();
        //}

        //////////////////////////////////////////////////////////////////////////////////

        public bool SaveSemester(Semester _semesterObj)
        {
            //var semester = datacontextObj.SEMESTERs.Where(s => s.SemesterNo == _semesterObj.SemesterNo).FirstOrDefault();

            var semester = (from s in datacontextObj.SEMESTERs where s.SemesterNo == _semesterObj.SemesterNo select s).Count();

            if (semester < 1)
            {
                var newSemester = new SEMESTER
                {
                    SemesterNo = _semesterObj.SemesterNo,
                    BanglaSemesterNo = _semesterObj.BanglaSemesterNo,
                };
                datacontextObj.SEMESTERs.Add(newSemester);
                datacontextObj.SaveChanges();

                return true;
            }
            else
                return false;
        }

        //////////////////////////////////////////////////////////////////////////////////

    }
}
