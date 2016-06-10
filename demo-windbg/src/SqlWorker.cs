using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Worker
{
    internal class SqlWorker
    {
        private CancellationToken _token;

        public SqlWorker(CancellationToken token)
        {
            _token = token;
        }

        public void Run()
        {

        }
    }
}
