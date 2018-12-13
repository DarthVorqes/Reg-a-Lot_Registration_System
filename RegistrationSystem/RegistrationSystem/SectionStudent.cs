using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    /// <summary>
    /// A class representation of a given student's grades in a section.
    /// </summary>
    class SectionStudent
    {
        /// <summary>
        /// The Enterprise ID of this student
        /// </summary>
        public int PersonID { get; set; }
        /// <summary>
        /// The grade for this student for 'SectionID' 
        /// </summary>
        public string Grade { get; set; }
        public int SectionID { get; set; }
        [TableSpecific(Tables.Section)]
        public int CourseID { get; set; }
        public string GetFirstName(User usr) => usr.Connection.GetValue("FirstName", new System.Data.SqlClient.SqlParameter[] {
                new System.Data.SqlClient.SqlParameter("ID",PersonID),
            }, Tables.Person) as string;
        /// <summary>
        /// This collect the last name of the person whose student ID is PersonID.
        /// </summary>
        /// <param name="usr"></param>
        /// <returns></returns>
        public string GetLastName(User usr) => usr.Connection.GetValue("LastName", new System.Data.SqlClient.SqlParameter[] {
                new System.Data.SqlClient.SqlParameter("ID",PersonID),
            }, Tables.Person) as string;
    }
}
