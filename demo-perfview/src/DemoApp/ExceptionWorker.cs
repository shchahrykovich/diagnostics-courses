using System;
using System.Threading;

namespace DemoApp
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
                DoAction();
                WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(1500));
            }
        }

        private void DoAction()
        {
            try
            {
                throw new Exception("42");
            }
            catch (Exception)
            {
            }
        }
    }
}
