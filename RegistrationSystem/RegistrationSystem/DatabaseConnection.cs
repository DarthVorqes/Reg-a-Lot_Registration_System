using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class DatabaseConnection
    {
        public DatabaseConnection(int userID, string password)
        {
            UserID = userID;
            HashedPassword = new byte[0];//placeholder
        }
        /// <summary>
        /// this will generally be the student's ID
        /// </summary>
        public int UserID { get; set; }
        byte[] HashedPassword { get; set; }
    }
}
