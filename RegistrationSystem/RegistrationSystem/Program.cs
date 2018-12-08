using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Was downgraded for lab computers
        /// test
        [STAThread]
        static void Main()
        {
            //var db = new DatabaseConnection();

            //db.Insert(Tables.Person,new System.Data.SqlClient.SqlParameter[] 
            //{
            //    new System.Data.SqlClient.SqlParameter("FirstName","John"),
            //    new System.Data.SqlClient.SqlParameter("LastName","Smith"),
            //    new System.Data.SqlClient.SqlParameter("IsProfessor",true),
            //    new System.Data.SqlClient.SqlParameter("IsStudent",true),
            //    new System.Data.SqlClient.SqlParameter("IsRegistrar",false),
            //    new System.Data.SqlClient.SqlParameter("Social",1234),
            //    new System.Data.SqlClient.SqlParameter("StreetAddress","Memory Ln."),
            //    new System.Data.SqlClient.SqlParameter("City","Small Texas"),
            //    new System.Data.SqlClient.SqlParameter("State","Saddness"),
            //    new System.Data.SqlClient.SqlParameter("ZipCode",1234),
            //    new System.Data.SqlClient.SqlParameter("PhoneNumber","8000060000"),
            //    new System.Data.SqlClient.SqlParameter("CanRegistrar",true),
            //    new System.Data.SqlClient.SqlParameter("Email","josh@cs.actx.edu"),
            //});
            //User test = new User()
            //{
            //    FirstName = "Bob",
            //    LastName = "en-King",
            //    IsProfessor = false,
            //    IsStudent = true,
            //    IsRegistrar = false,
            //    Social = 65,
            //    StreetAddress = "Ron Bergindy Ln.",
            //    City = "Twin Peaks",
            //    State = "Rhode Island",
            //    ZipCode = 124816,
            //    PhoneNumber = 123456789,
            //    Email = "steve@cs.actx.edu",  
            //    Password = "test123",
            //};


            User testAdmin = new User();
            System.Diagnostics.Debug.WriteLine("Auth Success = " + testAdmin.Authenticate(4, "test123"));
            System.Diagnostics.Debug.WriteLine("IsRegistrar = " + testAdmin.IsRegistrar);
            System.Diagnostics.Debug.WriteLine("First Name = " + testAdmin.FirstName);
            testAdmin.RemovePerson(18);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
