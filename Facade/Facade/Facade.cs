using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        System1 sys1;
        System2 sys2;
        System3 sys3;

        public Facade()
        {
            this.sys1 = new System1();
            this.sys2 = new System2();
            this.sys3 = new System3();
        }

        public void getInfo()
        {
            sys1.getInfo();
            sys2.getInfo();
            sys3.getInfo();
        }
    }
}
