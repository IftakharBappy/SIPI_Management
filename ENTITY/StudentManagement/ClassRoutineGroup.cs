﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.StudentManagement
{
    public class ClassRoutineGroup
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public int? ProgramId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SemesterId { get; set; }
       
        
    }
}
