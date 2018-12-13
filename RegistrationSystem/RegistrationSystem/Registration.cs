using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Registration
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int SectionID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Grade { get; set; }
        public bool AddDrop { get; set; }
        public bool HasPaid { get; set; }
    }
}
