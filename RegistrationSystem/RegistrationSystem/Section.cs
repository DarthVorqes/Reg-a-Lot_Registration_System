using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Section
    {
        public static byte Capacity => 10;
        public User Professor { get; set; }
        public User[] Students { get; set; }



    }
}
