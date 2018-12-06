using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography;
using System.Data;

namespace RegistrationSystem
{
    enum Tables
    {
        Person = 0,
        Semester,
        Sections,
        Courses,
    }
    enum QueryTypes
    {
        Select,
        Update,
        Delete,
    }
    class DatabaseConnection
    {
        delegate void SqlCommandExecuter(SqlCommand cmd);
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
        string HashedPassword { get; set; }
        int UserID { get; set; }
        public DatabaseConnection()
            : this("User Id=db1;Password=db10;Server=cis1.actx.edu;Database=Project1;")
        {

        }
        DatabaseConnection(string connectionString)
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
        HMACSHA512 Hashing { get; set; }
        public string Hash(string n) => Encoding.UTF8.GetString(
                Hashing.ComputeHash(Encoding.UTF8.GetBytes(n)));
        public DatabaseConnection(int userID, string password)
            : this()
        {
            UserID = userID;

            //you know, there is this concept called: "Logical Naming" 

            Hashing = new HMACSHA512(Key);
            HashedPassword = Hash(password);

            //HashedPassword = "000";

            Authenticate();

        }
        void Authenticate()
        {
            var permissions = GetOccurrences(
                Tables.Person,
                new SqlParameter[] {
                    new SqlParameter("ID",UserID),
                    new SqlParameter("Password",HashedPassword),
                },
                new string[] {
                    "IsProfessor",
                    "IsStudent",
                    "IsRegistrar",
                });
            if (permissions.Count == 0)
                return;
            IsProfessor = permissions[0][0] == "True";
            IsStudent = permissions[0][1] == "True";
            IsRegistrar = permissions[0][2] == "True";

        }
        void ExecuteQuery(string commandText, SqlParameter[] perams, SqlCommandExecuter action)
        {
            Connection.Open();
            List<string[]> query = new List<string[]>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                command.CommandText = commandText;
                command.Parameters.AddRange(perams);
                action(command);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new string[reader.FieldCount];
                        for (int i = 0; i < row.Length; i++)
                            row[i] = reader.GetValue(i) as string;
                        query.Add(row);
                    }

                }
            }
            Connection.Close();
        }
        public List<string[]> GetOccurrences(Tables table, SqlParameter[] perams, string[] desiredFields) => GetOccurrences(table.ToString(), perams, desiredFields);
        List<string[]> GetOccurrences(string table, SqlParameter[] perams, string[] desiredFields)
        {
            List<string[]> query = new List<string[]>();
            string sql = "SELECT " + EnumerateArray(desiredFields) + " FROM " + table;
            string perameters = BuildStringList(perams);
            if (perameters.Length > 0)
                sql += " WHERE " + perameters;
            ExecuteQuery(
                sql,
                perams,
                (SqlCommand cmd) =>
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var result = new string[reader.FieldCount];
                            for (int i = 0; i < result.Length; i++)
                            {
                                var n = reader.GetValue(i);
                                result[i] = Convert.ToString(n);
                            }
                            query.Add(result);
                        }
                    }
                });
            return query;
        }
        //Insert
        public bool Insert(Tables table, SqlParameter[] elements)
        {
            var headers = GetHeaders(table);
            string sql = "INSERT INTO " + table;
            string columns = null, values = null;
            foreach (string header in headers)
            {
                foreach(var element in elements)
                {
                    if(header == element.ParameterName)
                    {
                        if (values == null)
                        {
                            values = "@" + element.ParameterName;
                            columns = element.ParameterName;
                        }
                        else
                        {
                            values += ", @" + element.ParameterName;
                            columns += ", " + element.ParameterName;
                        }
                    }
                }
            }
            sql += "(" + columns + ") VALUES (" + values + ");";
            
            List<string[]> query = new List<string[]>();
            bool successful = false;
            //try
            //{
                ExecuteQuery(
                    sql,
                    elements,
                    (SqlCommand cmd) =>
                    {
                        cmd.StatementCompleted += (object sender,
                            System.Data.StatementCompletedEventArgs e) =>
                        {
                            successful = true;
                        };
                        cmd.ExecuteNonQuery();
                    });
            //}
            //catch (SqlException e)
            //{
                //if (Connection.State == ConnectionState.Open)
                //    Connection.Close();
                //System.Diagnostics.Debug.WriteLine("The following error occured: " + e.Message);
                //return false;
            //}
            return successful;
        }
        //Update
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="searchPerams"></param>
        /// <param name="updatePerams"></param>
        /// <returns>Whether or not the operation was successful.</returns>
        public bool Update(Tables table, SqlParameter[] searchPerams, SqlParameter[] updatePerams)
        {
            bool successful = false;
            string set = updatePerams[0].ParameterName + " = @" + updatePerams[0].ParameterName;
            for (int i = 1; i < set.Length; i++)
                set += ", " + updatePerams[i].ParameterName + " = @" + updatePerams[i].ParameterName;
            var allPerams = new List<SqlParameter>();
            allPerams.AddRange(searchPerams);
            allPerams.AddRange(updatePerams);
            ExecuteQuery(
                "UPDATE " + table + " SET " + set + " WHERE " + BuildStringList(searchPerams),
                allPerams.ToArray(),
                (SqlCommand cmd) => {
                    cmd.StatementCompleted += (object sender, 
                        System.Data.StatementCompletedEventArgs e) =>
                    {
                        successful = true;
                    };
                    cmd.ExecuteNonQuery();
                });
            return successful;
        }
        //Delete
        public bool Delete(Tables table, SqlParameter[] perams)
        {
            
            bool successful = false;
            List<string[]> query = new List<string[]>();
            ExecuteQuery(
                "DELETE FROM " + table + " WHERE " + BuildStringList(perams),
                perams,
                (SqlCommand cmd) => {
                    cmd.StatementCompleted += (object sender,
                        System.Data.StatementCompletedEventArgs e) =>
                    {
                        successful = true;
                    };
                    cmd.ExecuteNonQuery();
                });
            return successful;
        }
        //helper methods
        string[] GetHeaders(Tables table)
        {
            //var columns = GetOccurrences("information_schema.columns", new SqlParameter[] { new SqlParameter("table_name", table) }, new string[] { "column_name", "*" });
            //return columns[0];
            List<string> query = new List<string>();
            //string sql = "SELECT " + EnumerateArray(desiredFields) + " FROM " + table;
            //string perameters = BuildStringList(perams);
            //if (perameters.Length > 0)
            //    sql += " WHERE " + perameters;
            ExecuteQuery(
                "SELECT * FROM " + table,
                new SqlParameter[0],
                (SqlCommand cmd) =>
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        for(int i = 0; i < reader.FieldCount; i++)
                            query.Add(reader.GetName(i));
                    }
                });
            return query.ToArray();
        }
        string BuildStringList(SqlParameter[] perams, string delimiter = " AND ")
        {
            if (perams.Length == 0)
                return "";
            string combined = perams[0].ParameterName + " = " + '@' + perams[0].ParameterName;
            for (int i = 1; i < perams.Length; i++)
                combined += delimiter + perams[i].ParameterName +  " = " +  " @" + perams[i].ParameterName;
            return combined;
        }
        string EnumerateArray(string[] elements, string delimiter = ",")
        {
            string combined = elements[0];
            for (int i = 1; i < elements.Length; i++)
                combined += delimiter + elements[i];
            return combined;
        }
    }
}
