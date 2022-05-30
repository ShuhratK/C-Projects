using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Train : ITransport
    {
        static public string name { get; set; } = "Поезд";
    }
}
