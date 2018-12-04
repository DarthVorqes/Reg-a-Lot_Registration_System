using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Person
    {
        public int EnterpriseID { get; private set; }
        public string Name { get; set; }
        public bool HasPaid { get; private set; }
        public bool IsProffessor { get; private set; }
        public bool IsStudent { get; private set; }
        public bool IsRegistrar { get; private set; }
        public string Password { get; private set; }
        Schedule UserSchedule { get; set; }
    }
}
