using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMEthod
{
    class Plane : ITransport
    {
        public static string name { get; } = "Самолёт";
    }

    class Car : ITransport
    {
        public static string name { get; } = "Машина";
    }

    class Train : ITransport
    {
        public static string name { get; } = "Поезд";
    }
}
