using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer[] programmers = { new CPPProgrammer(), new CSProgrammer(), new PHPProgrammer() };

            for(int i = 0; i < programmers.Length; i++)
            {
                programmers[i].requestProject();
                Console.WriteLine(programmers[i].getInfo());
                programmers[i].completeProject();
                Console.WriteLine(programmers[i].getInfo());
            }


        }
    }
}
