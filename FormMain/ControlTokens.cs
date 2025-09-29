using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain
{
    public class ControlTokens : IDisposable
    {
        private readonly CancellationTokenSource cts;
        private readonly ManualResetEventSlim pauseEvent;

        public CancellationToken Token => cts.Token;

        public ControlTokens()
        {
            cts = new CancellationTokenSource();
            pauseEvent = new ManualResetEventSlim(true); // сразу в "работе"
        }

        public void Pause() => pauseEvent.Reset();
        public void Continue() => pauseEvent.Set();

        public void Stop()
        {
            pauseEvent.Set();
            cts.Cancel();
        }

        public void WaitIfPaused() => pauseEvent.Wait();

        public void Dispose()
        {
            cts.Dispose();
            pauseEvent.Dispose();
        }
    }
}
