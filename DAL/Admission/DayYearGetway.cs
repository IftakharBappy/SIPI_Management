using DATA;
using ENTITY.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
   public class DayYearGetway
    {
       SIPIDBEntities datacontextObj = new SIPIDBEntities();  

        public void SaveDay(Day _dayObj)
        {
            var newDay = new DAY
            {
                DaySeveneven = _dayObj.DaySeveneven,
                BanglaDay = _dayObj.BanglaDay,

            };
            datacontextObj.DAYs.Add(newDay);
            datacontextObj.SaveChanges();
        }
        public void SaveYear(Day _dayObjYear)
        {
            var newYear = new YEAR
            {
                Year1 = _dayObjYear.Year,
            };
            datacontextObj.YEARs.Add(newYear);
            datacontextObj.SaveChanges();
        }
        public List<Day> GetAllDay()
        {
            datacontextObj = new SIPIDBEntities();
            List<Day> yearList = new List<Day>();
            foreach (var p in (from j in datacontextObj.DAYs select j).Distinct())
            {
                Day dayObj = new Day();
                dayObj.Id = p.Id;
                dayObj.DaySeveneven = p.DaySeveneven;
                dayObj.BanglaDay = p.BanglaDay;
                yearList.Add(dayObj);
            }

            return yearList;
        }

        public List<Day> GetAllYear()
        {
            datacontextObj = new SIPIDBEntities();
            List<Day> yearList = new List<Day>();
            foreach (var p in (from j in datacontextObj.YEARs select new { j.Id, j.Year1 }).Distinct())
            {
                Day yearObj = new Day();
                yearObj.Id = p.Id;
                yearObj.Year = p.Year1;
                
                yearList.Add(yearObj);
            }

            return yearList;
        }

        public void DeleteYear(Day _dayObj)
        {
            YEAR yearobj = datacontextObj.YEARs.First(c => c.Id == _dayObj.Id);
            datacontextObj.YEARs.Remove(yearobj);
            datacontextObj.SaveChanges();
        }

        public List<Year> GetAllYear2()
        {
            datacontextObj = new SIPIDBEntities();
            List<Year> yearList = new List<Year>();
            foreach (var p in (from j in datacontextObj.YEARs select j).Distinct())
            {
                Year yearObj = new Year();
                yearObj.Id = p.Id;
                yearObj.Year_One = p.Year1;


                yearList.Add(yearObj);
            }

            return yearList;
        }
    }
}
