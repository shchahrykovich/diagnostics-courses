﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoApp
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
                CreateFirstWorker(),
                CreateSecondWorker(),
                CreateExceptionWorker(),
                CreateFirstSqlWorker(),
                CreateSecondSqlWorker()
            };

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        private static Thread CreateFirstWorker()
        {
            var worker = new FirstWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }

        private static Thread CreateSecondWorker()
        {
            var worker = new SecondWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }

        private static Thread CreateExceptionWorker()
        {
            var worker = new ExceptionWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }

        private static Thread CreateFirstSqlWorker()
        {
            var worker = new FirstSqlWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }

        private static Thread CreateSecondSqlWorker()
        {
            var worker = new SecondSqlWorker(_source.Token);
            Thread t = new Thread(worker.Run);
            t.Start();
            return t;
        }
    }
}
