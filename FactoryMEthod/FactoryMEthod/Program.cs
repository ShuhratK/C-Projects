using FactoryMEthod;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Классу {AeroPost.name} соответствует {AeroPost.selectTransport()}");
            Console.WriteLine($"Классу {GroundPost.name} соответствует {GroundPost.selectTransport()}, {GroundPost.selectTransport(true)}");
        }
    }

    
}
