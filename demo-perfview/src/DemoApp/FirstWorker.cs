using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class FirstWorker
    {
        private CancellationToken _token;
        private int _delay;

        public FirstWorker(CancellationToken token)
        {
            _token = token;
        }

        public void Run()
        {
            while (!_token.IsCancellationRequested)
            {
                DoAction();
                DoAction2();
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 2000 || _token.IsCancellationRequested)
                        break;

                    for (int i = 0; i < 100; i++)
                        _delay += i;
                }
                WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(700));
            }
        }

        private void DoAction2()
        {
            try
            {
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 4000 || _token.IsCancellationRequested)
                        break;

                    for (int i = 0; i < 100; i++)
                        _delay += i;
                }
            }
            catch (Exception)
            {
            }
        }

        private void DoAction()
        {
            try
            {
                DateTime start = DateTime.Now;
                for (;;)
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 4200 || _token.IsCancellationRequested)
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
