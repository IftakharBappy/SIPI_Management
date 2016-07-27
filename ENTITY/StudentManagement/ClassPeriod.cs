using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.StudentManagement
{
    public class ClassPeriod
    {
        private int? id;

        public int? Id
        {
            get { return id; }
            set { id = value; }
        }

        private string periodName;

        public string PeriodName
        {
            get { return periodName; }
            set { periodName = value; }
        }

        private string startTime;

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private string endTime;

        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }
}
