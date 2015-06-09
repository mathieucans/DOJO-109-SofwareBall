using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class RobotA
    {
        internal void TakeBall()
        {
        }

        internal void Wakeup(RobotSendToA target)
        {
            Console.WriteLine("A => " + target.Name);
            target.TakeBall();
        }
    }
}
