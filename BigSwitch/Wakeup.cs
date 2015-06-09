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
        private string condition;
        private RobotB target;

      
        public Wakeup(RobotA a, EventAggregator eventT, string condition, RobotB b)
        {
            // TODO: Complete member initialization
            this.a = a;
            this.eventT = eventT;
            this.eventT.Published +=OnPublished;
            this.condition = condition;
            this.target = b;
        }

        private void OnPublished(object sender, string e)
        {
            if (e == condition)
            {
                a.Wakeup(target);
            }
        }

        
    }
}
