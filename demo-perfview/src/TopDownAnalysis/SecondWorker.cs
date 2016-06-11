using System;
using System.Threading;

namespace TopDownAnalysis
{
    internal class SecondWorker
    {
        private CancellationToken _token;
        private int _delay;

        public SecondWorker(CancellationToken token)
        {
            _token = token;
        }

        public void Run()
        {
            while(!_token.IsCancellationRequested)
            {
                RunLongOperation();
                RunQuickOperation();
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 2500)
                        break;

                    for (int i = 0; i < 100; i++)
                        _delay += i;
                }
                WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(700));
            }
        }

        private void RunQuickOperation()
        {
            try
            {
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 3500)
                        break;

                    for (int i = 0; i < 100; i++)
                        _delay += i;
                }
            }
            catch (Exception)
            {
            }
        }

        private void RunLongOperation()
        {
            try
            {
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 5000)
                        break;

                    for (int i = 0; i < 100; i++)
                        _delay += i;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
