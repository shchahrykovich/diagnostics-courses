using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Worker
{
    internal class SimpleObject
    {
        private int _id;
        public SimpleObject(int id)
        {
            _id = id;
        }
    }

    internal class MemoryWorker
    {
        private CancellationToken _token;

        private const int MaxSize = 10000;

        public MemoryWorker(CancellationToken token)
        {
            _token = token;
        }

        public void Run()
        {
            int counter = 0;
            SimpleObject[] objects = new SimpleObject[MaxSize];
            while (!_token.IsCancellationRequested)
            {
                if(counter == MaxSize)
                {
                    counter = 0;
                    objects = new SimpleObject[MaxSize];
                }
                objects[counter] = new SimpleObject(counter);

                counter++;

                WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(500));
            }
        }
    }
}
