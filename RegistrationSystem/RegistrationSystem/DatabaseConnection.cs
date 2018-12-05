using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography;

namespace RegistrationSystem
{
    enum Tables
    {
        People = 0,
        Semester,
        Sections,
        Courses,
    }
    class DatabaseConnection
    {
        /*
         * Database Connection Values
         * "user id=db1;password=db10;server=cis1.actx.edu;Trusted_Connection=yes;database=Project1;");
         */
        //this value is just an example,
        //be sure to update it later with an accurate value
        const string BASE_DATABASE_LOCATION = "db_owner.";
        static byte[] Key => new byte[]
        {
            63, 23, 42, 68, 60, 172, 127, 64, 173, 61, 20, 98, 143, 92, 153, 145,
            237, 138, 239, 113, 176, 220, 251, 152, 168, 95, 227, 27, 166, 109, 53, 203,
            135, 66, 239, 100, 235, 181, 72, 101, 195, 114, 82, 118, 221, 253, 7, 42,
            143, 82, 141, 247, 228, 101, 40, 70, 231, 158, 74, 213, 55, 54, 45, 196,
            102, 6, 34, 245, 254, 218, 126, 217, 13, 219, 95, 112, 150, 241, 72, 25,
            251, 129, 242, 149, 138, 156, 214, 162, 108, 145, 250, 43, 67, 194, 129, 177,
            135, 72, 125, 56, 227, 174, 239, 246, 77, 192, 18, 146, 32, 48, 237, 20,
            234, 191, 96, 95, 230, 83, 122, 66, 163, 118, 199, 20, 113, 240, 119, 100
        };
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

            //you know, there is this concept called: "Logical Naming" 
            HMACSHA512 hasher = new HMACSHA512(Key);
            HashedPassword = Encoding.Unicode.GetString(
                hasher.ComputeHash(Encoding.Unicode.GetBytes(password)));
            Authenticate();

        }
        public void AddValue(Tables table, SqlParameter[] perams)
        {
            /*
             PERSON:
             
             
             
             */
        }
        void Authenticate()
        {
            var permissions = GetValue(
                Tables.People,
                "SELECT IsProfessor, IsStudent, IsRegistrar WHERE UserID = @userID AND Password = @password",
                new SqlParameter[] {
                    new SqlParameter("userID",UserID),
                    new SqlParameter("HashedPassword",HashedPassword),
                });

        }
        public List<string[]> GetValue(Tables table, SqlParameter[] perams)
        {
            string commandText = "SELECT @CollectingElement FROM @table WHERE " +
    "UserID = @userID AND" +
    "Password == @password";
            foreach (var peram in perams)
                commandText += "AND @" + peram.ParameterName;
            return GetValue(table, commandText, perams);
        }
        List<string[]> GetValue(Tables table, string commandText, SqlParameter[] perams)
        {
            Connection.Open();
            List<string[]> query = new List<string[]>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                command.CommandText = commandText;
                command.Parameters.AddRange(perams);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new string[reader.FieldCount];
                        for (int i = 0; i < row.Length; i++)
                            row[i] = reader.GetString(i);
                        query.Add(row);
                    }

                }
            }
            Connection.Close();
            return query;
        }
        /// <summary>
        /// The user's enterprise key
        /// </summary>
        public int UserID { get; set; }
        string HashedPassword { get; set; }
    }
}
