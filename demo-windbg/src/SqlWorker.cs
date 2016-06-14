using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            while (!_token.IsCancellationRequested)
            {
                try
                {
                    RunInternal("Hello World");
                }
                catch (Exception)
                {
                }

                Console.Write("Tock   ");
                WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(500));
            }
        }

        private static void RunInternal(string tableName)
        {
            SqlConnection connection = new SqlConnection("My connection string");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = $"SELECT * FROM {tableName}";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            connection.Open();

            reader = cmd.ExecuteReader();

            connection.Close();
        }
    }
}
