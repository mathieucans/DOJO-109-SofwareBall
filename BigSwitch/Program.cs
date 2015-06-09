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
            var a = new RobotA(eventT);
            var b = new RobotB();
            a.B = b;
            b.A =a;
            while (true)
            {
                var entry = Console.ReadLine();
                if (entry == "1")
                {
                    eventT.Publish(entry);
                    //Console.WriteLine("A => B");
                    //Console.WriteLine("B => A");
                    

                }

            }
        }
    }
}
