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
        Section,
        Semester,
        Registration,
        Course,
        Greenlight,
        Teach,
        SemesterYear,
    }
    class DatabaseConnection
    {
        /// <summary>
        /// A simple method for using an 'SqlCommand' in a customized way
        /// </summary>
        /// <param name="cmd">The perameter input to be used by the delegate</param>
        delegate void SqlCommandExecuter(SqlCommand cmd);
        /// <summary>
        /// The default constructor for 'DatabaseConnection'
        /// </summary>
        public DatabaseConnection()
        {
            Connection = new SqlConnection()
            {
                ConnectionString = "User Id=db1;Password=db10;Server=cis1.actx.edu;Database=Project1;"
            };
        }
        /// <summary>
        /// The connection linking 'this' object to the actual database
        /// </summary>
        SqlConnection Connection { get; }
        /// <summary>
        /// runs a query against the database
        /// </summary>
        /// <param name="commandText">the raw sql to be executed</param>
        /// <param name="perams">the perameters which specify what the keywords starting 
        /// with '@' in the 'commandText' perameter are to be substituted with</param>
        /// <param name="action">The specific action to be performed after the connection to the database is established and the command has been created</param>
        void ExecuteQuery(string commandText, SqlParameter[] perams, SqlCommandExecuter action)
        {
            Connection.Open();
            using (SqlCommand command = Connection.CreateCommand())
            {
                command.CommandText = commandText;
                command.Parameters.AddRange(perams);
                action(command);
            }
            Connection.Close();
        }
        /// <summary>
        /// Collects a singuler value from the database
        /// </summary>
        /// <param name="name">The column name (or variables name) to be collected.</param>
        /// <param name="perams">Any search perameters (NOTE: the first result to satisfy these will be selected).</param>
        /// <param name="table">The table for the query to be perfored in.</param>
        /// <returns>The value collected as a generic 'object'.</returns>
        public object GetValue(string name, SqlParameter[] perams, Tables table)
        {
            //constructed the sql command
            object result = null;
            string sql = "SELECT " + name + " FROM " + table;
            if (perams.Length > 0)
                sql += " WHERE " + BuildEqualityList(perams);
            //executed query (as the name would imply)
            ExecuteQuery(
                sql,
                perams,
                (SqlCommand cmd) =>//passing in a delegate to perform the actual search
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        var n = reader.GetValue(0);
                        result = n;
                    }
                });
            return result;
        }
        /// <summary>
        /// Collects all of the occerences which satisfy the specified perameters.
        /// </summary>
        /// <param name="table">The table being searched in.</param>
        /// <param name="perams">A list of perameters which the results must satisfy.</param>
        /// <param name="desiredFields">The actual fields/columns/variables desired.</param>
        /// <returns></returns>

        public List<string[]> GetOccurrences(Tables table, SqlParameter[] perams, string[] desiredFields) =>

            GetOccurrences(table.ToString(), perams, desiredFields);
        /// <summary>
        /// Collects all of the occerences which satisfy the specified perameters.
        /// </summary>
        /// <param name="table">The table being searched in.</param>
        /// <param name="perams">A list of perameters which the results must satisfy.</param>
        /// <param name="desiredFields">The actual fields/columns/variables desired.</param>
        /// <returns></returns>
        List<string[]> GetOccurrences(string table, SqlParameter[] perams, string[] desiredFields)
        {
            List<string[]> query = new List<string[]>();

            //constructing sql for query
            string sql = "SELECT " + EnumerateArray(desiredFields) + " FROM " + table;
            string perameters = BuildEqualityList(perams);
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
        /// <summary>
        /// Adds a records to the specified table.
        /// </summary>
        /// <param name="table">The table for which the record is to be added to.</param>
        /// <param name="elements">The elements/record to be added.</param>
        /// <returns>Whether or not the action was successful</returns>
        public bool Insert(Tables table, SqlParameter[] elements)
        {
            string sql = "INSERT INTO " + table;
            string columns = null, values = null;
            foreach(var element in elements)
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

            sql += "(" + columns + ") VALUES (" + values + ");";

            List<string[]> query = new List<string[]>();
            bool successful = false;
            //adding elements to the specified table.
            //try
            //{
            ExecuteQuery(
                sql,
                elements,
                (SqlCommand cmd) =>
                {
                    cmd.StatementCompleted += (object sender,
                        StatementCompletedEventArgs e) =>
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
        /// Updates the specified 'updatePerams' in the specified table.
        /// </summary>
        /// <param name="table">The table to be interacted with.</param>
        /// <param name="searchPerams">The search perameters to isolate the record(s) to be updated</param>
        /// <param name="updatePerams">The new values for each of the records</param>
        /// <returns>Whether or not the operation was successful.</returns>
        public bool Update(Tables table, SqlParameter[] searchPerams, SqlParameter[] updatePerams)
        {
            bool successful = false;
            //constructing sql command
            string set = updatePerams[0].ParameterName + " = @" + updatePerams[0].ParameterName;
            for (int i = 1; i < set.Length; i++)
                set += ", " + updatePerams[i].ParameterName + " = @" + updatePerams[i].ParameterName;
            //combining perameters, NOTE: it is possible to have multiple perameters with the same 'PerameterName'
            //whether or not this causes problems (which it most probabily does) and solving them.
            var allPerams = new List<SqlParameter>();
            allPerams.AddRange(searchPerams);
            allPerams.AddRange(updatePerams);
            //
            ExecuteQuery(
                "UPDATE " + table + " SET " + set + " WHERE " + BuildEqualityList(searchPerams),
                allPerams.ToArray(),

                (SqlCommand cmd) =>
                {

                    cmd.StatementCompleted += (object sender,
                        StatementCompletedEventArgs e) =>
                    {
                        successful = true;
                    };
                    cmd.ExecuteNonQuery();
                });
            return successful;
        }
        //Delete
        /// <summary>
        /// Removes a all records from the specifed table which satisfy 'perams'
        /// </summary>
        /// <param name="table">The table being queried in</param>
        /// <param name="perams">The perameters which must be met in order for a record to be deleted</param>
        /// <returns>Whether or not the operation was successful.</returns>
        public bool Delete(Tables table, SqlParameter[] perams)
        {

            bool successful = false;
            List<string[]> query = new List<string[]>();
            ExecuteQuery(
                "DELETE FROM " + table + " WHERE " + BuildEqualityList(perams),
                perams,
                (SqlCommand cmd) =>
                {
                    cmd.StatementCompleted += (object sender,
                        StatementCompletedEventArgs e) =>
                    {
                        successful = true;
                    };
                    cmd.ExecuteNonQuery();
                });
            return successful;
        }
        //helper methods
        /// <summary>
        /// Collects the headers for all of the columns in the specified table
        /// </summary>
        /// <param name="table">The table whose column names are desired</param>
        /// <returns>An ordered string array containing the column names for 'tablee'</returns>
        string[] GetHeaders(Tables table)
        {
            List<string> query = new List<string>();
            ExecuteQuery(
                "SELECT * FROM " + table,
                new SqlParameter[0],
                (SqlCommand cmd) =>
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            query.Add(reader.GetName(i));
                    }
                });
            return query.ToArray();
        }
        /// <summary>
        /// Constructs a string containing all of the 'perams' where the name is set as equal to the '@value' and each equality is seperated by the 'delimiter'
        /// </summary>
        /// <param name="perams">The values to be placed into the equations in the string</param>
        /// <param name="delimiter">the delimiter between each of the equations</param>
        /// <returns>The completed string</returns>
        string BuildEqualityList(SqlParameter[] perams, string delimiter = " AND ")
        {
            if (perams.Length == 0)
                return "";
            string combined = perams[0].ParameterName + " = " + '@' + perams[0].ParameterName;
            for (int i = 1; i < perams.Length; i++)
                combined += delimiter + perams[i].ParameterName + " = " + " @" + perams[i].ParameterName;
            return combined;
        }
        /// <summary>
        /// Takes all of the 'elements' and places them into a string, seperating them with 'delimiter[s]'
        /// </summary>
        /// <param name="elements">the elements to be placed into the list</param>
        /// <param name="delimiter">The delimiter to be used to seperated the 'elements'</param>
        /// <returns></returns>
        string EnumerateArray(string[] elements, string delimiter = ",")
        {
            string combined = elements[0];
            for (int i = 1; i < elements.Length; i++)
                combined += delimiter + elements[i];
            return combined;
        }

    }

}