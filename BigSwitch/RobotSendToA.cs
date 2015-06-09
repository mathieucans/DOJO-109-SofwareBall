using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class RobotSendToA
    {
        private RobotA a;

        public string Name { get; private set; }

        public RobotSendToA(string p, RobotA a)
        {
            Name = p;
            this.a = a;
        }       

        internal void TakeBall()
        {
            Console.WriteLine(Name + " => A");
            a.TakeBall();
        }
    }
}
