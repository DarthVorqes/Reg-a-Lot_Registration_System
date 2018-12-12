using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Course
    {
        public int ID { get; set; }
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte Hours { get; set; }
        public string Department { get; set; }
        public string Prerequisite { get; set; }
    }
}
