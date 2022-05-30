using System;
namespace Bridge
{
    public class CPPProgrammer : Programmer
    {
        public CPPProgrammer() : base(new CPP()) { }
    }

    public class CSProgrammer : Programmer
    {
        public CSProgrammer() : base(new CS()) { }
    }

    public class PHPProgrammer : Programmer
    {
        public PHPProgrammer() : base(new PHP(), "Создан проект") { }
    }
}
