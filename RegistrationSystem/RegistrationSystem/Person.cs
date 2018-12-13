using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Person
    {
        public int ID { get; set; }
        public bool IsProfessor { get; set; }
        public bool IsStudent { get; set; }
        public bool IsRegistrar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Social { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int Email { get; set; }
        public long PhoneNumber { get; set; }
    }
}
