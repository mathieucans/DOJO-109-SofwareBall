using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class RobotB
    {
        public RobotA A { get; set; }

        internal void TakeBall()
        {
            Console.WriteLine("B => A");
            A.TakeBall();
        }
    }
}
