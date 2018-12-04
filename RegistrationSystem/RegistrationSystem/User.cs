using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class User
    {
        public virtual int EnterpriseID { get; private set; }
        public virtual string Name { get; set; }
        public virtual bool HasPaid { get; private set; }
        public virtual bool IsProffessor { get; private set; }
        public virtual bool IsStudent { get; private set; }
        public virtual bool IsRegistrar { get; private set; }
        public virtual string Password { get; private set; }
        public virtual Schedule UserSchedule { get; private set; }
        public DatabaseConnection Connection { get; private set; }
        public User Focus{ get; private set; }
        public void InitializeConnection() =>
            Connection = new DatabaseConnection(EnterpriseID,Password);
    }
}
