using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Worker
{
        internal class ExceptionWorker
        {
            private CancellationToken _token;

            public ExceptionWorker(CancellationToken token)
            {
                _token = token;
            }

            public void Run()
            {
                while (!_token.IsCancellationRequested)
                {
                    try
                    {
                        DoAction();
                    }
                    catch (Exception)
                    {
                    }
                    WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(700));
                }
            }

            private void DoAction()
            {
                try
                {
                    WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(300));
                    throw new Exception("My exception");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
