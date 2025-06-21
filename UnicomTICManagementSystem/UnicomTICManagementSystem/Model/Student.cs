using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int? CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
