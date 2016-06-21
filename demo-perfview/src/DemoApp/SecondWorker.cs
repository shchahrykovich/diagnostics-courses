using System;
using System.Threading;

namespace DemoApp
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
                    if ((DateTime.Now - start).TotalMilliseconds > 2500 || _token.IsCancellationRequested)
                        break;

                    for (int i = 0; i < 100; i++)
                        _delay += i;
                }
                Console.Write("Second worker");
                WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(3000));
            }
        }

        private void RunQuickOperation()
        {
            try
            {
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 3500 || _token.IsCancellationRequested)
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
                    if ((DateTime.Now - start).TotalMilliseconds > 5000 || _token.IsCancellationRequested)
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
