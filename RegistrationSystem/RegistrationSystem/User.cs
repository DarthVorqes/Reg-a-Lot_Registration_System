using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace RegistrationSystem
{
    class User
    {

        //place constructors here

        public User()
        {
            Connection = new DatabaseConnection();
        }

        //place methods here
        public void SetFocus(int id)
        {
            if (IsRegistrar)
            {
                //collect password from DB
                string password = Connection.GetValue("Password", new SqlParameter[] {
                    new SqlParameter("ID",id.ToString())
                }, Tables.Person).ToString();

                Focus = new User();
                Focus.Authenticate(id, password);
                //initialize Focus
            }
        }

        //place properties
        public int EnterpriseID { get; private set; } = -1;
        public string FirstName
        {
            get
            {
                if (firstName == null)
                    firstName = GetPersonInfo("FirstName").ToString();
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                if (lastName == null)
                    lastName = GetPersonInfo("LastName").ToString();
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public bool HasPaid
        {
            get
            {
                if (!checkedIfHasPaid)
                {
                    //get from DB
                    checkedIfHasPaid = true;

                }
                return hasPaid;
            }
            set
            {
                hasPaid = value;
            }
        }
        public bool IsProfessor { get; set; }
        public bool IsStudent { get; set; }
        public bool IsRegistrar { get; set; }
        public string Password
        {
            set
            {
                _password = Hash(value);
            }
        }
        public Schedule UserSchedule
        {
            get
            {
                if (UserSchedule == null)
                {
                    //get from DB
                }
                return UserSchedule;
            }
        }
        public int Social
        {
            get
            {
                if (!social)
                {
                    //get from DB
                    social = true;

                }
            return social;
            }
            set
            {
                social = value;
            }
        }
        public string StreetAddress
        {
            get
            {
                if (!streetAddress)
                {
                    //get from DB
                    streetAddress = true;

                }
            return streetAddress;
            }
            set
            {
                streetAddress = value;
            }
        }
        public string City
        {
             get
             {
                if (!city)
                {
                    //get from DB
                    city = true;
                }
             return city;
             }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                if (!state)
                {
                    // get from DB
                    state = true;
                }
            return state;
            }
            set
            {
                state = value;
            }
        }
        public int ZipCode
        {
            get
            {
                if (!zipCode)
                {
                    // get from DB
                    zipCode = true;
                }
            return zipCode;
            }
            set
            {
                zipCode = value;

            }
        }
        public string Email
        {
            get
            {
                if (!email)
                {
                    // get from DB
                    email = true;
                }
            return email;
            }
            set
            {
                email = value;
            }
        }
        public long PhoneNumber
        {
            get
            {
                if (!phoneNumber)
                {
                    // get from DB
                    phoneNumber = true;
                }
            return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public DatabaseConnection Connection { get; }
        public User Focus { get; private set; }
        //public methods
        bool Authenticate() =>
            Authenticate(EnterpriseID, _password);

        public bool Authenticate(int userID, string password)

        {
            var permissions = Connection.GetOccurrences(
                Tables.Person,
                new SqlParameter[] {
                                new SqlParameter("ID",userID),
                                new SqlParameter("Password",Hash(password)),
                },
                new string[] {
                                "IsProfessor",
                                "IsStudent",
                                "IsRegistrar",
                });
            if (permissions.Count == 0)
                return false;
            IsProfessor = permissions[0][0] == "True";
            IsStudent = permissions[0][1] == "True";
            IsRegistrar = permissions[0][2] == "True";
            EnterpriseID = userID;
            this._password = password;
            return true;
        }

        // allows changes to person table to be pushed to database
        public void PushChanges(User authority)
        {
            // Authenticates user before proceeding
            authority.Authenticate();
            List<SqlParameter> changes = new List<SqlParameter>();

            if (authority.IsRegistrar)

            {
                if (firstName != null)
                    changes.Add(new SqlParameter("FirstName", firstName));
                if (lastName != null)
                    changes.Add(new SqlParameter("LastName", lastName));
                changes.AddRange(new SqlParameter[] {
                    new SqlParameter("IsProfessor",IsProfessor),
                    new SqlParameter("IsRegistrar",IsRegistrar),
                    new SqlParameter("IsStudent",IsStudent),
                });
                if (social != -1)
                    changes.Add(new SqlParameter("Social", social));
            }
            if (_password != null)
                changes.Add(new SqlParameter("Password", _password));
            if (streetAddress != null)
                changes.Add(new SqlParameter("StreetAddress", streetAddress));

            if (city != null)

                changes.Add(new SqlParameter("City", city));
            if (state != null)
                changes.Add(new SqlParameter("State", state));
            if (zipCode != -1)
                changes.Add(new SqlParameter("ZipCode", zipCode));
            if (email != null)
                changes.Add(new SqlParameter("Email", email));
            if (phoneNumber != -1)
                changes.Add(new SqlParameter("PhoneNumber", phoneNumber));

            // 

            if (EnterpriseID == -1)

            {
                Connection.Insert(Tables.Person, changes.ToArray());
            }
            else
            {
                Connection.Update(Tables.Person, new SqlParameter[] { new SqlParameter("ID", EnterpriseID) }, changes.ToArray());
            }
        }

        // Removes all references to person in all tables
        public bool RemovePerson(int id)
        {
            Authenticate();
            if (!IsRegistrar)
                return false;
            bool success = Connection.Delete(Tables.Person, new SqlParameter[] {
                new SqlParameter("ID",id),
            });
            success = Connection.Delete(Tables.Registration, new SqlParameter[] {
                new SqlParameter("PersonID",id),
            }) && success;
            success = Connection.Delete(Tables.Teach, new SqlParameter[] {
                new SqlParameter("PersonID",id),
            }) && success;
            success = Connection.Delete(Tables.Section, new SqlParameter[] {
                new SqlParameter("TeachID",id),
            }) && success;
            success = Connection.Delete(Tables.Greenlight, new SqlParameter[] {
                new SqlParameter("PersonID",id),
            }) && success;
            return success;
        }
        //private methods

        // Hashes passwords to length of 25 characters
        private string Hash(string raw) => Convert.ToBase64String(
        new System.Security.Cryptography.Rfc2898DeriveBytes(raw, new byte[]
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

        private object GetPersonInfo(string columnName) =>
            Connection.GetValue(columnName, new SqlParameter[]
                {
                    new SqlParameter("ID",EnterpriseID),

                }, Tables.Person);

        //do not touch these VVV go through the properties!
        string firstName, lastName, _password, streetAddress, state, email, city;
        long phoneNumber = -1;
        int social = -1, zipCode = -1;
        bool hasPaid,
            checkedIfHasPaid;
        Schedule userSchedule;

    }
}

