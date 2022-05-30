using System;
namespace Bridge
{
    public class CPP : Language
    {
        public string name { get; } = "C++";
    }

    public class CS : Language
    {
        public string name { get; } = "C#";
    }

    public class PHP : Language
    {
        public string name { get; } = "PHP";
    }
}
