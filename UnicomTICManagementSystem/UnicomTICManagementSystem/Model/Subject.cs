﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int? CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
