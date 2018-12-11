using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistrationSystem
{
    class Course
    {
        public Course(SqlParameter[] perams, User usr)
        {
            
        }
        public int ID { get; private set; }
        public string CourseNumber { get; private set; }
        public string CourseName { get; private set; }
        public string Description { get; private set; }
        public float Price { get; private set; }
        public byte Hours { get; private set; }
        public string Department { get; private set; }
        public string Prerequisite { get; private set; }
    }
}
