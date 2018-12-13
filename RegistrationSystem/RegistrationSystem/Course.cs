using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistrationSystem
{
    /// <summary>
    /// A class that represents the courses to create sections from.
    /// </summary>
    class Course
    {
        /// <summary>
        /// Runs a query and returns a list of 'Course' retreived from 'db.Course
        /// </summary>
        /// <param name="perams"></param>
        /// <param name="usr"></param>
        /// <returns></returns>
        public List<Course> GetCourse(System.Data.SqlClient.SqlParameter[] perams, User usr) =>
            usr.Connection.BuildClassArray<Course>(perams, Tables.Course);
        /// <summary>
        /// Primary key in db.Course
        /// </summary>
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
