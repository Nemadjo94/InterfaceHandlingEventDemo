using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHandlingAnEvent
{
    interface IRectangle
    {
        event EventHandler Draw;
    }
}
