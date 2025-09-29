using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain
{
    public class NumberCreatedEvent
    {
        public event EventHandler<EventCreatorEventArgs>? Creator;


    }
}
