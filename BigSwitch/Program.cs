using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSwitch
{

    class Program
    {
        static void Main(string[] args)
        {
            var eventT = new EventAggregator();
            var a = new RobotA();
            var b = new RobotB("B");
            var c = new RobotB("C");

            var wakeupforB = new Wakeup(a, eventT, "1", b);

            var wakeupforC = new Wakeup(a, eventT, "2", c);

            b.A =a;
            c.A =a;
            while (true)
            {
                var entry = Console.ReadLine();
                 eventT.Publish(entry);                 
            }
        }
    }
}
