using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class RobotB
    {
        public string Name { get; private set; }

        public RobotB(string name)
        {            
            this.Name = name;
        }
        public RobotA A { get; set; }

        internal void TakeBall()
        {
            Console.WriteLine(Name + " => A");
            A.TakeBall();
        }
    }
}
