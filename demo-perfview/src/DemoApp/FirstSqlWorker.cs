using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.Db;

namespace DemoApp
{
    internal class FirstSqlWorker
    {
        private CancellationToken _token;
        private Random _rand;

        public FirstSqlWorker(CancellationToken token)
        {
            _token = token;
            _rand = new Random(Guid.NewGuid().GetHashCode());
        }

        public void Run()
        {
            while (!_token.IsCancellationRequested)
            {
                using (UsersDbContext context = new UsersDbContext())
                {
                    int count = 0;

                    var currentSecond = DateTime.UtcNow.Second;
                    if (currentSecond % 5 == 0)
                    {
                        Console.Write(" .");
                        count = ExecuteQueries1(context);
                    }
                    else
                    {
                        Console.Write(" ,");
                        count = ExecuteQueries2(context);
                    }
                    WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(50 + count));
                }
            }
        }

        private int ExecuteQueries1(UsersDbContext context)
        {
            var users0 = context.Users0.Where(u => u.FirstName == "1").ToArray();
            var users1 = context.Users1.Where(u => u.FirstName == "1").ToArray();
            var users2 = context.Users2.Where(u => u.FirstName == "1").ToArray();
            var users3 = context.Users3.Where(u => u.FirstName == "1").ToArray();
            var users4 = context.Users4.Where(u => u.FirstName == "1").ToArray();
            var users5 = context.Users5.Where(u => u.FirstName == "1").ToArray();
            var users6 = context.Users6.Where(u => u.FirstName == "1").ToArray();
            var users7 = context.Users7.Where(u => u.FirstName == "1").ToArray();
            var users8 = context.Users8.Where(u => u.FirstName == "1").ToArray();

            int count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            users0 = context.Users0.Where(u => u.LastName == "1").ToArray();
            users1 = context.Users1.Where(u => u.LastName == "1").ToArray();
            users2 = context.Users2.Where(u => u.LastName == "1").ToArray();
            users3 = context.Users3.Where(u => u.LastName == "1").ToArray();
            users4 = context.Users4.Where(u => u.LastName == "1").ToArray();
            users5 = context.Users5.Where(u => u.LastName == "1").ToArray();
            users6 = context.Users6.Where(u => u.LastName == "1").ToArray();
            users7 = context.Users7.Where(u => u.LastName == "1").ToArray();
            users8 = context.Users8.Where(u => u.LastName == "1").ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            users0 = context.Users0.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == DateTime.Now).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == DateTime.Now).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            return count;
        }

        private int ExecuteQueries2(UsersDbContext context)
        {
            var users0 = context.Users0.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users1 = context.Users1.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users2 = context.Users2.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users3 = context.Users3.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users4 = context.Users4.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users5 = context.Users5.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users6 = context.Users6.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users7 = context.Users7.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();
            var users8 = context.Users8.Where(u => u.LastName == "1" && u.FirstName == "2").ToArray();

            int count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            var date = DateTime.Now.AddDays(-1);
            users0 = context.Users0.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.FirstName == "2").ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            date = DateTime.Now.AddHours(-25);
            var name = _rand.Next().ToString();
            users0 = context.Users0.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.FirstName == name).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            date = DateTime.Now.AddHours(-25);
            name = _rand.Next().ToString();
            users0 = context.Users0.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.LastName == name).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.LastName == name).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();
            return count;
        }        
    }    
}