using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        private static CancellationTokenSource _source = new CancellationTokenSource(); 
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (s, e) =>
            {
                e.Cancel = true;
                _source.Cancel();
            };
            Console.WriteLine("Press ctrl-c");

            List<Thread> threads = new List<Thread>
            {
                CreateMemoryWorker(),
                CreateSqlWorker(),
            };
            
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        private static Thread CreateSqlWorker()
        {
            var worker = new SqlWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }

        private static Thread CreateMemoryWorker()
        {
            var worker = new MemoryWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }
    }
}
