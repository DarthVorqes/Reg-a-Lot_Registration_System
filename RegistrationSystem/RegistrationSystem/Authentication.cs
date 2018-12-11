using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Authentication
    {
        public Authentication(int userID, string password, DatabaseConnection connection)
        {
            HashedPassword = Convert.ToBase64String(
                new System.Security.Cryptography.Rfc2898DeriveBytes(password, new byte[]
                {
                    63, 23, 42, 68, 60, 172, 127, 64, 173, 61, 20, 98, 143, 92, 153, 145,
                    237, 138, 239, 113, 176, 220, 251, 152, 168, 95, 227, 27, 166, 109, 53, 203,
                    135, 66, 239, 100, 235, 181, 72, 101, 195, 114, 82, 118, 221, 253, 7, 42,
                    143, 82, 141, 247, 228, 101, 40, 70, 231, 158, 74, 213, 55, 54, 45, 196,
                    102, 6, 34, 245, 254, 218, 126, 217, 13, 219, 95, 112, 150, 241, 72, 25,
                    251, 129, 242, 149, 138, 156, 214, 162, 108, 145, 250, 43, 67, 194, 129, 177,
                    135, 72, 125, 56, 227, 174, 239, 246, 77, 192, 18, 146, 32, 48, 237, 20,
                    234, 191, 96, 95, 230, 83, 122, 66, 163, 118, 199, 20, 113, 240, 119, 100
                }, 101).GetBytes(25));
            var permissions = connection.GetOccurrences(
                Tables.Person,
                new SqlParameter[] {
                                new SqlParameter("ID",userID),
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
            UserID = userID;
        }
        public int UserID { get; private set; } = -1;
        string HashedPassword { get; set; }
        public bool IsRegistrar { get; private set; }
        public bool IsStudent { get; private set; }
        public bool IsProfessor { get; private set; }
    }
}
