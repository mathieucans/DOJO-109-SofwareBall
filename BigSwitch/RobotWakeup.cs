using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class RobotWakeup
    {
        private RobotA a;
        private EventAggregator eventT;
        private string condition;
        private RobotSendToA target;

      
        public RobotWakeup(RobotA a, EventAggregator eventT, string condition, RobotSendToA target)
        {
            this.a = a;
            this.eventT = eventT;
            this.eventT.Published +=OnPublished;
            this.condition = condition;
            this.target = target;
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
