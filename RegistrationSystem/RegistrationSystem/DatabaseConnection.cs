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
        public enum Tables
        {
            Person,

        }
        public DatabaseConnection(int userID, string password)
        {
            UserID = userID;
            HashedPassword = new byte[0];//placeholder
        }
        public string[] GetRecord(Tables table)
        {
            Connection.Open();
            throw new NotImplementedException();
        }
        /// <summary>
        /// if the record already exists, it will update it
        /// </summary>
        /// <returns>Whether or not the operation was successful</returns>
        public bool SetRecord(Tables table, SqlParameter[] perams)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Whether or not the operation was successful</returns>
        public bool RemoveRecord()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// this will generally be the student's ID
        /// </summary>
        public int UserID { get; set; }
        byte[] HashedPassword { get; set; }
    }
}
