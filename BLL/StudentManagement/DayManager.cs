using DAL.Admission;
using ENTITY.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentManagement
{
    public class DayManager
    {
        DayYearGetway dayYearGetwayObj = new DayYearGetway(); 
        public void SaveDay(Day _dayObj)
        {
            dayYearGetwayObj.SaveDay(_dayObj);
        }

        public void SaveYear(Day _dayObjYear)
        {
            dayYearGetwayObj.SaveYear(_dayObjYear);
        }

        public List<Day> GetAllYear()
        {
            return dayYearGetwayObj.GetAllYear();
        }
        public List<Year> GetAllYear2()
        {
            return dayYearGetwayObj.GetAllYear2();
        }

        public List<Day> GetAllDay()
        {
            return dayYearGetwayObj.GetAllDay();
        }

        public void DeleteYear(Day _dayObj)
        {
            dayYearGetwayObj.DeleteYear(_dayObj);
        }
    }
}
