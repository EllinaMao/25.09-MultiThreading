using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain
{
    public class EventCreatorEventArgs : EventArgs
    {

        public long Number { get; set; }
        public EventCreatorEventArgs(long number)
        {
            Number = number;
        }

    }
}
