using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FactoryMEthod
{
    class AeroPost : IPost
    {
        public string name { get; } = "Авиапочта";
        public void planDelivery(bool trainDelivery = false)
        {
            Console.Write("Классу авиапочта соответствует");
        }
    }

    class GroundPost : IPost
    {
        public string name { get; } = "Наземная почта";
        public void planDelivery(bool trainDelivery = false)
        {

        }
    }
}
