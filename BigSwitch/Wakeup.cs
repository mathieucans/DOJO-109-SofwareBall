using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class Wakeup
    {
        private RobotA a;
        private EventAggregator eventT;


        public Wakeup(RobotA a, EventAggregator eventT)
        {
            this.a = a;
            this.eventT = eventT;
            eventT.Published += OnPublished;
        }

        private void OnPublished(object sender, string e)
        {
            if (e == "1")
            {
                a.Wakeup(B);
            }
        }

        public RobotB B { get; set; }
    }
}
