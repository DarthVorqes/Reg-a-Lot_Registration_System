using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace RegistrationSystem
{
    class DatabaseConnection
    {
        /*
         * Database Connection Values
         * "user id=db1;password=db10;server=cis1.actx.edu;Trusted_Connection=yes;database=Project1;");
         */
        //this value is just an example,
        //be sure to update it later with an accurate value
        const string BASE_DATABASE_LOCATION = "db_owner.";
        public DatabaseConnection(string connectionString)
        {
            Connection = new SqlConnection()
            {
                ConnectionString = connectionString
            };
        }
        SqlConnection Connection { get; }
        public bool IsProfessor { get; private set; }
        public bool IsStudent { get; private set; }
        public bool IsRegistrar { get; private set; }
        public DatabaseConnection(int userID, string password)
        {
            UserID = userID;
            HashedPassword = new byte[0];//placeholder

        }
        public void AddRow(string[] s)
        {
            
        }
        /// <summary>
        /// this will generally be the student's ID
        /// </summary>
        public int UserID { get; set; }
        byte[] HashedPassword { get; set; }
    }
}
