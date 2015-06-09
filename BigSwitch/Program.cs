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
            var b = new RobotSendToA("B", a);
            var c = new RobotSendToA("C", a);

            var wakeupforB = new RobotWakeup(a, eventT, "1", b);

            var wakeupforC = new RobotWakeup(a, eventT, "2", c);

            while (true)
            {
                var entry = Console.ReadLine();
                 eventT.Publish(entry);                 
            }
        }
    }
}
