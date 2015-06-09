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
            var b = new RobotB();

            var wakeup = new Wakeup(a, eventT);
            wakeup.B = b;
            b.A =a;
            while (true)
            {
                var entry = Console.ReadLine();
                 eventT.Publish(entry);                 
            }
        }
    }
}
