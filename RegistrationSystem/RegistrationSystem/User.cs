using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class User
    {
        //place constructors here
        //place methods here
        public void SetFocus(string name)
        {
            if (IsRegistrar)
            {
                //collect password from DB
                //initialize Focus
            }
        }
        void EnsurePermissions()
        {
            if (checkedPermissions)
                return;
            checkedPermissions = true;
            //collect data from DB
        }
        //place properties
        public int EnterpriseID { get; private set; }
        public string Name
        {
            get
            {
                if(name == null)
                {
                    //get name from DB
                }
                return name;
            }
        }
        public bool HasPaid
        {
            get
            {
                if (!checkedIfHasPaid)
                {
                    //get from DB
                }
                return hasPaid;
            }
        }
        public bool IsProfessor
        {
            get
            {
                EnsurePermissions();
                return isProfessor;
            }
        }
        public bool IsStudent
        {
            get
            {
                EnsurePermissions();
                return isStudent;
            }
        }
        public bool IsRegistrar
        {
            get
            {
                EnsurePermissions();
                return isRegistrar;
            }
        }
        public string Password
        {
            get
            {
                if(password == null)
                {
                    //get from DB
                }
                return password;
            }
            set
            {
                password = value;
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
        public DatabaseConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    //get from DB
                }
                return connection;
            }
        }
        public User Focus { get; private set; }
        //do not touch these VVV go through the properties!
        string name,
            password;
        bool hasPaid,
            checkedIfHasPaid,
            checkedPermissions,
            isProfessor,
            isStudent,
            isRegistrar;
        Schedule userSchedule;
        DatabaseConnection connection;
    }
}
