using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class TableSpecific: Attribute
    {
        public Tables Table { get; private set; }
        public TableSpecific(Tables table)
        {
            Table = table;
        }
    }
}
