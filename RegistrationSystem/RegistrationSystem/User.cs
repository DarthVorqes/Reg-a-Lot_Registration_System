using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class User
    {
        public bool HasPaid { get; private set; }
        public bool IsProffessor { get; private set; }
        public bool IsStudent { get; private set; }
        public bool IsRegistrar { get; private set; }
        public string Name { get; set; }
        public int StudentID { get; private set; }
        public DatabaseConnection Connection { get; set; }
        Schedule Calender { get; set; }
        public void ApplyChanges()
        {
            throw new NotImplementedException();
        }
    }
}
