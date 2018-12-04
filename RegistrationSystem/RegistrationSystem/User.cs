using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class User : Person
    {
        public DatabaseConnection Connection { get; set; }
        public void ApplyChanges(Person updated)
        {
            var type = typeof(Person);
            foreach(var property in type.GetProperties())
            {
                if (property.PropertyType.GetInterface("IEnumerable") != null)
                {
                    //find the sub table this stuff is in
                }
                else
                {
                    //

                }
            }
        }
    }
}
