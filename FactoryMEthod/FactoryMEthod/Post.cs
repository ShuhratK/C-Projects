using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FactoryMEthod
{
    public class AeroPost : IPost
    {
        static public string name { get; } = "Авиапочта";
        static public string selectTransport (bool trainDelivery = false)
        {
            return Plane.name;
        }
    }

    public class GroundPost : IPost
    {
        static public string name { get; } = "Наземная почта";
        static public string selectTransport(bool trainDelivery = false)
        {
            if (trainDelivery) return Train.name;
            return Car.name;
        }
    }
}
