using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    /// <summary>
    /// This attribute tells the DB connection not to
    /// push something to the backend or pull it from the backend.
    /// </summary>
    class DoNotTouch : Attribute
    {
    }
}
