using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Airplane : ITransport
    {
        static public string name { get; set; } = "Самолёт";
    }
}
