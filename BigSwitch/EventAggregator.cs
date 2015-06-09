using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigSwitch
{
    class EventAggregator
    {
        public event EventHandler<string> Published;
        
        internal void Publish(string entry)
        {
            if (Published != null)
            {
                Published(this, entry);
            }
        }
    }
}
