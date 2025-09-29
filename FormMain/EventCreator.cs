using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FormMain
{
    public class EventCreatorEventArgs : EventArgs
    {

        public BigInteger Number { get; set; }
        public EventCreatorEventArgs(BigInteger number)
        {
            Number = number;
        }

    }
}
