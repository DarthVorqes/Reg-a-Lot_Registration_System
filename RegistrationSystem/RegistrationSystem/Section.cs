using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;


namespace RegistrationSystem
{
    /// <summary>
    /// A class that represents the sections created from Course that students can register for
    /// </summary>
    class Section
    {
        /// <summary>
        /// Runs a query and returns a list of 'Section' retreived from 'db.Section
        /// </summary>
        /// <param name="perams"></param>
        /// <param name="usr"></param>
        /// <returns></returns>
        public List<Section> GetSections(System.Data.SqlClient.SqlParameter[] perams, User usr) =>
            usr.Connection.BuildClassArray<Section>(perams, Tables.Section);

        public const byte Capacity = 10;
        //public User Professor { get; set; }
        //public User[] Students { get; set; }

        // Add BuildClassArray() here

        // Section Properties

        public int ID { get; private set; } = -1;
        public int SectionNumber { get; private set; }

        public string MeetingTimes { get; private set; }

        public string MeetingDays { get; private set; }
        [TableSpecific (Tables.Section)]
        public int CourseID { get; private set; }

        public string Location { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public string Duration { get; private set; }

        public int SemesterID { get; private set; }
        [TableSpecific(Tables.Section)]
        public int InstructorID { get; private set; }

        public int SectionCapacity { get; private set; }

        public bool Status { get; private set; }
        public string GetCourseName(User usr) => usr.Connection.GetValue("CourseName",
        new SqlParameter[]
        {
                    new SqlParameter("ID",CourseID)
        }, Tables.Course) as string;
        public string GetDepartment(User usr) => usr.Connection.GetValue("Department",
        new SqlParameter[]
        {
                    new SqlParameter("ID",CourseID)
        }, Tables.Course) as string;
        public string GetInstructorName(User usr)
        {
            var perameters =
                new SqlParameter[] {
                new SqlParameter("ID", (int)usr.Connection.GetValue("InstructorID",
                new SqlParameter[]
                {
                            new SqlParameter("ID",CourseID)
                }, Tables.Course)) };

            return usr.Connection.GetValue("FirstName", perameters, Tables.Person).ToString() + ' ' +
                usr.Connection.GetValue("LastName", perameters, Tables.Person).ToString();
        }
        public Course GetCourse(User usr) => usr.Connection.BuildClassArray<Course>(new SqlParameter[] {
            new SqlParameter("ID",CourseID)
        },Tables.Course)[0];

    }
}
