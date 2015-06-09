using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class RobotA
    {
        private EventAggregator eventT;
        public RobotB B;

        public RobotA(EventAggregator eventT)
        {           
            this.eventT = eventT;
            eventT.Published += OnPublished;
        }

        private void OnPublished(object sender, string e)
        {
            if (e == "1")
            {
                Console.WriteLine("A => B");
                B.TakeBall();
            }
        }

        internal void TakeBall()
        {
        }
    }
}
